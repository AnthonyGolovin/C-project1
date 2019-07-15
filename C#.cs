using System;
using System.Collections.Generic;

class Pong
{
  static void Main()
  {
      Console.WriteLine("Enter a number");
    int userNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("You entered " + userNumber + " as your number.");
     

    Console.WriteLine("Ping Pong Test:");
    for (int i = 1; i <= userNumber; i++) {
        if (i % 5 == 0 && i % 3 == 0) {
            Console.WriteLine("ping-pong");
        } else if (i % 5 == 0) {
            Console.WriteLine("pong");
        } else if (i % 3 == 0) {
            Console.WriteLine("ping");
        } else { 
            Console.WriteLine(i);
        }
        
    }
  }
}