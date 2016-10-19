using Repository.Library.DbContext.Entities;

namespace Repository.Library.DbContext.Maps
{
    public class StudentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
            : this("dbo")
        {
        }

        public StudentConfiguration(string schema)
        {
            ToTable("Student", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Phone).HasColumnName(@"Phone").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.DateOfBirth).HasColumnName(@"DateOfBirth").IsOptional().HasColumnType("datetime");
            Property(x => x.Email).HasColumnName(@"Email").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}