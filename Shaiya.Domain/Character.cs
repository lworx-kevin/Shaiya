using Shaiya.Data.GameData;
using Shaiya.Domain.Stats;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shaiya.Domain
{
    public class Character
    {
        public bool IsActive { get; set; }

        public bool IsLoggedIn { get; set; }

        public Position Position { get; set; }

        public StatCollection Stats { get; set; }

        public static implicit operator CHAR(Character character) => new CHAR
        {
            Del = Convert.ToByte(!character.IsActive),
            LoginStatus = Convert.ToByte(character.IsLoggedIn),
            PosX = character.Position.X,
            PosY = character.Position.Y,
            Posz = character.Position.Z,
            Str = character.Stats.Strength,
            Rec = character.Stats.Resistance,
            Dex = character.Stats.Dexterity,
            Luc = character.Stats.Luck,
            Int = character.Stats.Intelligence,
            Wis = character.Stats.Wisdom,
            HP = character.Stats.Health,
            MP = character.Stats.Mana,
            SP = character.Stats.Stamina
        };

        public static implicit operator Character(CHAR character) => new Character
        {
            IsActive = character.Del != 0,
            IsLoggedIn = character.LoginStatus == 1,
            Position = new Position(character.PosX, character.PosY, character.Posz),
            Stats = new StatCollection(character.Str, character.Rec, character.Dex, character.Luc, character.Int, character.Wis, character.HP, character.MP, character.SP)
        };
    }
}