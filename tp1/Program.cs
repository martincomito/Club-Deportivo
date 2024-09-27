using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Instancio y hardcodeo a las clases correspondientes
            ClubDeportivo club = new ClubDeportivo();
            Socio Leandro = new Socio(41668660, "Leandro", "Seoane", 1);
            Socio Martin = new Socio(12312332, "Martin", "Comito", 3);
            Socio Martin2 = new Socio(12312332, "Martin", "Comito", 3);
            Socio Camila = new Socio(12332112, "Camila", "Cuns Arro", 2);
            Socio Lucrecia = new Socio(45665445, "Lucrecia", "Pedraza", 3);
            Socio Pablo = new Socio(78874589, "Pablo", "Combis", 0);
            Actividad futbol = new Actividad("Futbol",1);
            club.listaActividad.Add(futbol);

            //Doy de alta todos los socios hardcodeados
            club.altaSocio(Leandro.getDni(), Leandro.getNombre(), Leandro.getApellido(), Leandro.getCantAct());
            club.altaSocio(Martin.getDni(), Martin.getNombre(), Martin.getApellido(), Martin.getCantAct());
            club.altaSocio(Martin2.getDni(), Martin2.getNombre(), Martin2.getApellido(), Martin2.getCantAct());
            club.altaSocio(Camila.getDni(), Camila.getNombre(), Camila.getApellido(), Camila.getCantAct());
            club.altaSocio(Lucrecia.getDni(), Lucrecia.getNombre(), Lucrecia.getApellido(), Lucrecia.getCantAct());
            club.altaSocio(Pablo.getDni(), Pablo.getNombre(), Pablo.getApellido(), Pablo.getCantAct());

            //Muestro los socios
            club.mostrarListaSocios();

            Console.WriteLine("---------------------------------------------------------");

            //Inscribo a los socios en las actividades testeando todos los posibles escenarios de exito y error
            Console.WriteLine("DANDO DE ALTA ACTIVIDADES:");

            club.inscribirActividad("Futbol", Martin.getDni());
            Console.WriteLine("------------------------------------");
            club.inscribirActividad("Futbol", Pablo.getDni());
            Console.WriteLine("------------------------------------");
            club.inscribirActividad("Futbol", Camila.getDni());
            Console.WriteLine("------------------------------------");
            club.inscribirActividad("Futbol", 41668661);
            Console.WriteLine("------------------------------------");
            club.inscribirActividad("Tenis", Lucrecia.getDni());
        }
    }
}