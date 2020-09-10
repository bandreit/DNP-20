using System;

namespace S2_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitingRoom waitingRoom = new WaitingRoom();
            
            Patient patient0 = new Patient(waitingRoom);
            Patient patient1 = new Patient(waitingRoom);
            Patient patient2 = new Patient(waitingRoom);
            Patient patient3 = new Patient(waitingRoom);
            waitingRoom.RunWaitingRoom();
        }
    }
}