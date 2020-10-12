using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    class HandbookStudentTestService
    {
        const string Url = "http://pakdmitriy1989-001-site1.htempurl.com/api/teacher";

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }


        public async Task<IEnumerable<HandbookStudentTest>> Get(string login, string password, int userID, int testId, int taskId)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url + "/" + "students" + "/" + login + "/" + password + "/" + "Test/" + userID + "/" + testId + "/" + taskId);
            return JsonConvert.DeserializeObject<IEnumerable<HandbookStudentTest>>(result);
        }
    }
}
