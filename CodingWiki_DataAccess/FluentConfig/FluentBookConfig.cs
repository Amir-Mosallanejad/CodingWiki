using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingWiki_DataAccess.FluentConfig;

public class FluentBookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(u => u.BookId);
        builder.Property(p => p.Title).IsRequired().HasMaxLength(50);
        builder.HasOne(p => p.BookDetail)
            .WithOne(p => p.Book)
            .HasForeignKey<BookDetail>(p => p.BookId);
    }
}