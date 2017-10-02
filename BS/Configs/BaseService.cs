using Interfaces.BS;
using Interfaces.Repository;

namespace BS.Configs
{
    public abstract class BaseService : IBaseService
    {
        private IUnitOfWork unitOfWork;

        public BaseService(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return this.unitOfWork;
            }

            set
            {
                this.unitOfWork = value;
            }
        }
    }
}