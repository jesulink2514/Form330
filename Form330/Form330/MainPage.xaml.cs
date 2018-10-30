using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Form330
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ReadMore_Clicked(object sender, EventArgs e)
        {
            if (FullLabel.MaxLines != 3)
            {
                FullLabel.MaxLines = 3;
                ReadButton.Text = "Read more";
            }
            else
            {
                FullLabel.MaxLines = 20;
                ReadButton.Text = "Read less";
            }
            
        }
    }
}
