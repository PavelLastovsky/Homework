using System;

namespace task_DEV1._3
{
   public class Engine
    {
        double _power;
        double _volume;
        string _type;
        string _serialNumber;
        public double Power
        {
            get 
            { 
                return _power; 
            }
            set
            {
                _power = value;
            }
        }
        public double Volume
        {
            get 
            { 
                return _volume; 
            }
            set
            {
                _volume = value;
            }
        }
        public string Type
        {
            get { return _type; }
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _type = value;
            }
        }
        public string SerialNumber
        {
            get { return _serialNumber; }
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _serialNumber = value;
            }
        }
        public Engine(double Power, double Volume, string Type, string SerialNumber)
        {
            this.Power = Power;
            this.Volume = Volume;
            this.Type = Type;
            this.SerialNumber = SerialNumber;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Engine power is: {_power}");
            Console.WriteLine($"Engine Volume is: {_volume}");
            Console.WriteLine($"Engine Type is: {_type}");
            Console.WriteLine($"Engine serial number is: {_serialNumber}");
        }
        public void NullStringCheck(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("You entered null value");
            }
        }
        public void EmptyStringCheck(object value)
        {
            if ((string)value == string.Empty)
            {
                throw new FormatException("You entered empty string");
            }
        }
    }
}
