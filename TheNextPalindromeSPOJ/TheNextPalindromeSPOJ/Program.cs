using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNextPalindromeSPOJ
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("");
                int t = int.Parse(Console.ReadLine());
                int count = 0;
                while (count < t)
                {
                    Console.Write("");
                    BigInteger number = BigInteger.Parse(Console.ReadLine());
          
                 for (BigInteger i = number +1; ;i++)
                        if (palindrome2(i))
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
            }
            catch (Exception e) { Console.Write(e); }
            Console.ReadLine();
        }
        static bool palindrome(BigInteger number)
        {
            BigInteger a = number;
            BigInteger reverse = 0;
            while (number != 0)
            {
                BigInteger lastdigit = number % 10;
                reverse = reverse * 10 + lastdigit;
                number /= 10;
            }
            if (a != reverse) { return false; }
            return true;
        }
        static bool palindrome2(BigInteger number)
        {
             string word = number.ToString();
            char[] newchar = word.ToCharArray();
            int i = newchar.Length - 1;
            int j = 0;
            if (i <= 1000000)
            {
                while (i > j)
                {
                    if (newchar[i] != newchar[j]) { return false; }
                    j++;
                    i--;
                }
            }

                return true;     
        }
    }
    }
