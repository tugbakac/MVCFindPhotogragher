using FindPhotographer.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPhotographer.Model
{
    public class Photographer : BaseEntity
    {
        public Photographer()
        {
            Explanation = "New Member";//açıklama yeni üye
            Photo = "default.jpg";
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CompanyName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Photo { get; set; }
        public string Explanation { get; set; }

        //mapping gidenler
        public List<AppointmentRequest> AppointmentRequests { get; set; }
        public List<Photo> Photos { get; set; }
        public List<ServiceDetail> ServiceDetails { get; set; }
    }
}
