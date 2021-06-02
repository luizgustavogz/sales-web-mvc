using SalesWebMvc.Models;
using System.Linq;
using System.Collections.Generic;

namespace SalesWebMvc.Services {
    public class DepartmentService {

        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context) {
            _context = context;
        }

        public List<Department> findAll() {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
