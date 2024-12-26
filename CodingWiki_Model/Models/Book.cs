namespace CodingWiki_Model.Models;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public BookDetail BookDetail { get; set; }
}