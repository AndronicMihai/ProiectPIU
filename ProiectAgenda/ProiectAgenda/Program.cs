using System;

namespace ProiectAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            Activitate activitate1 = new Activitate("Fotbal", "FotbalLaCivica", new DateTime(2025, 3, 17), new TimeSpan(14, 0, 0), "Civica", "Sport", 1);
            Activitate activitate2 = new Activitate("Invatat", "TestLaPiu", new DateTime(2025, 3, 17), new TimeSpan(12, 0, 0), "BookCafe", "Studiere", 2);
            Activitate activitate3 = new Activitate("Handbal", "HandbalLaCivica", new DateTime(2025, 4, 17), new TimeSpan(14, 0, 0), "Civica", "Sport", 3);

            agenda.AdaugaActivitate(activitate1);
            agenda.AdaugaActivitate(activitate2);
            agenda.AdaugaActivitate(activitate3);

            Console.WriteLine("Activitati pe 17 Martie 2025:");
            var activitatiPeData = agenda.ObtineActivitatiPeData(new DateTime(2025, 3, 17));
            foreach (var activitate in activitatiPeData)
            {
                Console.WriteLine(activitate.ToString());
            }

            Console.WriteLine("\nActivitati pe 17 Martie 2025 la ora 14:00:");
            var activitatiPeDataSiOra = agenda.ObtineActivitatiPeDataSiOra(new DateTime(2025, 3, 17), new TimeSpan(14, 0, 0));
            foreach (var activitate in activitatiPeDataSiOra)
            {
                Console.WriteLine(activitate.ToString());
            }

            Console.WriteLine("\nActivitati pe luna Martie 2025:");
            agenda.AfiseazaActivitatiPeLuna(3, 2025);

            Console.WriteLine("\nNumar de activitati de tip 'Sport' in 2025:");
            int numarActivitatiSport = agenda.NumaraActivitatiPeAnSiTip(2025, "Sport");
            Console.WriteLine(numarActivitatiSport);

            agenda.AfiseazaToateActivitatile();
        }
    }
}
