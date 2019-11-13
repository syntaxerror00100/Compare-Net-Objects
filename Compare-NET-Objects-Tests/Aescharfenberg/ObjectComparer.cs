using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KellermanSoftware.CompareNetObjects;

namespace KellermanSoftware.CompareNetObjectsTests
{
    public static class ObjectComparer
    {
        public static ComparisonResult Compare(object expectedObject, object actualObject, IEnumerable<string> membersToIgnore = null, bool redactValues = false)
        {
            var config = new ComparisonConfig
            {
                IgnoreCollectionOrder = true,
                IgnoreObjectTypes = true,
                MaxDifferences = 100
            };

            if (membersToIgnore != null)
            {
                config.MembersToIgnore = new List<string>(membersToIgnore);
            }

            if (redactValues)
            {
                config.DifferenceCallback = difference =>
                {
                    difference.Object1Value = Constants.RedactedText;
                    difference.Object2Value = Constants.RedactedText;
                };
            }

            var compare = new CompareLogic(config);
            var result = compare.Compare(expectedObject, actualObject);
            return result;
        }
    }
}
