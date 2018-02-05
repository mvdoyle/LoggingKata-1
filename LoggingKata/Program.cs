using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.IO;
using Geolocation;

namespace LoggingKata
{
    class Program
    {
        private static readonly ILog Logger =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Logger.Info("Log initialized");

            var file = Path.Combine(Environment.CurrentDirectory, "Taco_Bell-US-AL-Alabama.csv");

            Console.WriteLine("file: " + file);

            var lines = File.ReadAllLines(file);
            Logger.Error("No lines were grabbed from the csv file");
            Logger.Warn("Only 1 line grabbed from csv file");

            var parser = new TacoParser();

            var locations = lines.Select(line => parser.Parse(line));

            ITrackable locationA = null;
            ITrackable locationB = null;
            double distance = 0;

            foreach (var locA in locations)
            {
                var origin = new Coordinate
                {
                    Latitude = locA.Location.Latitude,
                    Longitude = locA.Location.Longitude
                };

                foreach (var locB in locations)
                {
                    var destination = new Coordinate
                    {
                        Latitude = locB.Location.Latitude,
                        Longitude = locB.Location.Longitude
                    };
                    
                    var farthestDistance = GeoCalculator.GetDistance(origin, destination);
                    if (farthestDistance > distance)
                    {
                        locationA = locA;
                        locationB = locB;
                        distance = farthestDistance;
                    }

                }
            }

        }
    }
}