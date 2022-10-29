using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDBTestProject.Model
{
    public class FuelQueue
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; } = String.Empty;

        [BsonElement("stationId")]
        public String StationId { get; set; } = String.Empty;

        [BsonElement("vehicleNumber")]
        public String VehicleNumber { get; set; } = String.Empty;


        [BsonElement("user_id")]
        public String UserId { get; set; } = String.Empty;


        [BsonElement("no_of_liters")]
        public String NoOfLiters { get; set; } = String.Empty;

        [BsonElement("arrival_time")]
        public String ArrivalTime { get; set; } = String.Empty;

        [BsonElement("departure_time")]
        public String DepartureTime { get; set; } = String.Empty;


        [BsonElement("status")]
        public String Status { get; set; } = String.Empty;


        // User id 
        // Pump Id 
        // NooOfVehicle -> Vehicle number plate ID
        // Status (Pending, Already)

    }
}
