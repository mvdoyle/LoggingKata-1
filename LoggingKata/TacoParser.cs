using System.Collections;
using System.Collections.Generic;
using log4net;

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
            //if (double.Parse(line) == 0)
            //{
                //DO not fail if one record parsing fails, return null
                //return null; //TODO Implement
            //}
            return null;
        }
    }
}