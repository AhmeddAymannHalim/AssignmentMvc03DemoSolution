using AssignmentMvc03Demo.BLL.Interfaces;
using AssignmentMvc03Demo.BLL.Repositories;
using AssignmentMvc03Demo.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department entity)
        {
            if (ModelState.IsValid)
            {
               var count= _departmentRepository.Add(entity);

                if (count > 0)
                    RedirectToAction("Index");

            }

            return View(entity);

           
        }
    }
}
