using LiteDB;

namespace Data
{
    public class DbContext
    {
        private readonly LiteDatabase _database;

        public DbContext()
        {
            _database = new LiteDatabase("Config.dll");
        }
    }
}