using System;
using System.Text;

namespace Task_DEV1_2
{
    public class ConvertFromDeciminalNumberSystem
    {
        int _number, _ScaleOfNotation;
        public int Number
        {
            get { return _number; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _number = value;
            }
        }
        public int ScaleOfNotation
        {
            get { return _ScaleOfNotation; }
            set
            {
                if (value < 2 || value > 20)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _ScaleOfNotation = value;
            }
        }
        /// <summary>
        /// Convert Number and Scale of notation from string to int
        /// </summary>
        /// <param name="NumberString"> Entered string Number from console </param>
        /// <param name="ScaleOfNotationString"> Entered string Scale of notation from console </param>
        public ConvertFromDeciminalNumberSystem(string NumberString, string ScaleOfNotationString)
        {
            Number = Convert.ToInt32(NumberString);
            ScaleOfNotation = Convert.ToInt32(ScaleOfNotationString);
        }
        /// <summary>
        /// Convert Number from 2 to 20 scale of notation
        /// </summary>
        /// <returns> string Number in new scale of notation </returns>
        public string ReturnNumberInAnotherScaleOfNotation()
        {

                StringBuilder NewNumber = new StringBuilder();
                if (ScaleOfNotation >= 2 && ScaleOfNotation <= 20 && Number >= 0)
                {
                    const string Elements = "0123456789ABCDEFGHIJK";
                    while (Number >= ScaleOfNotation)
                    {
                        NewNumber.Insert(0, Elements[Number % ScaleOfNotation]);
                        Number /= ScaleOfNotation;
                    }
                    NewNumber.Insert(0, Elements[Number]);
                }
                return NewNumber.ToString();
        }
        /// <summary>
        /// Check our method for exceprions
        /// </summary>
        private void CheckForNullString(string NumberString, string ScaleOfNotationString)
        {
            if (NumberString == null || ScaleOfNotationString == null)
            {
                throw new NullReferenceException();
            }
        }
        private void CheckForEmptyString(string NumberString, string ScaleOfNotationString)
        {
            if (ScaleOfNotationString == string.Empty || NumberString == string.Empty)
            {
                throw new FormatException();
            }
        }

    }
}
