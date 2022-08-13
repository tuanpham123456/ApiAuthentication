using AuthenticationRepository;
using AutoMapper;
using DataAccess;
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
        private readonly IMapper _mapper;
        private readonly ILog _logger;
        public FacebookService(IRepository<Facebook> facebookRepository, IMapper mapper)
        {
            _facebookRepository = facebookRepository;
            _mapper = mapper;
            _logger = LogManager.GetLogger(typeof(FacebookService));        

        }

        public List<FacebookModel> GetAllFacebook()
        {
            var lstFacebook = _facebookRepository.GetAll().ToList();
            return _mapper.Map<List<Facebook>,List<FacebookModel>>(lstFacebook);
        }
    }
}
