using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Cordova_Mathias
{
    class Ensamblaje : Maquina
    {
        private int MemoriaMax = 8;
        private int MemoriaUse = 0;

        public override void Apagado()
        {
            Console.WriteLine("APAGANDO ENSAMBLAJE...");
            Console.WriteLine("");
        }
        public override void Encendido()
        {
            MemoriaUse = 0;
            Console.WriteLine("ENCENDIENDO ENSAMBLAJE...");
            Console.WriteLine("Memoria: " + MemoriaUse);
            Console.WriteLine("");
        }
        public override bool Reiniciado()
        {
            if (MemoriaUse >= MemoriaMax)
            {
                Console.WriteLine("ENSAMBLAJE NECESITA REINICIAR!");
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
