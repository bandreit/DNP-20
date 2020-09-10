using System;
using System.Threading;

namespace S2_Ex6
{
    public class Bird
    {
        public Action<string> ObserveBird;
        
        public void RunExample()
        {
            while (true)
            {
                Console.Out.WriteLine("Bird flaps wings");
                ObserveBird?.Invoke("Bird flaps wings");
                Thread.Sleep(2000);
                Console.Out.WriteLine("Bird sings");
                ObserveBird?.Invoke("Bird sings");
                Thread.Sleep(1500);
                Console.Out.WriteLine("Bird does acrobatics");
                ObserveBird?.Invoke("Bird does acrobatics");
                Thread.Sleep(5000);
                Console.Out.WriteLine("Bird talks like a human");
                ObserveBird?.Invoke("Bird talks like a human");
            }
        }
            
    }
}