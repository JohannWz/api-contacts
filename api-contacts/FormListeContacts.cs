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

namespace api_contacts {
    public partial class FormListeContacts : Form {
        private FluxConnexion flux;

        public FormListeContacts(FluxConnexion fcx) {
            InitializeComponent();
            flux = fcx;
        }

        private void FormListeContacts_Load(object sender, EventArgs e) {
            lBonjour.Text = "Bonjour " + flux.user.name + ", voici votre liste de contacts :";

            Requete demandeContacts = new Requete();
            demandeContacts.RecupererContacts(flux.token);

            String json = demandeContacts.GetResult();
            List<Contact> lc = JsonConvert.DeserializeObject<List<Contact>>(json);

            foreach (Contact c in lc) {
                lbContacts.Items.Add(c.first_name);
                lbContacts.Items.Add(c.last_name);
                lbContacts.Items.Add(c.address);
                lbContacts.Items.Add(c.phone);
                lbContacts.Items.Add(c.favorite);
            }

        }
    }
}