using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using practicaBD.iOS;
using Xamarin.Forms;

using Foundation;
using UIKit;

[assembly: Dependency(typeof(ISQLite_IOS))]
namespace practicaBD.iOS
{
    public class ISQLite_IOS : ISQLite
    {
        public String GetLocalFilePath(string Filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, Filename);
        }
    }
}