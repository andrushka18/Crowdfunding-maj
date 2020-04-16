using DALAspCrowdfunding.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DALAspCrowdfunding.Repositories
{
    public class UtilisateurASPRep:IUtilisateurRep<int, Utilisateur>
    {

        public IEnumerable<Utilisateur> Get()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:44356/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("utilisateur").Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Utilisateur[]>(json);
            }
        }

        public Utilisateur Get(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri("https://localhost:44356/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("Utilisateur").Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Utilisateur>(json);
            }
        }

        
       

        public void ChangePassword(int id, string Password)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri("https://localhost:44356/api/secure/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsonContent = JsonConvert.SerializeObject(Password);
                HttpContent httpContent = new StringContent(jsonContent);
                httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = httpClient.PostAsync("NomUtilisateur", httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                JsonConvert.DeserializeObject<Utilisateur>(json);
            }
        }

        public int Check(string NomUtilisateur, string Password)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri("https://localhost:44356/api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                string jsonContent = JsonConvert.SerializeObject(NomUtilisateur);
                HttpContent httpContent = new StringContent(jsonContent);
                httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = httpClient.PostAsync("NomUtilisateur", httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<int>(json);
            }
        }

        public void Add(Utilisateur entity)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri("https://localhost:44356/api/secure/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsonContent = JsonConvert.SerializeObject(entity);
                HttpContent httpContent = new StringContent(jsonContent);
                httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = httpClient.PostAsync("Utilisateur", httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                 JsonConvert.DeserializeObject<Utilisateur>(json);
            }
        }

        public void Update(int id, Utilisateur entity)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri("https://localhost:44356/api/secure/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsonContent = JsonConvert.SerializeObject(entity);
                HttpContent httpContent = new StringContent(jsonContent);
                httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = httpClient.PutAsync("utilisateur" + id, httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                JsonConvert.DeserializeObject<Utilisateur>(json);
            }
        }

        public void Delete(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri("https://localhost:44356/api/secure/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage httpResponseMessage = httpClient.DeleteAsync("Utilisateur/" + id).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                JsonConvert.DeserializeObject<Utilisateur>(json);
            }
        }
        public void SetAdmin(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri("https://localhost:44356/api/secure/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string jsonContent = JsonConvert.SerializeObject(id);
                HttpContent httpContent = new StringContent(jsonContent);
                httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                HttpResponseMessage httpResponseMessage = httpClient.PutAsync("utilisateur" +id, httpContent).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                 JsonConvert.DeserializeObject<Utilisateur>(json);
            }
        }
        public void UnsetAdmin(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri("https://localhost:44356/api/secure/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage httpResponseMessage = httpClient.DeleteAsync("Utilisateur/id" + id).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                JsonConvert.DeserializeObject<Utilisateur>(json);
            }
        }
    }
}
