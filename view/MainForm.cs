using InternetServiceProvider.model;
using InternetServiceProvider.view.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InternetServiceProvider.view {
    public partial class MainForm : Form {

        public static ClientForm clientForm = new ClientForm();
        public static AddClientForm addClientForm = new AddClientForm();
        public static AddOperatorForm addOperatorForm = new AddOperatorForm();
        public static OperatorListForm operatorListForm = new OperatorListForm();
        public static CountClientsByMonthForm countClientsByMonthForm = new CountClientsByMonthForm();
        public static ListOperatorsByDay listOperatorsByDay = new ListOperatorsByDay();

        private ModelBase modelBase;

        public MainForm(ModelBase modelBase) {
            InitializeComponent();
            this.modelBase = modelBase;
        }

        public void UpdateForm() {
            ClientList clientList = (ClientList)Controls.Find("clientList", true)[0];
            clientList.UpdateForm(modelBase.clients);
        }

        private void симуляціяToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e) {
            addClientForm.ShowDialog();
        }

        private void addOperatorToolStripMenuItem_Click(object sender, EventArgs e) {
            addOperatorForm.ShowDialog();
        }

        private void operatorBtn_Click(object sender, EventArgs e) {
            operatorListForm.UpdateForm();
            operatorListForm.ShowDialog();
        }

        private void connectSimulation_Click(object sender, EventArgs e) {
            DateTimePicker endDate = (DateTimePicker)Controls.Find("endDate", true)[0];
            DateTimePicker stardDate = (DateTimePicker)Controls.Find("startDate", true)[0];


            ClientList clientList = (ClientList)Controls.Find("clientList", true)[0];
            ListBox listBox = (ListBox)clientList.Controls.Find("clientLB", true)[0];
            Client client = (Client) listBox.SelectedItem;
            CheckBox pricePCB = (CheckBox)Controls.Find("pricePCB", true)[0];

            if(client != null) {
                if(ModelBase.currentOperator != null) {
                    client.Connect(stardDate.Value, endDate.Value);
                    ModelBase.currentOperator.CheckConnect(client, pricePCB.Checked);
                } else {
                    MessageBox.Show("Помилка! Виберіть оператора");
                }
            } else {
                MessageBox.Show("Помилка! Виберіть клієнта");
            }
        }

        private void countClientByMonthToolStripMenuItem_Click(object sender, EventArgs e) {
            countClientsByMonthForm.ShowDialog();
        }

        private void changerPrices_Click(object sender, EventArgs e) {
            TextBox priceTB = (TextBox)Controls.Find("priceTB", true)[0];
            TextBox pricePTB = (TextBox)Controls.Find("pricePTB", true)[0];
            ModelBase.PRICE = float.Parse(priceTB.Text);
            ModelBase.PRICEP = float.Parse(pricePTB.Text);

            ChangePricesLabel(ModelBase.PRICE, ModelBase.PRICEP);
        }

        public void ChangePricesLabel(float price, float priceP) {
            Label pricesL = (Label)Controls.Find("pricesL", true)[0];
            pricesL.Text = "Звичайна ціна: " + ModelBase.PRICE + " Пільгова ціна: " + ModelBase.PRICEP;
        }

        private void operatorsByDayToolStripMenuItem_Click(object sender, EventArgs e) {
            listOperatorsByDay.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                System.IO.File.WriteAllText(openFileDialog.FileName, JsonConvert.SerializeObject(Program.modelBase, Formatting.Indented, new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }));
            }
        }
    }
}
