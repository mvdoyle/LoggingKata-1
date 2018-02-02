namespace LoggingKata
{

    public struct Point
    {
        public Point(double lattitude, double longitude) : this()
        {
            Latitude = lattitude;
            Longitude = longitude;
        }
        double Longitude { get; set; }
        double Latitude { get; set; }
    }
}