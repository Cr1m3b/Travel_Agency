using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.CustomValidations
{
    public class MyValidations
    {
        public static ValidationResult ValidateDateAttribute(DateTime date, ValidationContext context)
        {
            bool isValid = true;
            if (date > DateTime.Now)
            {
                isValid = false;
            }
            if (isValid)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult($"The field {context.MemberName} can not be bigger than actual date", new List<string> { context.MemberName });
        }
    }
}
