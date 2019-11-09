using Shared.Types;
using System.Collections.Generic;

namespace Model.Entities
{
    public class ConfigEntity : BaseEntity
    {
        public ProtectMode ProtectMode { get; set; }
        public List<string> WhiteListExtensions { get; set; }
    }
}