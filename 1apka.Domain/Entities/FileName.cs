using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1apka.Domain.Entities
{
   public class DaneKontaktoweSzczegolowe

    {
        public required int Id { get; set; }
        public string? DaneKontaktowe { get; set; }

        public int NumerTelefonu {  get; set; } 

        public string? Miasto {  get; set; }   
    }
}
