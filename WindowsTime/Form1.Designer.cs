namespace WindowsTime
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLeftTime = new System.Windows.Forms.Label();
            this.cmbCommandType = new System.Windows.Forms.ComboBox();
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMinute = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextNotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMenuShowHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMenuStartStop = new System.Windows.Forms.ToolStripMenuItem();
            this.contextNotifyMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLeftTime
            // 
            this.lblLeftTime.AutoSize = true;
            this.lblLeftTime.Font = new System.Drawing.Font("Courier New", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftTime.Location = new System.Drawing.Point(3, 36);
            this.lblLeftTime.Name = "lblLeftTime";
            this.lblLeftTime.Size = new System.Drawing.Size(88, 29);
            this.lblLeftTime.TabIndex = 1;
            this.lblLeftTime.Text = "00:00";
            this.lblLeftTime.Visible = false;
            // 
            // cmbCommandType
            // 
            this.cmbCommandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommandType.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCommandType.FormattingEnabled = true;
            this.cmbCommandType.Location = new System.Drawing.Point(3, 4);
            this.cmbCommandType.Name = "cmbCommandType";
            this.cmbCommandType.Size = new System.Drawing.Size(173, 26);
            this.cmbCommandType.TabIndex = 2;
            this.cmbCommandType.SelectedIndexChanged += new System.EventHandler(this.cmbCommandType_SelectedIndexChanged);
            // 
            // tmrCounter
            // 
            this.tmrCounter.Interval = 1000;
            this.tmrCounter.Tick += new System.EventHandler(this.tmrCounter_Tick);
            // 
            // cmbHour
            // 
            this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHour.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(3, 37);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(49, 26);
            this.cmbHour.TabIndex = 3;
            this.cmbHour.Visible = false;
            // 
            // cmbMinute
            // 
            this.cmbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinute.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMinute.FormattingEnabled = true;
            this.cmbMinute.Location = new System.Drawing.Point(58, 37);
            this.cmbMinute.Name = "cmbMinute";
            this.cmbMinute.Size = new System.Drawing.Size(49, 26);
            this.cmbMinute.TabIndex = 4;
            this.cmbMinute.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextNotifyMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Windows Time";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextNotifyMenu
            // 
            this.contextNotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuStartStop,
            this.btnMenuShowHide,
            this.toolStripSeparator1,
            this.btnMenuExit});
            this.contextNotifyMenu.Name = "contextNotifyMenu";
            this.contextNotifyMenu.Size = new System.Drawing.Size(181, 98);
            // 
            // btnMenuShowHide
            // 
            this.btnMenuShowHide.Name = "btnMenuShowHide";
            this.btnMenuShowHide.Size = new System.Drawing.Size(180, 22);
            this.btnMenuShowHide.Text = "Hide";
            this.btnMenuShowHide.Click += new System.EventHandler(this.btnMenuShowHide_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(180, 22);
            this.btnMenuExit.Text = "Exit";
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtMinute);
            this.panel1.Controls.Add(this.txtHour);
            this.panel1.Controls.Add(this.cmbCommandType);
            this.panel1.Controls.Add(this.cmbMinute);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.cmbHour);
            this.panel1.Controls.Add(this.lblLeftTime);
            this.panel1.Location = new System.Drawing.Point(2, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 70);
            this.panel1.TabIndex = 5;
            // 
            // txtMinute
            // 
            this.txtMinute.Font = new System.Drawing.Font("Courier New", 12F);
            this.txtMinute.Location = new System.Drawing.Point(57, 36);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(49, 26);
            this.txtMinute.TabIndex = 6;
            // 
            // txtHour
            // 
            this.txtHour.Font = new System.Drawing.Font("Courier New", 12F);
            this.txtHour.Location = new System.Drawing.Point(3, 36);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(49, 26);
            this.txtHour.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::WindowsTime.Properties.Resources.start;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(132, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(44, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Windows Timer";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // btnVolume
            // 
            this.btnVolume.BackgroundImage = global::WindowsTime.Properties.Resources.volume;
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolume.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolume.Location = new System.Drawing.Point(136, 0);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(15, 15);
            this.btnVolume.TabIndex = 8;
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::WindowsTime.Properties.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(152, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 15);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::WindowsTime.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(167, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMenuStartStop
            // 
            this.btnMenuStartStop.Name = "btnMenuStartStop";
            this.btnMenuStartStop.Size = new System.Drawing.Size(180, 22);
            this.btnMenuStartStop.Text = "Start";
            this.btnMenuStartStop.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 89);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Windows Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextNotifyMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLeftTime;
        private System.Windows.Forms.ComboBox cmbCommandType;
        private System.Windows.Forms.Timer tmrCounter;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.ComboBox cmbMinute;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ContextMenuStrip contextNotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem btnMenuShowHide;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.ToolStripMenuItem btnMenuStartStop;
    }
}

