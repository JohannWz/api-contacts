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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion(tbEmail.Text, tbMdp.Text);
            Requete maRequete = new Requete();
            maRequete.SeConnecter(connexion);

            String json = maRequete.GetResult();
            FluxConnexion monFlux = JsonConvert.DeserializeObject<FluxConnexion>(json);

            Form monForm = new FormListeContacts(monFlux);
            this.Hide();
            monForm.ShowDialog();
            this.Close();
        }
    }
}
