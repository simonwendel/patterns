namespace UntrustedBoundary
{
    using Validation;

    public class SomeServiceOrWhatever
    {
        public void Action(Untrusted<string> input)
        {
            // only way of getting the value is through a ValidatorBase implementation.
            var value = new SanitizeStringValidator().Validate(input);
            DoStuff(value);
        }

        private void DoStuff(string input)
        {
            // ...
        }
    }
}
