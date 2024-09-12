using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMvc03Demo.DAL.Models
{
    public class Department : ModelBase
    {
        public string Code { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public DateOnly CreationDate { get; set; }

    }
}
