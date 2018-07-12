using System;
using Gtk;
namespace  cSharp_basic_homework_1 
{
    public partial class MainWindow : Gtk.Window
    {
        public MainWindow() : base(Gtk.WindowType.Toplevel)
        {
            Build();
        }

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

	    protected void OnButton7Pressed(object sender, EventArgs e)
	    {
			Dialog a = new Dialog("1");
	    }

		protected void OnButton8Pressed(object sender, EventArgs e)
        {
            Dialog a = new Dialog("2");
        }
      
		protected void OnButton9Pressed(object sender, EventArgs e)
		{
			Dialog a = new Dialog("3");
		}

		protected void OnButton10Pressed(object sender, EventArgs e)
		{
			Dialog a = new Dialog("4");
		}

		protected void OnButton11Pressed(object sender, EventArgs e)
		{
			Dialog a = new Dialog("5");
		}

		protected void OnButton12Pressed(object sender, EventArgs e)
		{
			Dialog a = new Dialog("6");
		}
	}
}