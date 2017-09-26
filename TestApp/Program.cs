using DB;
using System.Linq;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            var db = new AppraisalDbContext();
            var u = db.USERS.Select(x => x.FIRST_NAME).ToList();
        }
    }
}