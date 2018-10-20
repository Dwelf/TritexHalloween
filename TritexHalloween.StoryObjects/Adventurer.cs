using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TritexHalloween.StoryObjects
{
    [Serializable]
    public class Adventurer
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public decimal Temperature { get; set; }
        public decimal SuitPressure { get; set; }
        public HeartRateMode HeartRateMode { get; set; }
    }
}