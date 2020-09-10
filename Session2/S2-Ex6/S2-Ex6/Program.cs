using System;

namespace S2_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();

            Watcher watcher = new Watcher(bird);
            Watcher watcher1 = new Watcher(bird);
            Watcher watcher2 = new Watcher(bird);
            Watcher watcher3 = new Watcher(bird, true);
            bird.RunExample();
        }
    }
}