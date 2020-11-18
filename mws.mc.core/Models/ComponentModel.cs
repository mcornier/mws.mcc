using System;

namespace mws.mc.core.Models
{
    public class ComponentModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        public string Controller { get; set; }
    }
}