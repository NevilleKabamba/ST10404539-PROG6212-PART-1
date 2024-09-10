using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSys.Controllers
{
    // ApprovalController manages actions for approving claims
    public class ApprovalController : Controller
    {
        // Action method to display the 'Approve Claims' page
        public IActionResult ApproveClaims()
        {
            return View();
        }
    }
}