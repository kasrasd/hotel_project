using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_project1.Model
{
    class BaseClass
    {
    }

    public class Hotel
    {
        public int ID { get; set; }
        public int Row { get; set; }
    }
    public class Room : Hotel
    {
        public string RoomNum { get; set; }
        public DateTime RDate { get; set; }
        public int DReserve { get; set; }
        public string IsEmpty { get; set; }
        public string Status { get; set; }




    }
    public class Member : Hotel
    {
        
        public string Name { get; set; }
        public string NationalCode { get; set; }
        public string PassWord { get; set; }
        public string UserName { get; set; }
    }
    public class Clerck : Member
    {
        public int Salary { get; set; }
        public string Job { get; set; }
    }
    public class Manager : Clerck
    {
        
    }
    public class Receptionist : Clerck
    {
        
    }
    public class Guest : Member
    {
        public string RoomNum { get; set; }
        public string UserLevel{ get; set; }
    }

}
