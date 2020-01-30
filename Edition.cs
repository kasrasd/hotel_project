using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace hotel_project1.DB
{
    public class Edition
    {
        public void SaveClerk(string name, string salary, string job, string nc, string user, string pass)
        {
            try
            {

                Employee em = new Employee();
                em.name = name;
                em.salary = salary;
                em.job = job;
                em.national_code = nc;
                em.user_name = user;
                em.password = pass;

                staticClass.db.Employees.InsertOnSubmit(em);
                staticClass.db.SubmitChanges();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void EditClerk(int id, string name, string salary, string job, string nc,string user, string pass)
        {
            try
            {
                var em = DB.staticClass.db.Employees.Where(i => i.employee_id == id).FirstOrDefault();
                if (em != null)
                {
                    em.name = name;
                    em.salary = salary;
                    em.job = job;
                    em.national_code = nc;
                    em.user_name = user;
                    em.password = pass;
                    staticClass.db.SubmitChanges();
                }

                
                

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        public void RemoveClerk(int id, string name, string salary, string job, string nc,string user, string pass)
        {
            try
            {
                var em = DB.staticClass.db.Employees.Where(i => i.employee_id == id).FirstOrDefault();
                if (em != null)
                {
                    staticClass.db.Employees.DeleteOnSubmit(em);
                    staticClass.db.SubmitChanges();
                }




            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        public void EditGuest(int id, string name, string usern, string pass, string rn, string lev)
        {
            try
            {
                var em = DB.staticClass.db.Guests.Where(i => i.guest_id == id).FirstOrDefault();
                if (em != null)
                {
                    em.name = name;
                    em.user_name = usern;
                    em.password = pass;
                    em.room_num = rn;
                    em.isVip = lev;
                    staticClass.db.SubmitChanges();
                }




            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        public void RemoveGuest(int id, string name, string usern, string pass, string rn, string lev)
        {
            try
            {
                var em = DB.staticClass.db.Guests.Where(i => i.guest_id == id).FirstOrDefault();
                if (em != null)
                {
                    staticClass.db.Guests.DeleteOnSubmit(em);
                    staticClass.db.SubmitChanges();
                }




            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }



        public void RemoveRoom(int id, string num)
        {
            try
            {
                var em = DB.staticClass.db.Rooms.Where(i => i.room_id == id).FirstOrDefault();
                if (em != null)
                {
                    staticClass.db.Rooms.DeleteOnSubmit(em);
                    staticClass.db.SubmitChanges();
                }




            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        public void SaveGuest(string name, string Uname, string Pass)
        {
            try
            {

                Guest em = new Guest();
                em.name = name;
                em.user_name = Uname;
                em.password = Pass;
                em.isVip = "vip";


                staticClass.db.Guests.InsertOnSubmit(em);
                staticClass.db.SubmitChanges();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }




    }
}

