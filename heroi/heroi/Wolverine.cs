namespace heroi
{
    internal class Wolverine : Hero
    {
        private double _adamantium;
        private int _minutesForHealing;
        public Wolverine(string name, string desc, string dateCreation, string countryOrigin, int resistenceLevel, double adamantium, int minutesForHealing) : 
                         base(name, desc, dateCreation, countryOrigin, resistenceLevel)
        {
            Adamantium = adamantium;
            MinutesForHealing = minutesForHealing;
        }

        public double Adamantium { get => _adamantium; set => _adamantium = value; }
        public int MinutesForHealing { get => _minutesForHealing; set => _minutesForHealing = value; }

        public override void heal(Hero cured)
        {
            cured.ResistenceLevel += 20;
            cured.HealthCondition = HealthCondition;
        }

        public override void hurt(Hero attacked)
        {
            attacked.ResistenceLevel -= 5;
            attacked.HealthCondition = HealthCondition;

            if (attacked.GetType() == typeof(IronMan))
            {
                removeGirlfriend((IronMan)attacked);
            }
        }

        private void removeGirlfriend(IronMan ironMan)
        {
            ironMan.Girlfriends -= 1;
        }
    }
}
