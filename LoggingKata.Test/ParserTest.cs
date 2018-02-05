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
            var emptyString = "";
            var nullTestParse = new TacoParser();

            //Act
            var result = nullTestParse.Parse(emptyString);

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        public void ShouldParseLine()
        {
            //Arrange
            var exampleString = "-84.677017, 34.073638";
            var testParse = new TacoParser();

            //Act
            var result = testParse.Parse(exampleString);
            
            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void ShouldReturnNullString()
        {
            //Arrange
            string exampleString = null;
            var testParse = new TacoParser();
            
            //Act
            var result = testParse.Parse(exampleString);

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        public void NeedsBothLatAndLong()
        {
            //Arrange

            //Act

            //Assert

        }

        [Test]
        public void NoDiscription()
        {
            //Arange

            //Act

            //Assert
        }

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
            var ParseValues = new string[] { "-84.677017, Testing", "Testing, -84.677017", "-84.283254, 34.039588, \"Taco Bell Alpharetta /... (Free trial * Add to Cart for a full POI info)" };

            //Act
            foreach (var val in ParseValues)
            {
                var result = parser.Parse(val);

                //Assert
                Assert.IsNotNull(result, $"{result} should not be null");
            }
        }
    }
}
