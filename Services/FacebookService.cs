using AuthenticationRepository;
using AutoMapper;
using DataAccess;
using DataAccess.DBContext;
using DataAccess.DTO;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FacebookService : IFacebookRepository
    {
        private readonly IRepository<Facebook> _facebookRepository;
        private readonly ILog _logger;
        public FacebookService(IRepository<Facebook> facebookRepository, AppDBContext context)
        {
            _facebookRepository = facebookRepository;
            _logger = LogManager.GetLogger(typeof(FacebookService));        

        }

        public List<Facebook> GetAllFacebook()
        {
            var lstFacebook = _facebookRepository.GetAll().ToList();
            //return _mapper.Map<List<Facebook>,List<FacebookModel>>(lstFacebook);
            return lstFacebook;
        }
    }
}
