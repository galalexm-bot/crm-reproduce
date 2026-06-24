using System;

namespace Nemerle.Internal;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class IgnoreConstructorAttribute : Attribute
{
}
