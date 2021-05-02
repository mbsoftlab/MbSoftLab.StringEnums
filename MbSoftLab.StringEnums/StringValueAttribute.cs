using System;

namespace MbSoftLab.StringEnums
{

    [AttributeUsage(AttributeTargets.Field)]
    public class StringValueAttribute : Attribute
    {
        private string _value;
        public string Value => _value;
        public StringValueAttribute(string value) => _value = value;
    }
}
