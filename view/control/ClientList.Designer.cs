namespace InternetServiceProvider.view.control {
    partial class ClientList {
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
            this.clientLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clientLB
            // 
            this.clientLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientLB.FormattingEnabled = true;
            this.clientLB.Location = new System.Drawing.Point(0, 0);
            this.clientLB.Name = "clientLB";
            this.clientLB.Size = new System.Drawing.Size(361, 374);
            this.clientLB.TabIndex = 0;
            this.clientLB.DoubleClick += new System.EventHandler(this.clientLB_DoubleClick);
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.clientLB);
            this.Name = "ClientList";
            this.Size = new System.Drawing.Size(361, 374);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox clientLB;
    }
}
