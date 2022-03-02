using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.UWP
{
    public class UwpDbPath : IPath
    {
        public string GetDatabasePath(string sqliteFilename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
        }
    }
}
