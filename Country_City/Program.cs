using System;
using System.Globalization;

namespace Country_City
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("The first name of the person");
            String firstName = Console.ReadLine();
            Console.WriteLine("The last name of the person");
            String lastName = Console.ReadLine();
            Console.WriteLine("Enter the age of the person");
            int ageOfThePerson = int.Parse(Console.ReadLine());

            int ageOfThePension = 65;

            int requiredAgeForPension = ageOfThePension - ageOfThePerson;

            Console.WriteLine("Hej "+firstName+" "+lastName+ " ! Det är nu "+requiredAgeForPension+" år kvar till du går i pension.");*/

            Console.WriteLine("Enter a double number ");
            string number = (Console.ReadLine());

            double d1 = double.Parse(number, CultureInfo.InvariantCulture);

            string digit= String.Format("{0:0.000}", d1);

            Console.WriteLine(digit);
            
            /*Random rand = new Random();
            int numberFromRandom = rand.Next(1, 100);
            Console.WriteLine("The random number is " + numberFromRandom);

            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            
            if (number == numberFromRandom)
            {
                Console.WriteLine("rätt gissat");
            }
            else
            {
                Console.WriteLine("Fel gissat");
                while (number != numberFromRandom)
                {
                    Console.WriteLine("Börja gissa igin");
                    int nyGissatNumber = int.Parse(Console.ReadLine());
                    if (nyGissatNumber == numberFromRandom)
                    {
                        Console.WriteLine("Now you are right");
                        break;
                    }
                }
            }*/
                
            
            Console.ReadLine();
        }
    }
}
