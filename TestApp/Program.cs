using BS.AccountServices;
using BS.Configs;
using DB;
using Interfaces.BS;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            var db = new AppraisalDbContext();
            //var repo = new GenericRepository<User>(db);
            //var user = new User { FirstName = "Dinko", LastName = "Dinkov", Id = 123, Email = "dinko@abv.bg", Password = "dinko123", RoleId = 2 };

            //repo.Add(user);

            //var p = repo.GetFirstOrDefault<int>(1);
            using (UnityManagerModule u = new UnityManagerModule())
            {
                u.Init();
                ILoginService loginService = u.Resolve<ILoginService>();
                var p = loginService.ValidateUser("dinko@abv.bg", "dinko123");
            }

            //Console.WriteLine(p);

            //db.SaveChanges();
        }
    }
}