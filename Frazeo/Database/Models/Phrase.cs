using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazeo.Database.Models
{
    internal class Phrase
    {
        public ObjectId Id { get; set; }

        [BsonElement("phrase")]
        public string PhraseText { get; set; }

        [BsonElement("meanings")]
        public string[] Meanings { get; set; }
    }
}
