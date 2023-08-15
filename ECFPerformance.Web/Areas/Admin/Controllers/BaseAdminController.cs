using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static ECFPerformance.Constants.GeneralApplicationConstants;
using System.Data;

namespace ECFPerformance.Web.Areas.Admin.Controllers
{
    [Area(AdminAreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class BaseAdminController : Controller
    {
    }
}
