using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    class HandbookSubjectsService
    {
        const string Url = "http://pakdmitriy1989-001-site1.htempurl.com/api/teacher";
        //const string Url = "https://localhost:44326/api/teacher";

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }


        public async Task<IEnumerable<HandbookSubjects>> Get(string login, string password)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url + "/" + "subject" + "/" + login + "/" + password);
            return JsonConvert.DeserializeObject<IEnumerable<HandbookSubjects>>(result);
        }


        public async Task Add(string login, string password, HandbookSubjects handbookSubjects)
        {
            HttpClient client = GetClient();
            var response = await client.PostAsync(Url,
                new StringContent(
                    JsonConvert.SerializeObject(handbookSubjects),
                    Encoding.UTF8, "application/json"));
        }


        public async Task<Boolean> Delete(string login, string password, int id)
        {
            HttpClient client = GetClient();
            var response = await client.DeleteAsync(Url + "/" + login + "/" + password + "/" + id);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
