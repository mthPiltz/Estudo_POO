namespace heroi
{
    internal class Coringa : Hero
    {
        private string _countryCurrent;
        public Coringa(string name, string desc, string dateCreation, string countryOrigin, int resistenceLevel, string countryCurrent) : 
            base(name, desc, dateCreation, countryOrigin, resistenceLevel)
        {
            ContryCurrent = countryCurrent;
        }

        public string ContryCurrent { get => _countryCurrent; set => _countryCurrent = value; }

        public override void heal(Hero cured)
        {
            cured.ResistenceLevel += 1;
            cured.HealthCondition = HealthCondition;
        }

        public override void hurt(Hero attacked)
        {
            attacked.ResistenceLevel = 1;
            attacked.HealthCondition = HealthCondition;
        }
    }
}
