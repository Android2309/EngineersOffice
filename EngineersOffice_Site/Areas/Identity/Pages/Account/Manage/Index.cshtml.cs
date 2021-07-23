using EngineersOffice_Site.Areas.Identity.Data;
using EngineersOffice_Site.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EngineersOffice_Site.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<EngineersOfficeUser> _userManager;
        private readonly SignInManager<EngineersOfficeUser> _signInManager;
        private readonly EngineersOfficeUsersDBContext _context;

        public IndexModel(
            UserManager<EngineersOfficeUser> userManager,
            SignInManager<EngineersOfficeUser> signInManager,
            EngineersOfficeUsersDBContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [Display(Name = "Логин")]
        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Телефон")]
            public string PhoneNumber { get; set; }

            [PersonalData]
            [Display(Name = "Имя")]
            public string FirstName { get; set; }

            [PersonalData]
            [Display(Name = "Фамилия")]
            public string LastName { get; set; }
        }

        private async Task LoadAsync(EngineersOfficeUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;


            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {

                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            if (Input.FirstName != user.FirstName)
            {
                _context.Users.Find(user.Id).FirstName = Input.FirstName;
            }

            if (Input.LastName != user.LastName)
            {
                _context.Users.Find(user.Id).LastName = Input.LastName;
            }

             _context.SaveChanges();
            await _signInManager.RefreshSignInAsync(user);

            StatusMessage = $"Изменения применены успешно";

            return RedirectToPage();
        }
    }
}
