using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelCo.ColorCoder
{
    internal class RuleEngine
    {
        private readonly List<IRule> _rules;

        public RuleEngine(IEnumerable<IRule> rules)
        {
            _rules = rules.ToList();
        }

        public bool ExecuteAll()
        {
            foreach (var rule in _rules)
            {
                var result = rule.Evaluate();                

                if (!result)
                {
                    throw new Exception($"Rule: {rule.Name} failed. Stopping execution.");                    
                }
            }
            return true;
        }
    }
}
