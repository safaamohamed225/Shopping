using Shopping.DataAccess.Data;
using Shopping.Entities.Models;
using Shopping.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Implementation
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context):base(context) 
        {
            _context = context;
        }

        public void Update(Category category)
        {
            var categoryIndb = _context.categories.FirstOrDefault(c => c.Id == category.Id);
            if (categoryIndb != null)
            { 
                categoryIndb.Name= category.Name;
                categoryIndb.Description= category.Description;
                categoryIndb.CreatedTime= DateTime.Now;
            }
        }
    }
}
