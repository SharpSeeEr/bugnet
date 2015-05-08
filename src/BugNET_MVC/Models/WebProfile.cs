using BugNET.Models;
using BugNET.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugNET_MVC.Models
{
    public class WebProfile
    {
        private static string _sessionKey = "UserProfile";

        public static UserProfile Current
        {
            get
            {
                var profile = System.Web.HttpContext.Current.Session[_sessionKey] as UserProfile;
                if (profile == null)
                {
                    using (var repo = Repo.Open())
                    {
                        profile = repo.GetUserProfile(System.Web.HttpContext.Current.User.Identity.Name);
                        Current = profile;
                    }
                }
                return profile;
            }
            set
            {
                System.Web.HttpContext.Current.Session[_sessionKey] = value;
            }
        }

        public static string CurrentDisplayName
        {
            get
            {
                var profile = Current;
                string display = profile.UserName;
                if (!string.IsNullOrEmpty(profile.DisplayName))
                {
                    display = profile.DisplayName;
                }
                else if (!string.IsNullOrEmpty(profile.FirstName) &&
                    !string.IsNullOrEmpty(profile.LastName))
                {
                    display = string.Format("{0} {1}", profile.FirstName, profile.LastName);
                }
                return display;
            }
        }
    }
}