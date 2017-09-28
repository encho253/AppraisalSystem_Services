using DB;
using Repository;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            var db = new AppraisalDbContext();
            var repo = new GenericRepository<User>(db);
            var user = new User { FirstName = "Dinko", LastName = "Dinkov", Id = 123, Email = "dinko@abv.bg", Password = "dinko123", RoleId = 2 };

            repo.Add(user);

            db.SaveChanges();
        }
    }
}