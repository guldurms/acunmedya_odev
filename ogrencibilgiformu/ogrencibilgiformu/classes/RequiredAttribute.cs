using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrencibilgiformu.classes
{

    // Projenize bu class'ı ekleyin
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredAttribute : Attribute
    {
        public string ErrorMessage { get; }

        public RequiredAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public bool IsValid(object value)
        {
            return !string.IsNullOrWhiteSpace(value?.ToString());
        }
    }
}
