using DB;
using System.Linq;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            var db = new AppraisalDbContext();
            var u = db.Users.Select(x => x.Evaluations).ToList();
            var e = db.Positions.Select(x => x.EvaluationTemplates).ToList();
        }
    }
}