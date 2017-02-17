using System;

namespace LibCafe
{
    public class PintDish
    {
        public EventHandler PintStarted;
        private int pintCount;

        public int PintCount { get { return pintCount; } } // c#6.0 enkel get in property: set enkel in constructor
        public int MaxPints { get; }

        public PintDish(int maxPints)
        {
            MaxPints = maxPints;
        }

        public void AddPint()
        {
            if (pintCount >= MaxPints) throw new Exception("Dish full, order cancelled");
            PintStarted?.Invoke(this, EventArgs.Empty);
            pintCount++;
        }
    }
}
