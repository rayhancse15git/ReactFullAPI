﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReactFullAPI.Areas.Auth.Models;
using ReactFullAPI.Data;
using ReactFullAPI.Data.Entity;

namespace ReactFullAPI.Services.Auth.Interfaces
{
    public interface IRoleService
    {
        #region Application Role
        Task<List<ApplicationRole>> GetAllApplicationRole();
        Task<List<ApplicationRole>> GetAllApplicationRole2();
        Task<int> SaveApplicationRole(ApplicationRole role);
        Task<List<ApplicationRole>> GetAllRoleByCompnayId(int companyId);
        Task<List<ApplicationRole>> GetAllActiveRoleByCompnayId(int companyId);
        Task<IdentityRoleViewModel> GetRoleChartData(int companyId);
        Task<string> GetRoleIdByUserId(string userId);
        #endregion

        #region MyRegion
        Task<int> SaveAspNetCompanyRoles(AspNetCompanyRoles role);
        Task<AspNetCompanyRoles> GetAspNetCompanyRolesByRoleIdNCompanyId(string roleId, int companyId);
        #endregion

        #region DateTime
        DateTime GetDateTimeNow();
        #endregion
    }
}
