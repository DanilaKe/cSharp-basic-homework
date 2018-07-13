using System;
namespace cSharphomework2
{
    public partial class Window1 : Gtk.Window
    {
        public Window1() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

		protected void OnButton3Pressed(object sender, EventArgs e)
		{
			SortArray Sort = new SortArray(textview6.Buffer.Text);
				textview7.Buffer.Text = Sort.SortArray1();
		}

		protected void OnButton4Pressed(object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}
