using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace testConsole
{
    static class HexConverter
    {
       public static void PrintHello()
        {
            Console.WriteLine("Hello, World!");
        }

        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        public static float AddNumbers(float a, float b)
        {
            return a + b;
        }

        public static int HextoInt(string s)
        {
            char[] chars = s.ToUpper().ToCharArray();
            chars.Reverse();

            Dictionary<char, int> lookup = new Dictionary<char, int>()
            {
                { 'A', 10 },
                { 'B', 11 },
                { 'C', 12 },
                { 'D', 13 },
                { 'E', 14 },
                { 'F', 15 }
            };

            int result;
            result = 0;
            foreach (char c in chars)
            {
                int v;
                if (lookup.ContainsKey(c))
                {
                    v = lookup[c];
                }
                else
                {
                    try
                    {
                        v = Convert.ToInt32(c);
                        if (v > 15)
                        {
                            throw new Exception("");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(c + " is not an acceptable character, clamped to F");
                        v = 15;
                    }
                }
                result += v;
            }

            return result;
        }

        }
    }

