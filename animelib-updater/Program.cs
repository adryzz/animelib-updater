using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animelib_updater
{
    class Program
    {
        static void Main(string[] args)
        {
            var archive = ZipFile.OpenRead("Update.zip");
            foreach(var v in archive.Entries)
            {
                v.ExtractToFile(v.Name, true);
            }
        }
    }
}
