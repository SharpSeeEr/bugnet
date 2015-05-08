using BugNET.Common;
using BugNET.Models;
using BugNET.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BugNET_MVC.Models
{
    public class Settings
    {
        private static Dictionary<HostSettingNames, HostSetting> _settings;

        static Settings()
        {
            using (var repo = Repo.Open())
            {
                _settings = repo.GetHostSettings().ToDictionary(e => e.SettingName.ToEnum<HostSettingNames>());
            }
        }

        public static void Set(HostSettingNames key, string value)
        {
            using (var repo = Repo.Open())
            {
                if (!_settings.ContainsKey(key))
                {
                    _settings.Add(key, new HostSetting() 
                    { 
                        SettingName = key.ToString(), 
                        SettingValue = value 
                    });
                    repo.Add(_settings[key]);
                }
                else
                {
                    repo.Update(_settings[key]);
                }
                repo.SaveChanges();
            }
        }

        public static string Get(HostSettingNames key)
        {
            return Get(key, string.Empty);
        }

        /// <summary>
        /// Gets the host setting.  If the host setting isn't found returns <paramref name="defaultValue"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static T Get<T>(HostSettingNames key, T defaultValue) where T : IConvertible
        {
            var val = defaultValue;
            if (_settings.ContainsKey(key))
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                val = (T)converter.ConvertFromString(_settings[key].SettingValue);
            }

            return val;
        }
    }
}