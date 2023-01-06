using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Ex
{
    internal class Kiralık_Ev : Ev
    {
        public int KiralamaFiyatı { get; set; }
        public int DepozitoBedeli { get; set; }
        public string KiraBedeli { get; set; }
        public char EşyaDurumu { get; set; }

    }
}
