using SubnetMaskCalculator.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubnetMaskCalculator
{
    public partial class Form : System.Windows.Forms.Form
    {

        private readonly SubNetMaskCalculatorController subNetMaskCalculatorController;
        public Form()
        {
            InitializeComponent();

            subNetMaskCalculatorController = new SubNetMaskCalculatorController();
        }


    }
}
