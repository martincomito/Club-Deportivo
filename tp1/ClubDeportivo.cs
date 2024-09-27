using System;
using System.Xml.Linq;

namespace tp1
{
    internal class ClubDeportivo
    {

        public List<Socio> listaSocios;
        public List<Actividad> listaActividad;

            public ClubDeportivo()
            {
                this.listaSocios = new List<Socio>(); 
                this.listaActividad = new List<Actividad>();
            }

        //El metodo altaSocio verificara que todos los parametros que le pasan no sean null y tengan datos, ademas de comprobar que el socio no este ya inscrito en la lista desde antes.
        //Una vez se pasen todas las verificaciones, dara de alta al socio en la lista de socios.
        public void altaSocio(int dni, string nombre, string apellido, int cantAct)
        {

            bool duplicado = false;
            
            if (dni >= 1000000 && dni <= 100000000 && nombre != null && apellido != null && cantAct >= 0 && cantAct <= 3)
            {
                foreach(var socio in listaSocios)
                {
                    if(socio.getDni().Equals(dni))
                    {
                        duplicado = true;
                    }
                }

                if(duplicado)
                {
                    Console.WriteLine("El dni ingresado ya esta registrado, por favor ingrese otro dni.");
                    Console.WriteLine("------------------------------------");
                }
                else
                {
                    listaSocios.Add(new Socio(dni, nombre, apellido, cantAct));
                    Console.WriteLine("ALTA DE SOCIO EXITOSA.");
                    Console.WriteLine("------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Los datos estan incompletos o erroneos, por favor intentelo de nuevo.");
            }

        }

        //El metodo mostrarListaSocios imprimira por pantalla todos los socios existentes en la lista de socios.
        public void mostrarListaSocios()
        {
            Console.WriteLine("LISTADO DE SOCIOS ACTIVOS:");
            foreach (var socio in listaSocios)
            {
                Console.WriteLine("DNI: " + socio.getDni());
                Console.WriteLine("NOMBRE: " + socio.getNombre());
                Console.WriteLine("APELLIDO: " + socio.getApellido());
                Console.WriteLine("CUPOS DE ACTIVIDADES DISPONIBLES: " + socio.getCantAct());
                Console.WriteLine("------------------------------------");
            }
        }

        //El metodo inscribirActividad primero comprobara que los parametros que le pasaron no sean null, luego buscara en la lista de actividades si el nombre de la actividad que le pasamos por parametro existe.
        //Luego hara lo mismo con el numero de socio en la lista de socios.
        //Luego de verificar que ambos parametros existen en las listas, hara las verificaciones necesarias ya sea para inscribir al socio en la actividad o dar el error correspondiente.
        public string inscribirActividad(string nombreActividad, int numSocio)
         {
            string retorno;
            retorno = "Error";

            Actividad actEncontrada = new Actividad("Error", 0);
            Socio socEncontrado = new Socio(0, "Error", "Error", 0);

            if(nombreActividad != null && numSocio >= 1000000 && numSocio < 100000000)
            {
                foreach (var act in listaActividad)
                {
                    if (act.getNombre().Equals(nombreActividad))
                    {
                        actEncontrada = act;
                    }
                }

                if (actEncontrada.getNombre() != "Error")
                {
                    foreach (var socio in listaSocios)
                    {
                        if (socio.getDni().Equals(numSocio))
                        {
                            socEncontrado = socio;
                        }
                    }

                    if (socEncontrado.getNombre() != "Error")
                    {
                        Console.WriteLine("Inscribiendo a " + socEncontrado.getNombre() + " en la actividad " + actEncontrada.getNombre() + "...");

                        if (socEncontrado.hayCupos())
                        {
                            if (actEncontrada.hayCupos())
                            {
                                socEncontrado.restarCupoAct();
                                actEncontrada.reservarCupo();
                                retorno = "INSCRIPCION EXITOSA";
                            }
                            else
                            {
                                retorno = "NO HAY CUPOS SUFICIENTES EN LA ACTIVIDAD";
                            }
                        }
                        else
                        {
                            retorno = "TOPE DE ACTIVIDADES ALCANZADO";
                        }
                    }
                    else
                    {
                        retorno = "SOCIO INEXISTENTE";
                    }
                }
                else
                {
                    retorno = "ACTIVIDAD INEXISTENTE";
                }
            }

            Console.WriteLine(retorno);
            return retorno;
         }

    }
    
}