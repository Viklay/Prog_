using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodik
{
    public class Beer
    {
        public int id { get; set; }
        public string name { get; set; }

        public string tagline { get; set; }
        public string description { get; set; }

        public int ibu { get; set; }

        public ingradience ingradients { get; set; }

        public string url { get; set; }
    }
}
