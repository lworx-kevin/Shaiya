using System;
using System.Collections.Generic;
using System.Text;

namespace Shaiya.Domain.Stats
{
    public struct StatCollection
    {
        public Stat Strength { get; set; }
        public Stat Resistance { get; set; }
        public Stat Dexterity { get; set; }
        public Stat Luck { get; set; }
        public Stat Intelligence { get; set; }
        public Stat Wisdom { get; set; }
        public Stat Health { get; set; }
        public Stat Mana { get; set; }
        public Stat Stamina { get; set; }

        public StatCollection
        (
            Stat setStrength,
            Stat setResistance,
            Stat setDexterity,
            Stat setLuck,
            Stat setIntelligence,
            Stat setWisdom,
            Stat setHealth,
            Stat setMana,
            Stat setStamina
        )
        {
            Strength = setStrength;
            Resistance = setResistance;
            Dexterity = setDexterity;
            Luck = setLuck;
            Intelligence = setIntelligence;
            Wisdom = setWisdom;
            Health = setHealth;
            Mana = setMana;
            Stamina = setStamina;
        }
    }
}
