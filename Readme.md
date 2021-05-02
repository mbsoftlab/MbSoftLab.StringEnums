# MbSoftLab.StringEnums

[![CodeFactor](https://www.codefactor.io/repository/github/mbsoftlab/mbsoftlab.stringenums/badge)](https://www.codefactor.io/repository/github/mbsoftlab/mbsoftlab.stringenums)

[![Release](https://github.com/mbsoftlab/MbSoftLab.StringEnums/actions/workflows/Release.yml/badge.svg?branch=master)](https://github.com/mbsoftlab/MbSoftLab.StringEnums/actions/workflows/Release.yml)

[![BuildFromMaster](https://github.com/mbsoftlab/MbSoftLab.StringEnums/actions/workflows/BuildFromMaster.yml/badge.svg?branch=master)](https://github.com/mbsoftlab/MbSoftLab.StringEnums/actions/workflows/BuildFromMaster.yml)

## Description 

MbSoftLab.StringEnums can help you to decorate Enums with custom Strings

---


## Quick Start

### **Simple StringValues for Enums**
```csharp
 
// The enum 
 public enum MyEnum
 { 
   [StringValue("my-css-class-1")]
   Class1,

   [StringValue("my-css-class-2")]
   Class2
 }

Console.WriteLine(MyEnum.Class1.GetStringValue()); // output: my-css-class-1
Console.WriteLine(MyEnum.Class2.GetStringValue()); // output: my-css-class-2

```

---

### **Custom StringValue Attributes**
 
```csharp
using System;

namespace MbSoftLab.StringEnums.Demo
{
    public class CssClassAttribute : StringValueAttribute
    {
        public CssClassAttribute(string value) : base(value) { }
    }

    public static class CssClassEnumExtension
    {
        // Your concrete EnumExtension
        public static string GetCssClass(this Enum value)
        {
            return value.GetValueFromAttribute<CssClassAttribute>();
        }
    }
    // The enum 
    public enum MyEnum
    {
        [StringValue("i am a string")]
        [CssClass("my-css-class-1")]
        Class1,

        [CssClass("my-css-class-2")]
        Class2
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyEnum.Class1.GetStringValue()); // output: i am a string
            Console.WriteLine(MyEnum.Class1.GetCssClass()); // output: my-css-class-1
            Console.WriteLine(MyEnum.Class2.GetCssClass()); // output: my-css-class-2

            Console.ReadKey();
        }
    }
}


```

---
