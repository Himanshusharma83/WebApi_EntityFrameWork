

using Microsoft.EntityFrameworkCore;

namespace CRUD_ENITY
{
    [Keyless]

    public class User    {
       
        public int DepartmentId { get; set; } 
        public string DepartmentName { get; set; } = string.Empty;

    }
}
