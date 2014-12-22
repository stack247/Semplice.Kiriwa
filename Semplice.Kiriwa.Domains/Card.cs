using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semplice.Kiriwa.Domains
{
    public class Card
    {
        public int CardId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Stack Stack { get; set; }
    }
}
