using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SözlükUygulaması
{
    public class WordDal
    {
        public List<Word> GetAll()
        {
            using (WordsDatabaseContext context = new WordsDatabaseContext())
            {
                return context.Words.ToList();
            }
        }
        public void Add(Word word)
        {
            using (WordsDatabaseContext context = new WordsDatabaseContext())
            {
                context.Words.Add(word);
                context.SaveChanges();
            }
        }
        public void Update(Word word)
        {
            using (WordsDatabaseContext context = new WordsDatabaseContext())
            {
                var entity = context.Entry(word);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Word word)
        {
            using (WordsDatabaseContext context = new WordsDatabaseContext())
            {
                var entity = context.Entry(word);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<Word> GetByState(int day)
        {
            using (WordsDatabaseContext context = new WordsDatabaseContext())
            {
                return context.Set<Word>().Where(p => p.ÖgrenmeDurumu == 1).ToList();
            }
        }
    }
}
