using System;

namespace Sparegrisen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asking the user for data, the amount of money the user wishes to deposit, and store it in the variable: amount
            Console.WriteLine("Velkommen til Sparegrisen!");
            Console.WriteLine("Hvor mange penge ønsker du at sætte ind?");

            double amount = double.Parse(Console.ReadLine());


            //asking for the intrest the user is being offerd, and store the data in the variable: intrest
            Console.WriteLine("Hvd er den tilbudte rente? skrives som tal uden % tegn");

            double intrest = double.Parse(Console.ReadLine());

            //asking for the number of years the user want to deposit the money, and store it in the variable: years
            Console.WriteLine("Hvor mange år ønsker du at pengene skal stå?");

            double years = double.Parse(Console.ReadLine());



            //here is the intrest calculated 

            double calculatedIntrest = intrest / 100;


            //inside the forloop starts the calculation and the variable amount the is set equal to the amountWhitIntrests 

            for (int i = 0; i < years; i++)
            {
                double amountWhitIntrests = (amount * (1 + calculatedIntrest));

                amount = amountWhitIntrests;
            }

            Console.WriteLine($"Ved indsatte beløb, opnås ialt {amount}kr på {years} år!");
        }
    }
}
