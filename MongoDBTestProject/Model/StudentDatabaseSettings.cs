﻿namespace MongoDBTestProject.Model
{
    public class StudentDatabaseSettings : IStudentDatabaseSettings
    {
        public string StudentCollectionName { get; set; } = String.Empty;

        public string UserCollectionName { get; set; } = String.Empty;

        public string DatabaseName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string FuelStationCollectionName { get; set; } = String.Empty;
        public string FuelQueueHistoryCollectionName { get; set; } = String.Empty;
        public string FuelQueueCollectionName { get; set; } = String.Empty;
        public string FuelQueueRequestCollectionName { get; set; } = String.Empty;
    }

    }
