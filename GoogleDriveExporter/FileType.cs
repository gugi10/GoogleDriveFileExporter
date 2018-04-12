using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleDriveExporter {
    public class FileType {
        public string Name { get; set; }
        public string Value { get; set; }
        public string FileExtension { get; set; }
        public override string ToString() {
            return Name;
        }
    }
}
