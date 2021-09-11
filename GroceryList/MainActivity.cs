using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace GroceryList
{
	[Activity(Label = "Grocery List", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		public static List<Jugadores> jugadores = new List<Jugadores>();
		protected override void OnCreate(Bundle bundle)
		{
			jugadores.Add(new Jugadores()
			{
				Edad = "32",
				Equipo = "PSG",
				Goles = "692",
				Nombre = "Messi"
			});
			jugadores.Add(new Jugadores()
			{
				Edad = "28",
				Equipo = "Napoli",
				Goles = "300",
				Nombre = "Maradona"
			});
			jugadores.Add(new Jugadores()
			{
				Edad = "35",
				Equipo = "Man U",
				Goles = "700",
				Nombre = "Cristiano"
			});

			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);
			FindViewById<Button>(Resource.Id.itemsButton  ).Click += OnItemsClick;
			FindViewById<Button>(Resource.Id.addItemButton).Click += OnAddItemClick;
			FindViewById<Button>(Resource.Id.aboutButton  ).Click += OnAboutClick;
		}

		void OnItemsClick(object sender, EventArgs e)
		{
			// Codigo
			var intent = new Intent(this, typeof(JugadoresActivity));
			StartActivity(intent);
		}

		void OnAddItemClick(object sender, EventArgs e)
		{
			// Codigo
			var intent = new Intent(this, typeof(AddJugadorActivity));
			StartActivityForResult(intent,200);
		}

		void OnAboutClick(object sender, EventArgs e)
		{
			StartActivity(typeof(AboutActivity));
			// Codigo
		}                       

		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
		{
			if (requestCode == 200 &&  resultCode == Result.Ok)
			{
				
				string name = data.GetStringExtra("JugadorNombre"),
					equipo = data.GetStringExtra("JugadorEquipo"),
				 edad = data.GetStringExtra("JugadorEdad"),
					goles = data.GetStringExtra("JugadorGoles");
				
				jugadores.Add(new Jugadores()
				{
					Edad = edad,
					Equipo = equipo,
					Goles = goles,
					Nombre = name
				});
				
			}
		}
	}
}