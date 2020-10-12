using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFTestTeacherRestoreVer._2.Models
{
    class ApplicationViewModel
    {
        public User user { get; set; }

        public IEnumerable<HandbookStudents> handbookStudents { get; set; }

        public IEnumerable<HandbookStudentTest> handbookStudentTests { get; set; }
        public IEnumerable<HandbookSubjects> handbookSubjects { get; set; }
        public IEnumerable<HandbookGrade> handbookGrades { get; set; }

        public IEnumerable<HandbookTest> handbookTests { get; set; }
        public IEnumerable<HandbookQuestions> handbookQuestions { get; set; }

        public async Task ChekTeacher(string login, string password)
        {
            UserServise userService = new UserServise();
            user = await userService.GetCheckTeacher(login, password);

        }

        public async Task GetStudents(string login, string password)
        {
            HandbookStudentsService handbookStudentsService = new HandbookStudentsService();
            handbookStudents = await handbookStudentsService.Get(login, password);

        }

        public async Task GetStudentTest(string login, string password, int userId, int testId, int taskId)
        {
            HandbookStudentTestService handbookStudentTestService = new HandbookStudentTestService();
            handbookStudentTests = await handbookStudentTestService.Get(login, password, userId, testId, taskId);
        }

        public async Task GetSubjects(string login, string password)
        {
            HandbookSubjectsService handbookSubjectsService = new HandbookSubjectsService();
            handbookSubjects = await handbookSubjectsService.Get(login, password);

        }


        public async Task AddSubject(string login, string password, HandbookSubjects handbookSubjects)
        {
            HandbookSubjectsService handbookSubjectsService = new HandbookSubjectsService();
            await handbookSubjectsService.Add(login, password, handbookSubjects);
        }


        public async Task<Boolean> DeleteSubject(string login, string password, int id)
        {
            bool success;
            HandbookSubjectsService handbookSubjectsService = new HandbookSubjectsService();
            success = await handbookSubjectsService.Delete(login, password, id);
            return success;
        }



        public async Task GetGrades(string login, string password)
        {
            HandbookGradeService handbookGradeService = new HandbookGradeService();
            handbookGrades = await handbookGradeService.Get(login, password);

        }


        public async Task AddGrade(string login, string password, HandbookGrade handbookGrade)
        {
            HandbookGradeService handbookGradeService = new HandbookGradeService();
            await handbookGradeService.Add(login, password, handbookGrade);
        }


        public async Task<Boolean> DeleteGrade(string login, string password, int id)
        {
            bool success;
            HandbookGradeService handbookGradeService = new HandbookGradeService();
            success = await handbookGradeService.Delete(login, password, id);
            return success;
        }


        public async Task GetTests(string login, string password)
        {
            HandbookTestService handbookTestService = new HandbookTestService();
            handbookTests = await handbookTestService.Get(login, password);

        }


        public async Task AddTest(string login, string password, TestDB test)
        {
            HandbookTestService handbookTestService = new HandbookTestService();
            await handbookTestService.Add(login, password, test);
        }


        public async Task<Boolean> DeleteTest(string login, string password, int id)
        {
            bool success;
            HandbookTestService handbookTestService = new HandbookTestService();
            success = await handbookTestService.Delete(login, password, id);
            return success;
        }


        public async Task GetQuestions(string login, string password)
        {
            HandbookQuestionsService handbookQuestionsService = new HandbookQuestionsService();
            handbookQuestions = await handbookQuestionsService.Get(login, password);

        }

        public async Task<Boolean> DeleteQuestion(string login, string password, int id)
        {
            bool success;
            HandbookQuestionsService handbookQuestionsService = new HandbookQuestionsService();
            success = await handbookQuestionsService.Delete(login, password, id);
            return success;
        }

    }
}
