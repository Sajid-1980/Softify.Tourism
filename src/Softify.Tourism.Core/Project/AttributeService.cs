using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softify.Tourism.Project
{
    public class AttributeService : FullAuditedEntity
    {

        public string Value { get; set; }
        public int AttributeId { get; set; }
        public int ServiceId { get; set; }

        public Service Service { get; set; }
        public Attribute Attribute { get; set; }


    }
}
