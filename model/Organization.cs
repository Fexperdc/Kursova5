using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetServiceProvider.model {
    public class Organization {
        public String name;
        public String address;
        public String telephoneNumber;

        public Organization(String name, String address, String telephoneNumber) {
            this.name = name;
            this.address = address;
            this.telephoneNumber = telephoneNumber;
        }

        public override string ToString() {
            return name + " " + address + " " + telephoneNumber;
        }
    }
}
