using EasyConsole;
using PlaygroundLinkedList.Pages;
using System;

namespace PlaygroundLinkedList
{
    internal class LinkedListProgram : Program
    {
        public LinkedListProgram()
            : base("LinkedList Playground", breadcrumbHeader: true)
        {
            AddPage(new MainPage(this));
            AddPage(new ReversedListIterativePage(this));
            AddPage(new ReversedListRecursivePage(this));
            AddPage(new RemoveItemsPage(this));
            AddPage(new MergeSortedListPage(this));
            //AddPage(new Page2(this));
            //AddPage(new InputPage(this));

            SetPage<MainPage>();
        }
    }
}