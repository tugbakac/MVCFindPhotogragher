using FindPhotographer.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPhotographer.Model
{
    public class Photo : BaseEntity
    {
        public string PhotoName { get; set; }

        //mapping gelen
        public int PhotographerID { get; set; }

        //mapping baglanti
        public virtual Photographer Photographer { get; set; }
    }
}
