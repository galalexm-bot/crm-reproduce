using System;

namespace Orchard.Security;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class AlwaysAccessibleAttribute : Attribute
{
}
