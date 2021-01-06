using System;
using System.Collections.Generic;
using System.Text;

namespace SystemTester
{
    class FenParser: Itask
    {
        static Dictionary<char, int> dict = new Dictionary<char, int>
            {
                {'P', 0 },
                {'N', 1 },
                {'B', 2 },
                {'R', 3 },
                {'Q', 4 },
                {'K', 5 },
                {'p', 6 },
                {'n', 7 },
                {'b', 8 },
                {'r', 9 },
                {'q', 10 },
                {'k', 11 },

            };
        static ulong[] board = new ulong[12];
        public string Run(string[] data)
        {
            string fenString = data[0];
            string[] fenMass = fenString.Split('/');
            string mass_row = "";
            int position = 56;
            for (int row = 0; row < fenMass.Length; row++)
            {
                mass_row = fenMass[row];
                for (int i = 0; i < mass_row.Length; i++)
                {
                    if (char.IsDigit(mass_row[i]))
                    {
                        position += int.Parse(mass_row[i].ToString());
                    }
                    else if (char.IsLetter(mass_row[i]))
                    {

                        char ch = mass_row[i];
                        int numMass = dict[ch];
                        
                        Lshift(numMass, position);

                        position++;

                    }

                }
                
                position -= 2 * 8;
            }

            string answer = "";
            
            foreach (var el in board)
            {
                answer += el + "\n";
            }

            return answer;



            void Lshift(int numMass, int position)
            {
                board[numMass] |= (1ul << position);
            }


        }
    }
}
