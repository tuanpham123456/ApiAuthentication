using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class FacebookModel
    {
        public int FacebookId { get; set; }
        public string FacebookName { get; set; }

        public virtual List<Content> Content { get; set; }
    }
}
