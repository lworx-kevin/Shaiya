using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shaiya.Domain
{
    public class CharacterCollection
    {
        protected HashSet<Character> Characters { get; set; }

        public IEnumerable<Character> GetAll() => Characters;

        public IEnumerable<Character> GetActive() => Characters.Where(c => c.IsActive);

        public IEnumerable<Character> GetDeleted() => Characters.Where(c => !c.IsActive);

        public Character GetCurrent() => Characters.SingleOrDefault(c => c.IsLoggedIn);
    }
}
