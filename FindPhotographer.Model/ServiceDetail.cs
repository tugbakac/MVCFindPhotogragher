using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPhotographer.Model
{
    public class ServiceDetail
    {
        public decimal Price { get; set; }
        public string Explanation { get; set; }

        //mapping gelen
        public int PhotographerID { get; set; }
        public int ServiceID { get; set; }

        //mapping bağlantı
        public Photographer Photographer { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
