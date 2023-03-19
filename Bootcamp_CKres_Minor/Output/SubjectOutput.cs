using System.ComponentModel.DataAnnotations;

namespace Bootcamp_CKres_Minor.Output
{
    public class SubjectOutput
    {
        public List<Subject> payload { get; set; }

        public SubjectOutput()
        {
            payload = new List<Subject>();
        }
    }

    public class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
