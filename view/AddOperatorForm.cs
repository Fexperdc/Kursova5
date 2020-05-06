using InternetServiceProvider.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetServiceProvider.view {
    public partial class AddOperatorForm : Form {
        public AddOperatorForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            TextBox nspTB = (TextBox)Controls.Find("nspTB", true)[0];
            TextBox numberTB = (TextBox)Controls.Find("nspTB", true)[0];

            Operator operatorO = new Operator();
            operatorO.NSP = nspTB.Text;
            operatorO.telephoneNumber = numberTB.Text;

            if(Program.modelBase.AddOperator(operatorO)) {
                MessageBox.Show("");
            } else {
                MessageBox.Show("");
                operatorO = null;
            }
        }
    }
}
