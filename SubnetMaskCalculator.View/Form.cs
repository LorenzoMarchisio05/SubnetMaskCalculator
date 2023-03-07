using SubnetMaskCalculator.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubnetMaskCalculator
{
    public partial class Form : System.Windows.Forms.Form
    {

        private SubNetMaskCalculatorController subNetMaskCalculatorController;
        public Form()
        {
            InitializeComponent();

            txtIPAddress.Text = "192.168.12.25";
            txtSubnetMask.Text = "255.255.255.192";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                subNetMaskCalculatorController = SubNetMaskCalculatorController.Create(
                    txtIPAddress.Text,
                    txtSubnetMask.Text
                );

                txtNetMaskBit.Text = $"/{subNetMaskCalculatorController.CalculateNetmaskBitFormat()}";

                MessageBox.Show(subNetMaskCalculatorController.CalculateNetworkAddress());

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            foreach(var textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = "";
            }
        }
    }
}
