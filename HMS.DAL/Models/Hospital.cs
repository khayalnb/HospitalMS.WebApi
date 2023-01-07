using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Models
{
    public  class Hospital:BaseEntity
    {
        public string HospitalName { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public int HospitalTypeId { get; set; }
        public HospitalType HospitalType { get; set; }
        public virtual ICollection<Nurse> Nurses { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }

    }
}
