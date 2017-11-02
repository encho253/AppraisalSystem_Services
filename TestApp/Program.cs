using BS;
using BS.Configs;
using Interfaces.BS;
using Repository;
using Repository.Configs;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {          
            using (UnityManagerModule u = new UnityManagerModule())
            {
                u.Init();
                var competenceService = u.Resolve<IQuestionService>();

                competenceService.AddQuestion("sdfsdfsd", "Junior", 1);
            }
        }
    }
}