using Android.App;
using Android.OS;
using Android.Widget;

namespace GroceryList
{
	[Activity(Label = "Details")]			
	public class DetailsActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Details);

			int position = Intent.GetIntExtra("ItemPosition",-1);

			 var item = MainActivity.jugadores[position];

			FindViewById<TextView>(Resource.Id.nameTextView ).Text = "Edad: "  + item.Edad;
			FindViewById<TextView>(Resource.Id.countTextView).Text = "Goles: " + item.Goles;
		}
	}
}