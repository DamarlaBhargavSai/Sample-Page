using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DWebApp.Pages
{
    public class Sign_UpModel : PageModel
    {
        public bool hasData = false;
        public string firstName = "";
        public string lastName = "";
        public string Email = "";
        public string Password = "";
        public string ConfirmPassword = "";
        public string PhoneNumber = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData = true;
            firstName = Request.Form["firstname"];
            lastName = Request.Form["lastname"];
            Email = Request.Form["subject"];
            Password = Request.Form["Password"];
            ConfirmPassword = Request.Form["Password"];
            PhoneNumber = Request.Form["Data Type"];
        }
    }
}
