

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CRUD_ENITY
{
 

    public class User    {

        [Key]
        public int DepartmentId { get; set; } 
        public string DepartmentName { get; set; } = string.Empty;

    }
}
