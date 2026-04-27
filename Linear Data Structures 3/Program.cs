using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine()); // Reads input number

        Queue<int> queue = new Queue<int>(); // Initializes a queue to hold numbers
        queue.Enqueue(N);

        int printed = 0;

        while (printed < 50) // Loops until 50 numbers are printed
        {
            int M = queue.Dequeue(); // Dequeues the front element to print
            Console.Write(M + "\n");
            printed++;

            // Generates and enqueues the next three elements

            queue.Enqueue(M + 1); 
            queue.Enqueue(2 * M + 1);
            queue.Enqueue(M + 2);
        }
    }
}