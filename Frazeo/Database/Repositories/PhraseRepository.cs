using Frazeo.Database.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazeo.Database.Repositories
{
    internal class PhraseRepository : IRepository<Phrase>
    {
        private readonly IDatabase _db;
        private readonly IMongoCollection<Phrase> _collection;

        public PhraseRepository(IDatabase db)
        {
            _db = db;
            _collection = _db
                .GetClient()
                .GetDatabase("frazeo")
                .GetCollection<Phrase>("phrases");
        }

        public async Task<IEnumerable<Phrase>> GetAsync(string text)
        {
            return await GetByPhraseText(text);
        }

        private async Task<IEnumerable<Phrase>> GetByPhraseText(string text)
        {
            var cursor = await _collection.FindAsync(p => p.PhraseText == text);

            return cursor.ToEnumerable();
        }
    }
}
