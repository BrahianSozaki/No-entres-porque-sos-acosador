using System.Collections.Generic;
namespace Rodri
{
    public class Constructora
    {

        int presupuesto;
        int cantidadDeHorasDeTrabajo;
        List<contratistas> contratistas = new List<contratistas>();

        public Constructora(int presupuesto, int cantidadDeHorasDeTrabajo, List<contratistas> contratistas)
        {
            this.presupuesto = presupuesto;
            this.cantidadDeHorasDeTrabajo = cantidadDeHorasDeTrabajo;
            this.contratistas = contratistas;
        }

        public bool sePuede(){
            int acu = 0;
            foreach (var i in contratistas){
                i.trabajar(cantidadDeHorasDeTrabajo);
                acu += i.cobrar();
            }
            return presupuesto > acu;
        }

    }
}