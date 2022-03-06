using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Destinatio { get; set; }
        public DateTime Date { get; set; }
        public int SeatCount { get; set; }
        public int TakenSeats { get; set; }
    }
}
