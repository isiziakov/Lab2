using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Model
{
    public interface IPath
    {
        string GetDatabasePath(string filename);
    }
}
