using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelCo.ColorCoder
{    internal interface IRule
    {
        bool Evaluate();
        string Name { get; }
    }
}
