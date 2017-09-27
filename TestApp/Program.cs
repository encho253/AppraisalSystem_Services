using DB;
using System.Linq;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            var db = new AppraisalDbContext();
            var e = db.Results.Select(x => x.QuestionId).ToList();
        }
    }
}