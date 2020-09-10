using System;
using System.Threading;

namespace S2_Ex4
{
    public class WaitingRoom
    {
        public Action<int> NumberChange;
        private int currentNumber;
        private int ticketCount;

        public WaitingRoom()
        {
            currentNumber = 0;
            ticketCount = 0;
        }

        public void RunWaitingRoom()
        {
            while (currentNumber < ticketCount)
            {
                Thread.Sleep(1000);
                Console.Out.WriteLine("Diing!");
                NumberChange?.Invoke(currentNumber);
                currentNumber++;
                Console.Out.WriteLine($"Patient number {currentNumber} can now enter");
            }
        }

        public int DrawNumber()
        {
            return ticketCount++;
        }
    }
}