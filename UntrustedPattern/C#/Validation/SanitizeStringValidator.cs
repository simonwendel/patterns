namespace Validation
{
    public class SanitizeStringValidator : ValidatorBase<string>
    {
        protected override bool InnerValidate(string value)
        {
            // stupid, but makes a point
            return value.ToLowerInvariant().Contains("<script>") == false;
        }
    }
}
