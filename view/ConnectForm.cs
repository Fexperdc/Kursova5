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
    public partial class ConnectForm : Form {
        public ConnectForm() {
            InitializeComponent();
        }

        public void UpdateForm(Connect connect) {
            Label organizationName = (Label)Controls.Find("organizationName", true)[0];
            Label organizationAddress = (Label)Controls.Find("organizationAddress", true)[0];
            Label organizationNumber = (Label)Controls.Find("organizationNumber", true)[0];
            organizationName.Text = connect.receipt.organization.name;
            organizationAddress.Text = connect.receipt.organization.address;
            organizationNumber.Text = connect.receipt.organization.telephoneNumber;

            Label operatorNSP = (Label)Controls.Find("operatorNSP", true)[0];
            Label operatorNumber = (Label)Controls.Find("operatorNumber", true)[0];
            operatorNSP.Text = connect.receipt.operatorO.NSP;
            operatorNumber.Text = connect.receipt.operatorO.telephoneNumber;

            Label startDate = (Label)Controls.Find("startDate", true)[0];
            Label endDate = (Label)Controls.Find("endDate", true)[0];
            startDate.Text = connect.start.ToString();
            endDate.Text = connect.end.ToString();

            Label duration = (Label)Controls.Find("duration", true)[0];
            Label sum = (Label)Controls.Find("sum", true)[0];
            duration.Text = "" + connect.GetDuration();
            sum.Text = "" + connect.sum;
        }
    }
}
