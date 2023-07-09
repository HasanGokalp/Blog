using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Infrastructure.DbMappings
{
    // Seeder ve Tablo oluşturma.
    // BaseEntity'den gelen id de burada eklendi.
    public class BlogMapping : IEntityTypeConfiguration<Domain.Concrete.Blog>
    {
        public void Configure(EntityTypeBuilder<Domain.Concrete.Blog> builder)
        {
            builder.Property(x => x.Contextt).IsRequired().HasColumnName("CONTEXT").HasColumnType("nvarchar(500)");
            builder.Property(x => x.Title).IsRequired().HasColumnName("TITLE").HasColumnType("nvarchar(100)");
            builder.Property(x => x.Id).IsRequired().HasColumnName("ID");
            builder.Property(x => x.Description).IsRequired().HasColumnName("DESCRİPTİON").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Author).IsRequired().HasColumnName("AUTHOR").HasColumnType("nvarchar(10)");

            builder.HasData(
                new Domain.Concrete.Blog()
                {
                    Name = "Eleştirel Düşünme",
                    Id = 1,
                    Description = "Her şeyin temeline temel bir bakış",
                    Title = "Eleştirel düşünmeye bir bakış",
                    Author = "Hasan",
                    Contextt = "Selam dünya ben hasan"
                    
                }
            );
        }
    }
}
