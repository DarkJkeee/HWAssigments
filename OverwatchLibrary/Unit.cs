using System;

namespace OverwatchLibrary
{
    public class Unit
    {
        static Random random = new Random();

        // Some fields.
        private double health;
        private double dps;
        private double headDps;
        private double singleShot;
        private string reload;

        // Some properties for fields.
        public double MaxHealth { get; set; }
        public string Heroes { get; set; }
        public double DamagePS
        {
            get => dps;
            set {
                if (value >= 0)
                {
                    dps = value;
                }
            }
        }
        public double HeadDPS
        {
            get => headDps;
            set {
                if (value >= 0)
                {
                    headDps = value;
                }
            }
        }
        public double SingleShot
        {
            get => singleShot;
            set {
                if (value >= 0)
                {
                    singleShot = value;
                }
            }
        }
        public double Health
        {
            get {
                if (health < 0)
                {
                    return 0;
                }
                else
                {
                    return health;
                }
            }
            set {
                health = value;
            }
        }
        public string Reload
        {
            get => reload;
            set {
                if ((double.TryParse(value, out _) && (double.Parse(value) >= 0)) || value == "infinity")
                {
                    reload = value;
                }
            }
        }
        public Unit(string name, double damage, double headShot, double singleShot, double health, string reload)
        {
            Heroes = name;
            DamagePS = damage;
            HeadDPS = headShot;
            SingleShot = singleShot;
            Health = health;
            Reload = reload;
            MaxHealth = health;
        }
        // Method which returns true if unit is alive.
        public bool IsAlive()
        {
            if (Health != 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Method which implements default attack.
        /// </summary>
        /// <param name="enemy">Enemy unit to attack.</param>
        public void DefaultAttack(Unit enemy)
        {
            for (int i = 0; i < 5; ++i)
            {
                if (random.Next(1, 11) > 4)
                {
                    enemy.Health -= 0.1 * DamagePS;
                }
            }
        }
        /// <summary>
        /// Method which implements aim attack.
        /// </summary>
        /// <param name="enemy">Enemy unit to attack.</param>
        public void AimAttack(Unit enemy)
        {
            for (int i = 0; i < 3; ++i)
            {
                if (random.Next(1, 11) > 7)
                {
                    if (random.Next(1, 11) > 8)
                    {
                        enemy.Health -= headDps;
                    }
                    else
                    {
                        enemy.Health -= 0.4 * DamagePS;
                    }
                }
            }
        }
    }
}
