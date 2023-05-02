using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class libroFiccion : Libro
    {
        protected string genero;

        public libroFiccion(string genero, string autor, string titulo, int anioPubli) : base(autor,titulo,anioPubli)
        {
            this.genero = genero;
        }

        public libroFiccion(string autor, string titulo, int anioPubli) : base(autor, titulo, anioPubli)
        {
        }
        public void printInfo()
        {
            Console.WriteLine("Titulo: " + this.titulo + " Autor: " + this.autor + " Año de publicacion: " + this.anioPubli + " Genero: "+this.genero);
        }
        public void establecerGenero()
        {
            Console.WriteLine("Ingrese el genero del libro");
            this.genero=Console.ReadLine();
        }
        public string obtenerGenero()
        {
            return this.genero;
        }
    }
}
