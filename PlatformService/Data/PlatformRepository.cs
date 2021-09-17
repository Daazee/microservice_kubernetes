using PlatformService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public class PlatformRepository : IPlatformRepository
    {
        private readonly AppDbContext _context;
        public PlatformRepository(AppDbContext context)
        {
            _context = context;
        }
        public void CreatePlatform(Platform platform)
        {
            if(platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }
            _context.Add(platform);

        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(c=>c.Id == id);
        }

        public bool SaveChanges()
        {
           return _context.SaveChanges() > 0;
        }
    }
}
