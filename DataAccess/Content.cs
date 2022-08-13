using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Content : BaseEntity
    {
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FacebookId { get; set; }
        public Facebook Facebook { get; set; }
    }
}
