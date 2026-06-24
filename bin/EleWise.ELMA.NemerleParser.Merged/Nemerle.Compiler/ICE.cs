using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public sealed class ICE : Exception, ISupportRelocation
{
	[RecordCtor]
	public ICE()
	{
	}

	[RecordCtor]
	public ICE(string message)
		: base(message)
	{
	}

	[RecordCtor]
	public ICE(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	[RecordCtor]
	public ICE(SerializationInfo info, StreamingContext context)
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
