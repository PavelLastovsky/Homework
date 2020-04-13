using System;

namespace task_DEV2._1
{
    struct CarPark
    {
        const int MinAmount = 1, MaxAmount = 40;
        const float MinPrice = 0, MaxPrice = 99999999;
        const string EmptyStringExceptionText = "You entered empty string",
                     NullStringExceptionText = "You entered null string";
        string _brand,  _model;
        int _amount, _price;
        public CarPark(string brand, string model, int amount, int price)
        {
            _brand = brand;
            _model = model;
            _amount = amount;
            _price = price;
        }
        public string Brand
        {
            get => _brand;
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _brand = value;
            }
        }
        public string Model
        {
            get => _model;
            set
            {
                NullStringCheck(value);
                EmptyStringCheck(value);
                _model = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                ArgumentOutOfRangeExceptionPriceCheck(value);
                _price = value;
            }
        }
        public int Amount
        {
            get => _amount;
            set
            {
                ArgumentOutOfRangeExceptionAmountCheck(value);
                _amount = value;
            }
        }
        private void NullStringCheck(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(NullStringExceptionText);
            }
        }
        private void EmptyStringCheck(string value)
        {
            if (value == string.Empty)
            {
                throw new ArgumentNullException(EmptyStringExceptionText);
            }
        }
        private void ArgumentOutOfRangeExceptionPriceCheck(float value)
        {
            if (value < MinPrice || value > MaxPrice)
            {
                throw new ArgumentOutOfRangeException($"Price must be between {MinPrice} and {MaxPrice} ");
            }
        }
        private void ArgumentOutOfRangeExceptionAmountCheck(int value)
        {
            if (value < MinAmount || value > MaxAmount)
            {
                throw new ArgumentOutOfRangeException($"Amount must be between {MinAmount} and {MaxAmount} ");
            }
        }
    }
}
