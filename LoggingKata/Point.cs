namespace LoggingKata
{

    public struct Point
    {
        public Point(double lattitude, double longitude) : this()
        {
            Latitude = lattitude;
            Longitude = longitude;
        }

        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}