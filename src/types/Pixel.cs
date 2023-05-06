using System;
using Newtonsoft.Json;

namespace PichaLib2.Types
{
    /// <summary>
    /// Base unit of sprite generation. Defines the ID of the Pixel and its name.  
    /// Output colors are determined by generation rules.
    /// </summary>
    public class Pixel
    {
        public Guid ID { get; private set; }
        public string Name;

        public Pixel()
        {
            this.ID = Guid.NewGuid();
            this.Name = "[EMPTY]";
        }
    }
}
