using System;

namespace S2_Ex6
{
    public class Watcher
    {
        private Bird _bird;
        private bool IsDeaf;

        public Watcher(Bird bird)
        {
            _bird = bird;
            bird.ObserveBird += ReactToBird;
            IsDeaf = false;
        }

        public Watcher(Bird bird, bool isDeaf)
        {
            _bird = bird;
            bird.ObserveBird += ReactToBird;
            IsDeaf = true;
        }

        private void ReactToBird(string action)
        {
            if (IsDeaf)
            {
                Console.Out.Write("Deaf watcher: ");
                if (action == "Bird sings" || action == "Bird talks like a human")
                {
                    Console.Out.WriteLine("...");
                }
                else
                {
                    GetRandomReaction();
                }
            }
            else
            {
                Console.Out.Write("Non-deaf watcher: ");
                GetRandomReaction();
            }
        }

        private void GetRandomReaction()
        {
            string[] reactions = {"Ooh!", "How nice!", "Would you look at that!", "Impressive!"};
            Random radRandom = new Random();
            Console.Out.WriteLine(reactions[radRandom.Next(reactions.Length)]);
        }
    }
}