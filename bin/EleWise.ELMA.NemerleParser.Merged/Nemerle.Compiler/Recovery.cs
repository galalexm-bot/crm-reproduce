using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public sealed class Recovery : Exception, ISupportRelocation
{
	[RecordCtor]
	public Recovery()
	{
	}

	[RecordCtor]
	public Recovery(string message)
		: base(message)
	{
	}

	[RecordCtor]
	public Recovery(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	[RecordCtor]
	public Recovery(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	[CompilerGenerated]
	internal void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
