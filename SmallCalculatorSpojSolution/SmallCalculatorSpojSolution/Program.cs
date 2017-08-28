using System;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        int count = 0; int i = 1;
        string theoperator = "";
        BigInteger firstnumber = 0;
        BigInteger secondnumber = 0;
        try
        {
            Console.WriteLine("");
            count = int.Parse(Console.ReadLine());
            if (count <= 1000)
            {  
                while (i <= count)
                {
                    Console.Write("");
                    string input = Console.ReadLine();
                    if (input.Contains("+"))
                    {
                        theoperator = "+";
                        string[] splitinput = input.Split('+');
                        firstnumber =BigInteger.Parse(splitinput[0]);
                        secondnumber = BigInteger.Parse(splitinput[1]);
                    }
                    if (input.Contains("-"))
                    {
                        string[] splitinput = input.Split('-');
                        theoperator = "-";
                        firstnumber = BigInteger.Parse(splitinput[0]);
                        secondnumber = BigInteger.Parse(splitinput[1]);
                    }
                    if (input.Contains("*"))
                    {
                       
                        string[] splitinput = input.Split('*');
                        theoperator = "*";
                        firstnumber = BigInteger.Parse(splitinput[0]);
                        secondnumber = BigInteger.Parse(splitinput[1]);
                    }
                    if (digitnumber(firstnumber) <= 500 && digitnumber(secondnumber) <= 500)
                    {
                        sum(firstnumber, secondnumber, theoperator);
                        substract(firstnumber, secondnumber, theoperator);
                        multiply(firstnumber, secondnumber, theoperator);
                    }
                    i++;
                }
            }
        }
        catch (Exception e)
        {
           return;
            
        }

        Console.ReadKey();
    }
    static void sum(BigInteger number1,BigInteger number2,string theoperator)
    {
       BigInteger result = number1 + number2;
        int digitResult = digitnumber(result);
        int requiredSpace = 0;
        string inputSpace = new string(' ', requiredSpace);
        if (theoperator == "+")
        {
            if (maxdigit(number1,number2) == digitnumber(number2))
            {
                requiredSpace = (digitnumber(number2)- digitnumber(number1)) + 1;
                inputSpace = new string(' ', requiredSpace);
                Console.WriteLine("\n"+ inputSpace + number1);
                Console.WriteLine("+" + number2);
            }
            else
            {
                if (digitnumber(number1)== digitnumber(number2))
                {
                    requiredSpace = 1;
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n" + inputSpace + number1);
                    Console.WriteLine( "+" + number2);
                }else if(digitResult > digitnumber(number1)){
                    requiredSpace = (digitResult - digitnumber(number1)) ;
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n" + inputSpace + number1);
                    requiredSpace = (digitnumber(number1) - digitnumber(number2));
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine(inputSpace + "+"  + number2);
                }
                else
                {
                    requiredSpace = (digitnumber(number1) - digitnumber(number2)) - 1;
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n" + number1);
                    Console.WriteLine(inputSpace + "+" + number2);
                }
            }
            if (maxdigit(number1, number2) == digitnumber(number2) || digitnumber(number1)==digitnumber(number2)
                || digitResult > digitnumber(number1))
            {
                printdash(maxdigit(number1, number2) + 1);
            }else { printdash(maxdigit(number1, number2)); }
            
            if (digitResult== digitnumber(number2) && maxdigit(number1,number2)== digitnumber(number2))
            {
                requiredSpace = 1;
                inputSpace = new string(' ', requiredSpace);
                Console.WriteLine("\n{0}{1}",inputSpace, result);
            }
            else 
            {
                Console.WriteLine("\n{0}", result);
            }
        }

    }
    static void substract(BigInteger number1, BigInteger number2, string theoperator)
    {
        BigInteger result = number1 - number2;
        int digitResult = digitnumber(result);
        int requiredSpace = 0;
        string inputSpace = new string(' ', requiredSpace);
        if (theoperator == "-" && number1 >= number2)
        {      
                if (digitnumber(number1) == digitnumber(number2))
                {
                    requiredSpace = 1;
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n" + inputSpace + number1);
                    Console.WriteLine("-" + number2);
                printdash(digitnumber(number1) + 1);
            }
                else
                {
                    requiredSpace = (digitnumber(number1) - digitnumber(number2)) - 1;
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n" + number1);
                    Console.WriteLine(inputSpace + "-" + number2);
                printdash(digitnumber(number1));
            }
            
            if (digitResult==1)
            { if (digitnumber(number1) + digitnumber(number2) == 3)
                {
                    requiredSpace = digitnumber(number1) - 1;
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n{0}{1}", inputSpace, result);
                }
                else {
                    requiredSpace = digitnumber(number1);
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n{0}{1}", inputSpace, result);
                }
            }
           else if (digitResult < digitnumber(number1))
            {
                requiredSpace = digitnumber(number1) - digitResult;
                inputSpace = new string(' ', requiredSpace);
                Console.WriteLine("\n{0}{1}", inputSpace, result);
            } 
            else
            {
                Console.WriteLine("\n{0}", result);
            }
        }
    }
    static void multiply(BigInteger number1, BigInteger number2, string theoperator)
    {
        BigInteger firstmultiple = number1 * (number2 % 10);
        int requiredSpace = 0;
        BigInteger total = number1 * number2;
        int i = 0;
               int totaldigit = digitnumber(number1) + digitnumber(number2);
        int lastdash = digitnumber(number1) + digitnumber(number2);
        string inputSpace = new string(' ', requiredSpace);
        if (theoperator == "*")
        {
            if (digitnumber(firstmultiple) == digitnumber(number1))
            {
                if (maxdigit(number1, number2) == digitnumber(number2))
                {
                    requiredSpace = digitnumber(number2)-1;
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n" + inputSpace + number1);
                    requiredSpace = digitnumber(number1) -2;
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine(inputSpace + "*" + number2);
                }
                else
                {
                    if (digitnumber(number1) == digitnumber(number2))
                    {
                        requiredSpace = digitnumber(number2)-1;
                        inputSpace = new string(' ', requiredSpace);
                        Console.WriteLine("\n" + inputSpace + number1);
                        requiredSpace = digitnumber(number2) - 2;
                        inputSpace = new string(' ', requiredSpace);
                        Console.WriteLine(inputSpace + "*" + number2);
                    }
                    else
                    {
                        requiredSpace = digitnumber(number2)-1;
                        inputSpace = new string(' ', requiredSpace);
                        Console.WriteLine("\n" + inputSpace + number1);
                        requiredSpace = ((digitnumber(number1) - digitnumber(number2)) - 2) + digitnumber(number2);
                        inputSpace = new string(' ', requiredSpace);
                        Console.WriteLine(inputSpace + "*" + number2);
                    }
                }
                if (maxdigit(number1, number2) == digitnumber(number2) || digitnumber(number1) == digitnumber(number2))
                {
                    inputSpace = new string(' ', digitnumber(number1) - 2);
                    Console.Write(inputSpace);
                    printdash(digitnumber(number2) + 1);
                }
                else
                {
                    inputSpace = new string(' ', digitnumber(number2)-1);
                    Console.Write(inputSpace);
                    printdash(digitnumber(number1));

                }

            }
            else { 
            if (maxdigit(number1, number2) == digitnumber(number2))
            {
                requiredSpace = digitnumber(number2);
                inputSpace = new string(' ', requiredSpace);
                Console.WriteLine("\n" + inputSpace + number1);
                requiredSpace = digitnumber(number1) - 1;
                inputSpace = new string(' ', requiredSpace);
                Console.WriteLine(inputSpace + "*" + number2);
            }
            else
            {
                if (digitnumber(number1) == digitnumber(number2))
                {
                    requiredSpace = digitnumber(number2);
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n" + inputSpace + number1);
                    requiredSpace = digitnumber(number2) - 1;
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine(inputSpace + "*" + number2);
                }
                else
                {
                    requiredSpace = digitnumber(number2);
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n" + inputSpace + number1);
                    requiredSpace = ((digitnumber(number1) - digitnumber(number2)) - 1) + digitnumber(number2);
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine(inputSpace + "*" + number2);
                }
            }
            if (maxdigit(number1, number2) == digitnumber(number2) || digitnumber(number1) == digitnumber(number2))
            {
                inputSpace = new string(' ', digitnumber(number1) - 1);
                Console.Write(inputSpace);
                printdash(digitnumber(number2) + 1);
            }
            else
            {
                inputSpace = new string(' ', digitnumber(number2));
                Console.Write(inputSpace);
                printdash(digitnumber(number1));

            }
        }


            if (digitnumber(number2) == 1)
            {
                if (digitnumber(total) == totaldigit)
                {
                    Console.WriteLine("\n" + total);
                }
                else
                {
                  //  requiredSpace = 0;
                 //   inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n" +
                        total);

                }

            }
            else {
                int loop = 1;
                while (number2 > 0)
                {
                    BigInteger lasdigit = number2 % 10;
                    BigInteger multiplyresult = number1 * lasdigit;
                    int digitresult1 = digitnumber(multiplyresult);
                       
                    if (lasdigit == 0 && loop ==1)
                    {
                       // if (loop == 1)
                        
                            requiredSpace = digitnumber(number2) + digitnumber(number1) - 1;
                            inputSpace = new string(' ', requiredSpace);
                            Console.WriteLine("\n{0}{1}", inputSpace, multiplyresult);     
                        //else
                        //{
                        //    requiredSpace = digitnumber(number2) + digitnumber(number1) - 2;
                        //    inputSpace = new string(' ', requiredSpace);
                        //    Console.WriteLine("\n{0}{1}", inputSpace, multiplyresult);
                        //}
                    }
                   
                        else
                    {
                        if (lasdigit == 0)
                        {
                            requiredSpace = digitnumber(number2) + digitnumber(number1) - 2;
                            inputSpace = new string(' ', requiredSpace);
                            Console.WriteLine("\n{0}{1}", inputSpace, multiplyresult);
                        }
                        else
                        {
                            requiredSpace = digitnumber(number2) - 1;
                            inputSpace = new string(' ', requiredSpace);
                            Console.WriteLine("\n{0}{1}", inputSpace, multiplyresult);
                        }  
                        }
                    requiredSpace -= 1;
                    loop += 1;
                    number2 /= 10;
                }
              
                if (digitnumber(total) == totaldigit)
                {
                    printdash(lastdash);
                    Console.WriteLine("\n" + total);
           
                }
                else
                {
                    printdash(lastdash);
                    requiredSpace = 1;
                    inputSpace = new string(' ', requiredSpace);
                    Console.WriteLine("\n{0}{1}", inputSpace, total);
                   
                }
            }
        }
        }

    // find The digitNumber 
    static int digitnumber(BigInteger number)
    {
        string Snum = number.ToString();
        char[] digitnum = Snum.ToCharArray();
        return digitnum.Length;
    } static int maxdigit(BigInteger number1,BigInteger number2)
    {
        if (digitnumber(number1)>digitnumber( number2)) { return digitnumber(number1); }
        else { return digitnumber( number2); }
    } // less
   
    static void printdash(int limit)
    {
        for (int x = 1; x <= limit; x++)
        {
            Console.Write("-");
        }
    }

}

    
