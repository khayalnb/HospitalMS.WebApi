using HMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Interfaces.Repository
{
    public interface IHospitalTypeRepository
    {
        public HospitalType AddHospitalType(HospitalType hospitalType);
        public List<HospitalType> GetAllHospitalTypes();
        public HospitalType EditHospitalType(int? id);
        public HospitalType DeleteHospitalType(int? id);
    }
}
