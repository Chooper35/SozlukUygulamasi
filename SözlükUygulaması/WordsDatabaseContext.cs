using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SözlükUygulaması
{
    public class WordsDatabaseContext:DbContext
    {
        public DbSet<Word> Words { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<WordsDatabaseContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
