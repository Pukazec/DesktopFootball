using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    public class PlayerImage
    {
        private static readonly char DEL = '|';
        public string Player { get; set; }
        public string ImgUrl { get; set; }

        internal string ParseForFileLine() => $"{Player}{DEL}{ImgUrl}";
    }
}
