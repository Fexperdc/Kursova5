using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetServiceProvider.model {
    public class ModelBase {

        public static float PRICE = 5;
        public static float PRICEP = 3;
        public static Organization currentOrganization = new Organization("НТК", "Адрес", "564654654");
        public static DateTime currentDate = DateTime.Now;
        public static int currentId = 0;

        public List<Client> clients = new List<Client>();
        public List<Operator> operators = new List<Operator>();
        public static Operator currentOperator;

        public List<TimeCount> timeCounts = new List<TimeCount>();

        public bool AddClient(Client client) {
            if (client.ip.Equals("")) {
                return false;
            } else {
                clients.Add(client);
                currentId++;
                client.computerId = currentId;
                return true;
            }
        }

        public bool AddOperator(Operator operatorO) {
            if (operatorO.NSP.Equals("") || operatorO.telephoneNumber.Equals("")) {
                return false;
            } else {
                operators.Add(operatorO);
                return true;
            }
        }

        public bool ChangeOperator(Operator operatorO) {
            if(operatorO == null) {
                return false;
            } else {
                currentOperator = operatorO;
                return true;
            }
        }

        //public Receipt CheckConnect(Operator operatorO, Client client) {
        //    return operatorO.CheckConnect(client);
        //}

        public int GetClientCountByMonth(DateTime date) {
            int count = 0;
            foreach(Client client in clients) {
                foreach(Connect connect in client.connects) {
                    if(connect.start.Year == date.Year && connect.start.Month == date.Month) {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }

        public int GetClientCountByMonthAndDay(DateTime date) {
            int count = 0;
            foreach (Client client in clients) {
                foreach (Connect connect in client.connects) {
                    if (connect.start.Year == date.Year && connect.start.Month == date.Month &&
                        connect.start.Day == date.Day) {
                        count++;
                        break;
                    } else {
                        break;
                    }
                }
            }

            return count;
        }

        public List<Client> GetClientsByMonthAndDay(DateTime date) {
            List<Client> result = new List<Client>();
            foreach (Client client in clients) {
                foreach (Connect connect in client.connects) {
                    if (connect.start.Year == date.Year && connect.start.Month == date.Month &&
                        connect.start.Day == date.Day) {
                        result.Add(client);
                        break;
                    } else {
                        break;
                    }
                }
            }

            return result;
        }

        public List<Operator> GetOperatorsByDay(DateTime date) {
            List<Operator> operators = new List<Operator>();

            foreach(Client client in clients) {
                foreach (Connect connect in client.connects) {
                    if (connect.receipt != null && connect.start.Year == date.Year && connect.start.Month == date.Month &&
                        connect.start.Day == date.Day) {
                        operators.Add(connect.receipt.operatorO);
                    }
                }
            }

            return operators;
        }

        public static float GetPrice(TimeSpan timeSpan, bool p) {
            if (p) {
                return PRICEP;
            } else {
                return PRICE;
            }
        }
    }
}
