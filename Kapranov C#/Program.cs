using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number > 7)
            {
                Console.WriteLine("Hello");
            }


            Console.Write("Enter a name: ");
            string name =Console.ReadLine();


            if (name == "John")
            {
                Console.WriteLine("Hello, John");
            }
            else
            {
                Console.WriteLine("There is no such name");
            }


            Console.Write("Enter numbers separated by single spaces: ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            Console.WriteLine("Numbers that are multiples of 3:");
            foreach (int num in numbers)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
        catch(Exception error)
        {
            Console.WriteLine($"Exception! {error}");


        }
    }
}

//Answer the questions
//Given bracket sequence: [ ( (()) () (()) ]]

//Can this sequence be considered correct?
//My answer: No.

//If the answer to the previous question is “no”, then what needs to be changed in it to make it correct?
//My answer: we need to change this sequence as follows: [( (()) () (()) )]. I removed one closing square bracket and added one closing parenthesis. 
