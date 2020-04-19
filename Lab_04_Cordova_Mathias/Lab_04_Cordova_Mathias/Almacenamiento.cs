using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Cordova_Mathias
{
    class Almacenamiento : Maquina
    {
        private int MemoriaMax = 6;
        private int MemoriaUse = 0;

        public override void Apagado()
        {
            Console.WriteLine("APAGANDO ALMACENAMIENTO...");
            Console.WriteLine("");
        }
        public override void Encendido()
        {
            MemoriaUse = 0;
            Console.WriteLine("ENCENDIENDO ALMACENAMIENTO...");
            Console.WriteLine("Memoria: " + MemoriaUse);
            Console.WriteLine("");
        }
        public override bool Reiniciado()
        {
            if (MemoriaUse >= MemoriaMax)
            {
                Console.WriteLine("ALMACENAMIENTO NECESITA REINICIAR!");
                Console.WriteLine("Memoria: " + MemoriaUse);
                Console.WriteLine("");
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Procesar(int Peso)
        {
            MemoriaUse += Peso;
        }
    }
}
