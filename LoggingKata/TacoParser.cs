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
            var cells = line.Split(',');
            
            if (cells.Length < 3)
            {
                // Log that and return null
                Logger.Error("Length is less than 3");
                return null;
            }
 
            var longitude = Double.Parse(cells[0]);
            var lattitude = Double.Parse(cells[1]);
            var name = cells[2];
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