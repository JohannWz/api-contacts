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

        public FormListeContacts(FluxConnexion fc) {
            InitializeComponent();
            flux = fc;
        }

        private void FormListeContacts_Load(object sender, EventArgs e) {
            lBonjour.Text = "Bonjour " + flux.user.name + ", voici votre liste de contacts :";

            Requete demandeContacts = new Requete(flux.token);
            demandeContacts.RecupererContacts();

            String json = demandeContacts.GetResult();
            FluxContacts fc = JsonConvert.DeserializeObject<FluxContacts>(json);
        }
    }
}