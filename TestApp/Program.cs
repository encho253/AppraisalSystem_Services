using BS;
using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;
using Repository;
using Repository.Configs;
using System;

namespace TestApp
{
    public class Program
    {
        public static void Main()
        {
            //var db = new AppraisalDbContext();
            //var repo = new GenericRepository<User>(db);
            //var user = new User { FirstName = "Dinko", LastName = "Dinkov", Id = 123, Email = "dinko@abv.bg", Password = "dinko123", RoleId = 2 };

            //repo.Add(user);

            //var p = repo.GetFirstOrDefault<int>(1);
            //using (UnityManagerModule u = new UnityManagerModule())
            //{
            //    u.Init();
            //    var registerService = u.Resolve<IRegisterService>();
            //    registerService.CreateUser(22,"pesho", "stoilov", "99999999", "pstoilov@abv.bg", 1);

            //    registerService.SaveChanges();
            //}

            //using (UnityManagerModule u = new UnityManagerModule())
            //{
            //    u.Init();
            //    var registerService = u.Resolve<ILoginService>();
            //    var p = registerService.ValidateUser("pstoilov@abv.bg", "99999999");
            //}

            //using (UnityManagerModule u = new UnityManagerModule())
            //{
            //    u.Init();
            //    var registerService = u.Resolve<IUserService>();

            //    var p = registerService.GetRolesForUser("pesho@gmail.com");
            //}

            //using (UnityManagerModule u = new UnityManagerModule())
            //{
            //    u.Init();
            //    var p = u.Resolve<ILoginService>();

            //    var c = p.ValidateUser("pstoilov@abv.bg", "99999999");
            //}

            using (UnityManagerModule u = new UnityManagerModule())
            {
                u.Init();
                var p = u.Resolve<IEvaluationService>();
                var us = u.Resolve<IUserService>();
                var evalrepo = new EvaluationRepository(new UnitOfWork());

                var eval = evalrepo.GetFirstOrDefault(1);

                var evaluation = p.GetAllEvaluatorsForEvaluation("minka@gmail.com");


                UnitOfWork unit = new UnitOfWork();
                unit.SaveChanges();
            }
        }
    }
}