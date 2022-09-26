namespace heroi
{
    internal class IronMan : Hero
    {
        private int armorVersion;
        private int girlfriends;
        public IronMan(string name, string desc, string dateCreation, string countryOrigin, int resistenceLevel, int girlfiriends, int armorVersion) : 
                       base(name, desc, dateCreation, countryOrigin, resistenceLevel)
        {
            Girlfriends = girlfiriends;
            ArmorVersion = armorVersion;
        }

        public int ArmorVersion { get => armorVersion; 
            set
            {
                if (value >= 0 && value <= 10)
                {
                    armorVersion = value;
                }
            } 
        }
        public int Girlfriends { get => girlfriends; set => girlfriends = value; }

        public override void heal(Hero cured)
        {
            cured.ResistenceLevel += 5;
            cured.HealthCondition = HealthCondition;
        }

        public override void hurt(Hero attacked)
        {
            attacked.ResistenceLevel -= 20;
            attacked.HealthCondition = HealthCondition;
        }
    }
}
