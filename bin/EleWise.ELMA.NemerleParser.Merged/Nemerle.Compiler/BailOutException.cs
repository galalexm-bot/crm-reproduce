using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public sealed class BailOutException : Exception, ISupportRelocation
{
	[RecordCtor]
	public BailOutException()
	{
	}

	[RecordCtor]
	public BailOutException(string message)
		: base(message)
	{
	}

	[RecordCtor]
	public BailOutException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	[RecordCtor]
	public BailOutException(SerializationInfo info, StreamingContext context)
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
