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
    public partial class FenContact : Form
    {
        private FluxConnexion monFlux;
        private long idContact;
        Requete maRequete = new Requete();
        FullContact monContact = new FullContact();

        public FenContact(FluxConnexion flux, long id)
        {
            InitializeComponent();
            monFlux = flux;
            idContact = id;
        }

        private void FenContact_Load(object sender, EventArgs e)
        {
            maRequete.RecupererContact(monFlux.token, idContact);

            String json = maRequete.GetResult();
            monContact = JsonConvert.DeserializeObject<FullContact>(json);

            lbNom.Text = monContact.first_name;
            lbPrenom.Text = monContact.last_name;
            lbEmail.Text = monContact.email;
            lbTelephone.Text = monContact.phone;
            cbFavoris.Checked = monContact.favorite;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFavoris_CheckedChanged(object sender, EventArgs e)
        {
            monContact.favorite = cbFavoris.Checked;
            maRequete.ModifierContact(monFlux.token, monContact);
        }
    }
}
