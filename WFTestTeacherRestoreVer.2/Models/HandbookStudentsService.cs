using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    class HandbookStudentsService
    {
        const string Url = "http://pakdmitriy1989-001-site1.htempurl.com/api/teacher";

        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }


        public async Task<IEnumerable<HandbookStudents>> Get(string login, string password)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url + "/" + "students" + "/" + login + "/" + password);
            return JsonConvert.DeserializeObject<IEnumerable<HandbookStudents>>(result);
        }
    }
}
