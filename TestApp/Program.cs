using DB;
using Repository;
using System.Linq;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            var db = new AppraisalDbContext();
            var repo = new GenericRepository<User>(db);

            var p = repo.GetAllRecords();
        }
    }
}