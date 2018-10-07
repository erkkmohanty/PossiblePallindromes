using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossiblePallindromes
{
    class PossiblePallindromes : IPossiblePallindromes
    {
        public async Task<IList<string>> GetPossiblePallindromes()
        {
            List<string> pallindromeLIst = new List<string>();
            string input = "kirannarikrituutirchitraartihc";

            int minLength = 3;
            string temp = input.Substring(0, 3);
            int counter = 0;
            
            try
            {
                while (minLength <= (input.Length / 2))
                {
                    temp = input.Substring(0, minLength);
                    while (counter < (input.Length - temp.Length))
                    {
                        for (int j = temp.Length; j < (input.Length - temp.Length); j++)
                        {
                            string sub = input.Substring(j, temp.Length);
                            if (temp == sub.Reverse())
                            {
                                pallindromeLIst.Add(temp);
                                pallindromeLIst.Add(sub);
                            }
                        }
                        counter++;
                        temp = input.Substring(counter, minLength);
                    }
                    counter = 0;
                    minLength++;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return pallindromeLIst;
        }
    }
}
