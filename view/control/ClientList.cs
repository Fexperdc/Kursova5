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
    public partial class ClientList : UserControl {

        public ClientList() {
            InitializeComponent();
        }

        public void UpdateForm(List<Client> clients) {
            GetList().DataSource = null;
            GetList().DataSource = clients;
        }

        public ListBox GetList() {
            return (ListBox) Controls.Find("clientLB", true)[0];
        }

        private void clientLB_DoubleClick(object sender, EventArgs e) {
            Client client = (Client)GetList().SelectedItem;

            MainForm.clientForm.UpdateForm(client);
            MainForm.clientForm.ShowDialog();
        }
    }
}
