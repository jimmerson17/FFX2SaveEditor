using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX2SaveEditor.Saves
{
    /// <summary>
    /// The raw file format of the PC version.
    /// </summary>
    public class SwitchSave : Ffx2Save
    {
        public string OriginalName;

        public SwitchSave(string filename) : base(0x16270, 0x7988, 0x7cc8, 0x784C, 0x7855, 0x2234)
        {
            OriginalName = Path.GetFileName(filename);
            ReadFile(new MemoryStream(File.ReadAllBytes(filename)));
        }
    }
}
