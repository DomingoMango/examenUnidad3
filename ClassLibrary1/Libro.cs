using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Libro
    {
        protected string autor;
        protected string titulo;
        protected int anioPubli;

        public Libro(string autor, string titulo, int anioPubli)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.anioPubli = anioPubli;
        }
        public void printInfo()
        {
            Console.WriteLine("Titulo: "+ this.titulo+ " Autor: "+ this.autor + " Año de publicacion: "+this.anioPubli);
        }
    }
}
