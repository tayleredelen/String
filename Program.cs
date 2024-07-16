using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Tae Albert";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            fullName.Replace("Tae", "Edelen");
            // fullName.Replace('e', 'E');
            // fullName.Replace(' ', '');

            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid");

            var str = "30";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            price.ToString("C");
            price.ToString("C0"); //removes decimal




        }
    }
}