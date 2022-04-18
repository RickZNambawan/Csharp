using System;

namespace CsharpTutorial {
  public class Variables {
    public static void Main(string[] args) {
      // it will just predict the data type based on the value given.
      // you must initialize variable with their value.
      // var num; - this is invalid syntax.
      var num = 10;
      var name = "Fred";

      // this is the normal data type
      // variable can be declared first before the initialization
      string lastName = "Castaneda";
      int myNum = 2;
      char myChar = 'A';
      float myFloat = 23.5f;
      double myDouble = 354.234234;
      bool myBool = true;
    }
  }
}
