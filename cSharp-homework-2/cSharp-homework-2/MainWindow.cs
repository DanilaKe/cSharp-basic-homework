using System;
using Gtk;
using cSharphomework2;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		this.Title = "cSharp-homework-2";
		this.textview1.Buffer.Text = 
						 $"Problem 1. Sort Array of Numbers\n" +
						 $"Problem 2. Sort Array of Numbers Using Selection Sort\n" +
		                 $"Problem 3. Categorize Numbers\n" +
		                 $"Problem 4. Sequences of Equal Strings\n" +
		                 $"Problem 5. Longest Increasing Sequence\n" +
		                 $"Problem 6. Subset Sums\n" +
		                 $"Problem 7. Sorted Subset Sums(not ready)\n" +
		                 $"Problem 8. Lego Blocks(not ready)\n" +
		                 $"Problem 9. Stuck Numbers(not ready)";
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
