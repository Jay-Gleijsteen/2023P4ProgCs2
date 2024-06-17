namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        public int health { get; set; }
        public int energy { get; set; }
        public string name { get; set; }


        private List<Skill> Skills;

        internal Element weakness;
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