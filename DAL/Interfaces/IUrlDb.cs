using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL.Interfaces
{
    public interface IUrlDb
    {
        IEnumerable<tbl_Url> GetAll();
        tbl_Url GetByID(int id);
        void Insert(tbl_Url url);
        void Delete(int Id);
        void Update(tbl_Url url);
        void Save();
    }
}
