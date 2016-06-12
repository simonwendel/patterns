namespace Validation
{
    public class Untrusted<T>
    {
        private readonly T untrusted;

        public Untrusted(T untrusted)
        {
            this.untrusted = untrusted;
        }

        // this is internal, so is not be exposed to the world.
        internal T Value
        {
            get { return untrusted; }
        }
    }
}
