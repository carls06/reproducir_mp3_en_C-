using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 
//para que pueda reproducir un mp3 hay que agregar una referencia wmp.dll 
//la referencia wmp.dll esta en C:\Windows\    en esa direccion se puede buscar 
//
//despues de agregar la referencia se puede agregar la libreria siguiente 
using WMPLib;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            WindowsMediaPlayer musica = new WindowsMediaPlayer();

            //el archivo mp3 debe estar en la carpeta del proyecto
            musica.URL = "C:\\Users\\pc\\Desktop\\ConsoleApplication\\sound.mp3";

        
                Console.WriteLine("sonido");
                musica.controls.play();
           
            
            Console.ReadKey();
        }
    }
}
