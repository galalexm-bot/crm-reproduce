using System;

namespace Nemerle;

[AttributeUsage(AttributeTargets.Class)]
public sealed class TailRecursionTransparentAttribute : Attribute
{
	private bool is_transparent;

	public bool IsTransparent => is_transparent;

	public TailRecursionTransparentAttribute(bool tr)
	{
		is_transparent = tr;
	}
}
