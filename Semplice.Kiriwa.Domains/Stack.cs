using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semplice.Kiriwa.Domains
{
    public class Stack
    {
        public int StackId { get; set; }
        public string Name { get; set; }

        public HashSet<Card> Cards { get; set; }
    }
}
