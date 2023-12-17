using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1apka.Domain.Entities
{
    public class _1apka
    {
        public required int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set;}

        public DateTime KiedyUtworzony { get; set; } = DateTime.UtcNow;

        public DaneKontaktoweSzczegolowe Kontaktowe { get; set; } = default!;

        public string EncodedName { get; private set; } = default!;

        public void EncodeName() => EncodedName = Name.ToLower().Replace(" ", "-");



    }
}
