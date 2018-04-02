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
    public partial class FormContact : Form
    {
        private FluxConnexion monFlux;
        private long idContact;
        Requete maRequete = new Requete();
        private FullContact monContact = new FullContact();

        public FormContact(FluxConnexion flux, long id)
        {
            InitializeComponent();
            monFlux = flux;
            idContact = id;
        }

        private void FormContact_Load(object sender, EventArgs e)
        {
            if (idContact != 0)
            {
                maRequete.RecupererContact(monFlux.token, idContact);

                String json = maRequete.GetResult();
                monContact = JsonConvert.DeserializeObject<FullContact>(json);

                tbNom.Text = monContact.first_name;
                tbPrenom.Text = monContact.last_name;
                tbEmail.Text = monContact.email;
                tbTelephone.Text = monContact.phone;
                cbFavoris.Checked = monContact.favorite;

                btnModifier.Visible = true;
            }
            else
            {
                btnAjouter.Visible = true;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            monContact.first_name = tbNom.Text;
            monContact.last_name = tbPrenom.Text;
            monContact.email = tbEmail.Text;
            monContact.phone = tbTelephone.Text;
            monContact.favorite = cbFavoris.Checked;

            maRequete.ModifierContact(monFlux.token, monContact);
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            monContact.first_name = tbNom.Text;
            monContact.last_name = tbPrenom.Text;
            monContact.email = tbEmail.Text;
            monContact.phone = tbTelephone.Text;
            monContact.favorite = cbFavoris.Checked;

            maRequete.AjouterContact(monFlux.token, monContact);
            this.Close();
        }
    }
}
