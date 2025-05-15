using System;

namespace TelCo.ColorCoder
{    
    internal interface IRule
    {
        bool Evaluate();
        string Name { get; }
    }
}
