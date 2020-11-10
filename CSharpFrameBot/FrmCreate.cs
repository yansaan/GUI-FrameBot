using GleamTech.VideoUltimate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CSharpFrameBot
{
  public partial class FrmCreate : Form
  {
    public FrmCreate()
    {
      InitializeComponent();
    }

    string file;

    OpenFileDialog openVideo = new OpenFileDialog();

    private void FrmCreate_Load(object sender, EventArgs e)
    {
      TxtVideo.Text = "";
      DisabledRdo.Checked = true;

      BrowseVideo();
    }

    private void BrowseVideo()
    {
      openVideo.Title = "Find a VIdeo...";
      openVideo.Filter = "MP4 File|*.mp4|All|*.*";
      openVideo.FileName = TxtVideo.Text;
      if (TxtVideo.Text != "")
        openVideo.InitialDirectory = Path.GetDirectoryName(TxtVideo.Text);

      if (openVideo.ShowDialog() == DialogResult.OK)
      {
        TxtVideo.Text = openVideo.FileName;
        file = openVideo.FileName;

        if (!CountFrame.IsBusy)
        {
          durationLbl.Text = "Duration: ";
          fpsLbl.Text = "Frame Rate: ";
          totalFrameLbl.Text = "Total Frame: ";
          CountFrame.RunWorkerAsync();
        }
      }
      else
      {
        if (TxtVideo.Text == "")
        {
          this.Close();
        }
      }
    }

    private void CalculatingVideo(string file)
    {
      using (var videoFrameReader = new VideoFrameReader(file))
      {
        this.file = file;
      }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MessageBox.Show("This Video have unsupported characher in Filename", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void BrowseBtn_Click(object sender, EventArgs e)
    {
      BrowseVideo();
    }

    private void FrmCreate_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (CountFrame.IsBusy)
      {
        e.Cancel = true;
        MessageBox.Show("Waiting for completing progress", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      string temp = ClassString.tempVideo() + @"\tempVideo" + Path.GetExtension(TxtVideo.Text);
      if (File.Exists(temp) && !CountFrame.IsBusy)
        File.Delete(temp);
    }

    private void DisabledRdo_CheckedChanged(object sender, EventArgs e)
    {
      TxtFrame.Enabled = FramesRdo.Checked;
    }

    private void FramesRdo_CheckedChanged(object sender, EventArgs e)
    {
      TxtFrame.Enabled = FramesRdo.Checked;
    }

    private void SecondRdo_CheckedChanged(object sender, EventArgs e)
    {
      TxtFrame.Enabled = FramesRdo.Checked;
    }

    private void CountFrame_DoWork(object sender, DoWorkEventArgs e)
    {
      int prog = 0;
      string lblprog = "";

      if (prog == 0)
      {
        CountFrame.ReportProgress(prog, lblprog);
        lblprog = "Import Video";
        try
        {
          CalculatingVideo(TxtVideo.Text);
          linkLabel1.Visible = false;
        }
        catch (Exception)
        {
          lblprog = "Import Video (Unsupported character detect)";

          linkLabel1.Invoke((MethodInvoker)(() => linkLabel1.Visible = true));
          string temp = ClassString.tempVideo() + @"\tempVideo" + Path.GetExtension(TxtVideo.Text);
          if (File.Exists(temp))
            File.Delete(temp);

          File.Copy(TxtVideo.Text, ClassString.tempVideo() + @"\tempVideo" + Path.GetExtension(TxtVideo.Text));
          CalculatingVideo(temp);
        }
        Thread.Sleep(100);
        prog = 25;
      }

      using (var videoFrameReader = new VideoFrameReader(file))
      {
        string[] videoFormat = {".mp4", ".m4v", ".mkv", ".mov",
                             ".wmv", ".avi", ".webm"};
        if (videoFrameReader.Read() && Array.Exists(videoFormat, element => element == Path.GetExtension(file)) == true)
        {
          if (prog == 25)
          {
            lblprog = "Calculating Duration...";
            durationLbl.Invoke((MethodInvoker)(() => durationLbl.Text = durationLbl.Text + String.Format("{0:00}:{1:00}:{2:00}",
            videoFrameReader.Duration.Hours, videoFrameReader.Duration.Minutes, videoFrameReader.Duration.Seconds)));
            prog = 50;
          }
          if (prog == 50)
          {
            lblprog = "Calculating Frame Rate...";
            fpsLbl.Invoke((MethodInvoker)(() => fpsLbl.Text = fpsLbl.Text + string.Format("{0}", videoFrameReader.FrameRate)));
            prog = 75;
          }
          if (prog == 75)
          {
            lblprog = "Calculating Total Frame...";
            int frames = 0;
            foreach (var frame in videoFrameReader)
            {
              frames++;
            }
            totalFrameLbl.Invoke((MethodInvoker)(() => totalFrameLbl.Text = totalFrameLbl.Text + string.Format("{0}", frames)));
            prog = 100;
          }
        }
        else
        {
          e.Cancel = true;
          return;
        }
      }

      if (CountFrame.CancellationPending)
      {
        e.Cancel = true;
        return;
      }
    }

    private void CountFrame_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      progressBar1.Value = Convert.ToInt32(e.ProgressPercentage);
      label2.Text = (string)e.UserState;
      progressBar1.Update();
    }

    private void CountFrame_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (e.Cancelled == true) // jika backgroundWorker1 dibatalkan 
      {
        label2.Text = "Format not Support";
      }
      else if (e.Error != null) // jika terjadi error selama backgroundworker berjalan 
      {
        MessageBox.Show(e.Error.Message);
      }
      else
      {
        label2.Text = "";
      }
    }
  }
}
