using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment05
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int odds = 0;
            int evens = 0;
            int x;
            int min = 100001;
            int max = 0;
            string result = "min \tmax \todds \tevens\n";
            Random rnd = new Random();
            while (i < 1000)
            {
                i++;

                x = rnd.Next(1, 100000);
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;

                if ((x % 2) == 0)
                    evens++;
                else
                    odds++;

            }

            // message box contents
            result += min
                + "\t"
                + max
                + "\t"
                + odds
                + "\t"
                + evens;

            MessageBox.Show(result, "Problem 1 - min, max, odds, evens");
        }
    }
}
