using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    class HandbookTestService
    {
        const string Url = "http://pakdmitriy1989-001-site1.htempurl.com/api/teacher";
        //const string Url = "https://localhost:44326/api/teacher";

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<HandbookTest>> Get(string login, string password)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url + "/" + "Test" + "/" + login + "/" + password);
            return JsonConvert.DeserializeObject<IEnumerable<HandbookTest>>(result);
        }


        public async Task Add(string login, string password, TestDB test)
        {
            HttpClient client = GetClient();
            var response = await client.PostAsync(Url + "/" + "Test" + "/" + login + "/" + password,
                new StringContent(
                    JsonConvert.SerializeObject(test),
                    Encoding.UTF8, "application/json"));
        }


        public async Task<Boolean> Delete(string login, string password, int id)
        {
            HttpClient client = GetClient();
            var response = await client.DeleteAsync(Url + "/" + "Test" + "/" + login + "/" + password + "/" + id);
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
