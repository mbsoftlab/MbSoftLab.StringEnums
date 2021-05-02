namespace MbSoftLab.StringEnums.Test
{
    public class CustomConditionalStringValueAttribute : ConditionalStringValueAttribute
    {
        public CustomConditionalStringValueAttribute(string valueTrue, string valueFalse)
            : base(valueTrue, valueFalse) { }
    }
}
