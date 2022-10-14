using System;

namespace cf_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string players = Console.ReadLine();
            string test = "123";
            int i = 1;
            int count = 1;
            int maxCount = 1;  
            char cp = players[0];  
            int l = players.Length;  
            while ((i < l) && (maxCount < 7))  {
            if (cp == players[i]){
                count++;
                if (count > maxCount){
                maxCount = count;
                }
            } else {
                cp = players[i];
                count = 1;
            }
            i++;
            }
            if (maxCount > 6) {
                Console.WriteLine("YES");
            } else {
                Console.WriteLine("NO");
            }


        }
    }
}
