namespace InternetServiceProvider.view {
    partial class ListOperatorsByDay {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.accept = new System.Windows.Forms.Button();
            this.operatorList = new InternetServiceProvider.view.control.OperatorList();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(80, 13);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(12, 39);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(320, 23);
            this.accept.TabIndex = 2;
            this.accept.Text = "Підтвердити";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // operatorList
            // 
            this.operatorList.Location = new System.Drawing.Point(12, 68);
            this.operatorList.Name = "operatorList";
            this.operatorList.Size = new System.Drawing.Size(320, 179);
            this.operatorList.TabIndex = 0;
            // 
            // ListOperatorsByDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 252);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.operatorList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListOperatorsByDay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOperatorsByDay";
            this.ResumeLayout(false);

        }

        #endregion

        private control.OperatorList operatorList;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button accept;
    }
}