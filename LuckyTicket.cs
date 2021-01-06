using System;
using System.Collections.Generic;
using System.Text;

namespace SystemTester
{
    class LuckyTicket:Itask
    {
        int n;
        int count = 0;
        public string Run(string[] data)
        {
            n = Convert.ToInt32(data[0])/2;
            NextDigit(0, 0, 0);
            return count.ToString();


        }

        public void NextDigit(int nr,int sum1,int sum2)
        {
            if(nr == 2*n)
            {
                if(sum1 == sum2)
                {
                    count++;
                }
                return;

            }

            for (int a = 0; a <= 9; a++)
            {
                if (nr < n)
                {
                    NextDigit(nr + 1, sum1 + a, sum2);
                }
                else
                {
                    NextDigit(nr + 1, sum1, sum2 + a);
                }

            }



        }
    }
}
