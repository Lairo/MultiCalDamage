using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCalDamage
{
    internal class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = .35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;

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

        public int Damage { get; private set; }

        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
            
        }

        public ArrowDamage(int StartingRoll)
        {
            roll = StartingRoll;
            CalculateDamage();

        }
    }
}
