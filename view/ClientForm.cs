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
    public partial class ClientForm : Form {

        private Client client;

        public ClientForm() {
            InitializeComponent();
        }

        public void UpdateForm(Client client) {
            this.client = client;

            Label idL = (Label)Controls.Find("idL", true)[0];
            Label ipL = (Label)Controls.Find("ipL", true)[0];

            idL.Text = "" + client.computerId;
            ipL.Text = client.ip;

            ConnectList connectList = (ConnectList)Controls.Find("connectList", true)[0];
            connectList.UpdateForm(client.connects);
        }
    }
}
