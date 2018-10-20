using System;

namespace TritexHalloween.Networking
{
    [Serializable]
    public class Message
    {
        public int ObjectType { get; set; }
        public byte[] Data { get; set; }
        public string Text { get; set; }

        public Message(int objectType, byte[] objectData)
        {
            this.ObjectType = objectType;
            this.Data = objectData;

        }
    }
}
