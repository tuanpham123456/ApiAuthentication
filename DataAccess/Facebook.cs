using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Facebook : BaseEntity
    {
        public int FacebookId { get; set; }
        public string FacebookName { get; set; }
        public virtual List<Content> Content { get; set; }
    }
}
