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
        public string Id { get; set; }

        [BsonElement("phrase")]
        public string PhraseText { get; set; }

        public string[] Meanings { get; set; }
    }
}
