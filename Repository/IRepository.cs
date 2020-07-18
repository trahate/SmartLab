using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLab.Repository
{
    public interface IRepository<Tbl_Entity> where Tbl_Entity : class
    {
        void Add(Tbl_Entity entity);
        void update(Tbl_Entity entity);
        IEnumerable<Tbl_Entity> GetAllRecords();
        IEnumerable<Tbl_Entity> GetAllRecordsBySp();

    }
}
