using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Application.Exceptions
{
    public class BadRequestException:Exception
    {
        public IDictionary<string, string[]> ValidationsErrors { get; set; }
        public BadRequestException(string message):base(message) 
        { 
        }
        public BadRequestException(string message,ValidationResult validatioResult):base(message) 
        {
            ValidationsErrors = validatioResult.ToDictionary();
                }
    }
}
