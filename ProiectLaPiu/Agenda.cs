using System;
using System.Collections.Generic;
using System.Linq;
using AgendaPersonala.Models;

namespace AgendaPersonala.Services
{
    public class Agenda
    {
        private List<Activitate> listaActivitati = new List<Activitate>();

        public void AdaugaActivitate(Activitate activitate)
        {
            listaActivitati.Add(activitate);
        }

        public void StergeActivitate(int id)
        {
            listaActivitati.RemoveAll(a => a.Id == id);
        }

        public List<Activitate> AfiseazaActivitatiPeData(DateTime data)
        {
            return listaActivitati.Where(a => a.Data.Date == data.Date).ToList();
        }

        public List<Activitate> AfiseazaActivitatiRecurente(DateTime start, DateTime end)
        {
            return listaActivitati.Where(a => a.Recurenta && a.Data.Date >= start.Date && a.Data.Date <= end.Date).ToList();
        }

        public List<Activitate> AfiseazaActivitatiPeTip(string tip)
        {
            return listaActivitati.Where(a => a.Tip.Equals(tip, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
+
    +
