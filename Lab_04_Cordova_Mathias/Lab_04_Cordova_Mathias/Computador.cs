using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Cordova_Mathias
{
    class Computador
    {
        private Recepcion Rec= new Recepcion();
        private Almacenamiento Alm= new Almacenamiento();
        private Ensamblaje Ens= new Ensamblaje();
        private Verificacion Ver= new Verificacion();
        private Empaque Emp= new Empaque();

        public void FabricOn()
        {
            Rec.Encendido();
            Alm.Encendido();
            Ens.Encendido();
            Ver.Encendido();
            Emp.Encendido();
        }
        public void FabricOff()
        {
            Rec.Apagado();
            Alm.Apagado();
            Ens.Apagado();
            Ver.Apagado();
            Emp.Apagado();
        }
        public void Work(List<int> Peso) 
        {
            Rec.Procesar(Peso[0]);
            Alm.Procesar(Peso[1]);
            Ens.Procesar(Peso[2]);
            Ver.Procesar(Peso[3]);
            Emp.Procesar(Peso[4]);
        }
        public void CheckReset()
        {
            List<Maquina> allMaquinas = new List<Maquina>() { Rec, Alm, Ens, Ver, Emp };
            List<string> Nombres = new List<string>() { "RECEPCION", "ALMACENAMIENTO", "ENSAMBLAJE", "VERIFICACION", "EMPAQUE" };
            for (int i=0; i < allMaquinas.Count(); i++)
            {
                bool compReset = allMaquinas[i].Reiniciado();
                if (compReset == true)
                {
                    allMaquinas[i].Apagado();
                    allMaquinas[i].Encendido();
                }
                else
                {
                    Console.WriteLine("LA MAQUINA " + Nombres[i] + " PROCESO SIN PROBLEMAS");
                    Console.WriteLine("");
                }
            }
        }
    }
}
