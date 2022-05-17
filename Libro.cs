using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    class Libro
    {
        private int isbn;
        private string titulo;
        private Autor autor;    //relacion de asociacion 1 a 1 --> Libro "tiene un" Autor
        private int paginas;

        public int pIsbn

         { set { isbn = value; } 
          get { return isbn; } }

        public string pTitulo

        { set { titulo = value; }
          get { return titulo; } }

        public Autor pAutor
        { set { autor = value; } 
            get { return autor; } }

        public int pPaginas
        { set { paginas = value; } 
            get { return paginas; } }


        public Libro(int isbn, string titulo, Autor autor, int paginas)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }
        public Libro()
        {
            this.isbn = 0;
            this.titulo = string.Empty;
            this.autor = null;
            this.paginas = 0;
        }

        public string toString()
        { 
            return "ISBN: " + isbn + " |Titulo: " + titulo + " |Autor: " + autor.toString() //lleva parentecis porq es un metodo
                + " |Paginas: " + paginas;
        }

    }
}
