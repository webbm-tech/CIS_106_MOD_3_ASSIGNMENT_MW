using CIS_106_MOD_3_ASSIGNMENT_MW.models.LoadingScreenActions;
using CIS_106_MOD_3_ASSIGNMENT_MW.models.Book;
using CIS_106_MOD_3_ASSIGNMENT_MW.models.BookManagementService;

List <LoadingScreenActions> loadingScreenAction = new List<LoadingScreenActions>
{
    new LoadingScreenActions {ActionName = "Display Books", ActionID = 1 },
    new LoadingScreenActions {ActionName = "Display Display Book by Book ID", ActionID = 2},
    new LoadingScreenActions {ActionName = "Add New Book", ActionID = 3},
    new LoadingScreenActions {ActionName = "Remove Book By ID", ActionID = 4},
    new LoadingScreenActions {ActionName = "Exit", ActionID = 5}
};

BookManagementServices bookManagementServices = new BookManagementService();