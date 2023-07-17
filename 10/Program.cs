using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Write("Input the number of members on the List: ");
        int count = int.Parse(Console.ReadLine());
         
       
        List<int> members = new List<int>();

      
        Console.WriteLine("Input " + count + " members for the list:");
        for (int i = 0; i < count; i++)
        {
            Console.Write("Member " + i + ": ");
            int member = int.Parse(Console.ReadLine());
            members.Add(member);
        }

        Console.Write("Input the value above which you want to display the members of the List: ");
        int minValue = int.Parse(Console.ReadLine());


        Console.WriteLine("The numbers greater than " + minValue + " are:");
        foreach (int number in members)
        {
            if (number > minValue)
            {
                Console.WriteLine(number);
            }
        }

    }
}