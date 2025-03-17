using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectLaPiu
{
    class Activitate
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan OraInceput { get; set; }
        public TimeSpan OraSfarsit { get; set; }
        public string Tip { get; set; } // Ex: "Munca", "Personal", "Sport"
        public bool Recurenta { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Titlu} ({Tip}) - {Data.ToShortDateString()} {OraInceput} - {OraSfarsit}";
        }
    }
}
