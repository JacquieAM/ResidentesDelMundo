using System;
using System.Collections.Generic;
using System.Text;

namespace ResidentesDelMundo
{
    class Italia : Paises
    {
        public Italia(String nombrePais, String nombreHabitante, String saluda, String baila, String fraseIconica) :
            base(nombrePais, nombreHabitante, saluda, baila, fraseIconica)
        {

        }
        //constructor
        public Italia(String nombreHabitante)
        {
            this.nombrePais = "Italia";
            this.nombreHabitante = nombreHabitante;
            this.saluda = "Ciao " + nombreHabitante + "!";
            this.baila = "Tarantella";
            this.fraseIconica = "Ad ogni santo vien sua festa";

        }
    }
}
