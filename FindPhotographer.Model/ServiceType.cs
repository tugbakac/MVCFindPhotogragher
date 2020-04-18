using FindPhotographer.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPhotographer.Model
{
    public class ServiceType : BaseEntity
    {
        public string Name { get; set; }//enum olabilir

        //mapping giden
        public virtual List<ServiceDetail> ServiceDetail { get; set; }
    }
}
