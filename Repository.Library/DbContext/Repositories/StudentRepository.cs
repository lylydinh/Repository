using Repository.Library.DbContext.Entities;
using Repository.Library.UnitOfWork;

namespace Repository.Library.DbContext.Repositories
{
    public partial class StudentRepository : Repository<Student>
    {
        public StudentRepository(RepositoryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
 
 