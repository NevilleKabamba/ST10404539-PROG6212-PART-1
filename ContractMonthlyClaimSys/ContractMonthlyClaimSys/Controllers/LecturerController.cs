using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSys.Controllers
{
    // LecturerController handles actions for lecturers
    public class LecturerController : Controller
    {
        // Action method to display the 'Submit Claim' form
        public IActionResult SubmitClaim()
        {
            return View();
        }

        // Action method to display the 'Upload Documents' form
        public IActionResult UploadDocuments()
        {
            return View();
        }

        // Action method to display the 'Check Status' page
        public IActionResult CheckStatus()
        {
            return View();
        }
    }
}
