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
                Logger.Warn("No values pulled in");
                return null;
            }
            var cells = line.Split(',');
            
            if (cells.Length < 2)
            {
                Logger.Warn("Missing a lat or long");
                return null;
            }
            
            try
            {
                var lon = double.Parse(cells[0]);
                var lat = double.Parse(cells[1]);

                return new TacoBell
                {
                    Name = cells.Length > 2 ? cells[2] : null,
                    Location = new Point(lat, lon)
                };
            }
            catch (Exception e)
            {
                Logger.Error("Failed to parse lat and long", e);
                return null;
            }
        }
    }
}