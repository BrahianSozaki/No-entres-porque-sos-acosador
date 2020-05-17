namespace Rodri
{
    public class Albañil : contratistas
    {
        int horas;
        int edad;
        bool titulo;

        public Albañil(int edad, bool titulo)
        {
            this.edad = edad;
            this.titulo = titulo;
        }

        public void trabajar(int horas){
            this.horas = horas;
        }

        public int cobrar(){
            if (edad > 20 && edad < 30){

                if (titulo) return (horas * 50) + 50;
                else return horas * 50;

            }
            else{

                if (edad > 30 && edad < 50){

                    if (titulo) return (horas * 90) + 50;
                    else return horas * 90;

                }
                else{

                    if (titulo) return (horas * 120) + 50;
                    else return horas * 120;

                }

            }
        }

    }
}