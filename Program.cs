using System;

namespace ResidentesDelMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eliga su pais de Origen");
            Console.WriteLine("1. Francia ");
            Console.WriteLine("2. Italia");
            Console.WriteLine("3. Alemania");
            Console.WriteLine("4. Brasil");
            String mPais = Console.ReadLine();
            Console.WriteLine("Introduzca su nombre");
            String mNombre = Console.ReadLine();
            String menuKey;
            if (mPais == "1")
            {
                mPais = "Francia";
                Francia francia1 = new Francia(mNombre);
                Console.WriteLine("Eliga la accion que desee");
                Console.WriteLine("1. Saludo ");
                Console.WriteLine("2. Baile Tipico");
                Console.WriteLine("3. Frase Iconica");
                menuKey = Console.ReadLine();
                if(menuKey == "1")
                {
                    francia1.saludaAHabitante();
                }
                
                if(menuKey == "2")
                {
                    francia1.baileTipico();
                }
                if(menuKey == "3")
                {
                    francia1.frase();
                }
                
            }

            if(mPais == "2")
            {
                mPais = "Italia";
                Italia italia1 = new Italia(mNombre);
                Console.WriteLine("Eliga la accion que desee");
                Console.WriteLine("1. Saludo ");
                Console.WriteLine("2. Baile Tipico");
                Console.WriteLine("3. Frase Iconica");
                menuKey = Console.ReadLine();
                if (menuKey == "1")
                {
                    italia1.saludaAHabitante();
                }

                if (menuKey == "2")
                {
                    italia1.baileTipico();
                }
                if (menuKey == "3")
                {
                    italia1.frase();
                }
            }

            if(mPais == "3")
            {
                mPais = "Alemania";
                Alemania alemania1 = new Alemania(mNombre);
                Console.WriteLine("Eliga la accion que desee");
                Console.WriteLine("1. Saludo ");
                Console.WriteLine("2. Baile Tipico");
                Console.WriteLine("3. Frase Iconica");
                menuKey = Console.ReadLine();
                if (menuKey == "1")
                {
                    alemania1.saludaAHabitante();
                }

                if (menuKey == "2")
                {
                    alemania1.baileTipico();
                }
                if (menuKey == "3")
                {
                    alemania1.frase();
                }
            }

            if (mPais == "4")
            {
                mPais = "Brasil";
                Brasil brasil1 = new Brasil(mNombre);
                Console.WriteLine("Eliga la accion que desee");
                Console.WriteLine("1. Saludo ");
                Console.WriteLine("2. Baile Tipico");
                Console.WriteLine("3. Frase Iconica");
                menuKey = Console.ReadLine();
                if (menuKey == "1")
                {
                    brasil1.saludaAHabitante();
                }

                if (menuKey == "2")
                {
                    brasil1.baileTipico();
                }
                if (menuKey == "3")
                {
                    brasil1.frase();
                }

            }
        }
    }
}
