using System.Collections.Generic;
using System.Linq;

namespace GroceryList
{
    public class JugadoresData
    {
        public static List<Jugadores> Player { get; private set; }

        static JugadoresData()
        {
            var temp = new List<Jugadores>();
            AddDefault(temp);
            Player = temp;
        }

        private static void AddDefault(List<Jugadores> players) {
            players.Add(new Jugadores()
            {
                Edad = "32",
                Equipo = "PSG",
                Goles = "692",
                Nombre = "Messi"
            });
            players.Add(new Jugadores()
            {
                Edad = "28",
                Equipo = "Napoli",
                Goles = "300",
                Nombre = "Maradona"
            });
            players.Add(new Jugadores()
            {
                Edad = "35",
                Equipo = "Man U",
                Goles = "700",
                Nombre = "Cristiano"
            });
            
        }
    }
}