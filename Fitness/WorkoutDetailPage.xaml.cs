using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fitness
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WorkoutDetailPage : ContentPage
	{
		public WorkoutDetailPage (Workout workout)
		{
			InitializeComponent ();
            Heading.Text = workout.name;
            Descrition.Text = workout.description;
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = workout.URL;
            WebView.Source = htmlSource;

		}

        async private void OKButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }

        async private void AvailabilityButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}