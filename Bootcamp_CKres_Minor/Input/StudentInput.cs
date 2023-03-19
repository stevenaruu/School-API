namespace Bootcamp_CKres_Minor.Input
{
    public class StudentInput
    {
        public int? studentId { get; set; }
        public string? name { get; set; }
        public DateTime birthDate { get; set; }
        public int? gender { get; set; }
        public int? religion { get; set; }
        public string? email { get; set; }
        public string? addres { get; set; }

        public List<ScoreInput> scoreList { get; set; }
    }

    public class ScoreInput
    {
        public int? subjectId { get; set;}
        public decimal? semester1Score { get; set; }
        public decimal? semester2Score { get; set; }
    }
}
