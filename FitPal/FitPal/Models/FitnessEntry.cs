using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitPal.Models
{
    public class FitnessEntry
    {
        public string Username { get; set; }
        public double Weight { get; set; }
        public DateTime LogDate { get; set; }
    }
}