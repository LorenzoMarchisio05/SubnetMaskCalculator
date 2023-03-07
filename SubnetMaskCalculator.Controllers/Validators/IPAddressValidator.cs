using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SubnetMaskCalculator.Controllers.Validators
{
    internal static class IPAddressSubnetMaskValidator
    {
        private static readonly Regex _validationRegex = new Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$");

        public static bool Validate(string address) => _validationRegex.IsMatch(address);
    }


}
