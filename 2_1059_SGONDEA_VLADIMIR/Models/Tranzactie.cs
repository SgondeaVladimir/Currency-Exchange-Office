using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1059_SGONDEA_VLADIMIR.Models
{
    public enum TipTranzactie
    {
        Cumparare, 
        Vanzare    
    }

    public class Tranzactie
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ValutaId { get; set; }
        public int CasierId { get; set; }

        public DateTime DataTranzactie { get; set; }
        public decimal SumaValuta { get; set; } 
        public TipTranzactie Tip { get; set; }
        public decimal SumaTotalaLei { get; set; } 
    }
}
