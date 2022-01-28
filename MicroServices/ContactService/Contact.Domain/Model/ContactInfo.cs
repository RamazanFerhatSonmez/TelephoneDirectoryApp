using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace Contact.Domain.Model
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
