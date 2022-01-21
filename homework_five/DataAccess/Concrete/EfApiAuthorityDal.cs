using Airliness.Dal.Concrete;
using DataAccess.Abstract;
using Entities.AuthModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfApiAuthorityDal : EfEntityRepositoryBase<APIAuthority, AirlinessContext>, IAPIAuthorityDal
    {
       
        public void CreateLogin(APIAuthority loginUser)
        {
            using (AirlinessContext context = new AirlinessContext())
            {
                context.APIAuthority.Add(loginUser);
                context.SaveChanges();
            }
        }

        public APIAuthority GetLogin(APIAuthority loginUser)
        {
            using (AirlinessContext context = new AirlinessContext())
            {
                APIAuthority user = new APIAuthority();
                if (!string.IsNullOrEmpty(loginUser.UserName) && !string.IsNullOrEmpty(loginUser.Password))
                {
                    user = context.APIAuthority.FirstOrDefault(m => m.UserName == loginUser.UserName && m.Password == loginUser.Password);
                }

                return user;

            }
        }
    }
}
