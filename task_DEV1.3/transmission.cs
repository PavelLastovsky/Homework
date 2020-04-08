using System;

namespace task_DEV1._3
{
    public class Transmission
    {
        string _transmissionType;
        int _gearsNumber;
        string _producer;
        public string TransmissionType
        {
            get 
            { 
                return _transmissionType; 
            }
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _transmissionType = value;
            }
        }
        public int GearsNumber
        {
            get 
            { 
                return _gearsNumber; 
            }
            set
            {
                _gearsNumber = value;
            }
        }
        public string Producer
        {
            get
            {
                return _producer;
            }
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _producer = value;
            }
        }
        public Transmission(string TransmissionType, int GearsNumber, string Producer)
        {
            this.TransmissionType = TransmissionType;
            this.GearsNumber = GearsNumber;
            this.Producer = Producer;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Transmission type is: {_transmissionType}");
            Console.WriteLine($"Transmission number of gears is: {_gearsNumber}");
            Console.WriteLine($"Transmission producer is: {_producer}");
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
