namespace api_contacts
{
    partial class FormListeContacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
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
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Location = new System.Drawing.Point(16, 41);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.Size = new System.Drawing.Size(843, 300);
            this.dgvContacts.TabIndex = 1;
            this.dgvContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellContentClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(378, 351);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(117, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter un contact";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormListeContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 386);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.lBonjour);
            this.Name = "FormListeContacts";
            this.Text = "Liste des contacts";
            this.Load += new System.EventHandler(this.FormListeContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lBonjour;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.Button btnAjouter;
    }
}