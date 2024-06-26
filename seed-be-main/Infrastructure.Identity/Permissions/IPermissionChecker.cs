using Infrastructure.Identity.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Permissions
{
    public interface IPermissionChecker
    {
        Task<bool> IsGrantedAsync(Guid userId, string permission);
        Task<List<VwUserPermission>> GetPermission(Guid userId);
    }
}
