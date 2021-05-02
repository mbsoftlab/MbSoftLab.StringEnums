using System;

namespace MbSoftLab.StringEnums
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ConditionalStringValueAttribute : Attribute
    {
        private readonly string _valueTrue;
        private readonly string _valueFalse;
        public ConditionalStringValueAttribute(string valueTrue, string valueFalse)
        {
            _valueTrue = valueTrue;
            _valueFalse = valueFalse;
        }

        public string ValueTrue => _valueTrue;
        public string ValueFalse => _valueFalse;
    }
}
