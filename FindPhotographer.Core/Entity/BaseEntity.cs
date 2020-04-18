using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPhotographer.Core.Entity
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreationDate = DateTime.Now;//oluşturulma tarihi
            DidDelete = false;//silindi mi kontrolü
        }

        //her tabloda bulunmasını istediği temel veriler base entity de yer alıyor
        public int ID { get; set; }
        public DateTime CreationDate { get; set; }
        public bool DidDelete { get; set; }
    }
}
