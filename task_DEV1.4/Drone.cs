using System;

namespace task_DEV1._4
{
    public class Drone : IFlyable
    {
        /// <summary>
        /// MinDroneSpeed, MaxDroneSpeed are measured in kilometers per hour
        /// TimeChange, TimeStop are measured in hours
        /// MinDroneDistance, MaxDroneDistance are measured in kilometers
        /// </summary>

        const int MinDroneSpeed = 0, MaxDroneSpeed = 40, TimeChange = 1/6, TimeStop = 1/60, MinDroneDistance = 200, MaxDroneDistance = 1000;
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
        public Drone(Coordinate CurrentLocation, float _speed)
        {
            CurrentPoint = CurrentLocation;
            Speed = _speed;
        }
        public void FlyTo(Coordinate NewPoint)
        {
                CurrentPoint = NewPoint;
        }
        public float GetFlyTime(Coordinate NewPoint)
        {
            ArgumentOutOfRangeException(NewPoint);
            float Time = CurrentPoint.GetDistance(NewPoint) / Speed;
            int StopQuantity = (int)Time / TimeChange;
            Time =+ TimeStop * StopQuantity;
            return Time;
        }
        public void ArgumentOutOfRangeException(float value)
        {
            if (value < MinDroneSpeed || value > MaxDroneSpeed)
            {
                throw new ArgumentOutOfRangeException($"Speed must be between  {MinDroneSpeed} and {MaxDroneSpeed}");
            }
        }
        public void ArgumentOutOfRangeException(Coordinate NewPoint)
        {
            if (CurrentPoint.GetDistance(NewPoint) < MinDroneDistance || CurrentPoint.GetDistance(NewPoint) > MaxDroneDistance)
            {
                throw new ArgumentOutOfRangeException($"Distance must be between {MinDroneDistance} and {MaxDroneDistance}");
            }
        }
    }
}
