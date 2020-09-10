using System;

namespace S2_Ex4
{
    public class Patient
    {
        private int numberInQueue;
        private WaitingRoom _waitingRoom;
        private bool _entered;

        public Patient(WaitingRoom waitingRoom)
        {
            _waitingRoom = waitingRoom;
            numberInQueue = waitingRoom.DrawNumber();
            _waitingRoom.NumberChange += ReactToNumber;
            _entered = false;
            Console.Out.WriteLine($"Patient {numberInQueue} enters waiting room");
        }

        public void ReactToNumber(int ticketNumber)
        {
            if (_entered)
            {
                return;
            }
            
            Console.Out.WriteLine($"Patient {numberInQueue} looks up");

            if (numberInQueue == ticketNumber)
            {
                Console.Out.WriteLine($"Patient {numberInQueue} goes to the doctor's room");
                _entered = true;
            }
            else
            {
                Console.Out.WriteLine($"Patient {numberInQueue} goes back to looking at phone");
            }
        }
    }
}