using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

internal class Program//codingbat's warmup1 problems
{


    /*
    Problem:The parameter weekday is true if it is a weekday, 
    and the parameter vacation is true if we are on vacation. 
    We sleep in if it is not a weekday or we're on vacation. 
    Return true if we sleep in.
     */
    public static bool sleepIn(bool weekday, bool vacation)
    {

        if (!weekday || vacation)
        {
            return true;
        }

        else
        {
            return false;
        }

    }

    /*
    Problem:We have two monkeys, a and b, and the parameters aSmile and bSmile indicate if each is smiling. 
    We are in trouble if they are both smiling or if neither of them is smiling. 
    Return true if we are in trouble.
     */

    public static bool monkeyTrouble(bool aSmiling, bool bSmiling)

    {
        if ((aSmiling && bSmiling) || (!aSmiling && !bSmiling))

        {
            return true;
        }

        else
        {

            return false;
        }
    }

    /*
    Problem:Given two int values, return their sum. Unless the two values are the same, then return double their sum.
     */

    public static int sumDouble(int a, int b) {

        if (a == b)
        {

            return (a + b) * 2;
        }


        else
        {

            return (a + b);
        }

    }

    
    // Problem:Given an int n, return the absolute difference between n and 21, except return double the absolute difference if n is over 21.

    public static int diff21(int a)
    {

        if (a <= 21)
        {

            return 21 - a;
        }


        else
        {
            return (a - 21) * 2;

        }



    }

    /*
     Problem:We have a loud talking parrot. The "hour" parameter is the current hour time in the range 0..23. 
    We are in trouble if the parrot is talking and the hour is before 7 or after 20. Return true if we are in trouble.

     */
    public static bool parrotTrouble(bool talking, int hour)
    {
        if ((talking) && (7 > hour) || (hour > 20))


        {

            return true;


        }

        else
        {

            return false;
        }

    }


    //Problem:Given 2 ints, a and b, return true if one if them is 10 or if their sum is 10.

    public static bool makes10(int a, int b)
    {

        if (a == 10 || b == 10 || a + b == 10)
        {


            return true;
        }

        else
        {

            return false;
        }

    }


    //Problem:Given an int n, return true if it is within 10 of 100 or 200. Note: Math.abs(num) computes the absolute value of a number.

    public static bool nearHundred(int a)
    {
        if (Math.Abs(100 - a) <= 10 || Math.Abs(200 - a) <= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /*
     Problem:Given 2 int values, return true if one is negative and one is positive. Except if the parameter 
    "negative" is true, then return true only if both are negative.

     */
    public static bool posNeg(int a, int b, bool negative)
    {

        if ((a < 0) && (b < 0) && (negative))

        {

            return true;
        }

        else if (((a > 0) || (b > 0)) && (!negative))
        {
            return true;
        }

        else
        {

            return false;

        }

    }

    /*
    Problem: Given a string, return a new string where "not " has been added to the front. 
    However, if the string already begins with "not", return the string unchanged. Note: use .equals() to compare 2 strings.
     */

    public static string notString(string str)
    {
        if (str.StartsWith("not"))
        {

            return str;

        }

        else
        {

            str = "not " + str;

            return str;
        }
    }

    /*
     Problem:Given a non-empty string and an int n, return a new string where the char at index n has been removed. 
    The value of n will be a valid index of a char in the original string (i.e. n will be in the range 0..str.length()-1 inclusive).
     */

    public static string missingChar(string str, int n)
    {
        if (n >= 0 && n < str.Length)
        {
            // Convert the string to a character array
            char[] c = str.ToCharArray();

            // Remove the character at the specified index by replacing it with a space
            c[n] = ' ';

            // Convert the character array back to a string
            string result = new string(c);

            // Remove the space characters from the string
            result = result.Replace(" ", "");

            return result;
        }
        else
        {
            // If the index is invalid, return the original string
            return str;
        }

    }

    /*
     Or you can simply use;

 string front = str.substring(0, n);

 string back = str.substring(n+1, str.length());

 return front + back;

     */



    //Problem:Given a string, return a new string where the first and last chars have been exchanged.

    public static string frontBack(string str)
    {


        // Check if the string length is less than or equal to 1
        if (str.Length <= 1)
        {
            // If true, return the string as it is
            return str;
        }
        else
        {
            // Extract the first character of the string
            string first = str.Substring(0, 1);

            // Extract the middle part of the string (excluding the first and last characters)
            string mid = str.Substring(1, str.Length - 2);

            // Extract the last character of the string
            string last = str.Substring(str.Length - 1);

            // Return the string with the first and last characters swapped
            return last + mid + first;
        }


    }

    /*
     Problem:Given a string, we'll say that the front is the first 3 chars of the string. If the string length is less than 3, 
    the front is whatever is there. Return a new string which is 3 copies of the front.
     */

    public static string front3(string str)
    {

        // Check if the string length is less than 3
        if (str.Length < 3)
        {
            // If true, return the string as it is
            return str;
        }
        else
        {
            // Extract the first three characters of the string
            string x = str.Substring(0, 3);

            // Return the first three characters repeated three times
            return x + x + x;
        }

    }


    /*
     Problem:Given a string, take the last char and return a new string with the last char added at the front and back, 
    so "cat" yields "tcatt". The original string will be length 1 or more.

     */

    public static string backAround(string str)
    {
        // Extract the last character of the string
        string last = str.Substring(str.Length - 1);

        // Concatenate the last character to the beginning and end of the original string
        str = last + str + last;

        // Return the modified string
        return str;
    }

    
    //Problem:Return true if the given non-negative number is a multiple of 3 or a multiple of 5. Use the % "mod" operator -- see Introduction to Mod


    public static bool or35(int n)
    {

        if ((n > 0) && (n % 3 == 0 || n % 5 == 0))
        {


            return true;
        }

        else
        {

            return false;
        }

    }


    /*
     Problem:Given a string, take the first 2 chars and return the string with the 2 chars added at both the front and back, so "kitten" yields"kikittenki". 
    If the string length is less than 2, use whatever chars are there.

     */
    public static string front22(string str)
    {

        // Check if the length of the input string is less than 2
        if (str.Length < 2)
        {
            // If the string length is less than 2, return the string repeated three times
            return str + str + str;
        }
        else
        {
            // If the string length is 2 or more, take the first 2 characters
            string first = str.Substring(0, 2);

            // Return the first 2 characters, followed by the original string, followed by the first 2 characters again
            return first + str + first;
        }
    }

    //Problem:Given a string, return true if the string starts with "hi" and false otherwise.


    public static bool startHi(string str)
    {

        if (str.StartsWith("hi"))
        {

            return true;
        }

        else
        {

            return false;
        }


    }

    //Problem:Given two temperatures, return true if one is less than 0 and the other is greater than 100.


    public static bool icyHot(int temp1, int temp2)
    {

        if (((temp1 < 0) && (temp2 > 100)) || (temp1 > 100) && (temp2 < 0))
        {

            return true;

        }

        else
        {


            return false;
        }


    }

    //Problem:Given 2 int values, return true if either of them is in the range 10..20 inclusive.


    public static bool in1020(int a, int b)
    {

        if (((10 <= a) && (a <= 20)) || ((10 <= b) && (b <= 20)))
        {

            return true;
        }

        else

        {
            return false;



        }



    }
    //Problem:We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 3 int values, return true if 1 or more of them are teen.


    public static bool hasTeen(int a, int b, int c)
    {
        if ((a >= 13) && (a <= 19) || (b >= 13) && (b <= 19) || (c >= 13) && (c <= 19))
        {


            return true;

        }

        else
        {
            return false;
        }

    }

    /*Problem:We'll say that a number is "teen" if it is in the range 13..19 inclusive.
    Given 2 int values, return true if one or the other is teen, but not both.
    */

    public static bool loneTeen(int a, int b)
    {

        if (((a >= 13) && (a <= 19)) && ((b < 13) || (b > 19)) || ((b >= 13) && (b <= 19)) && ((a < 13) || (a > 19)))
        { return true;

        }

        else

        { return false;


        }

    }


    /*
     Given a string, if the string "del" appears starting at index 1, return a string where that "del" has been deleted. 
    Otherwise, return the string unchanged.
     */
    public static string delDel(string str)
    {
        // Convert the input string to a character array

        char[] chars = str.ToCharArray();


        chars.ToArray();

        if (chars[1].ToString().Equals("d")&& chars[2].ToString().Equals("e")&& chars[3].ToString().Equals("l"))//or str.substring(1, 4).equals("del")
        {

            // If "del" is found, return the string without the "del" part

            return str.Substring(0,1)+str.Substring(4);

        }
        else
        {

            // If "del" is not found, return the original string

            return str;
        }


    }

    
    //Problem:Return true if the given string begins with "mix", except the 'm' can be anything, so "pix", "9ix" .. all count.

    public static bool mixStart(string str)
    {

        // Convert the input string to a character array
        char[] chars = str.ToCharArray();

        // Check if the string starts with "mix" or if the characters at index 1 and 2 are 'i' and 'x' respectively
        if (str.StartsWith("mix") || (chars[1].ToString().Equals("i")) && (chars[2].ToString().Equals("x")))
        {
            // If either condition is true, return true
            return true;
        }
        else
        {
            // If neither condition is true, return false
            return false;
        }



    }

    /*
     Problem:Given a string, return a string made of the first 2 chars (if present), 
    however include first char only if it is 'o' and include the second only if it is 'z', so "ozymandias" yields "oz".

     */

    public static string startOz(string str)
    {

        // Convert the input string to a character array
        char[] chars = str.ToCharArray();

        // Check if the first character is 'o' and the second character is 'z'
        if (chars[0].ToString().Equals("o") && chars[1].ToString().Equals("z"))
        {
            // If both conditions are true, return "oz"
            return "oz";
        }
        // Check if only the first character is 'o'
        else if (chars[0].ToString().Equals("o"))
        {
            // If true, return "o"
            return "o";
        }
        // Check if only the second character is 'z'
        else if (chars[1].ToString().Equals("z"))
        {
            // If true, return "z"
            return "z";
        }
        // If neither condition is true, return an empty string
        else
        {
            return "";
        }


    }


    //Problem:Given three int values, a b c, return the largest.

    public static int intMax(int a, int b, int c)
    {

        int[] sayi = { a, b, c };

        int n = sayi.Max();

        return n;


    }

    /*
     Problem:Given 2 int values, return whichever value is nearest to the value 10, or return 0 in the event of a tie.
    Note that Math.abs(n) returns the absolute value of a number.

     */

    public static int close10(int a, int b)
    {

        int x = Math.Abs(10 - a);
        int y= Math.Abs(10 - b);

        if(x<y)
        {


            return a;

        }
        else if(x==y)
        {

            return 0;
        }

        else
        {

            return b;
        }
    }

    
    //Problem:Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both in the range 40..50 inclusive.
   
    public static bool in3050(int a, int b)
    {



      if(((a>=30&&a<=40)&&(b >= 30 && b <= 40))||((a >= 40 && a <= 50) && (b >= 40 && b <= 50)))
        {


            return true;
        }

      else
        {


            return false;
        }


    }

    //Problem:Given 2 positive int values, return the larger value that is in the range 10..20 inclusive, or return 0 if neither is in that range.

    public static int max1020(int a, int b)
    {

       if((a>=10&&a<=20)&&(b >= 10 && b <= 20))
        {
            int[]sayi= { a, b };

            return sayi.Max();


        }

       else if((a >= 10 && a <= 20)&&(b>20)||b<10)

        {
            return a;


        }

       else if((b >= 10 && b <= 20) && (a > 20) || a < 10)

        {


            return b;

        }
       else
        {


            return 0;
        }
    }

    //Return true if the given string contains between 1 and 3 'e' chars.


    public static bool stringE(string str)
    {

        // Extract substring from index 4 to the end of the string
        string a = str.Substring(4);

        // Check if character 'e' is not present in the substring
        bool notInString = !a.Contains("e");

        // Check if the length of the string is greater than 4 and if 'e' is present at least once in the first 3 characters,
        // and if 'e' is not present in the rest of the string
        if ((str.Length > 4) && (str.Substring(1, 1).Equals("e") || str.Substring(2, 1).Equals("e") || str.Substring(3, 1).Equals("e")) && notInString)
        {
            // If the conditions are met, return true
            return true;
        }
        else
        {
            // If the conditions are not met, return false
            return false;
        }
    }

    /*
     Problem:Given two non-negative int values, return true if they have the same last digit, such as with 27 and 57. 
    Note that the % "mod" operator computes remainders, so 17 % 10 is 7.

     */

    public static bool lastDigit(int a, int b)
    {

        if(a>0&&b>0)
        {

            if(a%10==b%10)
            {

                return true;
            }
            else
            {


                return false;
            }

        }

        else

        { return false; 
        
        

        }

    }


    /*
     Problem:Given a string, return a new string where the last 3 chars are now in upper case. 
    If the string has less than 3 chars, uppercase whatever is there. Note that str.toUpperCase() returns the uppercase version of a string.

     */
    public static string endUp(string str)
    {

        // Get the length of the input string
        int x = str.Length;

        // Check if the length of the string is greater than 3
        if (x > 3)
        {
            // If the length is greater than 3, return the substring from the beginning of the string up to the last three characters,
            // concatenated with the last three characters converted to uppercase
            return str.Substring(0, x - 3) + str.Substring(x - 3).ToUpper();
        }
        else
        {
            // If the length is not greater than 3, convert the entire string to uppercase and return it
            return str.ToUpper();
        }


    }

    /*
     Problem:Given a non-empty string and an int N, return the string made starting with char 0, 
    and then every Nth char of the string. So if N is 3, use char 0, 3, 6, ... and so on. N is 1 or more.

    */

    public static string everyNth(string str,int n)
    {
        // Initialize an empty string to store the result
        string result = "";

        // Convert the input string to a character array
        char[] chars = str.ToCharArray();

        // Get the length of the input string
        int x = str.Length;

        // Initialize a counter variable
        int i = 0;

        // Check if the value of 'n' is greater than or equal to 1
        if (n >= 1)
        {
            // Loop through the characters of the string with a step of 'n'
            while (i < x)
            {
                // Append the character at index 'i' to the result string
                result += chars[i];

                // Move to the next character by incrementing 'i' by 'n'
                i = i + n;
            }

            // Return the resulting string containing every nth character
            return result;
        }
        else
        {
            // If 'n' is less than 1, return the original string
            return str;
        }

    }
    /*
        Or

        string result = "";

     for (int i = 0; i < str.Length; i = i + n)
     {
         result = result + str[i];
     }

      return result;



        */


    private static void Main(string[] args)
    {

        //sleepIn Uygulama
        /*
        Console.WriteLine(sleepIn(false, false));
        Console.WriteLine(sleepIn(true, false));
        Console.WriteLine(sleepIn(false, true));
        */


        //monkeyTrouble Uygulama
        /*
        Console.WriteLine(monkeyTrouble(true, true));
        Console.WriteLine(monkeyTrouble(false, false));
        Console.WriteLine(monkeyTrouble(true, false));
        */


        //sumDouble Uygulama
        /*
        Console.WriteLine(sumDouble(1,2));
        Console.WriteLine(sumDouble(3,2));
        Console.WriteLine(sumDouble(2,2));
        */


        //diff21 Uygulama
        /*
        Console.WriteLine(diff21(19));
        Console.WriteLine(diff21(10));
        Console.WriteLine(diff21(24));
        */



        //parrotTrouble Uygulama
        /*
        Console.WriteLine(parrotTrouble(true,6));
        Console.WriteLine(parrotTrouble(true, 7));
        Console.WriteLine(parrotTrouble(false, 6));
        */


        //makes10 Uygulama
        /*
        Console.WriteLine(makes10(9, 10));
        Console.WriteLine(makes10(9, 9));
        Console.WriteLine(makes10(1, 9));
        */


        //nearHundred Uygulama
        /*
        Console.WriteLine(nearHundred(93));
        Console.WriteLine(nearHundred(90));
        Console.WriteLine(nearHundred(89));
        */


        //posneg Uygulama
        /*
        Console.WriteLine(posNeg(1, -1, false));
        Console.WriteLine(posNeg(-1, 1, false));
        Console.WriteLine(posNeg(-4, -5, true));
        */


        //notString Uygulama
        /*
        Console.WriteLine(notString("candy"));
        Console.WriteLine(notString("x"));
        Console.WriteLine(notString("not bad"));
        */


        //missingChar Uygulama
        /*
        Console.WriteLine(missingChar("kitten",1));
        Console.WriteLine(missingChar("kitten",0));
        Console.WriteLine(missingChar("kitten",4));
        */



        //frontBack Uygulama

        /*
        Console.WriteLine(frontBack("code"));
        Console.WriteLine(frontBack("a"));
        Console.WriteLine(frontBack("ab"));
        */



        //front3 Uygulama
        /*
        Console.WriteLine(front3("Java"));
        Console.WriteLine(front3("Chocolate"));
        Console.WriteLine(front3("abc"));
        */



        //backAround Uygulama

        /*
        Console.WriteLine(backAround("cat"));
        Console.WriteLine(backAround("Hello"));
        Console.WriteLine(backAround("a"));
        */

        //or35 Uygulama

        /*
        Console.WriteLine(or35(3));
        Console.WriteLine(or35(10));
        Console.WriteLine(or35(8));
        */



        //front22 Uygulama
        /*
        Console.WriteLine(front22("kitten"));
        Console.WriteLine(front22("Ha"));
        Console.WriteLine(front22("abc"));
        */


        //startHi Uygulama

        /*
        Console.WriteLine(startHi("hi there"));
        Console.WriteLine(startHi("hi"));
        Console.WriteLine(startHi("hello hi"));
        */

        //icyHot Uygulama

        /*
        Console.WriteLine(icyHot(120,-1));
        Console.WriteLine(icyHot(-1,120));
        Console.WriteLine(icyHot(2,120));
        */


        //in1020 Uygulama

        /*
        Console.WriteLine(in1020(12,99));
        Console.WriteLine(in1020(21, 12));
        Console.WriteLine(in1020(8, 99));
        */

        //hasTeen Uygulama

        /*
        Console.WriteLine(hasTeen(13,20,10));
        Console.WriteLine(hasTeen(20,19,10));
        Console.WriteLine(hasTeen(20,10,13));
        */

        //loneTeen Uygulama

        /*
        Console.WriteLine(loneTeen(13,99));
        Console.WriteLine(loneTeen(21,19));
        Console.WriteLine(loneTeen(13,13));
        */

        //delDel Uygulama

        /*
        Console.WriteLine(delDel("adelbc"));
        Console.WriteLine(delDel("adelHello"));
        Console.WriteLine(delDel("adedbc"));
        */

        //mixStart Uygulama

        /*
        Console.WriteLine(mixStart("mix snacks"));
        Console.WriteLine(mixStart("pix snacks"));
        Console.WriteLine(mixStart("piz snacks"));
        */


        //startOz Uygulama

        /*
        Console.WriteLine(startOz("ozymandias"));
        Console.WriteLine(startOz("bzoo"));
        Console.WriteLine(startOz("oxx"));
        */



        //intMax Uygulama

        /*
        Console.WriteLine(intMax(1,3,2));
        Console.WriteLine(intMax(3,2,1));
        Console.WriteLine(intMax(1,2,3));
        */



        //close10 Uygulama

        /*
        Console.WriteLine(close10(8,13));
        Console.WriteLine(close10(13,8));
        Console.WriteLine(close10(13,7));
        */


        //in3050 Uygulama

        /*
        Console.WriteLine(in3050(30, 31));
        Console.WriteLine(in3050(30, 41));
        Console.WriteLine(in3050(40, 50));
        */


        //max1020 Uygulama

        /*
        Console.WriteLine(max1020(11, 19));
        Console.WriteLine(max1020(19, 11));
        Console.WriteLine(max1020(11, 9));
        */


        //stringE Uygulama

        /*
        Console.WriteLine(stringE("Hello"));
        Console.WriteLine(stringE("Heelle"));
        Console.WriteLine(stringE("Heelele"));
        */


        //lastDigit Uygulama

        /*
        Console.WriteLine(lastDigit(7, 17));
        Console.WriteLine(lastDigit(6, 17));
        Console.WriteLine(lastDigit(3, 113));
        */


        //endUp Uygulama

        /*
        Console.WriteLine(endUp("Hello"));
        Console.WriteLine(endUp("hi there"));
        Console.WriteLine(endUp("hi"));
        */


        //everyNth Uygulama

        /*
        Console.WriteLine(everyNth("Miracle",2));
        Console.WriteLine(everyNth("abcdefg",2));
        Console.WriteLine(everyNth("abcdefg",3));
        */


    }
}