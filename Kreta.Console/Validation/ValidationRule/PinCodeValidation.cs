using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Console.Validation.ValidationRule
{
    public class PinCodeValidation
    {
        private readonly string _pinCode;
        public PinCodeValidation(string pinCode)
        {
            _pinCode = pinCode;
        }

        public bool IsFourCharactersLengths => false;
        public bool IsOnlyDecimalNumber => false;
    }
}
