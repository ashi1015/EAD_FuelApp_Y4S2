using MongoDBTestProject.Model;

namespace MongoDBTestProject.Service
{
    /* SERVICE CLASS - Fuel Stations */
    public interface IFuelStationService
    {
        /* Fuel Station Related Service methods */

        // List of fuel stations for the queue users references.
        List<FuelStation> GetFuelStations();
        // Single fuel station details for the Station Owner.
        FuelStation GetFuelStation(String id);
        FuelStation CreateToFuelStation(FuelStation station);
        // Update fuel station queue starting time and ending time.
        void UpdateFuelStation(String stationId, FuelStation station);
        void RemoveFuelStation(String id);
        void UpdateStartTimeAndEndTime(String id, FuelStation station);

        /* Fuel Queue Request Related Service methods */
        //void UpdateApprovalStatusFuelRequest(String approaval, String id);
      


        // Insert Queue
        FuelQueue CreateQueue(FuelQueue queue);

        // Get all Queue
        List<FuelQueue> GetAllQueue();

        // Specific get Queue
        FuelQueue GetQueueone(String id);


        // Remove from Queue
        void UpdateQueueStatus(String id);


        List<FuelQueue> GetAllQueueHistory();

        // Queue History Add

        // Status 



    }
}
