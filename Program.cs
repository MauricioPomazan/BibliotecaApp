using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un autor con parametros
            Autor autor1 = new Autor("J. K. Rowling", 60, "M", 57, 1.65);

            //Creamos un libro con parametros
            Libro libro1 = new Libro(1, "Harry Potter", autor1, 100);

            //Creamos un autor sin parametros y luego seteamos con propiedades
            Autor autor2 = new Autor();
            autor2.pNombre = "Un autor";
            autor2.pEdad = 70;
            autor2.pSexo = "H";
            autor2.pPeso = 80;
            autor2.pAltura = 1.80;

            //Creamos un libro sin parametros y luego seteamos con propiedades
            //algunos datos ingresamos por teclado, otros los asignamos directamente
            Libro libro2 = new Libro();

            Autor autor3 = new Autor("Autor3");
                autor3.pEdad = 35;
                autor3.pPeso = 70;

            //Libro libro3 = new Libro(1,"libro3",autor3);

            //libro3.pPaginas = 300;


            

            Console.WriteLine("Ingresar datos del libro");
            libro2.pAutor = autor2;         //relaciona libro2 con autor2 implica que primero debe crearse autor2
            Console.WriteLine("ISBN:");
            libro2.pIsbn = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Titulo:");
            libro2.pTitulo = Console.ReadLine();
            Console.WriteLine("Paginas:");
            libro2.pPaginas = 90;

            //Console.WriteLine("Ingresar datos del libro");
            //libro3.pAutor = autor3;         //relaciona libro3 con autor2 implica que primero debe crearse autor3
            //Console.WriteLine("Paginas:");
            //libro3.pPaginas = 300;
           
            Console.WriteLine(libro1.toString());
            Console.WriteLine(libro2.toString());
            //Console.WriteLine(libro3.toString());

            //Cual es el titulo del libro mas grande? (cantidad de paginas)
            if (libro1.pPaginas < libro2.pPaginas)
                Console.WriteLine("El libro " + libro1.pTitulo + " tiene más páginas");


            else
                Console.WriteLine("El libro" + libro2.pTitulo + "tiene mas paginas");

            //Cual es el titulo del libro que tiene el autor mas viejo? (mayor edad)
            if (libro1.pAutor.pEdad>libro2.pAutor.pEdad)
                Console.WriteLine("El libro " + libro1.pTitulo + " tiene el autor más viejo");
            else
                Console.WriteLine("El libro " + libro2.pTitulo + " tiene el autor más viejo");


            // if (autor1.pEdad > autor2.pEdad) Está mal!!! no corresponde por el modelo Libro --> Autor

            Console.WriteLine("\n\n");
            Console.WriteLine("Esta es mi repisa...\n\n");
            Biblioteca MiRepisa = new Biblioteca();
            MiRepisa.AgregarLibro(libro1);
            Console.WriteLine("\n\n");
            MiRepisa.AgregarLibro(libro2);
            MiRepisa.MostrarListado();


            Console.Read();
        }
    }
}
