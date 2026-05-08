using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1059_SGONDEA_VLADIMIR.Models
{
    public class CursValutar
    {
        public int Id { get; set; }
        public int ValutaId { get; set; } //Cheie externa catre Valuta
        public DateTime DataCotatiei { get; set; }
        public decimal CursCumparare { get; set; }
        public decimal CursVanzare { get; set; }
    }
}
