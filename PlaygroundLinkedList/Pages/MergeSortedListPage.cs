using EasyConsole;

namespace PlaygroundLinkedList.Pages
{
    internal class MergeSortedListPage : BasePage
    {
        public MergeSortedListPage(Program program)
            : base("Merge two sorted list", program)
        {
        }

        public override void Display()
        {
            base.Display();

            var list1 = LinkedListHelper.CreateFormuledList(5, i => 2 * i + 1);
            //var list2 = LinkedListHelper.CreateFormuledList(10, i => 2 * i + 1);
            var list2 = LinkedListHelper.CreateFormuledList(10, i => 2 * i);

            Output.WriteLine(TitleColor, "List1");
            list1.PrintList();

            Output.WriteLine(TitleColor, "List2");
            list2.PrintList();

            Output.WriteLine(string.Empty);
            Output.WriteLine(TitleColor, "Merged List");
            var mergedList = list1.MergeWith(list2);
            mergedList.PrintList();

            WriteExitMenu();
        }
    }
}