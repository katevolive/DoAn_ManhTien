using Infrastructure.Identity.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Permissions
{
    public interface IPermissionProvider
    {
        IReadOnlyList<string> GetAll();
    }
}
