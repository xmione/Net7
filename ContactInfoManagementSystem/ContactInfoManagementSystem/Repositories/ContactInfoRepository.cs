using ContactInfoManagementSystem.Data;
using ContactInfoManagementSystem.Interfaces;

namespace ContactInfoManagementSystem.Repositories
{
    public class ContactInfoRepository : IContactInfoRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public ContactInfoRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
