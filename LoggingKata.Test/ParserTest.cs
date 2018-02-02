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
        public void ReturnNullForEmptyString()
        {
            //Arrange
            var nullString = "";
            var nullTestParse = new TacoParser();

            //Act
            var result = nullTestParse.Parse(nullString);

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        public void ShouldParseLine()
        {
            //TODO: Complete ShouldParseLine
            //Arrange
            var exampleString = "-84.677017, 34.073638";
            var testParse = new TacoParser();

            //Act
            var result = testParse.Parse(exampleString);
            
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
