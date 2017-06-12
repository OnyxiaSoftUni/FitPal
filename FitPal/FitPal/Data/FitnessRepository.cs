using FitPal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitPal.Data
{
    public static class FitnessRepository
    {
        private static List<FitnessEntry> entries = new List<FitnessEntry>();

        public static ICollection<FitnessEntry> GetUserEntries(string username)
        {
            GenerateDummyEntriesCollection();
            return entries.Where(e => e.Username == username).OrderByDescending(ue => ue.LogDate).ToList();
        }

        private static void GenerateDummyEntriesCollection()
        {
            if (entries.Count <= 0)
            {
                entries.Add(new FitnessEntry() { Username = "Gosho", Weight = 70.5, LogDate = new DateTime(2017, 06, 13) });
                entries.Add(new FitnessEntry() { Username = "Ivanka", Weight = 60.2, LogDate = new DateTime(2017, 02, 15) });
                entries.Add(new FitnessEntry() { Username = "Gosho", Weight = 80.5, LogDate = new DateTime(2017, 03, 19) });
                entries.Add(new FitnessEntry() { Username = "Praska", Weight = 90.4, LogDate = new DateTime(2017, 09, 1) });
                entries.Add(new FitnessEntry() { Username = "Prasko", Weight = 120.8, LogDate = new DateTime(2017, 01, 2) });
            }
        }
    }
}