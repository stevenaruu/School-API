using Bootcamp_CKres_Minor.Output;

namespace Bootcamp_CKres_Minor.Helper
{
    public class GenderHelper
    {
        private SchoolDBContext dBContext;
        public GenderHelper(SchoolDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public List<Gender> GetAllGenders()
        {
            var returnValue = new List<Gender>();
            try
            {
                var genders = dBContext.MsGender.ToList();

                returnValue = genders.Select(gender => new Gender()
                {
                    id = gender.id,
                    description = gender.description,
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
