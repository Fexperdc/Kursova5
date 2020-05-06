using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetServiceProvider.model;

namespace InternetServiceProvider.view.control {
    public partial class OperatorList : UserControl {
        public OperatorList() {
            InitializeComponent();
        }

        public void UpdateForm(List<Operator> operators) {
            ListBox operatorLB = (ListBox)Controls.Find("operatorLB", true)[0];

            operatorLB.DataSource = null;
            operatorLB.DataSource = operators;
        }
    }
}
