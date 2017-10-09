using DB;
using Interfaces.Repository;
using Repository.Configs;

namespace Repository
{
    public class RoleRepository : GenericRepository<Role>, IGenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}