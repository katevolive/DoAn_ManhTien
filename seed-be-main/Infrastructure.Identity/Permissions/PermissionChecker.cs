using Infrastructure.Identity.Contexts;
using Infrastructure.Identity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Permissions
{
    public class PermissionChecker : IPermissionChecker
    {
        private readonly IdentityContext _context;
        public PermissionChecker(IdentityContext context)
        {
            _context = context;
        }

        public virtual async Task<bool> IsGrantedAsync(Guid userId, string permission)
        {
           
            var permissions = await _context
                .Set<VwUserPermission>()
                .Where(t=>t.UserId==userId).ToListAsync();
            var isGranted = permissions.Any(rp => rp.Name == permission);
            return isGranted;
        }
       public async Task<List<VwUserPermission>> GetPermission(Guid userId)
        {
            var permissions = await _context
               .Set<VwUserPermission>()
               .Where(t => t.UserId == userId).ToListAsync();
            return permissions;
        }
             
    }
}
