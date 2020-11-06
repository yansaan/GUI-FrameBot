using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GleamTech.VideoUltimate;
using System.IO;

namespace CSharpFrameBot
{
  public partial class Form1 : Form
  {
    string video;
    string saveto;

    public Form1()
    {
      InitializeComponent();
    }

    private void addVideo_Click(object sender, EventArgs e)
    {
      openFileDialog1.Title = "Find a VIdeo...";
      openFileDialog1.Filter = "MP4 File|*.mp4|All|*.*";
      openFileDialog1.FileName = "";
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        video = openFileDialog1.FileName;

        folderBrowserDialog1.Description = "Save frame to...";
        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        {
          saveto = folderBrowserDialog1.SelectedPath;
          backgroundWorker1.RunWorkerAsync();
        }
      }
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      label1.Text = "creating...";
      label1.Visible = true;
      
      using (var videoFrameReader = new VideoFrameReader(video))
      {
        if (videoFrameReader.Read()) //Only if frame was read successfully
        {
          int frm = 1;
          foreach (var frame in videoFrameReader)
          {
            using (frame)
            {
              frame.Save(saveto + "\\" + frm + @".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
              frm += 1;
            }
          }
        }
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      label1.Visible = false;
    }
  }
}
