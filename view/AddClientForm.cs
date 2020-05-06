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
    public partial class AddClientForm : Form {
        public AddClientForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            TextBox ipTB = (TextBox)Controls.Find("ipTB", true)[0];
            Client client = new Client();
            client.ip = ipTB.Text;

            if (Program.modelBase.AddClient(client)) {
                MessageBox.Show("Клієнт був успішно добавлений");
            } else {
                client = null;
                MessageBox.Show("Помилка!");
            }
            Program.mainForm.UpdateForm();
        }
    }
}
