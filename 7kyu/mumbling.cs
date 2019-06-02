using System;
using System.Linq;

public class Mumbling
{
  public static String Accum(string s) 
  {
    s = s.ToLower();
    var mumb_string = "";
     
     for(int i = 0; i < s.Length; i++)
     {
         if(i == 0)
         {
           mumb_string += char.ToUpper(s[i]);
           mumb_string += "-";
           
         }else if(i + 1 == s.Length)
         {
           var temp_string = string.Concat(Enumerable.Repeat(s[i], i + 1)); 
           mumb_string += char.ToUpper(temp_string[0]) + temp_string.Substring(1);
           
         }else 
         {
           var temp_string = string.Concat(Enumerable.Repeat(s[i], i + 1)); 
           mumb_string += char.ToUpper(temp_string[0]) + temp_string.Substring(1);
           mumb_string += "-";
         }
      
     }
     
      return mumb_string;
      
  }
}