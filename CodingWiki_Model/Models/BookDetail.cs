namespace CodingWiki_Model.Models;

public class BookDetail
{
    public int BookDetailId { get; set; }
    public double Price { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
}