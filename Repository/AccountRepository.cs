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

        public AppraisalDbContext DbContext { get; }

        public User FindUser(string email, string password)
        {
            return this.DbContext.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public void AddUser(int id, string firstName, string lastName, string password, string email, int roleId)
        {
            this.DbContext.Users.Add(new User { Id = id, FirstName = firstName, LastName = lastName, Password = password, Email = email, RoleId = roleId });
        }
    }
}