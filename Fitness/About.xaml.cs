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
	public partial class AboutPage : TabbedPage
	{
		public AboutPage ()
		{
			InitializeComponent ();
            var introPage = new IntroPage();
            introPage.Icon = "about.png";
            introPage.Title = "About";
            var workoutsPage = new WorkoutsPage();
            workoutsPage.Icon = "runningMan.png";
            workoutsPage.Title = "Workouts";

            this.Children.Add(introPage);
            this.Children.Add(workoutsPage);
		}
	}
}