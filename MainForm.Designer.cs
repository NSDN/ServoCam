namespace ServoCam
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupMain = new System.Windows.Forms.GroupBox();
            this.BtnCenter = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.CameraBox = new System.Windows.Forms.GroupBox();
            this.CamConnect = new System.Windows.Forms.Button();
            this.CameraList = new System.Windows.Forms.ComboBox();
            this.SerialBox = new System.Windows.Forms.GroupBox();
            this.SerialConnect = new System.Windows.Forms.Button();
            this.SerialList = new System.Windows.Forms.ComboBox();
            this.GroupVideo = new System.Windows.Forms.GroupBox();
            this.VideoPlayer = new AForge.Controls.VideoSourcePlayer();
            this.GroupMain.SuspendLayout();
            this.CameraBox.SuspendLayout();
            this.SerialBox.SuspendLayout();
            this.GroupVideo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupMain
            // 
            this.GroupMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GroupMain.Controls.Add(this.BtnCenter);
            this.GroupMain.Controls.Add(this.BtnDown);
            this.GroupMain.Controls.Add(this.BtnRight);
            this.GroupMain.Controls.Add(this.BtnLeft);
            this.GroupMain.Controls.Add(this.BtnUp);
            this.GroupMain.Controls.Add(this.CameraBox);
            this.GroupMain.Controls.Add(this.SerialBox);
            this.GroupMain.Location = new System.Drawing.Point(12, 14);
            this.GroupMain.Name = "GroupMain";
            this.GroupMain.Size = new System.Drawing.Size(200, 295);
            this.GroupMain.TabIndex = 1;
            this.GroupMain.TabStop = false;
            this.GroupMain.Text = "Main";
            // 
            // BtnCenter
            // 
            this.BtnCenter.Font = new System.Drawing.Font("宋体", 14F);
            this.BtnCenter.Location = new System.Drawing.Point(76, 187);
            this.BtnCenter.Name = "BtnCenter";
            this.BtnCenter.Size = new System.Drawing.Size(48, 48);
            this.BtnCenter.TabIndex = 9;
            this.BtnCenter.Text = "⊙";
            this.BtnCenter.UseVisualStyleBackColor = true;
            this.BtnCenter.Click += new System.EventHandler(this.BtnCenter_Click);
            this.BtnCenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnCenter_KeyDown);
            // 
            // BtnDown
            // 
            this.BtnDown.Font = new System.Drawing.Font("宋体", 14F);
            this.BtnDown.Location = new System.Drawing.Point(76, 241);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(48, 48);
            this.BtnDown.TabIndex = 8;
            this.BtnDown.Text = "↓";
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("宋体", 14F);
            this.BtnRight.Location = new System.Drawing.Point(130, 187);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(48, 48);
            this.BtnRight.TabIndex = 7;
            this.BtnRight.Text = "→";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("宋体", 14F);
            this.BtnLeft.Location = new System.Drawing.Point(22, 187);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(48, 48);
            this.BtnLeft.TabIndex = 6;
            this.BtnLeft.Text = "←";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.Font = new System.Drawing.Font("宋体", 14F);
            this.BtnUp.Location = new System.Drawing.Point(76, 133);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(48, 48);
            this.BtnUp.TabIndex = 2;
            this.BtnUp.Text = "↑";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // CameraBox
            // 
            this.CameraBox.Controls.Add(this.CamConnect);
            this.CameraBox.Controls.Add(this.CameraList);
            this.CameraBox.Location = new System.Drawing.Point(6, 72);
            this.CameraBox.Name = "CameraBox";
            this.CameraBox.Size = new System.Drawing.Size(188, 46);
            this.CameraBox.TabIndex = 5;
            this.CameraBox.TabStop = false;
            this.CameraBox.Text = "Camera";
            // 
            // CamConnect
            // 
            this.CamConnect.Location = new System.Drawing.Point(119, 20);
            this.CamConnect.Name = "CamConnect";
            this.CamConnect.Size = new System.Drawing.Size(64, 20);
            this.CamConnect.TabIndex = 5;
            this.CamConnect.Text = "Connect";
            this.CamConnect.UseVisualStyleBackColor = true;
            this.CamConnect.Click += new System.EventHandler(this.CamConnect_Click);
            // 
            // CameraList
            // 
            this.CameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CameraList.FormattingEnabled = true;
            this.CameraList.Location = new System.Drawing.Point(6, 20);
            this.CameraList.Name = "CameraList";
            this.CameraList.Size = new System.Drawing.Size(106, 20);
            this.CameraList.TabIndex = 4;
            this.CameraList.Click += new System.EventHandler(this.CameraList_Click);
            // 
            // SerialBox
            // 
            this.SerialBox.Controls.Add(this.SerialConnect);
            this.SerialBox.Controls.Add(this.SerialList);
            this.SerialBox.Location = new System.Drawing.Point(6, 20);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(188, 46);
            this.SerialBox.TabIndex = 4;
            this.SerialBox.TabStop = false;
            this.SerialBox.Text = "Serial";
            // 
            // SerialConnect
            // 
            this.SerialConnect.Location = new System.Drawing.Point(118, 20);
            this.SerialConnect.Name = "SerialConnect";
            this.SerialConnect.Size = new System.Drawing.Size(64, 20);
            this.SerialConnect.TabIndex = 6;
            this.SerialConnect.Text = "Connect";
            this.SerialConnect.UseVisualStyleBackColor = true;
            this.SerialConnect.Click += new System.EventHandler(this.SerialConnect_Click);
            // 
            // SerialList
            // 
            this.SerialList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialList.FormattingEnabled = true;
            this.SerialList.Location = new System.Drawing.Point(6, 20);
            this.SerialList.Name = "SerialList";
            this.SerialList.Size = new System.Drawing.Size(106, 20);
            this.SerialList.TabIndex = 3;
            this.SerialList.Click += new System.EventHandler(this.SerialList_Click);
            // 
            // GroupVideo
            // 
            this.GroupVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupVideo.Controls.Add(this.VideoPlayer);
            this.GroupVideo.Location = new System.Drawing.Point(218, 14);
            this.GroupVideo.Name = "GroupVideo";
            this.GroupVideo.Size = new System.Drawing.Size(394, 295);
            this.GroupVideo.TabIndex = 2;
            this.GroupVideo.TabStop = false;
            this.GroupVideo.Text = "Video";
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoPlayer.Location = new System.Drawing.Point(6, 20);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.Size = new System.Drawing.Size(382, 269);
            this.VideoPlayer.TabIndex = 1;
            this.VideoPlayer.VideoSource = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.GroupVideo);
            this.Controls.Add(this.GroupMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "MainForm";
            this.Text = "ServoCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.GroupMain.ResumeLayout(false);
            this.CameraBox.ResumeLayout(false);
            this.SerialBox.ResumeLayout(false);
            this.GroupVideo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupMain;
        private System.Windows.Forms.GroupBox GroupVideo;
        private System.Windows.Forms.GroupBox CameraBox;
        private System.Windows.Forms.ComboBox CameraList;
        private System.Windows.Forms.GroupBox SerialBox;
        private System.Windows.Forms.ComboBox SerialList;
        private AForge.Controls.VideoSourcePlayer VideoPlayer;
        private System.Windows.Forms.Button BtnCenter;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button CamConnect;
        private System.Windows.Forms.Button SerialConnect;
    }
}

