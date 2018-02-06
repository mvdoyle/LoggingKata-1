using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LoggingKata.Test
{
    [TestFixture]
    public class TacoParserTestFixture
    {
        [Test]
        public void ShouldNotParse()
        {
            //Arrange
            var parser = new TacoParser();
            var nonParseValues = new string[] {null, "", "-84.677017, Testing", "Testing, -84.677017"};

            //Act
            foreach (var val in nonParseValues)
            {
                
                var result = parser.Parse(val);

                //Assert
                Assert.IsNull(result, $"{result} should be null");
            }
        }

        [Test]
        public void ShouldParseString()
        {
            //Arrange
            var parser = new TacoParser();
            var parseValues = new string[]
            {
                "-84.677017, 34.039588",
                "-84.677017, 34.039588, Testing"
            };

            var lat = 34.039588;
            var lon = -84.677017;

            //Act
            foreach (var val in parseValues)
            {
                var result = parser.Parse(val);

                //Assert
                Assert.IsNotNull(result, $"{result} should not be null");
                Assert.AreEqual(lat, result.Location.Latitude);
                Assert.AreEqual(lon, result.Location.Longitude);
            }
        }
    }
}
