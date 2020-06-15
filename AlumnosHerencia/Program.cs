using System;

namespace AlumnosHerencia
{
    class Alumno
    {
        protected string nombreA;
        public Alumno(string nombreA)
        {
            this.nombreA = nombreA;
        }
        public void presentar()
        {
            Console.WriteLine("Mucho gusto me llamo {0} y soy estudiante.", nombreA);
        }
    }
    class Licenciatura:Alumno
    {
        protected int Servicio;
        protected string Residencia;
        public Licenciatura(string nombreA, int Servicio, string Residencia): base(nombreA)
        {
            this.Servicio = Servicio;
            this.Residencia = Residencia;
        }
        public new void presentar()
        {
            Console.WriteLine("Un gusto conocerle, me llamo {0} y estudió una licenciatura. Debo hacer {1} horas de servicio social y mi residencia {2}", nombreA, Servicio, Residencia);
        }
    }
    class Posgrado:Alumno
    {
        protected string Tema;
        public Posgrado(string nombreA, string Tema): base(nombreA)
        {
            this.Tema = Tema;
        }
        public new void presentar()
        {
            Console.WriteLine("Buen día! Me llamo {0}. En estos momentos me encuentro estudiando mi posgrado y he decidido que el tema de mi investigación será {1}.", nombreA, Tema);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alumno Vanessa = new Alumno("Vanessa");
            Vanessa.presentar();
            Alumno Noemi = new Alumno("Noemi");
            Noemi.presentar();
            Alumno Ricardo = new Alumno("Ricardo");
            Ricardo.presentar();

            //Objetos de tipo Licenciatura
            Licenciatura Usui = new Licenciatura("Usui", 400, "ya la he realizado.");
            Usui.presentar();
            Licenciatura Misaki = new Licenciatura("Misaki", 400, "ya la he realizado.");
            Misaki.presentar();
            Licenciatura Suzuna = new Licenciatura("Suzuna", 350, "aún no la he realizado.");
            Suzuna.presentar();

            //Objetos de tipo Posgrado
            Posgrado Emma = new Posgrado("Emma", "Energías Alternativas");
            Emma.presentar();
            Posgrado Elios = new Posgrado("Elios", "Inteligencia Artificial");
            Elios.presentar();
            Posgrado Johan = new Posgrado("Johan", "Estereotipos y prejuicios sociales del delincuente");
            Johan.presentar();
        }
    }
}
