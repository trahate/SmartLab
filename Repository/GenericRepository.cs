using SmartLab.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace SmartLab.Repository
{
    public class GenericRepository<Tbl_Entity> : IRepository<Tbl_Entity> where Tbl_Entity : class
    {
        DbSet<Tbl_Entity> _dbset;
       
        private Smart_LabEntities _DBEntity;


        public GenericRepository(Smart_LabEntities dBEntity)
        {
            _DBEntity = dBEntity;
            _dbset = _DBEntity.Set<Tbl_Entity>();
        }

        public void Add(Tbl_Entity entity)
        {
            
            _dbset.Add(entity);
            _DBEntity.SaveChanges();
        }

        public IEnumerable<Tbl_Entity> GetAllRecords()
        {
            return _dbset.ToList();
        }

        public IEnumerable<Tbl_Entity> GetAllRecordsBySp()
        {
            _DBEntity.spGetProcdure();
            return _dbset.ToList();
            
        }




        //public IEnumerable<Tbl_Entity> GetAllRecordsById(int id)
        //{

        //    //dynamic data = _DBEntity.Patient_Tbl.Where(x => x.PatientID == id.ToString()).OrderByDescending(x => x.PatientFName).ToList();
        //    //if (data != null)
        //    //{
        //    //    return data;
        //    //}
        //    //return data;
        //    throw new NotImplementedException();
        //}

        public void update(Tbl_Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}