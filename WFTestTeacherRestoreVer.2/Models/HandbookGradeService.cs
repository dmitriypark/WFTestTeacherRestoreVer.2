using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    class HandbookGradeService
    {
        const string Url = "http://pakdmitriy1989-001-site1.htempurl.com/api/teacher";
        //const string Url = "https://localhost:44326/api/teacher";

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<HandbookGrade>> Get(string login, string password)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url + "/" + "Grade" + "/" + login + "/" + password);
            return JsonConvert.DeserializeObject<IEnumerable<HandbookGrade>>(result);
        }


        public async Task Add(string login, string password, HandbookGrade handbookGrade)
        {
            HttpClient client = GetClient();
            var response = await client.PostAsync(Url + "/" + "Grade" + "/" + login + "/" + password,
                new StringContent(
                    JsonConvert.SerializeObject(handbookGrade),
                    Encoding.UTF8, "application/json"));
        }


        public async Task<Boolean> Delete(string login, string password, int id)
        {
            HttpClient client = GetClient();
            var response = await client.DeleteAsync(Url + "/" + "Grade" + "/" + login + "/" + password + "/" + id);
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
