namespace Bootcamp_CKres_Minor.Output
{
    public class ReligionOutput
    {
        public List<Religion> payload { get; set; }

        public ReligionOutput()
        {
            payload = new List<Religion>();
        }
    }

    public class Religion
    {
        public int id { get; set; }
        public string description { get; set; }
    }
}
