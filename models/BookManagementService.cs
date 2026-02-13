using System.Collections;

namespace CIS_106_MOD_3_ASSIGNMENT_MW.models.BookManagementService;

/// <summary>
/// Book Management class hadles actions against the book library 
/// </summary>
/// <author>Megan Webb </author>
public class BookManagementService
{
    Dictionary<string, Book> BookCollection = new Dictionary<string, Book>
    {
        {"1", new Book ("1", "Harry Potter", "J.K. Rowling", "Children's Fiction")},
        {"2", new Book ("2", "The Hobbit", "J.R.R. Tolkein", "Fantasy Fiction")}
    };
    
/// <summary>
/// Method that greets the user and prompts for a response 
/// </summary>
    public void OnStart()
    {
    
       Console.WriteLine($"Welcome to the Book Management System. You currently have 2 books in your system.");
       
       while (true)
       {
       Console.WriteLine($"What would you like to do?");
       foreach (LoadingScreenActions loadingScreenAction in LoadingScreenActions)
        {
            Console.WriteLine($"{actionID}: {name}");
        }

        string userResponse = Console.ReadLine();
         
        switch (userResponse)
        {
        case "1":
        DisplayAllBOoks();
        break;

        case "2":
        DisplayBookByID();
        break;

        case "3":
        AddBook();
        break;

        case "4":
        RemoveBook();
        break;

        case "5":
        Console.Write($"Exiting");
        Environment.Exit(0);
        break;
        }
       }
    }
       
       
     

    private void AddBook()
    {
        Console.WriteLine ($"Please enter the title of the book");
        bookTitle = Console.ReadLine();
        Console.WriteLine ($"Please enter the book's author");
        bookAuthor = Console.ReadLine();
        Console.WriteLine ($"Please enter the book's genre");
        bookGenre = Console.ReadLine();
        Console.WriteLine ($"Please enter a unique book ID");
        bookID = Console.ReadLine();

        Book book = new Book (bookID, bookTitle, bookAuthor, bookGenre);
        BookCollection.Add(bookID, book);
    }    
    /// <summary>
    /// Method for book output format
    /// </summary>
    /// <param name="book">Book that is being displayed</param>
    private void DisplayBook(Book book)
    {       Console.WriteLine ($"ID: {book.bookID}");
            Console.WriteLine ($"Title: {book.bookTitle}");
            Console.WriteLine ($"Author: {book.bookAuthor}");
            Console.WriteLine ($"Genre: {book.bookGenre}");
    }
    /// <summary>
    /// Asks user for book ID and displays requested book
    /// </summary>
    private void DisplayBookByID()
    {
        Console.WriteLine ($"What is the ID of the book you would like to look up?");
        lookUpID = Console.ReadLine();

    }
    /// <summary>
    /// Displays all books available in collection 
    /// </summary>
    private void DisplayAllBOoks()
    {
        Console.WriteLine ($"Books Avilalbe");
        foreach (Book book in BookCollection.Values)
        {
            DisplayBook(book);
        }
    }
/// <summary>
/// Remove book from teh collection of books
/// </summary>
    private void RemoveBook()
    {
        Console.WriteLine ($"Please enter the ID of the book you want to remove");
        string toRemove = Console.ReadLine();

        BookCollection.Remove(toRemove);

    }
    }