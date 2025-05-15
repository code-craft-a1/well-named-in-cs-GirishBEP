using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelCo.ColorCoder
{
    public class Rule : IRule
    {
        public string Name { get; }
        private readonly Func<bool> _logic;

        public Rule(string name, Func<bool> logic)
        {
            Name = name;
            _logic = logic;
        }

        public bool Evaluate() => _logic();
    }
}
