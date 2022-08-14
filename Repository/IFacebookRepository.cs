using DataAccess;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationRepository
{
    public interface IFacebookRepository
    {
        List<Facebook> GetAllFacebook();
    }
}
