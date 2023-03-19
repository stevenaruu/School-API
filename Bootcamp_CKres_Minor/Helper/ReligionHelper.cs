using Bootcamp_CKres_Minor.Output;

namespace Bootcamp_CKres_Minor.Helper
{
    public class ReligionHelper
    {
        private SchoolDBContext dBContext;
        public ReligionHelper(SchoolDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public List<Religion> GetAllReligions()
        {
            var returnValue = new List<Religion>();
            try
            {
                var religions = dBContext.MsReligion.ToList();

                returnValue = religions.Select(religion => new Religion()
                {
                    id = religion.id,
                    description = religion.description,
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
