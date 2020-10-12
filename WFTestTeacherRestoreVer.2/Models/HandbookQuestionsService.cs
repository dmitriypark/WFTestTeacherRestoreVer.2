using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    class HandbookQuestionsService
    {
        const string Url = "http://pakdmitriy1989-001-site1.htempurl.com/api/teacher";
        //const string Url = "https://localhost:44326/api/teacher";

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<HandbookQuestions>> Get(string login, string password)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url + "/" + "Question" + "/" + login + "/" + password);
            return JsonConvert.DeserializeObject<IEnumerable<HandbookQuestions>>(result);
        }


        public async Task Add(string login, string password, QuestionDB question)
        {
            HttpClient client = GetClient();
            var response = await client.PostAsync(Url + "/" + "Question" + "/" + login + "/" + password,
                new StringContent(
                    JsonConvert.SerializeObject(question),
                    Encoding.UTF8, "application/json"));
        }


        public async Task<Boolean> Delete(string login, string password, int id)
        {
            HttpClient client = GetClient();
            var response = await client.DeleteAsync(Url + "/" + "Question" + "/" + login + "/" + password + "/" + id);
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
