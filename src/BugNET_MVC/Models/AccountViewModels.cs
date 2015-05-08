using BugNET.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugNET_MVC.Models
{
    public class UserProfileViewModel
    {
        [StringLength(50)]
        public string UserName { get; set; }

        public UserProfileDetailsViewModel Details { get; set; }
        public UserProfilePreferencesViewModel Preferences { get; set; }
        public UserProfileNotificationsViewModel Notifications { get; set; }

        public UserProfileViewModel()
        {
            Details = new UserProfileDetailsViewModel();
            Preferences = new UserProfilePreferencesViewModel();
            Notifications = new UserProfileNotificationsViewModel();
        }
    }

    public class UserProfileDetailsViewModel
    {
        [StringLength(50)]
        public string UserName { get; set; }
        
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }
    }

    public class UserProfilePreferencesViewModel
    {
        [StringLength(50)]
        public string UserName { get; set; }
        
        public int? IssuesPageSize { get; set; }

        [StringLength(50)]
        public string PreferredLocale { get; set; }

        private static int[] _pageSizeOptions = new int[] { 5, 10, 15, 25, 50, 75, 100, 250 };

        public IEnumerable<System.Web.Mvc.SelectListItem> PageSizeOptions
        {
            get
            {
                foreach (var size in _pageSizeOptions)
                {
                    yield return new System.Web.Mvc.SelectListItem() { Text = size.ToString(), Value = size.ToString() };
                }
                yield break;
            }
        }

        private static IList<System.Globalization.CultureInfo> _installedCultureCodes;

        public IEnumerable<System.Web.Mvc.SelectListItem> LocaleOptions
        {
            get
            {
                foreach (var code in _installedCultureCodes)
                {
                    yield return new System.Web.Mvc.SelectListItem()
                    {
                        Text = code.DisplayName,
                        Value = code.Name
                    };
                }
                yield break;
            }
        }

        static UserProfilePreferencesViewModel()
        {
            using (var repo = BugNET.Repository.Repo.Open())
            {
                _installedCultureCodes = repo.GetLanguages()
                    .Select(e => new System.Globalization.CultureInfo(e.CultureCode))
                    .ToList();
            }
        }
    }

    public class UserProfileNotificationsViewModel
    {
        [StringLength(50)]
        public string UserName { get; set; }
        
        [StringLength(50)]
        public string SelectedIssueColumns { get; set; }

        public bool ReceiveEmailNotifications { get; set; }
    }

    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
