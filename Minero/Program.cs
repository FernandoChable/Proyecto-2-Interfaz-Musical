using System;
using System.IO;

class Program
{
    static void Main(String[] args)
    {
        // Esta linea de aquí nos servirá para obtener la ruta base del ejecutable, para después acceder a la carpeta de la música
        string basePath = AppDomain.CurrentDomain.BaseDirectory;

        // Aquí ya vamos a acceder a la carpeta de la música
        string musicaPath = Path.GetFullPath(Path.Combine(basePath, @"../../../../Rolitas"));

        // Aquí solo vamos a comprobar que de verdad exista dicha carpeta (y de paso ver si no la regué con la dirección xd)
        if (Directory.Exists(musicaPath))
        {
            Console.WriteLine($"Accediendo a los archivos MP3 en la carpeta: {musicaPath}");
        } else
        {
            Console.WriteLine($"No se encontró la carpeta en: {musicaPath}");
        }
    }
}