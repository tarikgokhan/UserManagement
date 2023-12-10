using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserManagement.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credentials UserCredentials { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Todo: Kullan�c� do�rulama mant���n�z burada olacak  �rne�in: veritaban�nda kullan�c� ad� ve �ifre kontrol�
            if (UserCredentials.Username == "test" && UserCredentials.Password == "password") // �rnek kontrol
            {
                return Redirect("/Index"); // veya ba�ka bir sayfaya y�nlendirme
            }
            //Todo: Giri� ba�ar�s�z
            ModelState.AddModelError("", "Kullan�c� ad� veya �ifre hatal�.");
            return Page();
        }
    }

    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
