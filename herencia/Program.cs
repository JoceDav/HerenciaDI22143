using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    /*Programa de herencia, herencia es la caracteristica de pasar atributos y  metodos a otros objetos o clases*/
    //clase mamá
    class Operacion
    {
        /*Guarda los espacios de memoria de 3 valores*/
        //Modificador    tipo de dato       nombre
        protected           float             valor1;
        protected           float             valor2;
        protected           float             resultado;
        //Atributos clase operacion
        /*Los metos que se ponen a continuacion son las funciones de obtener el valor de la caja de texto y guardarlo en la memoria
         * dentro de la variable indicada*/

        //Usamos el constructir POR CADA CLASE DE MEMORIA

        public float Valor1 //Caja de memoria 1
        {
            get { return valor1; } //Vamos por el valor de la caja de texto 
            set { valor1 = value; } //Lo guarda en la memoria
        }

        public float Valor2 //Caja de memoria 2
        {
            get { return valor2; } //Vamos por el valor de la caja de texto 
            set { valor2 = value; } //Lo guarda en la memoria
        }

        public float Resultado //Caja de memoria 3
        {
            get { return resultado; } //Vamos por el valor de la caja de texto 
            set { resultado = value; } //Lo guarda en la memoria
        }

    }

    //Creamos nuestras clases hijo que usara los metodos de crear dato
    class Sumar : Operacion //Los : nos dan permiso de usar lo que tiene operacion 
    {
        //Las clases hijos tambien pueden tener sus propios atributos y metodos.
        //Pueden tener variables de uso solamente para la clase hijo. 
        //Declarar variables de esta clase 
        //Atributos de esta clase 
        //Metodos de clase
        public float operar(float v1, float v2)
        {
            valor1 = v1; //Accesamos al contructor de operacion 
            valor2 = v2;
            return Resultado = valor1 + valor2;
        }

    }
    class Restar : Operacion //Los : nos dan permiso de usar lo que tiene operacion 
    {
        //Las clases hijos tambien pueden tener sus propios atributos y metodos.
        //Pueden tener variables de uso solamente para la clase hijo. 
        //Declarar variables de esta clase 
        //Atributos de esta clase 
        //Metodos de clase
        public float operar(float v1, float v2)
        {
            valor1 = v1; //Accesamos al contructor de operacion 
            valor2= v2;
            return Resultado = valor1 - valor2;
        }
    }
    class Multiplicar : Operacion //Los : nos dan permiso de usar lo que tiene operacion 
    {
        //Las clases hijos tambien pueden tener sus propios atributos y metodos.
        //Pueden tener variables de uso solamente para la clase hijo. 
        //Declarar variables de esta clase 
        //Atributos de esta clase 
        //Metodos de clase
        public float operar(float v1, float v2)
        {
            valor1 = v1; //Accesamos al contructor de operacion 
            valor2 = v2;
            return Resultado = valor1 * valor2;
        }
    }
    class dividir : Operacion //los : nos dan permisos de usar
                              //lo que tiene operacion
    {
        public double Operar(float num1, float num2)
        {
            // Verificar si el divisor es cero para evitar una división por cero
            if (num1 == 0)
            {
                throw new ArgumentException("No se puede dividir entre cero.");
            }

            // Realizar la división y devolver el resultado
            return (double)num1 / num2;
        }
    }

        static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculadora());
        }
    }
}
