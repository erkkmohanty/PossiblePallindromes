using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PossiblePallindromes
{
    interface IPossiblePallindromes
    {
        Task<IList<string>> GetPossiblePallindromes();
    }
}
