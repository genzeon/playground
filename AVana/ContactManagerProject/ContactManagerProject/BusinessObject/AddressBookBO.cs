using ContactManagerProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerProject.BusinessObject
{
    public class AddressBookBO
    {
        Data db;

        public AddressBookBO(Data _db)
        {
            db = _db;

        }
        public IEnumerable<AddressBook> GetAll()
        {
            var Data = db.AddressBooks.Include(s => s.Fkstate).ThenInclude(s=>s.Fkcountry);
           
            return Data.ToList();
        }

        public IEnumerable<AddressBook> sort(int? lf, string? b, string? c)
        {
            var data = db.AddressBooks.Include(a => a.Fkstate).ThenInclude(a => a.Fkcountry).Include(a => a.Fkuser)
            //.Where(a => a.Fkstate.Fkcountry.CountryName.Contains(lf)
            .Where(a => a.Fkstate.Fkcountry.PkcountryId == lf
            & a.Fkstate.StateName.Contains(b) &
            a.IsActive.ToString() == c);
            // var data = db.AddressBooks.Include(a => a.Fkstate).ThenInclude(a => a.Fkcountry).Where(a=>a.Fkstate.Fkcountry.CountryName.Contains(a) & a.Fkstate.StateName.Contains(b));

            return data.ToList();
        }

        public AddressBook GetById(int id)
        {
            return db.AddressBooks.Find(id);
        }


        public AddressBook Add(AddressBook AB)
        {
            db.AddressBooks.Add(AB);
            db.SaveChanges();
            return AB;
        }

        public void Update(AddressBook AB)
        {
            db.Entry<AddressBook>(AB).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var Data = db.AddressBooks.Find(id);
            db.AddressBooks.Remove(Data);
            db.SaveChanges();

        }

    }
}
