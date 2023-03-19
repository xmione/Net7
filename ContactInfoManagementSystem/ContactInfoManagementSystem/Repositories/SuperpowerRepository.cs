using ContactInfoManagementSystem.Data;
using ContactInfoManagementSystem.Interfaces;

namespace ContactInfoManagementSystem.Repositories
{
    public class SuperpowerRepository : ISuperpowerRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public SuperpowerRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
