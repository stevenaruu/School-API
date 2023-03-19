using System.ComponentModel.DataAnnotations;

namespace Bootcamp_CKres_Minor.Model
{
    public class MsSubject
    {
        [Key] public int id { get; set; }
        public string name { get; set; }
    }
}
