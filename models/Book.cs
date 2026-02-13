namespace CIS_106_MOD_3_ASSIGNMENT_MW.models.book;
/// <summary>
/// Book class for Book Manager Service
/// </summary>
/// <author> Megan Webb </author>
public class Book
{
    public string BookTitle {get; set;}
    public string BookAuthor {get; set;}
    public string BookGenre {get; set;}
    public string BookID {get; set;}
/// <summary>
/// Complete constructor for Book Class
/// </summary>
/// <param name="bookID">Unique identifier for each book</param>
/// <param name="bookTitle">Title of the given book</param>
/// <param name="bookAuthor">Author first and last name of given book</param>
/// <param name="bookGenre">The genre of the given book, category</param>
    public Book(string bookID, string bookTitle, string bookAuthor, string bookGenre)
    {
        BookID= bookID;
        BookTitle = bookTitle;
        BookAuthor = bookAuthor;
        BookGenre = bookGenre;
        
    }
             
}