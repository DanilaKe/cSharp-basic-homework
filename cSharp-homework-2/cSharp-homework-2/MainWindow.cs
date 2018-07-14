using System;
using Gtk;
using cSharphomework2;

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

	protected void OnButton1Clicked(object sender, EventArgs e)
	{
		Window1 win = new Window1(1);
		win.Show();
	}
    
	protected void OnButton2Clicked(object sender, EventArgs e)
	{
		Window1 win = new Window1(2);
		win.Show();
	}

	protected void OnButton8Pressed(object sender, EventArgs e)
	{
		Window1 win = new Window1(3);
        win.Show();
	}
}
