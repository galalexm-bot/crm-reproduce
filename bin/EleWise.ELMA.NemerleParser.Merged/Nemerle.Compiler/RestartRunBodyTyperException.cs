using System;
using System.Runtime.CompilerServices;

namespace Nemerle.Compiler;

public class RestartRunBodyTyperException : Exception, ISupportRelocation
{
	public RestartRunBodyTyperException()
		: base("Making typer restart RunBodyTyper.")
	{
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
