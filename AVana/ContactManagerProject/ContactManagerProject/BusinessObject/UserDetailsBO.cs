using ContactManagerProject.Models;

namespace ContactManagerProject.BusinessObject
{
    public class UserDetailsBO
    {
        Data db;

        public UserDetailsBO(Data _db)
        {
            db = _db;

        }
       public IEnumerable<UserDetail> GetAll()
        {
            var Data = db.UserDetails;
            return Data.ToList();
        }

        public UserDetail GetById(int id)
        {
            return db.UserDetails.Find(id);
        }


        public UserDetail Add(UserDetail UD)
        {
            db.UserDetails.Add(UD);
            db.SaveChanges();
            return UD;
        }

        public void Update(UserDetail UD)
        {
            db.Entry<UserDetail>(UD).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var Data = db.UserDetails.Find(id);
            db.UserDetails.Remove(Data);
            db.SaveChanges();

        }

        internal bool UserExits(int id)
        {
            throw new NotImplementedException();
        }
    }
}
