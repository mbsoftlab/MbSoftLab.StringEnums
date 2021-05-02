namespace MbSoftLab.StringEnums.Test
{
    enum DummyEnum
    {
        [StringValue("MyStringValue1")]
        [CustomStringValue("MyCustomStringValue1")]
        DummyValue1,

        [CustomStringValue("")]
        [StringValue("MyStringValue2")]
        DummyValue2,

        [StringValue(null)]
        NullValue,

        [StringValue("")]
        EmptyValue,

        [ConditionalStringValue("trueValue", "falseValue")]
        ConditionalValue
    }
}
