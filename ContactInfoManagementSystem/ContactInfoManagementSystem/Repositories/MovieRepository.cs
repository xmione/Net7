using ContactInfoManagementSystem.Data;
using ContactInfoManagementSystem.Interfaces;

namespace ContactInfoManagementSystem.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public MovieRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
