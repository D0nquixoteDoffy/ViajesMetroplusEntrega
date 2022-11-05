using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesMetroplusEntrega
{
    public class Viaje
    {
        //Atributos
        private string ruta;
        private int cantidadPasajeros;

        //Constructor
        public Viaje()
        {
            ruta = "";
            cantidadPasajeros = 0;
        }

        //Propiedades
        public string Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

        public int CantidadPasajeros
        {
            get { return cantidadPasajeros; }
            set { cantidadPasajeros = value; }
        }
    }
}
