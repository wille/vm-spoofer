using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VM_Spoofer
{
    class AbstractFile
    {
        public string Path { get; set; }
        public Program.vms VMType { get; set; }

        public bool exists()
        {
            return File.Exists(Path);
        }
    }
}
