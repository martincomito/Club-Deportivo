using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    internal class Actividad
    {
        string nombre;
        int cupos;

        public Actividad(string nombre, int cupos)
        {
            this.nombre = nombre;
            this.cupos = cupos;
        }

        //Retorna el nombre de la actividad.
        public string getNombre()
        {
            return this.nombre;
        }

        //Retorna la cantidad de cupos disponibles de la actividad.
        public int getCupos()
        {
            return this.cupos;
        }

        //Verifica si la actividad tiene cupos disponibles para dar de alta un socio en esa actividad.
        public bool hayCupos()
        {
            return this.cupos > 0;
        }

        //Si la actividad tiene cupos disponibles, le restara un cupo.
        public void reservarCupo()
        {
            if (hayCupos())
            {
                this.cupos--;
            }
        }

    }
}