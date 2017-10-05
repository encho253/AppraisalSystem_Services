using BS.Configs;
using Interfaces.BS;
using Interfaces.Repository;

namespace BS
{
    public class RoleService : BaseService, IBaseService, IRoleService
    {
        public RoleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}