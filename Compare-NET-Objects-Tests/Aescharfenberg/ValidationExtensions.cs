using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KellermanSoftware.CompareNetObjectsTests
{
    public static class ValidationExtensions
    {
        public static IEnumerable<ValidationResult> Validate<T>(this T subject)
        {
            return new List<ValidationResult>() { new ValidationResult()};
        }
    }
}
