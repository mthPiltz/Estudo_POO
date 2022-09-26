using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroi
{
    internal abstract class Hero : IPowers
    {
        private string name;
        private string desc;
        private string dateCreation;
        private string countryOrigin;
        private int resistenceLevel;
        private string healthCondition;

        protected Hero(string name, string desc, string dateCreation, string countryOrigin, int resistenceLevel)
        {
            Name = name;
            Desc = desc;
            DateCreation = dateCreation;
            CountryOrigin = countryOrigin;
            ResistenceLevel = resistenceLevel;
            HealthCondition = healthCondition;
        }

        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public string DateCreation { get => dateCreation; set => dateCreation = value; }
        public string CountryOrigin { get => countryOrigin; set => countryOrigin = value; }
        public int ResistenceLevel { get => resistenceLevel; set => resistenceLevel = value; }
        public string HealthCondition
        {
            get => healthCondition;
            set
            {
                if(this.ResistenceLevel <= 30)
                {
                    this.healthCondition = "bad";
                }
                else if (this.ResistenceLevel <= 70){
                    this.healthCondition = "good";
                }
                else
                {
                    this.healthCondition = "excellent";
                }
            }
        }


        public abstract void heal(Hero cured);

        public abstract void hurt(Hero attacked);
    }
}
