using EFDay1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1.ConfigurationClasses
{
    internal class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> B)
        {
            B.ToTable("Books");

            B.Property(B => B.Id)
             .HasColumnName("BookId")
             .IsRequired(true);

            B.Property(B => B.Title)
             .HasColumnName("Title")
             .HasColumnType("varchar")
             .HasMaxLength(150)
             .IsRequired(true);

            B.Property(B => B.Price)
             .HasColumnName("BookPrice")
             .HasColumnType("decimal(18,2)");

            B.Property(B => B.PublishedDate)
             .HasColumnName("PublishedDate")
             .HasColumnType("datetime2(7)")
             .IsRequired(false);
        }
    }
}
