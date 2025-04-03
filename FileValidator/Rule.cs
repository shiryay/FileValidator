using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileValidator
{
    internal class Rule
    {
        public string Regex { get; set; }
        public string Comment { get; set; }

        // Constructor parsing a comma-separated string
        public Rule(string ruleString)
        {
            var ruleComponents = ruleString.Split(',');
            if (ruleComponents.Length >= 2)
            {
                Regex = ruleComponents[0];
                Comment = ruleComponents[1];
            }
        }
    }
}
