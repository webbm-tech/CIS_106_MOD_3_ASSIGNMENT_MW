using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using CIS_106_MOD_3_ASSIGNMENT_MW.models;

/// <summary>
/// Book Management class handles actions against the book library 
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
    

       while (true)
       {       
        Console.WriteLine($"Welcome to the Book Management System. You currently have 2 books in your system.");
        Console.WriteLine($"What would you like to do?");        
        Console.WriteLine($"1. Display Books");
        Console.WriteLine($"2. Display Book By ID");
        Console.WriteLine($"3. Add New Book");
        Console.WriteLine($"4. Remove Book By ID");
        Console.WriteLine($"5. Exit");
        Console.WriteLine($"-------------------------------------------------\n");



        int choice = int.Parse(Console.ReadLine() ?? string.Empty);
        LoadingScreenActions action = (LoadingScreenActions)choice;
         
        switch (action)
        {
        case LoadingScreenActions.DiplayBooks:
        DisplayAllBOoks();
        break;

        case LoadingScreenActions.DisplayBookByID:
        DisplayBookByID();
        break;

        case LoadingScreenActions.AddNewBook:
        AddBook();
        break;

        case LoadingScreenActions.RemoveBookByID:
        RemoveBook();
        break;

        case LoadingScreenActions.Exit:
        Console.Write($"Exiting");
        Environment.Exit(0);
        break;
        }
       }
    }
       
       
     
/// <summary>
/// This method craetes adds a book to the dictionary
/// </summary>
    private void AddBook()
    {
        Console.WriteLine ($"Please enter the title of the book");
        string bookTitle = Console.ReadLine() ?? string.Empty;
        Console.WriteLine ($"Please enter the book's author");
        string bookAuthor = Console.ReadLine() ?? string.Empty;
        Console.WriteLine ($"Please enter the book's genre");
        string bookGenre = Console.ReadLine() ?? string.Empty;
        Console.WriteLine ($"Please enter a unique book ID");
        string bookID = Console.ReadLine() ?? string.Empty;

        Book book = new Book (bookID, bookTitle, bookAuthor, bookGenre);
        BookCollection.Add(bookID, book);
    }    
    /// <summary>
    /// Method for book output format
    /// </summary>
    /// <param name="book">Book that is being displayed</param>
    private void DisplayBook(Book book)
    {       Console.WriteLine ($"ID: {book.BookID}");
            Console.WriteLine ($"Title: {book.BookTitle}");
            Console.WriteLine ($"Author: {book.BookAuthor}");
            Console.WriteLine ($"Genre: {book.BookGenre}");
            Console.WriteLine($"--------------------\n");
    }
    /// <summary>
    /// Asks user for book ID and displays requested book
    /// </summary>
    private void DisplayBookByID()
    {
        while (true)
        {
            Console.WriteLine ($"What is the ID of the book you would like to look up?\n");
            string lookUpID = Console.ReadLine() ?? string.Empty;
            if (BookCollection.TryGetValue(lookUpID, out Book foundBook))
            {
                DisplayBook(foundBook);
                break;
                 
            }
        Console.WriteLine ($"That is not a valid book ID"); }
      
    }
       
    
    /// <summary>
    /// Displays all books available in collection 
    /// </summary>
    private void DisplayAllBOoks()
    {
        Console.WriteLine ($"Books Available");
        foreach (Book book in BookCollection.Values)
        {
            DisplayBook(book);
        }
    }
/// <summary>
/// Remove book from the collection of books
/// </summary>
    private void RemoveBook()
    {

        while (true)
        {   Console.WriteLine ($"Please enter the ID of the book you want to remove\n");
            string toRemove = Console.ReadLine() ?? string.Empty;
            if (BookCollection.TryGetValue(toRemove, out Book removedBook))
            {
                BookCollection.Remove(removedBook.BookID);
                break;
            }
        Console.WriteLine ($"That is not a valid book ID\n");
        }
    }
}
 
