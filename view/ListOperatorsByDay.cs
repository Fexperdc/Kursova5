using InternetServiceProvider.view.control;
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
    public partial class ListOperatorsByDay : Form {
        public ListOperatorsByDay() {
            InitializeComponent();
        }

        public void UpdateForm() {
            DateTimePicker dateTimePicker = (DateTimePicker)Controls.Find("dateTimePicker", true)[0];
            OperatorList operatorList = (OperatorList)Controls.Find("operatorList", true)[0];
            //ListBox operators = (ListBox)operatorList.Controls.Find("operatorLB", true)[0];

            operatorList.UpdateForm(Program.modelBase.GetOperatorsByDay(dateTimePicker.Value));
        }

        private void accept_Click(object sender, EventArgs e) {
            UpdateForm();
        }
    }
}
