using Bootcamp_CKres_Minor.Output;

namespace Bootcamp_CKres_Minor.Helper
{
    public class SubjectHelper
    {
        private SchoolDBContext dBContext;
        public SubjectHelper(SchoolDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public List<Subject> GetAllSubjects()
        {
            var returnValue = new List<Subject>();
            try
            {
                var subjects = dBContext.MsSubject.ToList();

                returnValue = subjects.Select(subject => new Subject()
                {
                    id = subject.id,
                    name = subject.name,
                }).ToList();

                return returnValue;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
