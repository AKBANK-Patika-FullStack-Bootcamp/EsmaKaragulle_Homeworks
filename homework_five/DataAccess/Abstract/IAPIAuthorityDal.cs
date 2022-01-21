using Airliness.Dal.Abstract;
using Entities.AuthModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAPIAuthorityDal : IEntityRepository<APIAuthority>
    {
        void CreateLogin(APIAuthority loginUser);
        APIAuthority GetLogin(APIAuthority loginUser);
    }
}
