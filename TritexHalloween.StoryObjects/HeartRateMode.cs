using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TritexHalloween.StoryObjects
{
    [Serializable]
    public enum HeartRateMode
    {
        Error,
        BelowResting,
        Resting,
        AboveResting,
        Stressed,
        ModerateExercise,
        High,
        Extreme
    }
}
