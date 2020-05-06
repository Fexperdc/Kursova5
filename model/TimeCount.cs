using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetServiceProvider.model {
    public class TimeCount {

        public DateTime time;
        public int count = 0;

        public TimeCount(DateTime time) {
            this.time = time;
        }

    }
}
