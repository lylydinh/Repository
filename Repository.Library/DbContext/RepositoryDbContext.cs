using Repository.Library.DbContext.Entities;
using Repository.Library.DbContext.Maps;
using System;
using System.Data.Entity;

namespace Repository.Library.DbContext
{
    public partial class RepositoryDbContext : System.Data.Entity.DbContext
    {
        public DbSet<Student> Students { get; set; } // Student

        //doan nay dung de lạm
        static RepositoryDbContext()
        {
            Database.SetInitializer<RepositoryDbContext>(null);
        }

        //khai bao Initialize
        partial void InitializePartial();

        public RepositoryDbContext()
            : base("Name=RepositoryContext")//chuoi connectsrting
        {
            InitializePartial();
        }

        public RepositoryDbContext(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        //????
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new StudentConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }

        //????
        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration(schema));
            return modelBuilder;
        }
        //?????

        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);

        //co che ngat ket noi
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}