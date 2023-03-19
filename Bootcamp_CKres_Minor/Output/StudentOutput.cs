using System.Globalization;

namespace Bootcamp_CKres_Minor.Output
{
    public class StudentOutput
    {
        public StudentData? payload { get; set; }
        public StudentOutput()
        {
            payload = new StudentData();
        }
    }

    public class Score
    {
        public int subjectId { get; set; }
        public string subjectName { get; set; }
        public decimal semester1Score { get; set; }
        public decimal semester2Score { get; set; }
        public decimal finalScore { get; set; }
    }

    public class StudentData
    {
        public Student student { get; set; }
        public DateTime birthDate { get; set; }
        public Gender gender { get; set; }
        public Religion religion { get; set; }
        public string email { get; set; }
        public string addres { get; set; }
        public List<Score> scoreList { get; set; }
        public decimal averageFinalScore { get; set; }
        public string grade { get; set; }
    }

    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
