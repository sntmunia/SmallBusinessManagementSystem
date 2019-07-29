using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2MVC.DatabaseContext.DatabaseContext;
using Project2MVC.Models.Model;

namespace Project2MVC.Repository.Repositorys
{
    public class CustomerRepository
    {
        Project2DbContext db = new Project2DbContext();
        public bool Add(Customer customer)
        {
            int isExecuted = 0;

            Customer isExist = GetByCode(customer);
            if (isExist != null)
                return false;
            db.Customers.Add(customer);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }

            return false;
        }
        public bool Delete(Customer customer)
        {
            int isExecuted = 0;
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.Code == customer.Code);

            db.Customers.Remove(aCustomer);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }


            return false;
        }
        public bool Update(Customer customer)
        {
            int isExecuted = 0;
            //Method 1
            //Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            //if (aStudent != null)
            //{
            //    aStudent.Name = student.Name;
            //    isExecuted = db.SaveChanges();
            //}

            //Method 2
            db.Entry(customer).State = EntityState.Modified;
            isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }
        //public List<Customer> GetAll()
        //{
        //    return db.Customers.ToList();
        //}
        public Customer GetByCode(Customer customer)
        {
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.Code == customer.Code);
            return aCustomer;
        }
    }
}
