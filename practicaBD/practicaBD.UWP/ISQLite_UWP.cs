using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using practicaBD.UWP;
using Xamarin.Forms;
using Windows.Storage;

[assembly: Dependency(typeof(ISQLite_UWP))]


namespace practicaBD.UWP
{
    public class ISQLite_UWP : ISQLite
    {
        public String GetLocalFilePath(string Filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, Filename);
        }
    }
}