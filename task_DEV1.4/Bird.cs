using System;

namespace task_DEV1._4
{
    public class Bird : IFlyable
    {
        const int MinBirdSpeed = 0, MaxBirdSpeed = 20; // bird speed measured in kilometers per hour
        float _speed;
        Coordinate CurrentPoint;
        public float Speed
        {
            get 
            {
                return _speed;
            }
            set
            {
                ArgumentOutOfRangeException(value);
                SpeedNotZeroCheck(value);
                _speed = value;
            }
        }
        public Bird(Coordinate CurrentLocation, float _speed)
        {
            Speed = _speed;
            CurrentPoint = CurrentLocation;
        }
        public void FlyTo(Coordinate NewPoint)
        {
            CurrentPoint = NewPoint;
        }
        public float GetFlyTime(Coordinate destination)
        {
            return CurrentPoint.GetDistance(destination) / _speed;
        }
        public void SpeedNotZeroCheck(float value)
        {
            if (value == 0)
            {
                throw new Exception("Bird can't fly"); // speed must be more than 0
            }
        }
        public void ArgumentOutOfRangeException(float value)
        {
            if (value < MinBirdSpeed || value > MaxBirdSpeed)
            {
                throw new ArgumentOutOfRangeException($"Speed must be between  {MinBirdSpeed} and {MaxBirdSpeed}");
            }
        }

    }
}
