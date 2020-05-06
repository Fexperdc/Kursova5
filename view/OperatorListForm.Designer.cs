namespace InternetServiceProvider.view {
    partial class OperatorListForm {
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
            this.operatorList = new InternetServiceProvider.view.control.OperatorList();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operatorList
            // 
            this.operatorList.Location = new System.Drawing.Point(12, 12);
            this.operatorList.Name = "operatorList";
            this.operatorList.Size = new System.Drawing.Size(335, 183);
            this.operatorList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(335, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вибрати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OperatorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operatorList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperatorListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperatorListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private control.OperatorList operatorList;
        private System.Windows.Forms.Button button1;
    }
}