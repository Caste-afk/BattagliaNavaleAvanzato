using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattagliaNavale
{
    public class CGiocatore
    {
        public List<CNave> navi { get; private set; }

        public CGiocatore(List<CNave> navi)
        {
            this.navi = navi;
        }
    }
}
