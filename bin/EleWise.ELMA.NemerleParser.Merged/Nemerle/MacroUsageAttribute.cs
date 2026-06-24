using System;

namespace Nemerle;

[AttributeUsage(AttributeTargets.Class)]
public sealed class MacroUsageAttribute : Attribute
{
	private readonly AttributeTargets valid_on;

	private bool allow_multiple;

	private bool inherited;

	private readonly MacroPhase phase;

	public bool AllowMultiple
	{
		get
		{
			return allow_multiple;
		}
		set
		{
			allow_multiple = value;
		}
	}

	public bool Inherited
	{
		get
		{
			return inherited;
		}
		set
		{
			inherited = value;
		}
	}

	public AttributeTargets ValidOn => valid_on;

	public MacroUsageAttribute(MacroPhase phase, AttributeTargets validOn)
	{
		valid_on = validOn;
		this.phase = phase;
	}
}
