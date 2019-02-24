using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptGeneration.Attributes
{
    [AttributeUsage(AttributeTargets.Property |
                    AttributeTargets.Field, AllowMultiple = false)]
    public class CanUpdateAttribute:Attribute
    {
    }
}
