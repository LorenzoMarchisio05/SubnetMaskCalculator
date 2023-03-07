using SubnetMaskCalculator.Controllers.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SubnetMaskCalculator.Controllers
{
    public sealed class SubNetMaskCalculatorController
    {

        private readonly string ip;
        private readonly byte maskbits;
        private readonly string[] binary_netmask;
        private readonly string mask;

        public static SubNetMaskCalculatorController Create(string ip, string subnetMask) => new SubNetMaskCalculatorController(ip, subnetMask);
        private SubNetMaskCalculatorController(string ip, string subnetMask)
        {

            if(!IPAddressSubnetMaskValidator.Validate(ip))
            {
                throw new ArgumentException($"Invalid ip address: {ip}");
            }

            if (!IPAddressSubnetMaskValidator.Validate(subnetMask))
            {
                throw new ArgumentException($"Invalid subnet mask: {subnetMask}");
            }

            this.ip = ip;
            this.mask = subnetMask;

            binary_netmask = (mask.Split('.').Select(x => Convert.ToString(int.Parse(x), 2).PadLeft(8, '0'))).ToArray();



            maskbits = (byte)binary_netmask.Sum(s => s.Select(c => c.));
        }

        public string CalculateNetworkAddress()
        {
            return "";

        }


        public byte CalculateNetmaskBitFormat() => maskbits;


    }
}
