using System;

namespace CsharpTutorial {
  public class UserInput {
    public static void Main(string[] args) {
      // getting the user input and output
      Console.Write("Enter your name: "); // write means at the end of the sentence there's no newline
      string firstName = Console.ReadLine(); // read the user input
      Console.WriteLine("Enter you last name: ");
      string lastName = Console.ReadLine(); // after the sentence there's a newline

      Console.Write("Hi, your first name is: " + firstName + " \nand your last name is: " + lastName);
    }
  }
}
