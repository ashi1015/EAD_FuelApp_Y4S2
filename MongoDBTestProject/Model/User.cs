﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace MongoDBTestProject.Model
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;
        [BsonElement("username")]
        public String Username { get; set; } = String.Empty;
        [BsonElement("email")]
        public String Email { get; set; } = String.Empty;
        [BsonElement("password")]
        public String Password { get; set; } = String.Empty;
        /*public byte[]? Password { get; set; }
        [BsonElement("passwordKay")]
        public byte[]? PasswordKay { get; set; }*/
        [BsonElement("role")]
        public String Role { get; set; } = String.Empty;
        [BsonElement("vehicleType")]
        public String VehicleType { get; set; } = String.Empty;
    }
}
