using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess.Services;

public class BookService(ApplicationDbContext context)
{
    public async Task<List<Book>> ReturnBookDetailFromBooks()
    {
        List<Book> book = await context.Books.ToListAsync();
        foreach (var obj in book)
        {
            await context.Entry(obj).Reference(u => u.BookDetail).LoadAsync();
        }

        return book;
    }
}