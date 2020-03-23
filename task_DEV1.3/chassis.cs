using System;

namespace task_DEV1._3
{
   public class Chassis
    {
        int _wheelsQuantity;
        string _chassisNumber;
        double _permissibleLoad;

        public int WheelsQuantity
        {
            get 
            { 
                return _wheelsQuantity; 
            }
            set
            {
                _wheelsQuantity = value;
            }
        }
        public string ChassisNumber
        {
            get 
            { 
                return _chassisNumber; 
            }
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _chassisNumber = value;
            }
        }
        public double PermissibleLoad
        {
            get 
            { 
                return _permissibleLoad; 
            }
            set
            {
                _permissibleLoad = value;
            }
        }
        /// <summary>
        /// Chassis constructor
        /// </summary>
        /// <param name="WheelsQuantity"> Quantity of wheels </param>
        /// <param name="ChassisNumber"> </param>
        /// <param name="PermissibleLoad"></param>
        public Chassis(int WheelsQuantity, string ChassisNumber, double PermissibleLoad)
        {
            this.WheelsQuantity = WheelsQuantity;
            this.ChassisNumber = ChassisNumber;
            this.PermissibleLoad = PermissibleLoad;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Chassis number of wheels is: {_wheelsQuantity}");
            Console.WriteLine($"Chassis serial number is: {_chassisNumber}");
            Console.WriteLine($"Chassis permissible load is: {_permissibleLoad}");
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
