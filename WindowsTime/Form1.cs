using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTime
{
    public partial class Form1 : Form
    {
        #region Constraction
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        DateTime startedTime;
        DateTime endTime;
        bool isStarted = false;
        bool isHide = false;
        bool mouseClick = false;
        Point startPoint;
        bool timeoutClose = false;
        bool mute = false;
        enum CommandType
        {
            Choose = 0,
            Shutdown = 1,
            Restart = 2,
            Sleep = 3,
            Lock
        }
        CommandType commandType;
        #endregion

        #region Actions
        private void Form1_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now.AddMinutes(15);
            txtMinute.Text = now.Minute.ToString();
            txtHour.Text = now.Hour.ToString();
            //cmbHour.Items.Clear();
            //cmbMinute.Items.Clear();
            //for (int i = 0; i < 24; i++)
            //    cmbHour.Items.Add(new ComboboxItem { Value = i, Text = i.ToString("00") });
            //for (int i = 0; i < 60; i++)
            //    cmbMinute.Items.Add(new ComboboxItem { Value = i, Text = i.ToString("00") });
            foreach (CommandType item in Enum.GetValues(typeof(CommandType)))
                cmbCommandType.Items.Add(new ComboboxItem { Value = item, Text = item.ToString() });
            cmbCommandType.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //var cmbHourValue = (ComboboxItem)cmbHour.SelectedItem;
            //var cmbMinuteValue = (ComboboxItem)cmbMinute.SelectedItem;
            var cmbHourValue = int.Parse(txtHour.Text);
            var cmbMinuteValue = int.Parse(txtMinute.Text);
            //if (cmbMinuteValue == null && cmbHourValue == null)
            if (string.IsNullOrEmpty(txtMinute.Text) && string.IsNullOrEmpty(txtHour.Text))
            {
                MessageBox.Show("Please select a hour and minute!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isStarted)
            {
                btnMenuStartStop.Text = "Start";
                startedTime = new DateTime();
                this.btnStart.BackgroundImage = global::WindowsTime.Properties.Resources.start;
                tmrCounter.Stop();
                notifyIcon1.Text = "Windows Timer";
                lblLeftTime.Text = "--:--:--";
                //cmbHour.Visible = true;
                //cmbMinute.Visible = true;
                txtHour.Visible = true;
                txtMinute.Visible = true;
                lblLeftTime.Visible = false;
                TimeSpan leftTime = endTime - DateTime.Now;
            }
            else
            {
                if (commandType != CommandType.Choose)
                {
                    btnMenuStartStop.Text = "Stop";
                    startedTime = DateTime.Now;
                    tmrCounter.Start();
                    this.btnStart.BackgroundImage = global::WindowsTime.Properties.Resources.stop;
                    //cmbHour.Visible = false;
                    //cmbMinute.Visible = false;
                    txtHour.Visible = false;
                    txtMinute.Visible = false;
                    lblLeftTime.Visible = true;
                    //int hour = (int)cmbHourValue.Value;
                    //int minute = (int)cmbMinuteValue.Value;
                    int hour = int.Parse(txtHour.Text);
                    int minute = int.Parse(txtMinute.Text);
                    endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, 0);
                    if (hour < DateTime.Now.Hour || (hour == DateTime.Now.Hour && minute <= DateTime.Now.Minute))
                        endTime = endTime.AddDays(1);
                }
                else
                {
                    MessageBox.Show("Please select a command!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            isStarted = !isStarted;
        }

        private void cmbCommandType_SelectedIndexChanged(object sender, EventArgs e)
        {
            commandType = (CommandType)((ComboboxItem)cmbCommandType.SelectedItem).Value;
        }

        private void tmrCounter_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = endTime - DateTime.Now;
            notifyIcon1.Text = $"Left time " + (leftTime.Hours > 0 ? leftTime.Hours + "h" : "") + leftTime.Minutes + "m";
            if (!mute && leftTime.TotalSeconds <= 10)
            {
                Show();
                TopMost = true;
                System.Media.SystemSounds.Beep.Play();
            }
            if (leftTime.TotalSeconds <= 0)
            {
                TopMost = false;
                try
                {
                    switch (commandType)
                    {
                        case CommandType.Choose:
                            break;
                        case CommandType.Shutdown:
                            Process.Start("shutdown", "/s /t 0");
                            timeoutClose = true;
                            Application.Exit();
                            break;
                        case CommandType.Restart:
                            Process.Start("shutdown", "/r /t 0");
                            timeoutClose = true;
                            Application.Exit();
                            break;
                        case CommandType.Sleep:
                            Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState 0,1,0");
                            break;
                        case CommandType.Lock:
                            Process.Start("rundll32.exe", "user32.dll,LockWorkStation");
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Unknown error occurred !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnStart_Click(sender, e);
            }
            lblLeftTime.Text = $"{leftTime.Hours.ToString("00")}:{leftTime.Minutes.ToString("00")}:{leftTime.Seconds.ToString("00")}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (isHide)
            {
                Show();
                btnMenuShowHide.Text = "Hide";
            }
            else
            {
                Hide();
                btnMenuShowHide.Text = "Show";
            }
            isHide = !isHide;
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void btnMenuShowHide_Click(object sender, EventArgs e)
        {
            btnMinimize_Click(sender, e);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnMinimize_Click(sender, e);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClick = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClick = true;
            startPoint = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClick)
                Location = new Point(Left + e.X - startPoint.X, Top + e.Y - startPoint.Y);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!timeoutClose && isStarted)
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            if (mute)
                btnVolume.BackgroundImage = global::WindowsTime.Properties.Resources.volume;
            else
                btnVolume.BackgroundImage = global::WindowsTime.Properties.Resources.mute;
            mute = !mute;
        }
        #endregion
    }

    public class ComboboxItem
    {
        public object Value { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
