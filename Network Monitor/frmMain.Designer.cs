namespace Network_Monitor
{
    partial class frmMain
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
            this.dropdownNetwork = new System.Windows.Forms.ComboBox();
            this.lblMaxSpeedTitle = new System.Windows.Forms.Label();
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblUploadTitle = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.lblDownloadTitle = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupNetworkSelection = new System.Windows.Forms.GroupBox();
            this.grpUnits = new System.Windows.Forms.GroupBox();
            this.rbtnBytes = new System.Windows.Forms.RadioButton();
            this.rbtnBits = new System.Windows.Forms.RadioButton();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.progressDownloadSpeed = new System.Windows.Forms.ProgressBar();
            this.grpDownloadSpeed = new System.Windows.Forms.GroupBox();
            this.lblDownloadSpeed = new System.Windows.Forms.Label();
            this.dropdownMaxDownloadSpeedUnits = new System.Windows.Forms.ComboBox();
            this.lblMaxDownloadTitle = new System.Windows.Forms.Label();
            this.updownMaxDownloadSpeed = new System.Windows.Forms.NumericUpDown();
            this.grpUploadSpeed = new System.Windows.Forms.GroupBox();
            this.dropdownMaxUploadSpeedUnits = new System.Windows.Forms.ComboBox();
            this.progressUploadSpeed = new System.Windows.Forms.ProgressBar();
            this.lblMaxUploadTitle = new System.Windows.Forms.Label();
            this.updownMaxUploadSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblUploadSpeed = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.grpMoreInfo = new System.Windows.Forms.GroupBox();
            this.grpBasicInfo.SuspendLayout();
            this.groupNetworkSelection.SuspendLayout();
            this.grpUnits.SuspendLayout();
            this.grpOperation.SuspendLayout();
            this.grpDownloadSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMaxDownloadSpeed)).BeginInit();
            this.grpUploadSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMaxUploadSpeed)).BeginInit();
            this.grpMoreInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropdownNetwork
            // 
            this.dropdownNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownNetwork.FormattingEnabled = true;
            this.dropdownNetwork.Location = new System.Drawing.Point(9, 22);
            this.dropdownNetwork.Margin = new System.Windows.Forms.Padding(4);
            this.dropdownNetwork.Name = "dropdownNetwork";
            this.dropdownNetwork.Size = new System.Drawing.Size(246, 24);
            this.dropdownNetwork.TabIndex = 0;
            this.dropdownNetwork.SelectedIndexChanged += new System.EventHandler(this.dropdownNetwork_SelectedIndexChanged);
            // 
            // lblMaxSpeedTitle
            // 
            this.lblMaxSpeedTitle.AutoSize = true;
            this.lblMaxSpeedTitle.Location = new System.Drawing.Point(6, 96);
            this.lblMaxSpeedTitle.Name = "lblMaxSpeedTitle";
            this.lblMaxSpeedTitle.Size = new System.Drawing.Size(132, 16);
            this.lblMaxSpeedTitle.TabIndex = 2;
            this.lblMaxSpeedTitle.Text = "Max Network Speed:";
            // 
            // grpBasicInfo
            // 
            this.grpBasicInfo.Controls.Add(this.lblUpload);
            this.grpBasicInfo.Controls.Add(this.lblUploadTitle);
            this.grpBasicInfo.Controls.Add(this.lblMaxSpeed);
            this.grpBasicInfo.Controls.Add(this.lblMaxSpeedTitle);
            this.grpBasicInfo.Controls.Add(this.lblDownload);
            this.grpBasicInfo.Controls.Add(this.lblDownloadTitle);
            this.grpBasicInfo.Location = new System.Drawing.Point(12, 77);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Size = new System.Drawing.Size(262, 119);
            this.grpBasicInfo.TabIndex = 3;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Text = "Basic Information";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(143, 64);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(29, 16);
            this.lblUpload.TabIndex = 7;
            this.lblUpload.Text = "???";
            // 
            // lblUploadTitle
            // 
            this.lblUploadTitle.AutoSize = true;
            this.lblUploadTitle.Location = new System.Drawing.Point(5, 64);
            this.lblUploadTitle.Name = "lblUploadTitle";
            this.lblUploadTitle.Size = new System.Drawing.Size(72, 16);
            this.lblUploadTitle.TabIndex = 6;
            this.lblUploadTitle.Text = "Uploaded:";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(143, 32);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(29, 16);
            this.lblDownload.TabIndex = 5;
            this.lblDownload.Text = "???";
            // 
            // lblDownloadTitle
            // 
            this.lblDownloadTitle.AutoSize = true;
            this.lblDownloadTitle.Location = new System.Drawing.Point(5, 32);
            this.lblDownloadTitle.Name = "lblDownloadTitle";
            this.lblDownloadTitle.Size = new System.Drawing.Size(88, 16);
            this.lblDownloadTitle.TabIndex = 4;
            this.lblDownloadTitle.Text = "Downloaded:";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Location = new System.Drawing.Point(144, 96);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(29, 16);
            this.lblMaxSpeed.TabIndex = 3;
            this.lblMaxSpeed.Text = "???";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupNetworkSelection
            // 
            this.groupNetworkSelection.Controls.Add(this.dropdownNetwork);
            this.groupNetworkSelection.Location = new System.Drawing.Point(12, 12);
            this.groupNetworkSelection.Name = "groupNetworkSelection";
            this.groupNetworkSelection.Size = new System.Drawing.Size(262, 59);
            this.groupNetworkSelection.TabIndex = 4;
            this.groupNetworkSelection.TabStop = false;
            this.groupNetworkSelection.Text = "Network";
            // 
            // grpUnits
            // 
            this.grpUnits.Controls.Add(this.rbtnBits);
            this.grpUnits.Controls.Add(this.rbtnBytes);
            this.grpUnits.Location = new System.Drawing.Point(510, 77);
            this.grpUnits.Name = "grpUnits";
            this.grpUnits.Size = new System.Drawing.Size(116, 85);
            this.grpUnits.TabIndex = 5;
            this.grpUnits.TabStop = false;
            this.grpUnits.Text = "Units";
            // 
            // rbtnBytes
            // 
            this.rbtnBytes.AutoSize = true;
            this.rbtnBytes.Checked = true;
            this.rbtnBytes.Location = new System.Drawing.Point(6, 28);
            this.rbtnBytes.Name = "rbtnBytes";
            this.rbtnBytes.Size = new System.Drawing.Size(60, 20);
            this.rbtnBytes.TabIndex = 0;
            this.rbtnBytes.TabStop = true;
            this.rbtnBytes.Text = "Bytes";
            this.rbtnBytes.UseVisualStyleBackColor = true;
            this.rbtnBytes.CheckedChanged += new System.EventHandler(this.rbtnBytes_CheckedChanged);
            // 
            // rbtnBits
            // 
            this.rbtnBits.AutoSize = true;
            this.rbtnBits.Location = new System.Drawing.Point(6, 56);
            this.rbtnBits.Name = "rbtnBits";
            this.rbtnBits.Size = new System.Drawing.Size(48, 20);
            this.rbtnBits.TabIndex = 1;
            this.rbtnBits.Text = "Bits";
            this.rbtnBits.UseVisualStyleBackColor = true;
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.chkOnTop);
            this.grpOperation.Location = new System.Drawing.Point(510, 15);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(116, 56);
            this.grpOperation.TabIndex = 6;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "Operation";
            // 
            // chkOnTop
            // 
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Checked = true;
            this.chkOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnTop.Location = new System.Drawing.Point(4, 28);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(110, 20);
            this.chkOnTop.TabIndex = 0;
            this.chkOnTop.Text = "Always on top";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // progressDownloadSpeed
            // 
            this.progressDownloadSpeed.Location = new System.Drawing.Point(129, 21);
            this.progressDownloadSpeed.Name = "progressDownloadSpeed";
            this.progressDownloadSpeed.Size = new System.Drawing.Size(87, 23);
            this.progressDownloadSpeed.TabIndex = 13;
            this.progressDownloadSpeed.Visible = false;
            // 
            // grpDownloadSpeed
            // 
            this.grpDownloadSpeed.Controls.Add(this.dropdownMaxDownloadSpeedUnits);
            this.grpDownloadSpeed.Controls.Add(this.progressDownloadSpeed);
            this.grpDownloadSpeed.Controls.Add(this.lblMaxDownloadTitle);
            this.grpDownloadSpeed.Controls.Add(this.updownMaxDownloadSpeed);
            this.grpDownloadSpeed.Controls.Add(this.lblDownloadSpeed);
            this.grpDownloadSpeed.Location = new System.Drawing.Point(280, 12);
            this.grpDownloadSpeed.Name = "grpDownloadSpeed";
            this.grpDownloadSpeed.Size = new System.Drawing.Size(224, 86);
            this.grpDownloadSpeed.TabIndex = 14;
            this.grpDownloadSpeed.TabStop = false;
            this.grpDownloadSpeed.Text = "Download Speed";
            // 
            // lblDownloadSpeed
            // 
            this.lblDownloadSpeed.AutoSize = true;
            this.lblDownloadSpeed.Location = new System.Drawing.Point(9, 23);
            this.lblDownloadSpeed.Name = "lblDownloadSpeed";
            this.lblDownloadSpeed.Size = new System.Drawing.Size(29, 16);
            this.lblDownloadSpeed.TabIndex = 9;
            this.lblDownloadSpeed.Text = "???";
            // 
            // dropdownMaxDownloadSpeedUnits
            // 
            this.dropdownMaxDownloadSpeedUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownMaxDownloadSpeedUnits.FormattingEnabled = true;
            this.dropdownMaxDownloadSpeedUnits.Items.AddRange(new object[] {
            "Bytes/s",
            "KB/s",
            "MB/s",
            "GB/s",
            "bits/s",
            "Kb/s",
            "Mb/s",
            "Gb/s"});
            this.dropdownMaxDownloadSpeedUnits.Location = new System.Drawing.Point(144, 51);
            this.dropdownMaxDownloadSpeedUnits.Margin = new System.Windows.Forms.Padding(4);
            this.dropdownMaxDownloadSpeedUnits.Name = "dropdownMaxDownloadSpeedUnits";
            this.dropdownMaxDownloadSpeedUnits.Size = new System.Drawing.Size(72, 24);
            this.dropdownMaxDownloadSpeedUnits.TabIndex = 15;
            // 
            // lblMaxDownloadTitle
            // 
            this.lblMaxDownloadTitle.AutoSize = true;
            this.lblMaxDownloadTitle.Location = new System.Drawing.Point(9, 54);
            this.lblMaxDownloadTitle.Name = "lblMaxDownloadTitle";
            this.lblMaxDownloadTitle.Size = new System.Drawing.Size(36, 16);
            this.lblMaxDownloadTitle.TabIndex = 14;
            this.lblMaxDownloadTitle.Text = "Max:";
            // 
            // updownMaxDownloadSpeed
            // 
            this.updownMaxDownloadSpeed.DecimalPlaces = 1;
            this.updownMaxDownloadSpeed.Location = new System.Drawing.Point(51, 52);
            this.updownMaxDownloadSpeed.Name = "updownMaxDownloadSpeed";
            this.updownMaxDownloadSpeed.Size = new System.Drawing.Size(86, 22);
            this.updownMaxDownloadSpeed.TabIndex = 13;
            this.updownMaxDownloadSpeed.ValueChanged += new System.EventHandler(this.updownMaxDownloadSpeed_ValueChanged);
            // 
            // grpUploadSpeed
            // 
            this.grpUploadSpeed.Controls.Add(this.dropdownMaxUploadSpeedUnits);
            this.grpUploadSpeed.Controls.Add(this.progressUploadSpeed);
            this.grpUploadSpeed.Controls.Add(this.lblMaxUploadTitle);
            this.grpUploadSpeed.Controls.Add(this.updownMaxUploadSpeed);
            this.grpUploadSpeed.Controls.Add(this.lblUploadSpeed);
            this.grpUploadSpeed.Location = new System.Drawing.Point(280, 110);
            this.grpUploadSpeed.Name = "grpUploadSpeed";
            this.grpUploadSpeed.Size = new System.Drawing.Size(224, 86);
            this.grpUploadSpeed.TabIndex = 15;
            this.grpUploadSpeed.TabStop = false;
            this.grpUploadSpeed.Text = "Upload Speed";
            // 
            // dropdownMaxUploadSpeedUnits
            // 
            this.dropdownMaxUploadSpeedUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownMaxUploadSpeedUnits.FormattingEnabled = true;
            this.dropdownMaxUploadSpeedUnits.Items.AddRange(new object[] {
            "Bytes/s",
            "KB/s",
            "MB/s",
            "GB/s",
            "bits/s",
            "Kb/s",
            "Mb/s",
            "Gb/s"});
            this.dropdownMaxUploadSpeedUnits.Location = new System.Drawing.Point(144, 51);
            this.dropdownMaxUploadSpeedUnits.Margin = new System.Windows.Forms.Padding(4);
            this.dropdownMaxUploadSpeedUnits.Name = "dropdownMaxUploadSpeedUnits";
            this.dropdownMaxUploadSpeedUnits.Size = new System.Drawing.Size(72, 24);
            this.dropdownMaxUploadSpeedUnits.TabIndex = 15;
            // 
            // progressUploadSpeed
            // 
            this.progressUploadSpeed.Location = new System.Drawing.Point(129, 21);
            this.progressUploadSpeed.Name = "progressUploadSpeed";
            this.progressUploadSpeed.Size = new System.Drawing.Size(87, 23);
            this.progressUploadSpeed.TabIndex = 13;
            this.progressUploadSpeed.Visible = false;
            // 
            // lblMaxUploadTitle
            // 
            this.lblMaxUploadTitle.AutoSize = true;
            this.lblMaxUploadTitle.Location = new System.Drawing.Point(9, 54);
            this.lblMaxUploadTitle.Name = "lblMaxUploadTitle";
            this.lblMaxUploadTitle.Size = new System.Drawing.Size(36, 16);
            this.lblMaxUploadTitle.TabIndex = 14;
            this.lblMaxUploadTitle.Text = "Max:";
            // 
            // updownMaxUploadSpeed
            // 
            this.updownMaxUploadSpeed.DecimalPlaces = 1;
            this.updownMaxUploadSpeed.Location = new System.Drawing.Point(51, 52);
            this.updownMaxUploadSpeed.Name = "updownMaxUploadSpeed";
            this.updownMaxUploadSpeed.Size = new System.Drawing.Size(86, 22);
            this.updownMaxUploadSpeed.TabIndex = 13;
            this.updownMaxUploadSpeed.ValueChanged += new System.EventHandler(this.updownMaxUploadSpeed_ValueChanged);
            // 
            // lblUploadSpeed
            // 
            this.lblUploadSpeed.AutoSize = true;
            this.lblUploadSpeed.Location = new System.Drawing.Point(9, 23);
            this.lblUploadSpeed.Name = "lblUploadSpeed";
            this.lblUploadSpeed.Size = new System.Drawing.Size(29, 16);
            this.lblUploadSpeed.TabIndex = 9;
            this.lblUploadSpeed.Text = "???";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 18);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(606, 239);
            this.treeView1.TabIndex = 0;
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Location = new System.Drawing.Point(510, 168);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(116, 28);
            this.btnMoreInfo.TabIndex = 18;
            this.btnMoreInfo.Text = "More Info";
            this.btnMoreInfo.UseVisualStyleBackColor = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // grpMoreInfo
            // 
            this.grpMoreInfo.Controls.Add(this.treeView1);
            this.grpMoreInfo.Location = new System.Drawing.Point(12, 202);
            this.grpMoreInfo.Name = "grpMoreInfo";
            this.grpMoreInfo.Size = new System.Drawing.Size(612, 260);
            this.grpMoreInfo.TabIndex = 17;
            this.grpMoreInfo.TabStop = false;
            this.grpMoreInfo.Text = "More Information";
            this.grpMoreInfo.VisibleChanged += new System.EventHandler(this.grpMoreInfo_VisibleChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 467);
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.grpMoreInfo);
            this.Controls.Add(this.grpUploadSpeed);
            this.Controls.Add(this.grpDownloadSpeed);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.grpUnits);
            this.Controls.Add(this.groupNetworkSelection);
            this.Controls.Add(this.grpBasicInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Network Monitor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            this.groupNetworkSelection.ResumeLayout(false);
            this.grpUnits.ResumeLayout(false);
            this.grpUnits.PerformLayout();
            this.grpOperation.ResumeLayout(false);
            this.grpOperation.PerformLayout();
            this.grpDownloadSpeed.ResumeLayout(false);
            this.grpDownloadSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMaxDownloadSpeed)).EndInit();
            this.grpUploadSpeed.ResumeLayout(false);
            this.grpUploadSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownMaxUploadSpeed)).EndInit();
            this.grpMoreInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox dropdownNetwork;
        private System.Windows.Forms.Label lblMaxSpeedTitle;
        private System.Windows.Forms.GroupBox grpBasicInfo;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblUploadTitle;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label lblDownloadTitle;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupNetworkSelection;
        private System.Windows.Forms.GroupBox grpUnits;
        private System.Windows.Forms.RadioButton rbtnBits;
        private System.Windows.Forms.RadioButton rbtnBytes;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.ProgressBar progressDownloadSpeed;
        private System.Windows.Forms.GroupBox grpDownloadSpeed;
        private System.Windows.Forms.ComboBox dropdownMaxDownloadSpeedUnits;
        private System.Windows.Forms.Label lblMaxDownloadTitle;
        private System.Windows.Forms.NumericUpDown updownMaxDownloadSpeed;
        private System.Windows.Forms.Label lblDownloadSpeed;
        private System.Windows.Forms.GroupBox grpUploadSpeed;
        private System.Windows.Forms.ComboBox dropdownMaxUploadSpeedUnits;
        private System.Windows.Forms.ProgressBar progressUploadSpeed;
        private System.Windows.Forms.Label lblMaxUploadTitle;
        private System.Windows.Forms.NumericUpDown updownMaxUploadSpeed;
        private System.Windows.Forms.Label lblUploadSpeed;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnMoreInfo;
        private System.Windows.Forms.GroupBox grpMoreInfo;
    }
}

