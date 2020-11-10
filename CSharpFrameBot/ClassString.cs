using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSharpFrameBot
{
  static class ClassString
  {
    private const string folderLocation = @"\yansaan\FrameBot";
    public static string Locations =
      Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString() + folderLocation;

    public static string tempVideo() {
      string loc = Locations + @"\temp";
      if (!Directory.Exists(loc))
        Directory.CreateDirectory(loc);

      return Locations + @"\temp";
    }
  }
}
