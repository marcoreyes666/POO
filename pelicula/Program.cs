using System;

namespace Pelicula
{
    class Pelicula
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;

        public pelicula (int año ) {this.año=añ;}
        public void SetAño(string a) {año=a;}
        public string GetAño(){return año;}

        public pelicula (string titulo) {this.titulo=ti;}
        public void SetTitulo(string t) {titulo= t;}
        public string GetTitulo(){return titulo;}

        public pelicula (string pais){this.pais=pa;}
        public void SetPais (string p){pais = pa;}
        public string GetPais (){return pais;}

        public pelicula (string director){this.director=di;}
        public void SetDirector (string d){director=d;}
        public string GetDirector(){return director;}
        public void imprime()

        {
            Console.Writeline("Datos de pelicula:{0}", titulo, pais, director)
        }
        public pelicula(){titulo= "n/a", año = "n/a", director = "n/a", pais = "n/a" }
    }

    class Program
    {
        static void Main()
        {
            Pelicula p1= new Pelicula();
            p1.SetTitulo("");
            p1.SetAño();
            Console.WriteLine("{0}{1}", p1.GetTitulo(), p1.GetAño());

            Pelicula p2 = new Pelicula();
            p2.SetTitulo("");
            p2.SetAño();
            Console.Writeline("{0}{1}", p2.GetTitulo(), p2.GetAño());

            //Imprimir datos de peliculas con fecha
            p1.imprime();
            p2.imprime();

        }
    }
}
