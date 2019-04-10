
using Fitness.models;
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
	public partial class WorkoutsPage : ContentPage
	{
		public WorkoutsPage ()
		{

			InitializeComponent ();

            workoutList.ItemsSource = new List<Workout>
            {
                //new Workout { name = "Legs, Bums, Tums", id = "LBT" },
                //new Workout { name = "Body Highlights", id = "BH" },
                //new Workout { name = "Drum'n'Bass", id = "DNB" },
                //new Workout { name = "Personal Training", id = "PT" },
                //new Workout { name = "Another", id = "AO" }
                new Workout(new PT()),
                new Workout(new DNB()),
                new Workout(new Kettle()),
                new Workout(new LBT())

            };
            
		}

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            

        }

        private void WorkoutList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
          //  WorkoutList_ItemSelected(sender, e);
        }

        async private void WorkoutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var workout = e.SelectedItem as Workout;
            // DisplayAlert("Message", workout.name + " " + workout.id + " " + workout.URL, "OK");
            
            await Navigation.PushAsync(new WorkoutDetailPage(workout));
            




        }
        
    }
}