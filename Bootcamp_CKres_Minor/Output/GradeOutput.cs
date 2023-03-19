using System.ComponentModel.DataAnnotations;

namespace Bootcamp_CKres_Minor.Output
{
    public class GradeOutput
    {
        public List<Grade> payload { get; set; }

        public GradeOutput()
        {
            payload = new List<Grade>();
        }
    }

    public class Grade
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal minScore { get; set; }
        public decimal maxScore { get; set; }
    }
}
