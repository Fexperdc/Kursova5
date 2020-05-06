namespace InternetServiceProvider.view.control {
    partial class OperatorList {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.operatorLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // operatorLB
            // 
            this.operatorLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorLB.FormattingEnabled = true;
            this.operatorLB.Location = new System.Drawing.Point(0, 0);
            this.operatorLB.Name = "operatorLB";
            this.operatorLB.Size = new System.Drawing.Size(299, 311);
            this.operatorLB.TabIndex = 0;
            // 
            // OperatorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.operatorLB);
            this.Name = "OperatorList";
            this.Size = new System.Drawing.Size(299, 311);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox operatorLB;
    }
}
