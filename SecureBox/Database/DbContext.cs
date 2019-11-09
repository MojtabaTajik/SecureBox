using System.IO;
using Data.Operations;
using Data.Properties;
using LiteDB;
using Shared.Utils;

namespace Data
{
    public class DbContext
    {
        public ConfigOperations Config { get; set; }

        public DbContext()
        {
            string dbPath = Path.Combine(PathUtils.ConfigPath(), Resources.DBFileName);
            var database = new LiteDatabase(dbPath);

            Config = new ConfigOperations(database);
        }
    }
}