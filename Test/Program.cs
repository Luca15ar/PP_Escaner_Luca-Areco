namespace Entidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Escaner";

            Escaner escaner1 = new Escaner("HP", Escaner.TipoDoc.libro);

            Libro libro1 = new Libro("Libro 1", "Autor 1", 2001, "1234567890", "ABC123", 100);
            Libro libro2 = new Libro("Libro 2", "Autor 2", 2002, "0987654321", "DEF456", 200);
            Mapa mapa1 = new Mapa("Mapa 1", "Autor 3", 2003, "GHI789", 50, 60);
            Mapa mapa2 = new Mapa("Mapa 2", "Autor 4", 2004, "JKL012", 70, 80);

            bool resultado;

            resultado = escaner1 + libro1;
            resultado = escaner1 + libro2;
            resultado = escaner1 + mapa1;
            resultado = escaner1 + mapa2;

            int extension;
            int cantidad;
            string resumen;

            Informes.MostrarDistribuidos(escaner1, out extension, out cantidad, out resumen);
            Console.WriteLine($"Distribuidos:\nExtensión = {extension}\nCantidad = {cantidad} items\nResumen =\n{resumen}\n");

            escaner1.CambiarEstadoDocumento(libro1);
            escaner1.CambiarEstadoDocumento(libro2);
            //escaner1.CambiarEstadoDocumento(mapa1);
            //escaner1.CambiarEstadoDocumento(mapa2);

            Informes.MostrarEnEscaner(escaner1, out extension, out cantidad, out resumen);
            Console.WriteLine($"En escaner:\nExtensión = {extension}\nCantidad = {cantidad} items\nResumen =\n{resumen}\n");
        }
    }
}