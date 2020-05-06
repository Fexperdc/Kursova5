using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetServiceProvider.model {
    public class Connect {
        public DateTime start, end;
        public Receipt receipt;
        public float price, priceP;
        public float sum;

        public float GetDuration() {
            return (float) end.Subtract(start).TotalMinutes;
        }

        public float GetSum(bool p) {
            return ModelBase.GetPrice(new TimeSpan(), p) * GetDuration();
        }

        public override string ToString() {
            return "Початок: " + start + " Кінець: " + end; 
        }
    }
}
