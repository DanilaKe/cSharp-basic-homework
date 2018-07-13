using System;
using Gtk;

namespace cSharphomework2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
			Window1  win = new Window1();
            win.Show();
            Application.Run();
        }
    }
}
