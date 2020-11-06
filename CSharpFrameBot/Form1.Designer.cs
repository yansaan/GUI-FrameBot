namespace CSharpFrameBot
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
      this.addVideo = new System.Windows.Forms.Button();
      this.addFrame = new System.Windows.Forms.Button();
      this.editToken = new System.Windows.Forms.Button();
      this.openConfig = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.label2 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // addVideo
      // 
      this.addVideo.Location = new System.Drawing.Point(38, 71);
      this.addVideo.Name = "addVideo";
      this.addVideo.Size = new System.Drawing.Size(119, 23);
      this.addVideo.TabIndex = 0;
      this.addVideo.Text = "Add Video";
      this.addVideo.UseVisualStyleBackColor = true;
      this.addVideo.Click += new System.EventHandler(this.addVideo_Click);
      // 
      // addFrame
      // 
      this.addFrame.Location = new System.Drawing.Point(260, 31);
      this.addFrame.Name = "addFrame";
      this.addFrame.Size = new System.Drawing.Size(119, 23);
      this.addFrame.TabIndex = 0;
      this.addFrame.Text = "Add Frames";
      this.addFrame.UseVisualStyleBackColor = true;
      // 
      // editToken
      // 
      this.editToken.Location = new System.Drawing.Point(260, 60);
      this.editToken.Name = "editToken";
      this.editToken.Size = new System.Drawing.Size(119, 23);
      this.editToken.TabIndex = 0;
      this.editToken.Text = "Setting Page Token";
      this.editToken.UseVisualStyleBackColor = true;
      // 
      // openConfig
      // 
      this.openConfig.Location = new System.Drawing.Point(260, 89);
      this.openConfig.Name = "openConfig";
      this.openConfig.Size = new System.Drawing.Size(119, 23);
      this.openConfig.TabIndex = 0;
      this.openConfig.Text = "Open Config";
      this.openConfig.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 105);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 140);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(398, 10);
      this.progressBar1.TabIndex = 2;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(35, 29);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Skip Every";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(37, 45);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
      this.numericUpDown1.TabIndex = 4;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.addVideo);
      this.groupBox1.Controls.Add(this.numericUpDown1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(12, 9);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 125);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Create Frame from Video";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(422, 162);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.editToken);
      this.Controls.Add(this.addFrame);
      this.Controls.Add(this.openConfig);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button addVideo;
    private System.Windows.Forms.Button addFrame;
    private System.Windows.Forms.Button editToken;
    private System.Windows.Forms.Button openConfig;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}

