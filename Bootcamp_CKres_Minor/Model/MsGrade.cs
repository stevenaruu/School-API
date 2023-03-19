using System.ComponentModel.DataAnnotations;

namespace Bootcamp_CKres_Minor.Model
{
    public class MsGrade
    {
        [Key] public int id { get; set; }
        public string name { get; set; }
        public decimal minScore { get; set; }
        public decimal maxScore { get; set; }

    }
}
