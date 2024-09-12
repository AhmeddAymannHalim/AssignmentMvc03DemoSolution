using AssignmentMvc03Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMvc03Demo.BLL.Interfaces
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAll();

        public Department Get(int id);

        public int Add(Department entity);

        public int Update(Department entity);

        public int Delete(Department entity);


    }
}
