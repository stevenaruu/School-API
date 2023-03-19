using Bootcamp_CKres_Minor.Output;

namespace Bootcamp_CKres_Minor.Helper
{
    public class GradeHelper
    {
        private SchoolDBContext dBContext;
        public GradeHelper(SchoolDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public List<Grade> GetAllGrades()
        {
            var returnValue = new List<Grade>();
            try
            {
                var grades = dBContext.MsGrade.ToList();

                returnValue = grades.Select(grade => new Grade()
                {
                    id = grade.id,
                    name = grade.name,
                    minScore = grade.minScore,
                    maxScore = grade.maxScore,
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
