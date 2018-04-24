using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SiteDbContext dbContext;
        public SiteDbContext Init()
        {
            return dbContext ?? (dbContext = new SiteDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
