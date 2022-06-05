using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    public class GroupResults
    {
        public int Id { get; set; }
        public char Letter { get; set; }
        public IList<Result> Results { get; set; }
    }
}
