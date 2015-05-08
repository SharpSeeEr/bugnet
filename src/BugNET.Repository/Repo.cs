using BugNET.DataAccess;
using BugNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugNET.Repository
{
    public class Repo : IDisposable
    {
        private BugNETDbContext _context;
        
        public static Repo Open()
        {
            return new Repo();
        }
        
        private Repo()
        {
            _context = new BugNETDbContext();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
        }

        public void Attach<T>(T entity) where T : class
        {
            _context.Set<T>().Attach(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public IList<HostSetting> GetHostSettings()
        {
            return _context.HostSettings.ToList();
        }
        
        public UserProfile GetUserProfile(string userName)
        {
            return _context.UserProfiles.SingleOrDefault(e => e.UserName == userName);
        }

        public IList<Language> GetLanguages()
        {
            return _context.Languages.ToList();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
