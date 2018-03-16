using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace api_contacts {
    public class Requete {

        private String json;
        private HttpWebRequest httpWebRequest;
        private String result;

        public Requete() {}

        public Requete(String e, String mdp) {
            json = "{\"email\":\"" + e + "\",\"password\":\"" + mdp + "\"}";
        }

        public void SeConnecter() {
            httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.nebulon.fr/api/v1/authenticate");
            httpWebRequest.Method = "POST";
            EnvoyerPost();
        }

        public void RecupererContacts(String token) {
            httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.nebulon.fr/api/v1/users/contacts");
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
            Envoyer();
        }

        public void EnvoyerPost() {
            httpWebRequest.ContentType = "application/json";

            StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
            streamWriter.Write(json);
            streamWriter.Flush();
            streamWriter.Close();

            Envoyer();
        }

        public void Envoyer() {
            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream());
            result = streamReader.ReadToEnd();
        }

        public String GetResult() {
            return result;
        }
    }
}
