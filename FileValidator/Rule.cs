using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileValidator
{
    internal class Rule(string name, string regex, string comment)
    {
        public string Name = name;
        public string Regex = regex;
        public string Comment = comment;
    }

    // TODO: change constructor to parse a comma-separated string
}
