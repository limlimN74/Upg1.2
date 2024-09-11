using System;
namespace Upg1_3
{
    class program
    {
        static void Main(string[] args)
        {
            //Blå bakgrundsfärg//
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            //Vit text//
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(":(");
            Console.WriteLine("Det ser ut som din dator har fått ett problem och behöver startas om");
        }
    }
}