using System;
using Gtk;
using cSharphomework2;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
	}

	private void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
	}

	private void OnButton1Clicked(object sender, EventArgs e)
	{
		var win = new Window1(1);
		win.Show();
	}
    
	private void OnButton2Clicked(object sender, EventArgs e)
	{
		var win = new Window1(2);
		win.Show();
	}

	private void OnButton8Pressed(object sender, EventArgs e)
	{
		var win = new Window1(3);
        win.Show();
	}
	
	private void OnButton3Pressed(object sender, EventArgs e)
	{
		var win = new Window1(4);
		win.Show();
	}
	
	private void OnButton5Pressed(object sender, EventArgs e)
	{
		var win = new Window1(5);
		win.Show();
	}
	
	private void OnButton7Pressed(object sender, EventArgs e)
	{
		var win = new Window1(6);
		win.Show();
	}
}
