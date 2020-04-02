using System;

namespace task_DEV1._4
{
    public class Coordinate
    {
        float _pointX,
              _pointY,
              _pointZ;

        /// <summary>
        /// Coordinate constructor that creates point with 3 coordinates and return them
        /// </summary>
        /// <param name="_pointx"> coordinate x return float value </param>
        /// <param name="_pointy"> coordinate y return float value </param>
        /// <param name="_pointz"> coordinate z return float value </param>
        public Coordinate(float _pointx, float _pointy, float _pointz)
        {
            PointX = _pointx;
            PointY = _pointy;
            PointZ = _pointz;
        }
        public float PointX
        {
            get 
            { 
                return _pointX; 
            }
            set
            {
                ArgumentExceptionCheck(value);
                _pointX = value;
            }
        }
        public float PointY
        {
            get 
            { 
                return _pointY; 
            }
            set
            {
                ArgumentExceptionCheck(value);
                _pointY = value;
            }
        }
        public float PointZ
        {
            get 
            { 
                return _pointZ; 
            }
            set
            {
                ArgumentExceptionCheck(value);
                _pointZ = value;
            }
        }

        /// <summary>
        /// return distance between two Points as float
        /// </summary>
        /// <param name="A"> object of class Coordinate </param>
        /// <returns></returns>
        public float GetDistance(Coordinate A)
        {
            return (float)(Math.Sqrt(Math.Pow(A.PointX - _pointX, 2) + Math.Pow(A.PointY - _pointY, 2) + Math.Pow(A.PointZ - _pointZ, 2)));
        }
        public void ArgumentExceptionCheck(float value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("You entered negative coordinate"); // Coordinates of point must be positive
            }
        }
    }
}
