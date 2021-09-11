namespace GroceryList
{
    public class Jugadores
    {
        public string Nombre { get; set; }
        
        public string Equipo { get; set; }
        
        public string Goles { get; set; }
        
        public string Edad { get; set; }

        public override string ToString()
        {
            return Nombre + "/" + Equipo ;
        }
    }
}