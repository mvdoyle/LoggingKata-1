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
        //Why do you think we use ILog?
        private static readonly ILog Logger =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Logger.Info("Log initialized");

            var file = Path.Combine(Environment.CurrentDirectory, "Taco_Bell-US-AL-Alabama.csv");

            Console.WriteLine("file: " + file);

            var lines = File.ReadAllLines(file);
            var parser = new TacoParser();

            var locations = lines.Select(line => parser.Parse(line));

            foreach (var location in locations)
            {
                
            }

            //TODO:  Find the two TacoBells in Alabama that are the furthurest from one another.
            //HINT:  You'll need two nested forloops
            

            // DON'T FORGET TO LOG YOUR STEPS
            // Grab the path from Environment.CurrentDirectory + the name of your file

            // use File.ReadAllLines(path) to grab all the lines from your csv file
            // Log and error if you get 0 lines and a warning if you get 1 line

            // Create a new instance of your TacoParser class
            // Grab an IEnumerable of locations using the Select command: var locations = lines.Select(line => parser.Parse(line));

            // Now, here's the new code

            // Create two `ITrackable` variables with initial values of `null`. These will be used to store your two taco bells that are the furthest from each other.
            // Create a `double` variable to store the distance

            // Include the Geolocation toolbox, so you can compare locations
            // Do a loop for your locations to grab each location as the origin (perhaps: `locA`)
            // Create a new Coordinate with your locA's lat and long

            // Now, do another loop on the locations with the scope of your first loop, so you can grab the "destination" location (perhaps: `locB`)
            // Create a new Coordinate with your locB's lat and long
            // Now, compare the two using `GeoCalculator.GetDistance(origin, destination)`, which returns a double
            // If the distance is greater than the currently saved distance, update the distance and the two `ITrackable` variables you set above

            // Once you've looped through everything, you've found the two Taco Bells furthest away from each other.

        }
    }
}