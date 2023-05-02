using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class libroNoFiccion : Libro
    {
        protected string tema;
        public libroNoFiccion(string autor, string titulo, int anioPubli,string tema) : base(autor, titulo, anioPubli)
        {
            this.tema = tema;
            this.autor=autor;
            this.titulo = titulo;
            this.anioPubli = anioPubli;
        }
        public libroNoFiccion(string autor, string titulo, int anioPubli) : base(autor, titulo, anioPubli)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.anioPubli = anioPubli;
        }
        public void printInfo()
        {
            Console.WriteLine("Titulo: " + this.titulo + " Autor: " + this.autor + " Año de publicacion: " + this.anioPubli+ " Tema: " + this.tema);
        }
        public void establecerTema()
        {
            Console.WriteLine("Ingrese el tema del libro");
            this.tema = Console.ReadLine();
        }
        public string obtenerTema()
        {
            return this.tema;
        }
    }
}
