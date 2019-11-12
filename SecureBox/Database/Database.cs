using System.IO;
using Data.Operations;
using Data.Properties;
using LiteDB;
using Shared.Utils;

namespace Data
{
    public class Database
    {
        public ConfigOperations Config { get; set; }

        public Database()
        {
            string dbPath = Path.Combine(PathUtils.ConfigPath(), Resources.DBFileName);
            var database = new LiteDatabase(dbPath);

            Config = new ConfigOperations(database);

            SeedData();
        }

        private void SeedData()
        {
            new Seed().SeedConfig(Config);
        }
    }
}