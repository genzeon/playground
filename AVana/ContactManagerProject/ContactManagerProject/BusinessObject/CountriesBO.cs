using ContactManagerProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerProject.BusinessObject
{
    public class CountriesBO
    {
        Data db;

        public CountriesBO(Data _db)
        {
            db = _db;

        }


        public IEnumerable<Country> GetAll()
        {
            var Data = db.Countries;
            return Data.ToList();
        }

        public Country GetById(int id)
        {
            return db.Countries.Find(id);
        }


        public Country Add(Country cnt)
        {
            db.Countries.Add(cnt);
            db.SaveChanges();
            return cnt;
        }

        public void Update(Country cnt)
        {
            db.Entry<Country>(cnt).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var Data= db.Countries.Find(id);
            db.Countries.Remove(Data);
            db.SaveChanges();

        }
    }

    
}
