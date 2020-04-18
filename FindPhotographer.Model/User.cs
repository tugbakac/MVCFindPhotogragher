using FindPhotographer.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPhotographer.Model
{
    public class User : BaseEntity
    {
        public User()
        {
            IsitApproved = false;
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateofBirth { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsitApproved { get; set; }

        //mapping giden ORM(Object Relational Mapping) İlişksel veri tabanı ile OOP arasında veri dönüşümünü sağlar.
        public List<AppointmentRequest> AppointmentRequest { get; set; }

    }
}
