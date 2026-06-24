using System;

namespace Nemerle.Internal;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class IgnoreFieldAttribute : Attribute
{
}
