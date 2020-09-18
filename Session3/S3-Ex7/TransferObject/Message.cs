using System;

namespace TransferObjec
{
    [Serializable]
    public class Message
    {
        public string MessageBody { get; set; }
        public long TimeStamp { get; set; }

        public Message()
        {
        }

        public Message(string message)
        {
            MessageBody = message;
            TimeStamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        }

        public override string ToString()
        {
            return MessageBody + " (" + TimeStamp + ")";
        }
    }
}    