using EasyConsole;

namespace PlaygroundLinkedList.Pages
{
    internal class ReversedListRecursivePage : BasePage
    {
        public ReversedListRecursivePage(Program program)
            : base("ReversedList Recursive", program)
        {
        }

        public override void Display()
        {
            base.Display();

            var testList = LinkedListHelper.CreateSequentialList(20);

            Output.WriteLine(TitleColor, "List");
            testList.PrintList();

            Output.WriteLine(string.Empty);
            Output.WriteLine(TitleColor, "Reversed List (Recursive)");
            testList.RecursiveReverseList(testList.Head);
            testList.PrintList();

            WriteExitMenu();
        }
    }
}