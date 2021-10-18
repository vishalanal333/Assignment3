using System;

namespace Assignment3
{
    class Program
    {
        public  int value(char rom )
        {
            if (rom == 'I')
                return 1;
            if (rom == 'V')
                return 5;
            if (rom == 'X')
                return 10;
            if (rom == 'L')
                return 50;
            if (rom == 'C')
                return 100;
            if (rom == 'D')
                return 500;
            if (rom == 'M')
                return 1000;
            else
                return -1;
        }
        public int RomToInt(string str)
        {
            int ans = 0;
            for (int i = 0; i < str.Length; i++)
            {              
                int s1 = value(str[i]);
               
                if (i+1< str.Length)
                {
                    int s2 = value(str[i + 1]);
                    int check = s2 - s1;
                    if (s1 < s2)
                    {
                        if (check==4 ||check== 40 || check==90 || check==400 || check==900)
                        {
                            ans += s2 - s1;
                            i++;
                        }
                        else 
                        {
                            
                            Console.WriteLine("invalid input");
                            ans = 0;
                            break;

                        }
                    }
                    else if(i != 0&&value(str[i - 1]) < s1 )
                    {
                        Console.WriteLine("invalid input");
                        ans = 0;
                        break;
                    }
                    else
                    {
                        ans += s1;
                    }
                }
                else
                {
                    ans += s1;

                }
                
            }
            return ans;
            
        }
        public static void Main()
        {
            Program obj = new Program();
            string str = Console.ReadLine();
            Console.WriteLine(obj.RomToInt(str));

        }
    }
}
// xxx
