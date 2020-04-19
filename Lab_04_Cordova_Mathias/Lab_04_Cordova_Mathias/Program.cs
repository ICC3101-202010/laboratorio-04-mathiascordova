using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Cordova_Mathias
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador compu = new Computador();
            Random random = new Random();
            int Hora = 9;
            Console.WriteLine("Hora de inicio: "+Hora+".00");
            Console.WriteLine("");
            compu.FabricOn();
            for (int i=10; i < 20; i++)
            {
                Console.WriteLine("Hora: " + Hora + ".00");
                Console.WriteLine("");
                List<int> Piezas = new List<int>() { random.Next(1,4), random.Next(1, 4), random.Next(1, 4), random.Next(1, 4), random.Next(1, 4) };
                compu.Work(Piezas);
                compu.CheckReset();
                Console.WriteLine("");
                Hora++;

            }
            Console.WriteLine("Hora cierre: "+Hora+".00");
            Console.WriteLine("");
            compu.FabricOff();
            
            
        }
    }
}
