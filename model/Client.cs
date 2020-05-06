using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetServiceProvider.model {
    public class Client {

        public int computerId;
        public String ip;
        public List<Connect> connects = new List<Connect>();

        public Connect lastConnect;

        public void Connect(DateTime start, DateTime end) {
            Connect connect = new Connect();
            connect.start = start;
            connect.end = end;
            connects.Add(connect);

            lastConnect = connect;
        }

        public override string ToString() {
            return "ID: " + computerId + "IP" + ip;
        }
    }
}
