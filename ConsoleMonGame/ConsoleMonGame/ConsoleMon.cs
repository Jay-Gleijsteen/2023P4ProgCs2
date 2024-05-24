namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        public int health;
        public int energy;
        string name = "kip";

        private List<skills> skills;
        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        
        internal void DepleteEnergy(int energy) 
        {
            this.energy -= energy;
        }


    }

   
}