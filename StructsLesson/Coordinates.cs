using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsLesson
{
    public struct Coordinates
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public Coordinates(double latitude, double longitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public string GetCoordinates()
        {
            return $"{Latitude}; {Longitude}";
        }
    }
}
