using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConfigurationManager
{
    public class EFConfigSource : IConfigurationSource
    {
        private readonly Action<DbContextOptionsBuilder> _optionsAction;
        public EFConfigSource(Action<DbContextOptionsBuilder> optionsAction)
        {
            _optionsAction = optionsAction;
        }
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new EFConfigProvider(_optionsAction);
        }
    }
}
