namespace Rodri
{
    public class Plomero : contratistas
    {

        int horas;
        public void trabajar(int horas){
            this.horas = horas;
        }

        public int cobrar(){
            return 80 * horas;
        }
    }
}