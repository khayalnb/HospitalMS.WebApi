using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DAL.Models;

namespace HMS.DAL.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<HospitalType> HospitalTypes  { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Appointment>  Appointments { get; set; }
        public DbSet<AppointmentType>  AppointmentTypes { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicine> Medicines{ get; set; }

    }
}
