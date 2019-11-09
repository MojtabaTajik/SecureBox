using System.Linq;
using LiteDB;
using Model.Entities;

namespace Data.Operations
{
    public class ConfigOperations
    {
        private readonly LiteCollection<ConfigEntity> _config;

        public ConfigOperations(LiteDatabase database)
        {
            _config = database.GetCollection<ConfigEntity>("Config");
        }

        public bool AddConfig(ConfigEntity config)
        {
            var configRecord = _config.FindAll().FirstOrDefault() ?? new ConfigEntity();

            configRecord.ProtectMode = config.ProtectMode;
            configRecord.WhiteListExtensions = config.WhiteListExtensions;

            return _config.Upsert(configRecord);
        }

        public ConfigEntity ReadConfig()
        {
            return _config.FindAll().ToList().FirstOrDefault();
        }
    }
}