using AssignmentMvc03Demo.BLL.Interfaces;
using AssignmentMvc03Demo.DAL.Data.Context;
using AssignmentMvc03Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMvc03Demo.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public DepartmentRepository(ApplicationDbContext dbContext)//ASK CLR FOR CREATING OBJ FROM AppDBCONTEXT CLASS
        {
            _dbContext = dbContext;
        }

        public Department Get(int id)
        {
          // var department = _dbContext.Departments.Local.Where(D => D.Id == id).FirstOrDefault();
          //  
          //  if (department is null)
          //      department = _dbContext.Departments.Where(D => D.Id == id).FirstOrDefault();
            

            return _dbContext.Find<Department>(id);
        }

        public IEnumerable<Department> GetAll()
        {

            return _dbContext.Departments.ToList();

        }
        
    
        public int Add(Department entity)
        {
            if (entity is null)
            {
                return 0;
            }

            _dbContext.Add(entity);
            return _dbContext.SaveChanges();
        }
        public int Update(Department entity)
        {
            if (entity is null) return 0;

            _dbContext.Update(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(Department entity)
        {
            if (entity is null) return 0;

            _dbContext.Remove(entity);
            return _dbContext.SaveChanges();
        }

       
       

      
    }
}
