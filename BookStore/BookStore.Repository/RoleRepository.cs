using BookStore.Models.ViewModels;
using BookStore.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repository
{
    public class ModelRepository : BaseRepository
    {
        public ListResponse<Role> GetRoles(int pageIndex, int pageSize, string keyword)
        {
            keyword = keyword?.ToLower()?.Trim();
            var query = _context.Roles.Where(c => keyword == null || c.Name.ToLower().Contains(keyword)).AsQueryable();
            int totalReocrds = query.Count();
            List<Role> roles = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return new ListResponse<Role>()
            {
                Results = roles,
                TotalRecords = totalReocrds,
            };
        }
 
               
    }
}
