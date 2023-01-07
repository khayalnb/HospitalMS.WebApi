using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DAL.Enums;

namespace HMS.DAL.Models
{
    public class Patient:BaseEntity
    {
        public  string BloodGroup { get; set; }
    }
}
