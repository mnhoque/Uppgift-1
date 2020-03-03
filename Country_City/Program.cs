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

            //Console.WriteLine("Enter a double number ");
            /*string number = (Console.ReadLine());

            double d1 = double.Parse(number, CultureInfo.InvariantCulture);

            string digit= String.Format("{0:0.000}", d1);

            Console.WriteLine(digit);
            //Random Number
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


            //Uppgift 2
            /*Console.WriteLine("Enter age ");
            int enteredAge = int.Parse(Console.ReadLine());
            int money = 15000;
            do
            {
                if (money > 20000 || enteredAge < 60)
                {
                    money = money + 500;
                    //enteredAge = enteredAge + 1;
                    Console.WriteLine("You are saving little." + money);
                    enteredAge = enteredAge + 1;

                }
                else
                {
                    money = money + 1000;

                    Console.WriteLine("You are saving a lot." + money);

                }
            } while (money < 20000 && enteredAge < 65);*/

            //uppgift 2 del 3:
            /*double temparatureInCelcius=0;
            int temparatureInFarenhite=0;
            Console.WriteLine("Enter a temparature in farenhite ");
            temparatureInFarenhite= int.Parse(Console.ReadLine());
            Console.WriteLine("Temparatu in farenhite " + temparatureInFarenhite);

            temparatureInCelcius = (temparatureInFarenhite - 32) * (5 / 9.00);
            Console.WriteLine("Now the temparature is in celcius "+temparatureInCelcius);
            
            if(temparatureInCelcius>73 && temparatureInCelcius < 77)
            {
                Console.WriteLine("Der ar rätt in celcius");
            }
            else
            {
                Console.WriteLine("Wrong temparature");
                while(temparatureInCelcius<73||temparatureInCelcius>77){
                    Console.WriteLine("Enter a temparature in farenhite again");
                    temparatureInFarenhite = int.Parse(Console.ReadLine());

                    temparatureInCelcius = (temparatureInFarenhite - 32) * (5 / 9.00);
                    Console.WriteLine("Now the temparature is in celcius " + String.Format("{0:0.00}", temparatureInCelcius));

                    if (temparatureInCelcius > 73 && temparatureInCelcius < 77)
                    {
                        Console.WriteLine("Der ar nu rätt temparature in celcius" );
                    }

                }
                

            }*/

            //uppgift 2 del 4:

            /*double temparatureInCelcius = 0;
            int temparatureInFarenhite = 0;
            bool checkRight = false;
            do
            {
                Console.WriteLine("Enter a temparature in farenhite ");
                try
                {
                    temparatureInFarenhite = int.Parse(Console.ReadLine());
                    Console.WriteLine("Temparatu in farenhite " + temparatureInFarenhite);
                    checkRight = true;
                }
                catch
                {
                    Console.WriteLine("skriv fel , bara intiger allowed");
                }
            } while (checkRight==false);

            temparatureInCelcius = (temparatureInFarenhite - 32) * (5 / 9.00);
            Console.WriteLine("Now the temparature is " + String.Format("{0:0.00}", temparatureInCelcius));

            if (temparatureInCelcius > 73 && temparatureInCelcius < 77)
            {
                Console.WriteLine("Der ar rätt in celcius");
            }
            else
            {
                
                while (temparatureInCelcius < 73 || temparatureInCelcius > 77)
                {
                    Console.WriteLine("Wrong temparature");
                    Console.WriteLine("Enter a temparature in farenhite again");
                    try
                    {
                        temparatureInFarenhite = int.Parse(Console.ReadLine());
                        Console.WriteLine("Temparatu in farenhite " + temparatureInFarenhite);
                        checkRight = true;
                        if (checkRight == true)
                        {
                            temparatureInCelcius = (temparatureInFarenhite - 32) * (5 / 9.00);
                            Console.WriteLine("Now the temparature is in celcius " + String.Format("{0:0.00}", temparatureInCelcius));
                            
                        }
                        
                    }
                    catch
                    {
                        Console.WriteLine("skriv fel , bara intiger allowed");
                    }
                    //while (checkRight == false) ;
                    //temparatureInFarenhite = int.Parse(Console.ReadLine());

                    if (temparatureInCelcius > 73 && temparatureInCelcius < 77)
                    {
                        Console.WriteLine("Der ar nu rätt temparature in celcius");
                    }

                }
            }*/
            //Uppgift 3:2
            /*int anyNumber = 40;
            int[] numberArray = new int[10];

            numberArray[0] = 5;
            numberArray[1] = 10;
            numberArray[2] = 15;
            numberArray[3] = 20;
            numberArray[4] = 25;
            numberArray[5] = 30;
            numberArray[6] = 35;
            numberArray[7] = 40;
            numberArray[8] = 45;
            numberArray[9] = 50;

            foreach (int i in numberArray)
            {
                Console.WriteLine(i);
            }

            for(int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] == anyNumber)
                {
                    Console.WriteLine("matched");
                }
            }*/

            //Uppgift 3:3;
            /*Random rand = new Random();
            int randomNumber = rand.Next(1, 10);

            bool match = false;

            int[] numberArray = new int[10];

            numberArray[0] = 5;
            numberArray[1] = 10;
            numberArray[2] = 15;
            numberArray[3] = 20;
            numberArray[4] = 25;
            numberArray[5] = 30;
            numberArray[6] = 35;
            numberArray[7] = 40;
            numberArray[8] = 45;
            numberArray[9] = 50;


            for (int i = 0; i <= numberArray.Length - 1; i++)
            {
                if (numberArray[i] == randomNumber)
                {
                    match=true;
                }
                

            }

            if (match == true)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("You dib not won");
            }*/

            //Uppgift 3:Mål C

            Console.WriteLine("Enter a number between 1 and 25 ");
            

            bool match = false;

            int[] numberArray = new int[10];

            for(int i = 0; i < numberArray.Length;i++)
            {
                Console.WriteLine("Enter a number between 1 and 25 ");
                int numberEntered = int.Parse(Console.ReadLine());
                if (numberEntered < 1 || numberEntered > 25)
                {
                    i = i - 1;
                }
                else
                {
                    numberArray[i] = numberEntered;
                }
            }

            foreach(int i in numberArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
