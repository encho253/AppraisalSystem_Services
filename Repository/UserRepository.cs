using DB;
using Interfaces.Repository;
using System.Linq;

namespace Repository
{
    public class UserRepository : GenericRepository<User>, IGenericRepository<User>, IUserRepository
    {
        public UserRepository(AppraisalDbContext dbContext) : base(dbContext)
        {
        }

        public User FindUserByEmailAndPassword(string email, string password)
        {
            return this.DbContext.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}