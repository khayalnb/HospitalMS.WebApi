﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Models
{
    public class Appointment:BaseEntity
    {
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public string AppointmentNumber  { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Description { get; set; }
        public int AppointmentTypeId { get; set; }
        public AppointmentType AppointmentType { get; set; }
    }
}
