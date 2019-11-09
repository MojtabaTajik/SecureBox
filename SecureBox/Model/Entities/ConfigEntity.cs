using System.Collections.Generic;

namespace Model.Entities
{
    public class ConfigEntity : BaseEntity
    {
        public List<string> WhiteListExtensions { get; set; }
    }
}