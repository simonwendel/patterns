namespace Validation
{
    public abstract class ValidatorBase<T>
    {
        public T Validate(Untrusted<T> untrusted)
        {
            if(!InnerValidate(untrusted.Value))
            {
                throw new ValidationException();
            }

            return untrusted.Value;
        }

        protected abstract bool InnerValidate(T value);
    }
}
