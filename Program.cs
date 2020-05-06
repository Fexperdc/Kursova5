using InternetServiceProvider.model;
using InternetServiceProvider.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InternetServiceProvider {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static ModelBase modelBase = new ModelBase();

        public static MainForm mainForm;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                modelBase = JsonConvert.DeserializeObject<ModelBase>(System.IO.File.ReadAllText(openFileDialog.FileName));
            } else {
                modelBase = new ModelBase();
            }

            mainForm = new MainForm(modelBase);
            mainForm.UpdateForm();

            Application.Run(mainForm);
        }
    }
}
