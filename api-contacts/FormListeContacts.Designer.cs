namespace api_contacts {
    partial class FormListeContacts {
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
            this.lBonjour = new System.Windows.Forms.Label();
            this.lbContacts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lBonjour
            // 
            this.lBonjour.AutoSize = true;
            this.lBonjour.Location = new System.Drawing.Point(13, 13);
            this.lBonjour.Name = "lBonjour";
            this.lBonjour.Size = new System.Drawing.Size(35, 13);
            this.lBonjour.TabIndex = 0;
            this.lBonjour.Text = "label1";
            // 
            // lbContacts
            // 
            this.lbContacts.FormattingEnabled = true;
            this.lbContacts.Location = new System.Drawing.Point(13, 48);
            this.lbContacts.MultiColumn = true;
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.Size = new System.Drawing.Size(775, 381);
            this.lbContacts.TabIndex = 1;
            // 
            // FormListeContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbContacts);
            this.Controls.Add(this.lBonjour);
            this.Name = "FormListeContacts";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormListeContacts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBonjour;
        private System.Windows.Forms.ListBox lbContacts;
    }
}