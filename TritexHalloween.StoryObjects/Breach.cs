namespace TritexHalloween.StoryObjects
{
    using System;

    [Serializable]
    public class Breach
    {
        public int MinutesLost { get; set; }

        public Breach()
        {

        }
        public Breach(int minutesLost)
        {
            MinutesLost = minutesLost;
        }
    }
}
