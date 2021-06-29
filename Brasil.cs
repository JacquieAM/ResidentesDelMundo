using System;
using System.Collections.Generic;
using System.Text;

namespace ResidentesDelMundo
{
    class Brasil : Paises
    {
        public Brasil(String nombrePais, String nombreHabitante, String saluda, String baila, String fraseIconica ) :
            base(nombrePais, nombreHabitante, saluda, baila, fraseIconica)
        {

        }
        //constructor
        public Brasil(String nombreHabitante)
        {
            this.nombrePais = "Brasil";
            this.nombreHabitante = nombreHabitante;
            this.saluda = "Oi " + nombreHabitante + "!";
            this.baila = "Samba";
            this.fraseIconica = "Joga Bonito";

        }
    }
}
