using EasyConsole;

namespace PlaygroundLinkedList.Pages
{
    internal class Page1 : Page
    {
        public Page1(Program program)
            : base("Page 1", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page 1");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}