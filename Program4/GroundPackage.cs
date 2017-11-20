using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class GroundPackage
    {
        private int _originZip;//Backing variable for origin zip
        private int _destinationZip;//Backing variable for destination zip
        private double _length;//Backing variable for length
        private double _width;//Backing variable for width
        private double _height;//Backing variable for height
        private double _weight;//Backing variable for weight

        private const int DEFAULT_DESTINATION = 90210;//Default destination, if user input invalid
        private const int DEFAULT_ORIGIN = 40202;//default origin, if user input isnt valid

        //Constructor for the groundpackage class, takes the six user input and passes them to properties.
        //Precondition: all entered data is numericand greater than 0, the zips are within 00000-99999
        //Postcondition: Package with those properties created
        public GroundPackage(int originZip, int destinationZip, double length, double width, double height, double weight)
        {
            OriginZip = originZip;
            DestinationZip = destinationZip;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;
        }

        //Origin Zip code Property
        public int OriginZip
        {
            //Precondition:None 
            //Postcondition: Origin Zip returned
            get
            {
                return _originZip;
            }
            //Precondition: entered value >=0 and <=99999 
            //Postcondition: Origin Zip set to specified value
            set
            {
                //if zip is a non negative five digit number, value is set
                if (value >= 0 && value <= 99999)
                    _originZip = value;
                //Otherwise, origin zip will default to 40202
                else
                    _originZip = DEFAULT_ORIGIN;
            }
        }

        //Destination Zip code Property
        public int DestinationZip
        {
            //Precondition:None 
            //Postcondition: Destination Zip returned
            get
            {
                return _destinationZip;
            }
            //Precondition: entered value >=0 and <=99999 
            //Postcondition: Destination Zip set to specified value
            set
            {
                if (value >= 0 && value <= 99999)
                    _destinationZip = value;
                //otherwise, destination zip defaults to 90210
                else
                    _destinationZip = DEFAULT_DESTINATION;
            }
        }

        //Length Property
        public double Length
        {
            //Precondition:None 
            //Postcondition: Length returned
            get
            {
                return _length;
            }
            //Precondition: entered value >0
            //Postcondition: Length set to specified value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    _length = 1;
            }
        }

        //width Property
        public double Width
        {
            //Precondition:None 
            //Postcondition: width returned
            get
            {
                return _width;
            }
            //Precondition: entered value >0
            //Postcondition: width set to specified value
            set
            {
                if (value > 0)
                    _width = value;
                else
                    _width = 1;
            }
        }

        //height Property
        public double Height
        {
            //Precondition:None 
            //Postcondition: height returned
            get
            {
                return _height;
            }
            //Precondition: entered value >0
            //Postcondition: height set to specified value
            set
            {
                if (value > 0)
                    _height = value;
                else
                    _height = 1;
            }
        }

        //weight Property
        public double Weight
        {
            //Precondition:None 
            //Postcondition: weight returned
            get
            {
                return _weight;
            }
            //Precondition: entered value >0
            //Postcondition: weight set to specified value
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    _weight = 1;
            }
        }

        //ZoneDistance property, calculated from the two zip codes.
        public int ZoneDistance
        {
            //Precondition:None 
            //Postcondition: ZoneDistance returned
            get
            {
                return Math.Abs(_originZip - _destinationZip) / 10000;
            }
        }

        //Method for calculating the cost of the package.
        //Precondition:  none
        //Postcondition: the cost of the package is returned
        public double CalcCost()
        {
            return .20 * (Length + Width + Height) + .5 * (ZoneDistance + 1)*Weight;
        }

        //Tostring method for formatting package properties, overrides default tostring property.
        //Precondition: none
        //Postcondtion: a string for the package is returned.
        public override string ToString()
        {
            string nl = Environment.NewLine; //shortcut for new line function
            return string.Format("Origin Zip: {1}{0}", nl, OriginZip.ToString("d5")) +
                string.Format("Destination Zip: {1}{0}", nl, DestinationZip.ToString("d5")) +
                string.Format("Length: {1}{0}", nl, Length) +
                string.Format("Width: {1}{0}", nl, Width) +
                string.Format("Heigth: {1}{0}", nl, Height) +
                string.Format("Weight: {1}{0}", nl, Weight) +
                string.Format("Zone Distance: {1}{0}", nl, ZoneDistance) +
                string.Format("Cost: {1}{0}", nl, CalcCost().ToString("C"));
        }
    }
}
