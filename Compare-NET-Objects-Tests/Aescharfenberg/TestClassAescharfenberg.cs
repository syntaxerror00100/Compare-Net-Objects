using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KellermanSoftware.CompareNetObjectsTests.Aescharfenberg
{
    [TestFixture]
    public class TestClassAescharfenberg
    {
        [Test]
        public void Subject_Validate_Valid()
        {
            // Arrange
            var subject = new object();
            var expected = new[] { new ValidationResult() };

            // Act
            var actual = subject.Validate();

            // Assert
            var result = ObjectComparer.Compare(expected, actual);
            Assert.IsTrue(result.AreEqual, result.DifferencesString);
        }
    }
}
