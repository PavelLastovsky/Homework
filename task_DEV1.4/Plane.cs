using System;

namespace task_DEV1._4
{
    public class Plane : IFlyable
    {
        /// <summary>
        /// MinPlaneSpeed, MaxPlaneSpeed, SpeedChange are measured in kilometers per hour
        /// DistanceChange, MinPlaneDistance, MaxPlaneDistance are measured in kilometers
        /// </summary>

        const int MinPlaneSpeed = 200, MaxPlaneSpeed = 3000, DistanceChange = 10, SpeedChange = 10, MinPlaneDistance = 10, MaxPlaneDistance = 6000;
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
                _speed = value;
            }
        }
        public Plane(Coordinate NewPoint, float _speed)
        {
            CurrentPoint = NewPoint;
            Speed = _speed;
        }
        public void FlyTo(Coordinate NewPoint)
        {
            CurrentPoint = NewPoint;
        }
        public float GetFlyTime(Coordinate NewPoint)
        {
            while (NewPoint.GetDistance(CurrentPoint) < MaxPlaneDistance)
            {
                int NumberSpeedChanges = (int)NewPoint.GetDistance(CurrentPoint) / DistanceChange;
                Speed = MinPlaneSpeed + NumberSpeedChanges * SpeedChange;
                ArgumentOutOfRangeException(NewPoint);
            }
            return CurrentPoint.GetDistance(NewPoint) / Speed;
        }
        public void ArgumentOutOfRangeException(float value)
        {
            if (value < MinPlaneSpeed || value > MaxPlaneSpeed)
            {
                throw new ArgumentOutOfRangeException($"Speed must be between  {MinPlaneSpeed} and {MaxPlaneSpeed}");
            }
        }
        public void ArgumentOutOfRangeException(Coordinate NewPoint)
        {
            if (CurrentPoint.GetDistance(NewPoint) < MinPlaneDistance || CurrentPoint.GetDistance(NewPoint) > MaxPlaneDistance)
            {
                throw new ArgumentOutOfRangeException($"Distance must be between {MinPlaneDistance} and {MaxPlaneDistance}");
            }
        }
    }
}
