using HMS.DAL.Data;
using HMS.DAL.Interfaces.Repository;
using HMS.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DAL.Repositories
{
    public class HospitalTypeRepository : IHospitalTypeRepository
    {
        private readonly DataContext _dataContext;
        public HospitalTypeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    
        public HospitalType AddHospitalType(HospitalType hospitalType)
        {
            _dataContext.HospitalTypes.Add(hospitalType);   
            _dataContext.SaveChanges();
            return hospitalType;    
        }
        public List<HospitalType> GetAllHospitalTypes()
        {
            var hospitalTypeList = _dataContext.HospitalTypes.ToList();
            return hospitalTypeList;
        }
        public HospitalType DeleteHospitalType(int? id)
        {
            throw new NotImplementedException();


        }

        public HospitalType EditHospitalType(int? id)
        {
            throw new NotImplementedException();
        }

      
    }
}
