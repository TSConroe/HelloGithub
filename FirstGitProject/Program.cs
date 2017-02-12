using System;


namespace FirstGitProject
{
    class Program
    {
        static void Main()
        {
            int sum=0;
           
            for (int i =1; i<=999; i++)
            {
                int remainder =0;
                int num = i;
                while (num > 0)
                {
                    remainder = remainder + (num % 10);
                    num /= 10;
                }
                if (remainder == 15)
                Console.WriteLine(i);
            }
        }
    }
}
