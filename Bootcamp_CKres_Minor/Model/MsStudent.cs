using System.ComponentModel.DataAnnotations;

namespace Bootcamp_CKres_Minor.Model
{
    public class MsStudent
    {
        [Key] public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public int genderId { get; set; }
        public int religionId { get; set; }
        public string email { get; set; }
        public string address { get; set; }

    }
}
