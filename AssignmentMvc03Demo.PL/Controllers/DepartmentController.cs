using AssignmentMvc03Demo.BLL.Interfaces;
using AssignmentMvc03Demo.BLL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentMvc03Demo.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = /*new DepartmentRepository();*/ departmentRepository; // ASK CLR FOR CREATING OBJ FROM Class Implmented IDepartmentRepository 


        }
        public IActionResult Index()
        {
            var departments = _departmentRepository.GetAll();
            return View(departments);
        }
    }
}
