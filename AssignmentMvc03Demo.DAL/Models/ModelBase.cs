using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMvc03Demo.DAL.Models
{
    public class ModelBase
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public int LastModifiedOn { get; set; }

        public DateTime LastModifiedBy { get; set; }
    }
}
