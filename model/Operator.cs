using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetServiceProvider.model {
    public class Operator {
        public String NSP;
        public String telephoneNumber;

        public Receipt CheckConnect(Client client, bool p) {
            Receipt receipt = null;
            if(client.lastConnect != null) {
                receipt = new Receipt();
                //receipt.date = ModelBase.currentDate;
                receipt.operatorO = this;
                receipt.organization = ModelBase.currentOrganization;
                client.lastConnect.sum = client.lastConnect.GetSum(p);
                client.lastConnect.receipt = receipt;
                client.lastConnect.price = ModelBase.PRICE;
                client.lastConnect.priceP = ModelBase.PRICEP;

                client.lastConnect = null;
            }

            return receipt;
        }

        public override string ToString() {
            return NSP + " | " + telephoneNumber;
        }
    }
}
