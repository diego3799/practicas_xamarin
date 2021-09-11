using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace GroceryList
{
    [Activity(Label = "Jugadores")]
    public class JugadoresActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Jugadores);
            var lv = FindViewById<ListView>(Resource.Id.jugadoresListView);
            lv.Adapter = new ArrayAdapter<Jugadores>(this, 
                Android.Resource.Layout.SimpleListItem1,
                MainActivity.jugadores);
            lv.ItemClick += LvOnItemClick;
        }

        private void LvOnItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {

            var position = e.Position;
            var player = MainActivity.jugadores[position];
            var dialog = new AlertDialog.Builder(this);
            dialog.SetMessage($"{player.Nombre} -> {player.Goles}");
            dialog.SetNeutralButton("Ok", delegate { });
            dialog.Show();
            /*
            int position = e.Position;
            var intent = new Intent(this, typeof(DetailsActivity));
            intent.PutExtra("ItemPosition", position);
            StartActivity(intent);
            */
        }
    }
}