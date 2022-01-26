using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelephoneDirectoryApp.Models
{
    public class ContactInfo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string type { get; set; }
        public string Info { get; set; }
        public string personUUID { get; set; }
    }
}
