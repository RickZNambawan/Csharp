using System;

namespace CsharpTutorial {
  public class ConvertDataTypes {
    public static void Main(string[] args) {
      // string to int
      string firstNum = "53";
      string secondNum = "76";

      int convertedFirstNum = Convert.ToInt32(firstNum);
      int convertedSecondNum = Convert.ToInt32(secondNum);
      int total = convertedFirstNum + convertedSecondNum;

      Console.WriteLine(total);

      // int to string
      Console.WriteLine("Enter first digit: ");
      int firstDig = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter second digit: ");
      int secondDig = Convert.ToInt32(Console.ReadLine());
      string newStatement = "My grade is " + Convert.ToString(firstDig) + " and my Age is " + Convert.ToString(secondDig);
      Console.WriteLine(newStatement);
    }
  }
}
