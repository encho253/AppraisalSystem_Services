using DB;
using System.Linq;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            var db = new AppraisalDbContext();
            var u = db.Users.Select(x => x.LastName).ToList();
            var r = db.Roles.Select(x => x.Users).ToList();
        }
    }
}
