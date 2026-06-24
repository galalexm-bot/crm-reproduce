using System;

namespace Orchard.Themes;

public class ThemedAttribute : Attribute
{
	public bool Enabled { get; set; }

	public ThemedAttribute()
	{
		Enabled = true;
	}

	public ThemedAttribute(bool enabled)
	{
		Enabled = enabled;
	}
}
