namespace CSharpFrameBot
{
  partial class FrmCreate
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
      this.label1 = new System.Windows.Forms.Label();
      this.TxtVideo = new System.Windows.Forms.TextBox();
      this.BrowseBtn = new System.Windows.Forms.Button();
      this.TxtFrame = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.SecondRdo = new System.Windows.Forms.RadioButton();
      this.FramesRdo = new System.Windows.Forms.RadioButton();
      this.DisabledRdo = new System.Windows.Forms.RadioButton();
      this.durationLbl = new System.Windows.Forms.Label();
      this.fpsLbl = new System.Windows.Forms.Label();
      this.totalFrameLbl = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.CountFrame = new System.ComponentModel.BackgroundWorker();
      ((System.ComponentModel.ISupportInitialize)(this.TxtFrame)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(34, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Video";
      // 
      // TxtVideo
      // 
      this.TxtVideo.Location = new System.Drawing.Point(52, 18);
      this.TxtVideo.Name = "TxtVideo";
      this.TxtVideo.ReadOnly = true;
      this.TxtVideo.Size = new System.Drawing.Size(205, 20);
      this.TxtVideo.TabIndex = 1;
      // 
      // BrowseBtn
      // 
      this.BrowseBtn.Location = new System.Drawing.Point(263, 16);
      this.BrowseBtn.Name = "BrowseBtn";
      this.BrowseBtn.Size = new System.Drawing.Size(55, 23);
      this.BrowseBtn.TabIndex = 2;
      this.BrowseBtn.Text = "Browse";
      this.BrowseBtn.UseVisualStyleBackColor = true;
      this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
      // 
      // TxtFrame
      // 
      this.TxtFrame.Location = new System.Drawing.Point(125, 48);
      this.TxtFrame.Name = "TxtFrame";
      this.TxtFrame.Size = new System.Drawing.Size(70, 20);
      this.TxtFrame.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 218);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "label1";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.SecondRdo);
      this.groupBox1.Controls.Add(this.FramesRdo);
      this.groupBox1.Controls.Add(this.DisabledRdo);
      this.groupBox1.Controls.Add(this.TxtFrame);
      this.groupBox1.Location = new System.Drawing.Point(12, 104);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(306, 110);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Frame Skip";
      // 
      // SecondRdo
      // 
      this.SecondRdo.AutoSize = true;
      this.SecondRdo.Location = new System.Drawing.Point(17, 77);
      this.SecondRdo.Name = "SecondRdo";
      this.SecondRdo.Size = new System.Drawing.Size(101, 17);
      this.SecondRdo.TabIndex = 4;
      this.SecondRdo.TabStop = true;
      this.SecondRdo.Text = "Every a Second";
      this.SecondRdo.UseVisualStyleBackColor = true;
      this.SecondRdo.CheckedChanged += new System.EventHandler(this.SecondRdo_CheckedChanged);
      // 
      // FramesRdo
      // 
      this.FramesRdo.AutoSize = true;
      this.FramesRdo.Location = new System.Drawing.Point(17, 48);
      this.FramesRdo.Name = "FramesRdo";
      this.FramesRdo.Size = new System.Drawing.Size(89, 17);
      this.FramesRdo.TabIndex = 4;
      this.FramesRdo.TabStop = true;
      this.FramesRdo.Text = "Every Frames";
      this.FramesRdo.UseVisualStyleBackColor = true;
      this.FramesRdo.CheckedChanged += new System.EventHandler(this.FramesRdo_CheckedChanged);
      // 
      // DisabledRdo
      // 
      this.DisabledRdo.AutoSize = true;
      this.DisabledRdo.Location = new System.Drawing.Point(17, 19);
      this.DisabledRdo.Name = "DisabledRdo";
      this.DisabledRdo.Size = new System.Drawing.Size(66, 17);
      this.DisabledRdo.TabIndex = 4;
      this.DisabledRdo.TabStop = true;
      this.DisabledRdo.Text = "Disabled";
      this.DisabledRdo.UseVisualStyleBackColor = true;
      this.DisabledRdo.CheckedChanged += new System.EventHandler(this.DisabledRdo_CheckedChanged);
      // 
      // durationLbl
      // 
      this.durationLbl.AutoSize = true;
      this.durationLbl.Location = new System.Drawing.Point(12, 47);
      this.durationLbl.Name = "durationLbl";
      this.durationLbl.Size = new System.Drawing.Size(35, 13);
      this.durationLbl.TabIndex = 0;
      this.durationLbl.Text = "label1";
      // 
      // fpsLbl
      // 
      this.fpsLbl.AutoSize = true;
      this.fpsLbl.Location = new System.Drawing.Point(12, 65);
      this.fpsLbl.Name = "fpsLbl";
      this.fpsLbl.Size = new System.Drawing.Size(35, 13);
      this.fpsLbl.TabIndex = 0;
      this.fpsLbl.Text = "label1";
      // 
      // totalFrameLbl
      // 
      this.totalFrameLbl.AutoSize = true;
      this.totalFrameLbl.Location = new System.Drawing.Point(12, 83);
      this.totalFrameLbl.Name = "totalFrameLbl";
      this.totalFrameLbl.Size = new System.Drawing.Size(35, 13);
      this.totalFrameLbl.TabIndex = 0;
      this.totalFrameLbl.Text = "label1";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(263, 253);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(55, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Import";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.LinkColor = System.Drawing.Color.Red;
      this.linkLabel1.Location = new System.Drawing.Point(15, 262);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(47, 13);
      this.linkLabel1.TabIndex = 5;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Warning";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 237);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(306, 10);
      this.progressBar1.TabIndex = 6;
      // 
      // CountFrame
      // 
      this.CountFrame.WorkerReportsProgress = true;
      this.CountFrame.WorkerSupportsCancellation = true;
      this.CountFrame.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CountFrame_DoWork);
      this.CountFrame.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.CountFrame_ProgressChanged);
      this.CountFrame.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CountFrame_RunWorkerCompleted);
      // 
      // FrmCreate
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(330, 286);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.BrowseBtn);
      this.Controls.Add(this.TxtVideo);
      this.Controls.Add(this.totalFrameLbl);
      this.Controls.Add(this.fpsLbl);
      this.Controls.Add(this.durationLbl);
      this.Controls.Add(this.label1);
      this.Name = "FrmCreate";
      this.Text = "FrmCreate";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCreate_FormClosing);
      this.Load += new System.EventHandler(this.FrmCreate_Load);
      ((System.ComponentModel.ISupportInitialize)(this.TxtFrame)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TxtVideo;
    private System.Windows.Forms.Button BrowseBtn;
    private System.Windows.Forms.NumericUpDown TxtFrame;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label durationLbl;
    private System.Windows.Forms.Label fpsLbl;
    private System.Windows.Forms.Label totalFrameLbl;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.RadioButton SecondRdo;
    private System.Windows.Forms.RadioButton FramesRdo;
    private System.Windows.Forms.RadioButton DisabledRdo;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.ComponentModel.BackgroundWorker CountFrame;
  }
}