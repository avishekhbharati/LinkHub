using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL.Interfaces;

namespace DAL
{
    public class UrlDb :IUrlDb
    {
        private LinkHubDbEntities db = null;
        public UrlDb()
        {
            db = new LinkHubDbEntities();
        }

        public IEnumerable<tbl_Url> GetAll()
        {
            return db.tbl_Url.ToList();
        }

        public tbl_Url GetByID(int id)
        {
            return db.tbl_Url.Find(id);
        }

        public void Insert(tbl_Url url)
        {
            db.tbl_Url.Add(url);
            Save();
        }

        public void Delete(int Id)
        {
            db.tbl_Url.Remove(db.tbl_Url.Find(Id));
            Save();
        }

        public void Update(tbl_Url url)
        {
            db.Entry(url).State = EntityState.Modified;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
