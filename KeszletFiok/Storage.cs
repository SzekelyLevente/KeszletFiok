using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszletFiok
{
    class Storage
    {
        public ImageSource path1 { get; set; }
        public String labelText1 { get; set; }
        public ImageSource path2 { get; set; }
        public String labelText2 { get; set; }

        public Storage(ImageSource path1, string labelText1, ImageSource path2, string labelText2)
        {
            this.path1 = path1;
            this.labelText1 = labelText1;
            this.path2 = path2;
            this.labelText2 = labelText2;
        }
    }
}
