using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLitePCL;

namespace practicaBD
{
    public interface ISQLite
    {
        String GetLocalFilePath(string Filename);
    }
}
