using EasyConsole;

namespace PlaygroundLinkedList.Pages
{
    internal class MainPage : MenuPage
    {
        public MainPage(Program program)
            : base("Main Page", program,
                  new Option(nameof(ReversedListIterativePage), () => program.NavigateTo<ReversedListIterativePage>()),
                  new Option(nameof(ReversedListRecursivePage), () => program.NavigateTo<ReversedListRecursivePage>()),
                  new Option(nameof(RemoveItemsPage), () => program.NavigateTo<RemoveItemsPage>()),
                  new Option(nameof(MergeSortedListPage), () => program.NavigateTo<MergeSortedListPage>())
                  )
        {
        }
    }
}