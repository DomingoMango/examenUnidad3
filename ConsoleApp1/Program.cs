using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Arthur conan Doyle", "Rata girando", 1808);
            libroFiccion goth = new libroFiccion("Gotico", "Edgar Allan Poe", "El cuervo", 12);
            libroNoFiccion BenitoJuarezEsGay = new libroNoFiccion("Mi tio", "Benito juare ES gay", 2023, "Historia verdadera");
            libro1.printInfo();
            goth.printInfo();
            BenitoJuarezEsGay.printInfo();
            goth.establecerGenero();
            BenitoJuarezEsGay.establecerTema();
            goth.printInfo();
            BenitoJuarezEsGay.printInfo();
        }
    }
}
