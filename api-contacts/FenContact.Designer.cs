namespace api_contacts
{
    partial class FenContact
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.cbFavoris = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Téléphone";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(174, 216);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(206, 42);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(29, 13);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(206, 67);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(43, 13);
            this.lbPrenom.TabIndex = 1;
            this.lbPrenom.Text = "Prénom";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(206, 94);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Location = new System.Drawing.Point(206, 120);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(58, 13);
            this.lbTelephone.TabIndex = 1;
            this.lbTelephone.Text = "Téléphone";
            // 
            // cbFavoris
            // 
            this.cbFavoris.AutoSize = true;
            this.cbFavoris.Location = new System.Drawing.Point(209, 150);
            this.cbFavoris.Name = "cbFavoris";
            this.cbFavoris.Size = new System.Drawing.Size(15, 14);
            this.cbFavoris.TabIndex = 3;
            this.cbFavoris.UseVisualStyleBackColor = true;
            this.cbFavoris.CheckedChanged += new System.EventHandler(this.cbFavoris_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Favoris";
            // 
            // FenContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 251);
            this.Controls.Add(this.cbFavoris);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTelephone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.label1);
            this.Name = "FenContact";
            this.Text = "Info du contact";
            this.Load += new System.EventHandler(this.FenContact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.CheckBox cbFavoris;
        private System.Windows.Forms.Label label5;
    }
}