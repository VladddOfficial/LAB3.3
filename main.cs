using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the number: ");
    var n = Console.ReadLine();
    int number = Convert.ToInt32(n);
    
    for ( int i=2 ; i <= number; i++){
      if (number%2 == 0){
        Console.WriteLine (number + " is not a prime number");
        break;
      }
      if ( i == number ){
        Console.WriteLine (number + " is a prime number");
      }
    }

  }
}