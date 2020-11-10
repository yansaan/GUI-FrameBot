using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpFrameBot
{
  public partial class FrameConfig : Form
  {
    public FrameConfig()
    {
      InitializeComponent();
    }

    private void FrameConfig_Load(object sender, EventArgs e)
    {
      if (!Directory.Exists(ClassString.Locations)){
        Directory.CreateDirectory(ClassString.Locations);
      }
    }

    private void ImportVideo()
    {
      FrmCreate IprtVideo = new FrmCreate();
      IprtVideo.ShowDialog();
    }

    private void ImportVideoBtn_Click(object sender, EventArgs e)
    {
      ImportVideo();
    }

    private void importFrameFromVideoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ImportVideo();
    }


  }
}
