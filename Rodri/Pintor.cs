namespace Rodri
{
    public class Pintor : contratistas
    {

        int horas;
        public void trabajar(int horas){
            this.horas = horas;
        }

        public int cobrar(){
            return horas * 150;
        }

    }
}