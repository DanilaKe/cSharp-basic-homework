using System;
namespace cSharphomework2
{
    public partial class Window1 : Gtk.Window
    {
		int number = 0;
        public Window1(int n) :
                base(Gtk.WindowType.Toplevel)
        {
			this.number = n;
            this.Build();
	        var textview = new TextProblems();
			switch (number)
            {
                case 1:
	                textview.EditNumberProblem(1);
                    button3.Label = "Sort";
                    break;
                case 2:
	                textview.EditNumberProblem(2);
                    button3.Label = "Sort";
                    break;
                case 3:
	                textview.EditNumberProblem(3);
                    button3.Label = "Categorize";
                    break;
                default:
                    throw new Exception("Unknown problem");
            }
	        textview1.Buffer.Text = textview.makeProblemText();
        }

		protected void OnButton3Pressed(object sender, EventArgs e)
		{
			try
			{
				SortArray Sort;
				Number numbers;
    			switch (number)
				{
    				case 1 :
						Sort = new SortArray(textview6.Buffer.Text);
    					textview7.Buffer.Text = Sort.SortArray1();
    					break;
    				case 2 :
						Sort = new SortArray(textview6.Buffer.Text);
    					textview7.Buffer.Text = Sort.SortArray2();
    					break;
					case 3 :
						numbers = new Number(textview6.Buffer.Text);
						textview7.Buffer.Text = numbers.Categorize();
                        break;
    				default:
                        throw new Exception("Unknown problem");
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("Error: " + er.Message);
            }
		}

		protected void OnButton4Pressed(object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}
