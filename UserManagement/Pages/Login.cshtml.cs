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
            //Todo: Kullanýcý doðrulama mantýðýnýz burada olacak  Örneðin: veritabanýnda kullanýcý adý ve þifre kontrolü
            if (UserCredentials.Username == "test" && UserCredentials.Password == "password") // Örnek kontrol
            {
                return Redirect("/Index"); // veya baþka bir sayfaya yönlendirme
            }
            //Todo: Giriþ baþarýsýz
            ModelState.AddModelError("", "Kullanýcý adý veya þifre hatalý.");
            return Page();
        }
    }

    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
