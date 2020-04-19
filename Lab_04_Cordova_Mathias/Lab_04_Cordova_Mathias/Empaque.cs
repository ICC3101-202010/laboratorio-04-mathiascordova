using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Cordova_Mathias
{
    class Empaque : Maquina
    {
        private int MemoriaMax = 5;
        private int MemoriaUse = 0;

        public override void Apagado()
        {
            Console.WriteLine("APAGANDO EMPAQUE...");
            Console.WriteLine("");
        }
        public override void Encendido()
        {
            MemoriaUse = 0;
            Console.WriteLine("ENCENDIENDO EMPAQUE...");
            Console.WriteLine("Memoria: " + MemoriaUse);
            Console.WriteLine("");
        }
        public override bool Reiniciado()
        {
            if (MemoriaUse >= MemoriaMax)
            {
                Console.WriteLine("EMPAQUE NECESITA REINICIAR!");
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
