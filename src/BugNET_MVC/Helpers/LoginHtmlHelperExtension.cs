using BugNET.Common;
using BugNET_MVC.Models;
using HtmlTags;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BugNET_MVC.Helpers
{
    public static class LoginHtmlHelperExtension
    {
        public static ApplicationUser UserInfo(this HtmlHelper htmlHelper, string userId)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var user = manager.FindById(userId);
            return user;
        }
        /// <summary>
        /// Gets the gravatar image URL.
        /// </summary>
        /// <param name="email">The email id.</param>
        /// <param name="imgSize">Size of the img.</param>
        /// <returns></returns>
        public static HtmlTag GetGravatarImage(this HtmlHelper htmlHelper, string email)
        {
            var img = new HtmlTag("img")
                .Attr("src", UrlHelper.GenerateContentUrl("~/Images/noprofile.png", htmlHelper.ViewContext.HttpContext))
                .Attr("width", "32px")
                .Attr("height", "32px")
                .AddClass("gravatar");

            if (Settings.Get(HostSettingNames.EnableGravatar, true))
            {
                // Convert emailID to lower-case
                email = email.Trim().ToLower();

                var emailBytes = Encoding.ASCII.GetBytes(email);
                var hashBytes = new MD5CryptoServiceProvider().ComputeHash(emailBytes);

                Debug.Assert(hashBytes.Length == 16);

                var hash = new StringBuilder();
                foreach (var b in hashBytes)
                {
                    hash.Append(b.ToString("x2"));
                }

                // build Gravatar Image URL
                img.Attr("src", string.Format("https://www.gravatar.com/avatar/{0}?s={1}&d=identicon&r=g", hash, 32));
            }
                
            return img;
        }
    }
}