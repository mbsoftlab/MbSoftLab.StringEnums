using Xunit;

namespace MbSoftLab.StringEnums.Test
{
    public class EnumExtensionsUnitTest
    {
        [Fact]
        public void Can_Get_StringValues_From_EnumMember()
        {
            var currentString = DummyEnum.DummyValue1.GetStringValue();
            Assert.Equal("MyStringValue1", currentString);
        }

        [Fact]
        public void Can_Handle_Null_Values()
        {
            var currentString = DummyEnum.NullValue.GetStringValue();
            Assert.Null(currentString);
        }

        [Fact]
        public void Can_Handle_Empty_Values()
        {
            var currentString = DummyEnum.EmptyValue.GetStringValue();
            Assert.NotNull(currentString);
        }

        [Fact]
        public void Can_Handle_Missing_Attribs()
        {
            var currentString = DummyEnumWithMissingAttribs.EmptyValue.GetStringValueByCondition(true);
            Assert.NotNull(currentString);
        }

        [Theory]
        [InlineData("trueValue", true)]
        [InlineData("falseValue", false)]
        public void Can_get_values_by_condition(string expectedOutput, bool condition)
        {
            var currentString = DummyEnum.ConditionalValue.GetStringValueByCondition(condition);
            Assert.Equal(expectedOutput, currentString);
        }

        [Fact]
        public void Can_GetCustomStringValue()
        {
            Assert.Equal("MyCustomStringValue1", DummyEnum.DummyValue1.GetCustomStringValue());
        }

        [Fact]
        public void Can_GetCustomStringValue_and_StringValue()
        {
            Assert.Equal("MyCustomStringValue1", DummyEnum.DummyValue1.GetCustomStringValue());
            Assert.Equal("MyStringValue1", DummyEnum.DummyValue1.GetStringValue());
        }
    }
}
