using Data.Operations;
using Model.Entities;
using Shared.Types;
using System.Collections.Generic;

namespace Data
{
    public class Seed
    {
        public void SeedConfig(ConfigOperations config)
        {
            config.AddConfig(new ConfigEntity
            {
                ProtectMode = ProtectMode.SandboxAll,
                WhiteListExtensions = new List<string>
                {
                    "txt",
                    "mp3",
                    "jpg",
                    "png",
                }
            });
        }
    }
}