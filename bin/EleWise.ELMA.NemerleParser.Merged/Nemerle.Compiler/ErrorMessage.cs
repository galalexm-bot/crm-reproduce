using System;
using System.Runtime.CompilerServices;

namespace Nemerle.Compiler;

public class ErrorMessage : Exception, ISupportRelocation
{
	public ErrorMessage(string m)
		: base(m)
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
