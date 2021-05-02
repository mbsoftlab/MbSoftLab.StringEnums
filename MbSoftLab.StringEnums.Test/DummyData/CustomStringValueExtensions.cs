using System;

namespace MbSoftLab.StringEnums.Test
{
    public static class CustomStringValueExtensions
    {
        public static string GetCustomStringValue(this Enum value)
        {
            return value.GetValueFromAttribute<CustomStringValueAttribute>();
        }
    }

    
 
}
