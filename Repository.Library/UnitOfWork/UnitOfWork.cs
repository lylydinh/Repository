using Repository.Library.DbContext;
using Repository.Library.DbContext.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Library.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private bool _disposed;
        // Field Dbcontext
        /// <summary>
        /// Khai báo DbContext
        /// </summary>
        private RepositoryDbContext _dbContext;

        // Field Repository
        // Khái Báo Repository
        private StudentRepository _studentRepository; 
        #region ========================= DbContext Propeties =========================================================
        public RepositoryDbContext DbContext => _dbContext ?? (_dbContext = new RepositoryDbContext());
        #endregion

        #region ========================= Repository Properties =======================================================
      
        public StudentRepository StudentRepo => _studentRepository ?? (_studentRepository = new StudentRepository(DbContext));
        
        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose DbContext
                    _dbContext?.Dispose();
                }
            }
            _disposed = true;
        }
    }
}