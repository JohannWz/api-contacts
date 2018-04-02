using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace api_contacts
{
    public partial class FormListeContacts : Form
    {
        private FluxConnexion monFlux;
        Requete maRequete = new Requete();
        Form monForm;

        public FormListeContacts(FluxConnexion flux)
        {
            InitializeComponent();
            monFlux = flux;
        }

        private void FormListeContacts_Load(object sender, EventArgs e)
        {
            lBonjour.Text = "Bonjour " + monFlux.user.name + ", voici votre liste de contacts :";
            RemplirDGV();
        }

        private void RemplirDGV()
        {
            dgvContacts.Rows.Clear();
            dgvContacts.Columns.Clear();

            maRequete.RecupererContacts(monFlux.token);

            String json = maRequete.GetResult();
            BindingList<Contact> lc = JsonConvert.DeserializeObject<BindingList<Contact>>(json);
            dgvContacts.DataSource = lc;

            DataGridViewButtonColumn btAff = new DataGridViewButtonColumn();
            btAff.UseColumnTextForButtonValue = true;
            btAff.Text = "Afficher";
            btAff.Name = "Afficher";
            dgvContacts.Columns.Add(btAff);

            DataGridViewButtonColumn btModif = new DataGridViewButtonColumn();
            btModif.UseColumnTextForButtonValue = true;
            btModif.Text = "Modifier";
            btModif.Name = "Modifier";
            dgvContacts.Columns.Add(btModif);

            DataGridViewButtonColumn btSupp = new DataGridViewButtonColumn();
            btSupp.UseColumnTextForButtonValue = true;
            btSupp.Text = "Supprimer";
            btSupp.Name = "Supprimer";
            dgvContacts.Columns.Add(btSupp);
        }

        private void dgvContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvContacts.Columns["Afficher"].Index)
            {
                monForm = new FenContact(monFlux, Convert.ToInt64(dgvContacts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                monForm.ShowDialog();
                RemplirDGV();
            }

            if (e.ColumnIndex == dgvContacts.Columns["Modifier"].Index)
            {
                monForm = new FormContact(monFlux, Convert.ToInt64(dgvContacts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                monForm.ShowDialog();
                RemplirDGV();
            }

            if (e.ColumnIndex == dgvContacts.Columns["Supprimer"].Index)
            {
                if (MessageBox.Show("Voulez-vous supprimer ce contact ?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    maRequete.SupprimerContact(monFlux.token, Convert.ToInt64(dgvContacts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    dgvContacts.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            monForm = new FormContact(monFlux, 0);
            monForm.ShowDialog();
            RemplirDGV();
        }
    }
}