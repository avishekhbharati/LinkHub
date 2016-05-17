using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Interfaces;

namespace BLL
{
    public class UrlBs 
    {
        private UrlDb repo;

        public UrlBs()
        {
            repo = new UrlDb();
        }
        public IEnumerable<BOL.tbl_Url> GetAll()
        {
            return repo.GetAll();
        }

        public BOL.tbl_Url GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(BOL.tbl_Url url)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(BOL.tbl_Url url)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
