using System;
using System.Collections.Generic;
using System.Text;

namespace ResidentesDelMundo
{
    class Alemania : Paises
    {
        public Alemania(String nombrePais, String nombreHabitante, String saluda, String baila, String fraseIconica) :
            base(nombrePais, nombreHabitante, saluda, baila, fraseIconica)
        {

        }
        //constructpr
        public Alemania(String nombreHabitante)
        {
            this.nombrePais = "Alemania";
            this.nombreHabitante = nombreHabitante;
            this.saluda = "Hallo " + nombreHabitante + "!";
            this.baila = "Schuhplattler";
            this.fraseIconica = "Abwarten und Tee trinken";

        }
    }
}
