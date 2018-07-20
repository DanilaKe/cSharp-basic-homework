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
	            case 4:
		            textview.EditNumberProblem(4);
		            button3.Label = "Find";
		            break;
	            case 5:
		            textview.EditNumberProblem(5);
		            button3.Label = "Find";
		            break;
	            case 6:
		            textview.EditNumberProblem(6);
		            button3.Label = "Subset sum";
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
				ArrayOfStrings EqualStrings;
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
					case 4 :
						EqualStrings = new ArrayOfStrings(textview6.Buffer.Text);
						textview7.Buffer.Text = EqualStrings.SequencesofEqualStrings();
						break;
					case 5 :
						EqualStrings = new ArrayOfStrings(textview6.Buffer.Text);
						textview7.Buffer.Text = EqualStrings.LongestIncreasingSequence();
						break;
					case 6 :
						EqualStrings = new ArrayOfStrings(textview6.Buffer.Text);
						textview7.Buffer.Text = EqualStrings.SubsetSums();
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
