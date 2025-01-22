using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Domain.Common
{
    public class APIWarning
    {
        public string Description{ get; set; }
        public APIWarning(string description)
            { this.Description = description; }
    }
}
