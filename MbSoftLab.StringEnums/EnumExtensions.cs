using System;
using System.Reflection;

namespace MbSoftLab.StringEnums
{
    public static class StringEnumExtensions
    {
        public static string GetStringValue(this Enum value)
        {
            StringValueAttribute[] stringValueAttribs = GetAttributesFromEnum<StringValueAttribute>(value);

            if (stringValueAttribs.Length < 1)
                return "";


            return stringValueAttribs[0].Value;
        }
        public static string GetStringValueByCondition(this Enum value, bool condition)
        {
            ConditionalStringValueAttribute[] conditionalValueAttribs = GetAttributesFromEnum<ConditionalStringValueAttribute>(value);

            if (conditionalValueAttribs.Length < 1)
                return "";


            string trueValue = conditionalValueAttribs[0].ValueTrue;
            string falseValue = conditionalValueAttribs[0].ValueFalse;

            return condition ? trueValue : falseValue;
        }
        public static TAttribute[] GetAttributesFromEnum<TAttribute>(this Enum value)
        {
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());
            TAttribute[] stringValues = fieldInfo.GetCustomAttributes(typeof(TAttribute), false) as TAttribute[];
            return stringValues;
        }
        public static string GetValueFromAttribute<TAttribute>(this Enum value) where TAttribute : StringValueAttribute
        {
            TAttribute[] stringValueAttribs = GetAttributesFromEnum<TAttribute>(value);

            if (stringValueAttribs.Length < 1)
                return default;

            return stringValueAttribs[0].Value;
        }
    }
}