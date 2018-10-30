using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Form330
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LabelDecorations : ContentPage
	{
		public LabelDecorations ()
		{
			InitializeComponent ();
		}

	    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        Device.OpenUri(new Uri("https://somostechies.com"));
	    }
	}
}