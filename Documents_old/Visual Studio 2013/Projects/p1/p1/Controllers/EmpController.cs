using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using empdb;
namespace p1.Controllers
{
    public class EmpController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using(empdb.EmployeeDBEntities entities = new empdb.EmployeeDBEntities())
            {
            return entities.Employees.ToList();
            }
        }
        public HttpResponseMessage Get(int id)
        {

            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                if(entities!=null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entities);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,"not htere");
                }
            }
               //entities.Employees.FirstOrDefault(e => e.ID == id);
            
        }
        public void Post([FromBody]Employee employee)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                      entities.Employees.Add(employee);
                      entities.SaveChanges();
            }
        }
        public HttpResponseMessage Delete(int id)
        {
            using(EmployeeDBEntities entity=new EmployeeDBEntities())
            {
                if (entity.Employees.FirstOrDefault(e => e.ID == id) != null)
                {
                    entity.Employees.Remove(entity.Employees.FirstOrDefault(e => e.ID == id));
                    entity.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Implemented");
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "NotFound");
                }
            }
        }
        public HttpResponseMessage Put(int id,[FromBody]Employee employee)
        {

            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                var entity = entities.Employees.FirstOrDefault(e => e.ID == id);
                if (entity != null)
                {
                    entity.FirstName=employee.FirstName;
                    entity.Gender = employee.Gender;
                    entity.LastName = employee.LastName;
                    entity.Salary = employee.Salary;
                    entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, entities);
                }
                else
                { 
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "not htere");
                }
                  
            }
            //entities.Employees.FirstOrDefault(e => e.ID == id);

        }
    }
}
