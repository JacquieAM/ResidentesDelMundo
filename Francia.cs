using System;
using System.Collections.Generic;
using System.Text;

namespace ResidentesDelMundo
{
    class Francia : Paises
    {
        public Francia(string nombrePais, string nombreHabitante, string saluda, string baila, string fraseIconica) : 
            base (nombrePais, nombreHabitante, saluda, baila, fraseIconica)
        {

        }
        //constructor
        public Francia(string nombreHabitante)
        {
            this.nombrePais = "Francia";
            this.nombreHabitante = nombreHabitante;
            this.saluda = "Salut " + nombreHabitante + "!";
            this.baila = "Vals";
            this.fraseIconica = "C'est la Vie";
        }


    }
}
