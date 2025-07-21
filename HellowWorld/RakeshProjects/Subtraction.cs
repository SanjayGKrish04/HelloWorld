using System;

namespace HellowWorld.RakeshProjects
{
    internal class Subtraction

    {
        public Subtraction()
        {
            Console.WriteLine("Subtraction of Two Number:");

            Console.Write($"Enter 1st number: ");

            string firststnum = Console.ReadLine();
            int firststnumer = 0;
            int.TryParse(firststnum, out firststnumer);

            Console.Write($"Enter 2nd number: ");

            string secnum = Console.ReadLine();
            int secnumber = 0;
            int.TryParse(secnum, out secnumber);

            int sum = firststnumer - secnumber;

            Console.WriteLine($"Subtraction of Two Number is {sum}");

        }
    }
}
