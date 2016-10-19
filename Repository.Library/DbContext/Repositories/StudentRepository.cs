using Repository.Library.DbContext.Entities;
using Repository.Library.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Library.DbContext.Repositories
{
   public class StudentRepository:Repository<Student>
    {
        public StudentRepository(RepositoryDbContext dbContext) : base(dbContext)
        {
        }
    } 
}
