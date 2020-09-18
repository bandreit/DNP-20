using System.Collections.Generic;

namespace Ex7_Server
{
    public class ConnectionPool
    {
        private List<CommunicationThreadHandler> connectionPool = new List<CommunicationThreadHandler>();

        public void BroadcastMessage(string message)
        {
            connectionPool.ForEach(handler => handler.SendMessage(message));
        }
        
        public void AddHandler(CommunicationThreadHandler communicationThreadHandler)
        {
            connectionPool.Add(communicationThreadHandler);
        }
        
        public void RemoveHandler(CommunicationThreadHandler communicationThreadHandler)
        {
            connectionPool.Remove(communicationThreadHandler);
        }
    }
}