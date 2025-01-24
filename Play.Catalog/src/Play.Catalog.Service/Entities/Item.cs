using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Play.Common;

namespace Play.Catalog.Service.Entities
{
    public class Item : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)] // Store GUID as a string
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [BsonRepresentation(BsonType.String)] // Store decimal as a string
        public decimal Price { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}