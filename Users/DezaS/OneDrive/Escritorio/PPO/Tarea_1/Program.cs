using System;

class OsitoCariñosito
{
    public string Nombre { get; set; }
    public string Color { get; set; }
    public string Poder { get; set; }

    public OsitoCariñosito(string nombre, string color, string poder)
    {
        Nombre = nombre;
        Color = color;
        Poder = poder;
    }

    public void MostrarPoder()
    {
        Console.WriteLine($"{Nombre} usa su poder: {Poder}!");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Osito: {Nombre}, Color: {Color}, Poder: {Poder}");
    }
}

class GenshinImpact
{
    public string Nombre { get; set; }
    public string PersonajeFavorito { get; set; }
    public int CantidadPersonajes { get; set; }

    public GenshinImpact(string nombre, string personajeFavorito, int cantidadPersonajes)
    {
        Nombre = nombre;
        PersonajeFavorito = personajeFavorito;
        CantidadPersonajes = cantidadPersonajes;
    }

    public void IniciarAventura()
    {
        Console.WriteLine($"¡Felicidades {Nombre}! Conseguiste a el mayor nivel con {PersonajeFavorito}.");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Juego: {Nombre}, Personaje favorito: {PersonajeFavorito}, Personajes jugables: {CantidadPersonajes}");
    }
}

class Program
{
    static void Main()
    {
        OsitoCariñosito osito1 = new OsitoCariñosito("Brillo Estelar", "Azul", "Rayos de felicidad");
        osito1.MostrarPoder();
        osito1.MostrarInformacion();

        GenshinImpact genshin1 = new GenshinImpact("Genshin Impact", "Klee", 80);
        genshin1.IniciarAventura();
        genshin1.MostrarInformacion();
    }
}
