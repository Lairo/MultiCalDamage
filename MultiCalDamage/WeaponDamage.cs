using System;

namespace MultiCalDamage
{
    class WeaponDamage
    {
        private int roll;

        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }

        }

        private bool flaming;

        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }

        }

        private bool magic;

        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value; CalculateDamage();
            }
        }

        public int Damage { get; protected set; }

        protected virtual void CalculateDamage() 
        {
            Console.WriteLine("This statement will never get called.");
        }

        public WeaponDamage(int StartingRoll) 
        {
            roll = StartingRoll;
            CalculateDamage();

        }

    }
}
