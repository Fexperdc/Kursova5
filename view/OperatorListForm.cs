using InternetServiceProvider.model;
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
    public partial class OperatorListForm : Form {
        public OperatorListForm() {
            InitializeComponent();
        }

        public void UpdateForm() {
            OperatorList operatorList = (OperatorList)Controls.Find("operatorList", true)[0];

            ListBox listBox = (ListBox) operatorList.Controls.Find("operatorLB", true)[0];
            listBox.DataSource = null;
            listBox.DataSource = Program.modelBase.operators;
        }

        private void button1_Click(object sender, EventArgs e) {
            OperatorList operatorList = (OperatorList)Controls.Find("operatorList", true)[0];
            ListBox listBox = (ListBox) operatorList.Controls.Find("operatorLB", true)[0];

            Operator operatorO = (Operator)listBox.SelectedItem;

            if (Program.modelBase.ChangeOperator(operatorO)) {
                Button button = (Button)Program.mainForm.Controls.Find("operatorBtn", true)[0];
                button.Text = operatorO.ToString();
                ModelBase.currentOperator = operatorO;
                Hide();
            } else {
                MessageBox.Show("Помилка! Виберіть оператора");
            }
        }
    }
}
