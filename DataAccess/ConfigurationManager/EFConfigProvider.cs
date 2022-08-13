using DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ConfigurationManager
{
    // file này đóng vai trò tạo ra các extension method cho IConfigurationBuilder
    public  class EFConfigProvider : ConfigurationProvider
    {
        Action<DbContextOptionsBuilder> _optionAction { get; }

        public EFConfigProvider(Action<DbContextOptionsBuilder> optionAction)
        {
            _optionAction = optionAction;
        }
        public override void Load()
        {
            var builder = new DbContextOptionsBuilder<AppDBContext>();
            _optionAction(builder);
            using (var dbContext = new AppDBContext(builder.Options))
            {
                dbContext.Database.EnsureCreated();
                Data = dbContext.Configs.ToDictionary(c => c.Key, c => c.Value);
            }
        }

    }
}
