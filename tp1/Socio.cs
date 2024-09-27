using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Socio
    {
         int dni;
         String nombre;
         String apellido;
         int cantAct;

        public Socio (int dni, string nombre, string apellido, int cantAct)
        {
            this.dni = dni; 
            this.nombre = nombre;
            this.apellido = apellido;
            this.cantAct = cantAct;
        }

        //Retorna el dni del socio.
        public int getDni()
        {
            return this.dni;
        }

        //Retorna el nombre del socio.
        public string getNombre()
        {
            return this.nombre;
        }

        //Retorna el apellido del socio.
        public string getApellido()
        {
            return this.apellido;
        }

        //Retorna la cantidad de actividades en las que esta inscrito el socio.
        public int getCantAct()
        {
            return this.cantAct;
        }

        //Establece el dni del socio con el dni que recibio por parametro.
        public void setDni(int dni)
        {
            this.dni = dni;
        }

        //Establece el nombre del socio con el nombre que recibio por parametro.
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        //Establece el apellido del socio con el apellido que recibio por parametro.
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        //Verifica si el socio tiene cupos disponibles para inscribirse a actividades.
        public bool hayCupos()
        {
            return this.cantAct > 0;
        }

        //Si el socio tiene cupos disponibles, le restara un cupo.
        public void restarCupoAct()
        {
            if(hayCupos())
            {
                this.cantAct--;
            }
        }

    }
}