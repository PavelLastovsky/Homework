using System;

namespace task_DEV1._4
{
    public class Coordinate
    {
        float _pointX,
              _pointY,
              _pointZ;
        public Coordinate(float _pointx, float _pointy, float _pointz)
        {
            PointX = _pointx;
            PointY = _pointy;
            PointZ = _pointz;
        }
        /// <summary>
        /// 
        /// </summary>
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
        public override string ToString()
        {
            return ($"Coordinate x:  {_pointX.ToString()}  Coordinate y:  {_pointY.ToString()}   Coordinate z:  {_pointZ.ToString()}");
        }
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
