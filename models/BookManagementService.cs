namespace CIS_106_MOD_3_ASSIGNMENT_MW.models.BookManagementService;

public class BookMangementService
{

    public void OnStart()
    {
       Console.WriteLine($"Welcome to the Book Management System. You currently have 2 books in your system.");
       Console.WriteLine($"What would you like to do?");
       foreach (LoadingScreenActions loadingScreenAction in LoadingScreenActions)
        {
            Console.WriteLine($"{actionID}: {name}");
        }

        string userResponse = Console.ReadLine();
        Console.WriteLine($"{userResponse}");
    }    
}
