using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PossiblePallindromes
{
    class Application : IApplication
    {
        private readonly IPossiblePallindromes _possiblePallindromes;
        public Application(IPossiblePallindromes possiblePallindromes)
        {
            _possiblePallindromes = possiblePallindromes;
        }
        public async Task Run()
        {
         var data= await  _possiblePallindromes.GetPossiblePallindromes();
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
