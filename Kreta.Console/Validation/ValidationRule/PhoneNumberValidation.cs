using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Console.Validation.ValidationRule
{
    public class PhoneNumberValidation
    {
        // Valid phone number: "ddd-ddd"
        private readonly string _phoneNumber;
        public PhoneNumberValidation(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }

        public bool IsExactlySevenLong => false;
        public bool IsDashInMiddle => false;
        public bool IsThreNumberAtTheBeggining =>false;
        public bool IsThreNumberAtTheEnd => false;
    }
}
