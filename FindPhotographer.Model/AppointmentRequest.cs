using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPhotographer.Model
{
    public class AppointmentRequest
    {
        public AppointmentRequest()
        {
            ApprovalStatus = false;
        }

        public DateTime AppointmentDate { get; set; }
        public bool ApprovalStatus { get; set; }

        //Mapping gelenler
        public int UserID { get; set; }
        public int PhotographerID { get; set; }
        public int ServiceID { get; set; }

        //mapping bağlantılar
        public virtual User User { get; set; }
        public virtual Photographer Photographer { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
