using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Cordova_Mathias
{
    class Computador
    {
        private Recepcion Rec;
        private Almacenamiento Alm;
        private Ensamblaje Ens;
        private Verificacion Ver;
        private Empaque Emp;

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
                    continue;
                }
            }
        }
    }
}
