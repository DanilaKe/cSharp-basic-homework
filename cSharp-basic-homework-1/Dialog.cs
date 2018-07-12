using System;
using Gtk;

enum Problem
{
    One = 1,
    Two,
    Three,
    Four,
    Five,
    Six
}

namespace cSharp_basic_homework_1
{
	public partial class Dialog : Gtk.Dialog
	{
		public Dialog(string selection)
		{
			this.Build();
			try
            {
                switch (selection)
                {
                    case "1":
						textview1.Buffer.Text = Problems.One();
                        break;
                    case "2":
						textview1.Buffer.Text = Problems.Two();
                        break;
                    case "3":
						textview1.Buffer.Text = Problems.Three();
                        break;
                    case "4":
						textview1.Buffer.Text = Problems.Four();
                        break;
                    case "5":
						textview1.Buffer.Text = Problems.Five();
                        break;
                    case "6":
						textview1.Buffer.Text = Problems.Six();
                        break;
                    default:
                        throw new Exception("Unknown problem");
                }
                Console.WriteLine($"\nProblem {(Problem)(Int32.Parse(selection))} : ");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
		}
		protected void OnButtonOkClicked(object sender, EventArgs e)
        {
			this.OnClose();
        }
	}
}
