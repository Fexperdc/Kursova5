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
    public partial class ConnectList : UserControl {

        private ConnectForm connectForm = new ConnectForm();

        public ConnectList() {
            InitializeComponent();
        }

        public void UpdateForm(List<Connect> connects) {
            if (connects != null) {
                GetListBox().DataSource = null;
                GetListBox().DataSource = connects;
            }
        }

        public ListBox GetListBox() {
            return (ListBox)Controls.Find("connectLB", true)[0];
        }

        private void connectLB_DoubleClick(object sender, EventArgs e) {
            Connect connect = (Connect) GetListBox().SelectedItem;
            if (connect != null) {
                connectForm.UpdateForm(connect);
                connectForm.ShowDialog();
            }
        }
    }
}
