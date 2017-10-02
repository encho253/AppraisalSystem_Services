using DB;
using Interfaces.Repository;
using System.Linq;

namespace Repository
{
    public class AccountRepository : GenericRepository<User>, IAccountRepository
    {
        public AccountRepository(AppraisalDbContext dbContext) : base(dbContext)
        {
            this.DbContext = dbContext;
        }

        public AppraisalDbContext DbContext { get; set; }

        public User FindUser(string email, string password)
        {
            return this.DbContext.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}