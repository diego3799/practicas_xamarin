using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace GroceryList
{
    [Activity (Label = "Add Jugador")]
    public class AddJugadorActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AddJugador);
            FindViewById<Button>(Resource.Id.cancelButton).Click += OnCancelClick;
            FindViewById<Button>(Resource.Id.saveButton).Click += OnSaveClick;
                
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            Finish();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            string nombre = FindViewById<EditText>(Resource.Id.nameInput).Text,
                equipo = FindViewById<EditText>(Resource.Id.equipoInput).Text,
                edad = FindViewById<EditText>(Resource.Id.edadInput).Text,
                goles = FindViewById<EditText>(Resource.Id.golesInput).Text;
            var intent = new Intent();
            intent.PutExtra("JugadorNombre", nombre);
            intent.PutExtra("JugadorEquipo",  equipo);
            intent.PutExtra("JugadorEdad",  edad);
            intent.PutExtra("JugadorGoles",  goles);
            SetResult(Result.Ok,intent);
            Finish();
           
        }
    }
}