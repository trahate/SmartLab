using SmartLab.DAL;
using SmartLab.Models;
using SmartLab.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace SmartLab.Controllers
{
    public class ValuesController : ApiController
    {
        // jly
        IList<HomeModel> homeModels;
        IRepository<Patient_Tbl> _repository;
        Smart_LabEntities _context;
        public GenericUnitWork _unitOfWork = new GenericUnitWork();
        public ValuesController(IRepository<Patient_Tbl> repository)
        {
            repository = _repository;
        }
     
        // GET api/values
        //[HttpGet]
        //public IEnumerable<HomeModel> GetAllRecords()
        //{
           
        //    return ;
        //}

        // GET api/values/5
        //[HttpPost]
        //public IEnumerable<HomeModel> APIpost(int id)
        //{
        //    var bv = _unitOfWork.GetRepositoryInstance<HomeModel>().GetAllRecords(id);
        //    return bv;
        //}

        // POST api/values
        [HttpPost]
        public void ApiAdd(HomeModel val)
        {
            
            homeModels.Add(val);
            _context.SaveChanges();
            

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
