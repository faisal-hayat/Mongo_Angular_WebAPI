using Microsoft.Extensions.Options;
using MongDbWebAPI.Configration;
using MongDbWebAPI.Models;
using MongoDB.Driver;

namespace MongDbWebAPI.Services
{
    public class DriverService
    {
        private readonly IMongoCollection<Driver> _driverCollection;

        public DriverService(IOptions<DatabaseSettings> options)
        {
            // start mongoDb client
            var mongoClient = new MongoClient(options.Value.ConnectionString);
            // connect to mongo database
            var mongoDb = mongoClient.GetDatabase(options.Value.DatabaseName);
            _driverCollection = mongoDb.GetCollection<Driver>(options.Value.CollectionName);
        }

        // retrieve all records
        public async Task<List<Driver>> GetAsync()
        {
            return await _driverCollection.Find(_ => true).ToListAsync();
        }
    }
}
