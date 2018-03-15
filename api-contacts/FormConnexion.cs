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
    public partial class FormConnexion : Form {
        public FormConnexion() {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e) {

            Requete maConnexion = new Requete(tbEmail.Text, tbMdp.Text);
            maConnexion.SeConnecter();

            String json = maConnexion.GetResult();
            FluxConnexion fc = JsonConvert.DeserializeObject<FluxConnexion>(json);

            Form form = new FormListeContacts(fc);
            form.ShowDialog(this);
        }
    }
}
