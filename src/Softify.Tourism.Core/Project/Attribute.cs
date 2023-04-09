using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softify.Tourism.Project
{
    public class Attribute : FullAuditedEntity
    {
        public string AttributeName { get; set; }
        public string AttributeDescription { get; set; }

        public ICollection<AttributeService> AttributeServices { get; set; }

    }
}
