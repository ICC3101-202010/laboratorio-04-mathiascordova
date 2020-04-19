using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Cordova_Mathias
{
    class Recepcion : Maquina
    {
        private int MemoriaMax = 10;
        private int MemoriaUse = 0;

        public override void Apagado()
        {
            Console.WriteLine("APAGANDO RECEPCION...");
            Console.WriteLine("");
        }
        public override void Encendido()
        {
            MemoriaUse = 0;
            Console.WriteLine("ENCENDIENDO RECEPCION...");
            Console.WriteLine("Memoria: " + MemoriaUse);
            Console.WriteLine("");
        }
        public override bool Reiniciado()
        {
            if (MemoriaUse >= MemoriaMax)
            {
                Console.WriteLine("RECEPCION NECESITA REINICIAR!");
                Console.WriteLine("Memoria: "+MemoriaUse);
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
