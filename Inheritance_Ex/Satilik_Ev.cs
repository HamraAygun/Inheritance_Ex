using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Ex
{
    internal class Satilik_Ev : Ev
    {
        public char İpotekDurumu { get; set; }
        public char DepremRiski { get; set; }
        public string TapuHarcıYüzdesi { get; set; }
        public int Fiyat { get; set; }
    }
}
