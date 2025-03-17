using System;

namespace ProiectAgenda
{
    class Activitate
    {
        private string nume;
        private string descriere;
        private string tip;
        private int id;
        private int repetareanuala = 0;
        private DateTime data;
        private TimeSpan ora;
        private string locatie;

        public Activitate(string nume, string descriere, DateTime data, TimeSpan ora, string locatie, string tip, int id)
        {
            this.nume = nume;
            this.descriere = descriere;
            this.data = data;
            this.ora = ora;
            this.locatie = locatie;
            this.tip = tip;
            this.id = id;
            this.repetareanuala++; // de facut asta
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Descriere
        {
            get { return descriere; }
            set { descriere = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public TimeSpan Ora
        {
            get { return ora; }
            set { ora = value; }
        }

        public string Locatie
        {
            get { return locatie; }
            set { locatie = value; }
        }

        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        public override string ToString()
        {
            return $"{nume} {descriere} {data} {ora} {locatie} {id} {tip} {repetareanuala}";
        }
    }
}
