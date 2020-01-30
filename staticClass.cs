using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_project1.DB
{
    public class staticClass
    {
        public static HotelDBDataContext db = new HotelDBDataContext("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=hotel;Data Source=DESKTOP-1OIQVR6");
    }
}
