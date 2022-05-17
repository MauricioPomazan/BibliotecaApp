using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    class Biblioteca
    {
        private Libro[] estanteria = new Libro[2];
        private int posicion;
        public Biblioteca()
        {
            this.posicion = 0;
            this.estanteria = new Libro[2];
        }


        public bool AgregarLibro(Libro libro)

        {
            if (posicion < 2) { 
            estanteria[posicion] = libro;
                posicion++;
                return true;
            }
            else
            {
                return false;
            }


        }

        public void MostrarListado()
        {
            for(int i = 0; i < 2; i++)
            {
                if(estanteria[i] != null)
                Console.WriteLine(estanteria[i].toString());
            }
        }





    }
}
