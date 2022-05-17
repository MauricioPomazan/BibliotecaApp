using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    class Autor
    {
        //Reutilizamos la misma clase Persona de la semana pasada y la consideramos Autor
        // Atributos

        private string nombre;
        private int edad;
        private string sexo;
        private double peso;
        private double altura;

        // Métodos constructores

        public Autor()

        {

            this.nombre = "";
            this.edad = 0;
            sexo = string.Empty;
            peso = 0;
            altura = 0.0;

        }

        public Autor(string nombre, int edad, string sexo, double peso, double altura)

        {

            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;

        }

        public Autor(string nom)
        {
            nombre = nom;
        }



        //Propiedades

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int pEdad
        {
            set { edad = value; }
            get { return edad; }
        }

        public string pSexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public double pPeso
        {
            set { peso = value; }
            get { return peso; }
        }

        public double pAltura
        {
            get { return altura; }
            set { altura = value; }
        }



        //Métodos de control o comportamiento

        public int calcularIMC()
        {
            const int pesoMin = 20;
            const int pesoMax = 25;
            double imc = 0;

            imc = peso / (altura * altura);

            if (imc < pesoMin)
                return -1;

            else
                if (imc > pesoMax)
                return 1;

            else
                return 0;

        }

        public bool esMayorDeEdad()
        {

            bool mayor = false;
            if (edad >= 21)
            {
                mayor = true;
            }

            else
            {
                mayor = false;
            }
            return mayor;

        }

        //Método toString()

        public string toString()
        {
            return "Nombre: " + this.nombre + " |Edad: " + edad + " |Sexo: " + sexo
                   + " |Peso: " + peso + "kgs. |Altura: " + altura + "mts. |IMC: " + this.calcularIMC()
                   + " |Mayor de Edad: " + this.esMayorDeEdad();
        }


    }
}
