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
        private static readonly ILog Logger =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ITrackable Parse(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                
            }
            var cells = line.Split(',');
            
            if (cells.Length < 3)
            {
                Logger.Error("Length is less than 3");
                return null;
            }

            if (cells.Length < 2)
            {
                Logger.Warn("Missing a lat or long");
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
            
            return tacoBell;
        }
    }
}