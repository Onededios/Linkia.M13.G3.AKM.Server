using AKM.Server.Infrastructure.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKM.Server.Library.Contracts.Services
{
    public interface IAppService
    {
        Task<List<App>> GetAllAppsAsync();
    }
}
