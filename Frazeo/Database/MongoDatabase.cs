using Frazeo.Database.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazeo.Database
{
    internal class MongoDatabase : IDatabase
    {
        private MongoClient _client;

        public MongoDatabase(string connectionString)
        {
            _client = new MongoClient(connectionString);
        }

        public MongoClient GetClient()
        {
            return _client;
        }
    }
}
