using System;
using System.Collections.Generic;
using System.Linq;

namespace ProiectAgenda
{
    class Agenda
    {
        private List<Activitate> activitati;

        public Agenda()
        {
            activitati = new List<Activitate>();
        }

        public void AdaugaActivitate(Activitate activitate)
        {
            activitati.Add(activitate);
        }

        public List<Activitate> ObtineActivitatiPeData(DateTime data)
        {
            return activitati.Where(a => a.Data.Date == data.Date).ToList();
        }

        public List<Activitate> ObtineActivitatiPeDataSiOra(DateTime data, TimeSpan ora)
        {
            return activitati.Where(a => a.Data.Date == data.Date && a.Ora == ora).ToList();
        }

        public void AfiseazaToateActivitatile()
        {
            foreach (var activitate in activitati)
            {
                Console.WriteLine(activitate.ToString());
            }
        }

        public void AfiseazaActivitatiPeLuna(int luna, int an)
        {
            var activitatiPeLuna = activitati.Where(a => a.Data.Month == luna && a.Data.Year == an).ToList();
            foreach (var activitate in activitatiPeLuna)
            {
                Console.WriteLine(activitate.ToString());
            }
        }

        public int NumaraActivitatiPeAnSiTip(int an, string tip)
        {
            return activitati.Count(a => a.Data.Year == an && a.Tip == tip);
        }
    }
}
