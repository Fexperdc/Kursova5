﻿namespace InternetServiceProvider.view.control {
    partial class ConnectList {
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
            this.connectLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // connectLB
            // 
            this.connectLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectLB.FormattingEnabled = true;
            this.connectLB.Location = new System.Drawing.Point(0, 0);
            this.connectLB.Name = "connectLB";
            this.connectLB.Size = new System.Drawing.Size(260, 274);
            this.connectLB.TabIndex = 0;
            this.connectLB.DoubleClick += new System.EventHandler(this.connectLB_DoubleClick);
            // 
            // ConnectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.connectLB);
            this.Name = "ConnectList";
            this.Size = new System.Drawing.Size(260, 274);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox connectLB;
    }
}
