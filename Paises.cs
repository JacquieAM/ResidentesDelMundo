using System;
using System.Collections.Generic;
using System.Text;

namespace ResidentesDelMundo
{
    class Paises
    {
        // declaracion de  variables
        protected string nombrePais;
        protected string nombreHabitante;
        protected string saluda;
        protected string baila;
        protected string fraseIconica;

        //constructor
        public Paises (string nombrePais, string nombreHabitante, string saluda, string baila, string fraseIconica)
        {
            this.nombrePais = nombrePais;
            this.nombreHabitante = nombreHabitante;
            this.saluda = saluda;
            this.baila = baila;
            this.fraseIconica = fraseIconica;
        }
        //constructor vacio
        public Paises()
        {

        }
        // metodo de saludo
        public void saludaAHabitante()
        {
            Console.WriteLine(saluda);
        }

        //metodo saludo introduciendo nombre
        public void saludaAHabitante(String nombreHabitante)
        {
            this.nombreHabitante = nombreHabitante;
            Console.WriteLine(saluda);
        }
        //metodo baile
        public void baileTipico()
        {
            Console.WriteLine(baila);
        }
        //metodo baile tomando nombre
        public void baileTipico(String nombreHabitante)
        {
            this.nombreHabitante = nombreHabitante;
            Console.WriteLine(baila);
        }
        //metodo frase
        public void frase()
        {
            Console.WriteLine(fraseIconica);
        }
        //metodo frase tomando nombre
        public void frase(String nombreHabitante)
        {
            this.nombreHabitante = nombreHabitante;
            Console.WriteLine(fraseIconica);
        }
        //metodo para mostrar la informacion
        public void info()
        {
            Console.WriteLine("\n Pais : " + nombrePais);
            Console.WriteLine("\n Nombre de Habitante : " + nombreHabitante);
            Console.WriteLine("\n Saludo : " + saluda);
            Console.WriteLine("\n Baile Tipico: " + baila);
            Console.WriteLine("\n Frase Iconica: " + fraseIconica);
        }

        // get setters

        public String NombrePais
        {
            get { return this.nombrePais; }
            set { this.nombrePais = nombrePais; }
        }
        public String NombreHabitante
        {
            get { return this.nombreHabitante; }
            set { this.nombreHabitante = nombreHabitante; }
        }

        public String Saludo
        {
            get { return this.saluda; }
            set { this.saluda = saluda; }
        }

        public String Baila
        {
            get { return this.baila; }
            set { this.baila = baila; }
        }

        public String FraseIconica
        {
            get { return this.fraseIconica; }
            set { this.fraseIconica = fraseIconica; }
        }

    }
}
