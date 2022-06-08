using ContactManagerProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerProject.BusinessObject
{
    public class StateBO
    {

        Data db;

        public StateBO(Data _db)
        {
            db = _db;

        }


        public IEnumerable<State> GetAll()
        {
            var Data = db.States.Include(s => s.Fkcountry); 
            return Data.ToList();
        }
        public IEnumerable<State> sort(string? lf)
        {
            var a = db.States.Include(s => s.Fkcountry).Where(a => a.Fkcountry.CountryName.Contains(lf));
            return a.ToList();
        }

        public IEnumerable<State> GetAllonlyselectedstates(string sk)
        {
           return db.States.Where(a => a.FkcountryId.ToString() == sk);
        }

        public State GetById(int? id)
        {
            return db.States.Find(id);
        }


        public State Add(State st)
        {
            db.States.Add(st);
            db.SaveChanges();
            return st;
        }

        public void Update(State st)
        {
            db.Entry<State>(st).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int? id)
        {
            var Data = db.States.Find(id);
            db.States.Remove(Data);
            db.SaveChanges();

        }
    }


}



