using DB;
using System.Linq;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            var db = new AppraisalDbContext();
            var e = db.Ratings.Select(x => x.Explanation).ToList();
        }
    }
}