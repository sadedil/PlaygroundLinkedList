using EasyConsole;

namespace PlaygroundLinkedList.Pages
{
    internal class ReversedListIterativePage : BasePage
    {
        public ReversedListIterativePage(Program program)
            : base("ReversedList Iterative", program)
        {
        }

        public override void Display()
        {
            base.Display();

            var testList = LinkedListHelper.CreateSequentialList(20);

            Output.WriteLine(TitleColor, "List");
            testList.PrintList();

            Output.WriteLine(string.Empty);
            Output.WriteLine(TitleColor, "Reversed List (Iterative)");
            testList.IterativeReverseList();
            testList.PrintList();

            WriteExitMenu();
        }
    }
}