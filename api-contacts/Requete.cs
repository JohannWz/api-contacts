using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace api_contacts 
{
    public class Requete
    {
        private String uri = "https://api.nebulon.fr/api/v1/";
        private String json;
        private HttpWebRequest httpWebRequest;
        private String result;

        public Requete() {}

        public void SeConnecter(Connexion c)
        {
            json = JsonConvert.SerializeObject(c);
            httpWebRequest = (HttpWebRequest)WebRequest.Create(uri + "authenticate");
            httpWebRequest.Method = "POST";
            EnvoyerJson();
        }

        public void RecupererContacts(String token)
        {
            httpWebRequest = (HttpWebRequest)WebRequest.Create(uri + "users/contacts");
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
            Envoyer();
        }

        public void RecupererContact(String token, long id)
        {
            httpWebRequest = (HttpWebRequest)WebRequest.Create(uri + "users/contacts/" + id);
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
            Envoyer();
        }

        public void AjouterContact(String token, FullContact fc)
        {
            json = JsonConvert.SerializeObject(fc);
            // Suppression de l'id dans le json
            var o = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(json);
            json = o.ToString();

            httpWebRequest = (HttpWebRequest)WebRequest.Create(uri + "users/contacts");
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
            EnvoyerJson();
        }

        public void ModifierContact(String token, FullContact fc)
        {
            json = JsonConvert.SerializeObject(fc);
            httpWebRequest = (HttpWebRequest)WebRequest.Create(uri + "users/contacts/" + fc.id);
            httpWebRequest.Method = "PUT";
            httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
            EnvoyerJson();
        }

        public void SupprimerContact(String token, double id)
        {
            httpWebRequest = (HttpWebRequest)WebRequest.Create(uri + "users/contacts/" + id);
            httpWebRequest.Method = "DELETE";
            httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
            Envoyer();
        }

        public void EnvoyerJson()
        {
            StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
            streamWriter.Write(json);
            streamWriter.Flush();
            streamWriter.Close();

            Envoyer();
        }

        public void Envoyer()
        {
            httpWebRequest.ContentType = "application/json";
            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream());
            result = streamReader.ReadToEnd();
        }

        public String GetResult()
        {
            return result;
        }
    }
}
