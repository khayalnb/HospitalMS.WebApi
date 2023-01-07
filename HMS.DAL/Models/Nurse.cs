using HMS.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Models
{
    public class Nurse : Person, IWorkingTime
    {
        public decimal? DutyHours { get; set; }
        public DateTime? StartDate { get ; set ; }
        public DateTime? EndDate { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}
