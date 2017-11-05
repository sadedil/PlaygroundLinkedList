using EasyConsole;
using System;

namespace PlaygroundLinkedList.Pages
{
    internal class BasePage : Page
    {
        public ConsoleColor MenuColor { get; set; } = ConsoleColor.Red;
        public ConsoleColor TitleColor { get; set; } = ConsoleColor.Yellow;

        public BasePage(string title, Program program)
            : base(title, program)
        {
        }

        protected void WriteExitMenu()
        {
            Output.WriteLine(String.Empty);
            Output.WriteLine(String.Empty);
            Output.WriteLine(MenuColor, new string('-', 3));
            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}