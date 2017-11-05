using EasyConsole;

namespace PlaygroundLinkedList.Pages
{
    internal class RemoveItemsPage : BasePage
    {
        public RemoveItemsPage(Program program)
            : base("Remove Odd Items", program)
        {
        }

        public override void Display()
        {
            base.Display();

            var testList = LinkedListHelper.CreateSequentialList(20);

            Output.WriteLine(TitleColor, "List");
            testList.PrintList();

            Output.WriteLine(string.Empty);
            Output.WriteLine(TitleColor, "Remove odd items");
            testList.RemoveItems(i => i % 2 == 1);
            testList.PrintList();

            WriteExitMenu();
        }
    }
}