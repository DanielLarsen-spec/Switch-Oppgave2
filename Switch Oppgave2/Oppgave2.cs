using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Oppgave2
{
    internal class Oppgave2
    {
        public void Run()
        {

            Console.WriteLine("Her kan du velger dager");
            Console.WriteLine("Skriv inn et nummer mellom 1-7 for å velge dag");
            
            
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            DayPrinter(dayNumber);
        }


        private void DayPrinter(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Dette er mandag");
                    break;

                case 2:
                    Console.WriteLine("Dette er tirsdag");
                    break;

                case 3:
                    Console.WriteLine("Dette er onsdag");
                    break;

                case 4:
                    Console.WriteLine("Dette er torsdag");
                    break;

                case 5:
                    Console.WriteLine("Dette er fredag");
                    break;

                case 6:
                    Console.WriteLine("Dette er lørdag");
                    break;

                case 7:
                    Console.WriteLine("Dette er søndag");
                    break;

                default:
                    Console.WriteLine("Ikke et validert nummer!");
                    Run();
                    break;





            }



        }



    }
}
