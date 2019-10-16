using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Titolo
            Console.WriteLine("Esercitazione sulla gestione");

            // Primo processo,apertura di un file text
            Process.Start("Notepad.exe", @"\\dc01srv\_Condivisa\INF\4 B\Deboli Christopher\Processo_Gestione\ProcessiApp\File\HelloWorld.txt");

            //Apertura di un link
            Process.Start("Chrome.exe", "@ https://classroom.google.com/h");


            //-----------------------------------------------------------------------------------------------------------------------------------


            var app = new Process(); // Aprire un processo con la variabile var

            app.StartInfo.FileName = @"Notepad.exe"; // Apro il programma Notepad.exe
            
            app.StartInfo.Arguments = @"\\dc01srv\_Condivisa\INF\4 B\Deboli Christopher\Processo_Gestione\ProcessiApp\"; // Apertura
            
            app.Start(); // 
            
            app.PriorityClass = ProcessPriorityClass.RealTime; // 
            
            //app.WaitForExit(); // Esce solo quando clicco la freccia

            /*var processes = Process.GetProcesses();

            foreach (var p in processes)
            {
                if (p.ProcessName == "notepad") // Chiude tutte le app di nome "Notepad"
                {
                    p.Kill(); // Chiudo app
                }
            }*/

            Console.WriteLine("Processo Terminato");
            Console.ReadLine();

        }
    }
}