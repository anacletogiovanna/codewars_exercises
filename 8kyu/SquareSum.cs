using System;

public static class SquareSum
{
  public static int SquareSum(int[] n)
  { 
    double numbersSquare = 0;
    
    foreach(int num in n)
    {
      numbersSquare += Math.Pow(num, 2);
      
    }
    
    int resultNumbers = Convert.ToInt32(numbersSquare);
    return resultNumbers;
    
    
  }
}