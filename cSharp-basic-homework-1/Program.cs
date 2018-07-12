using System;
using Gtk;

namespace cSharp_basic_homework_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("This program is a homework solution from");
            Console.WriteLine("https://github.com/Innos/Soft-Uni-Homework.git");
            Console.WriteLine("------------------------------------------------");
            Application.Init();
            MainWindow win = new MainWindow();
			win.Show();
            Application.Run();
        }
    }
}
