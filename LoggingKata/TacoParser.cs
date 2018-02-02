using System;
using System.Collections;
using System.Collections.Generic;
using log4net;
using System.Linq;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the TacoBells
    /// </summary>
    public class TacoParser
    {
        public TacoParser()
        {

        }

        private static readonly ILog Logger =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ITrackable Parse(string line)
        {
            //TODO Implement
            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                Logger.Error("Length is less than 3");
                return null;
            }

            // grab the long from your array at index 0 
            var longitude = Double.Parse(cells[0]);
            // grab the lat from your array at index 1
            var lattitude = Double.Parse(cells[1]);
            // grab the name from your array at index 2
            var name = cells[2];
            // Your going to need to parse your string as a `double`
            // which is similar to parse a string as an `int`

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var tacoBell = new TacoBell
            {
                Name = name,
                Location = new Point(lattitude,longitude)
                
            };
            
            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            return tacoBell;
        }
    }
}