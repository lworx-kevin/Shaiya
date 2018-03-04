namespace Shaiya.Domain.Stats
{
    public class Stat
    {
        protected short Value { get; set; }

        public Stat(short setValue) => Value = setValue;

        public static implicit operator short(Stat stat) => stat.Value;

        public static implicit operator Stat(short value) => new Stat(value);
    }
}