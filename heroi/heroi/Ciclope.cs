namespace heroi
{
    internal class Ciclope : Hero
    {
        private string _eyewearBrand;
    
        public Ciclope(string name, string desc, string dateCreation, string countryOrigin, int resistenceLevel, string eyewearBrand) : 
                       base(name, desc, dateCreation, countryOrigin, resistenceLevel)
        {
            EyewearBrand = eyewearBrand;
        }

        public string EyewearBrand
        {
            get => _eyewearBrand; 
            set
            {
                if ((((String.Equals(value, "Oakley")) || String.Equals(value, "Rayban")) || String.Equals(value, "HB")))
                {
                    _eyewearBrand = value;
                }
            } 
        }

        public override void heal(Hero cured)
        {
            cured.ResistenceLevel += 10;
            cured.HealthCondition = HealthCondition;
        }

        public override void hurt(Hero attacked)
        {
            attacked.ResistenceLevel -= 10;
            attacked.HealthCondition = HealthCondition;

            if (attacked.GetType() == typeof(Wolverine))
            {
                attackWolverine((Wolverine)attacked);
            }
        }

        private void attackWolverine(Wolverine wolverine)
        {
            wolverine.MinutesForHealing -= 5;
        }
    }
}
