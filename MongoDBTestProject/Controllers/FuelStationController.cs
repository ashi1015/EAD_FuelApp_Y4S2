using Microsoft.AspNetCore.Mvc;
using MongoDBTestProject.Model;
using MongoDBTestProject.Service;

namespace MongoDBTestProject.Controllers
{
    public class FuelStationController : Controller
    {
        private readonly IFuelStationService fuelStationService;
        public FuelStationController(IFuelStationService fuelStationService)
        {
            this.fuelStationService = fuelStationService;
        }

        // Fuel Station
        [HttpPost("addToFuelStation")]
        public ActionResult<FuelStation> AddFuelStation([FromBody] FuelStation request)
        {
            DateTime now = DateTime.Now;
            if (request.Location == null || request.Capacity == null || request.Availability == null)
            {
                return BadRequest("Missing Fuel Station Details!");
            }
            FuelStation station = new FuelStation();
            station.Location = request.Location;
            station.Capacity = request.Capacity;
            station.Availability = request.Availability;
            station.StartingTime = now.ToLongDateString();
            station.EndingTime = "0.0.00";
            fuelStationService.CreateToFuelStation(station);
            return CreatedAtAction(nameof(GetFuelStation), new { id = station.Id }, station);
        }


        // GET api/<FuelStationController>/<id>
        [HttpGet("getfuelstationById/{id}")]
        public ActionResult<FuelStation> GetFuelStation(String id)
        {
            var station = fuelStationService.GetFuelStation(id);
            if (station == null)
            {
                return NotFound($"Fuel Station with Id = {id} not found");
            }

            return station;
        }
         





        //Queue
        //Create Queue
        [HttpPost("addFuelStationQueue")]
        public ActionResult<FuelQueue> AddQueue([FromBody] FuelQueue request)
        {
            if (request.VehicleNumber == null || request.UserId == null || request.StationId == null || request.NoOfLiters == null)
            {
                return BadRequest("Missing Fuel Station Details!");
            }
            DateTime now = DateTime.Now;

            FuelQueue queue = new FuelQueue();
            queue.VehicleNumber = request.VehicleNumber;
            queue.StationId = request.StationId;
            queue.UserId = request.UserId;
            queue.NoOfLiters = request.NoOfLiters;
            queue.ArrivalTime = now.ToLongTimeString();
            queue.DepartureTime = "0.00.00";
            queue.Status = "IN";
            fuelStationService.CreateQueue(queue);
            return CreatedAtAction(nameof(GetFuelStation), new { id = queue.Id }, queue);
        }

        //Get All Fuel Station
        [HttpGet("getAllFuelStations")]
        public ActionResult<List<FuelStation>> GetAllFuelStation()
        {
            return fuelStationService.GetFuelStations();
        }

        //Get All Queue 
        [HttpGet("getFuelQueue")]
        public ActionResult<List<FuelQueue>> GetAllFuelQueue()
        {
            return fuelStationService.GetAllQueue();
        }

        //Get One Queue
        [HttpGet("getqueue/{id}")]
        public ActionResult<FuelQueue> GetQueue(String id)
        {
            var station = fuelStationService.GetQueueone(id);
            if (station == null)
            {
                return NotFound($"Fuel Queue with Id = {id} not found");
            }

            return station;
        }

        [HttpPut("updateQueueState/{id}")]
        public ActionResult updateQueueStatus(String id, [FromBody] FuelQueue station)
        {
            String status = "OUT";

            fuelStationService.UpdateQueueStatus( id);
            return Content(id+" Status Updated!");
        }

        //History
        //Get All history
        [HttpGet("getFuelQueueHistory")]
        public ActionResult<List<FuelQueue>> GetAllFuelQueueHistory()
        {
            return fuelStationService.GetAllQueueHistory();
        }

    }
}
