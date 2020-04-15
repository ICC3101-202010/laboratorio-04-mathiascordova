using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_Cordova_Mathias
{
    abstract class Maquina
    {
        abstract public void Apagado();
        abstract public void Encendido();
        abstract public bool Reiniciado();
        abstract public void Procesar(int Peso);

    }
}
