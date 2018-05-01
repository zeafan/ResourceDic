using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ResourceDir
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
         void ChangeColor(object sender, System.EventArgs e)
        {
           Application.Current.Resources["BackGroundColorBtn"] =Color.Azure;
        }

    }
}
