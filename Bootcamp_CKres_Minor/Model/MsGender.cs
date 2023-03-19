using System.ComponentModel.DataAnnotations;

namespace Bootcamp_CKres_Minor.Model
{
    public class MsGender
    {
        [Key] public int id { get; set; }
        public string description { get; set; }
    }
}
