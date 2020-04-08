using System;

namespace task_DEV1._3
{
   public class Vehicle
    {
        Engine _engine;
        Chassis _chassis;
        Transmission _transmission;
        string _vehicleType;
        public Vehicle(Engine Engine, Chassis Chassis, Transmission Transmission, string _vehicleType)
        {
            this.Engine = Engine;
            this.Transmission = Transmission;
            this.Chassis = Chassis;
            VehicleType = _vehicleType;
        }
        protected Engine Engine
        {
            get
            {
                return _engine;
            }
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _engine = value;
            }
        }
        protected Chassis Chassis
        {
            get
            {
                return _chassis;
            }
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _chassis = value;
            }
        }
        protected Transmission Transmission
        {
            get
            {
                return _transmission;
            }
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _transmission = value;
            }
        }
        protected string VehicleType
        {
            get
            {
                return _vehicleType;
            }
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _vehicleType = value;
            }
        }
        virtual public void GetInfo()
        {
            Console.WriteLine($"Vehicle type: {_vehicleType}");
            _engine.GetInfo();
            _chassis.GetInfo();
            _transmission.GetInfo();
        }
        protected void NullStringCheck(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("You entered null value");
            }
        }
        protected void EmptyStringCheck(object value)
        {
                if ((string)value == string.Empty)
                {
                    throw new FormatException("You entered empty string");
                }
        }

    }
}

