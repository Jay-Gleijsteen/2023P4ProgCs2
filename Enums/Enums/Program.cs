namespace Enums
{
    internal class Program
    {
        internal Colors myMainThemeColor;
        static void Main(string[] args)
        {
            Program programma = new Program();
            programma.run();
        }

        private void run()
        {
            myMainThemeColor = Colors.Red;
            if (myMainThemeColor == Colors.Purple)
            {
                Console.WriteLine("Color = purple");
            }
            else if (myMainThemeColor == Colors.Blue)
            {
                Console.WriteLine("Color = Blue");
            }
            else if (myMainThemeColor == Colors.Red)
            {
                Console.WriteLine("Color = Red");
            }
            else if (myMainThemeColor == Colors.Green)
            {
                Console.WriteLine("Color = Green");
            }
        }
    }
}
