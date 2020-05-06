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
using System.Windows.Forms.DataVisualization.Charting;

namespace InternetServiceProvider.view {
    public partial class CountClientsByMonthForm : Form {
        public CountClientsByMonthForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Chart chart = (Chart)Controls.Find("chart", true)[0];
            MonthCalendar monthCalendar = (MonthCalendar)Controls.Find("monthCalendar", true)[0];
            chart.Series[0].Points.Clear();
            for (int i = 0; i < DateTime.DaysInMonth(monthCalendar.SelectionRange.Start.Year, monthCalendar.SelectionRange.Start.Month); i++) {
                DateTime date = new DateTime(2020, monthCalendar.SelectionRange.Start.Month, i + 1, 0, 0, 0);
                //MessageBox.Show(Program.modelBase.GetClientCountByMonth(date) + "");
                chart.Series[0].Points.AddXY(i, Program.modelBase.GetClientCountByMonthAndDay(date));
            }
            chart.Update();
        }
    }
}
