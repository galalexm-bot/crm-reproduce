using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Nemerle.Internal;

namespace Nemerle.Compiler;

[Serializable]
public sealed class CompilationAbortedException : Exception, ISupportRelocation
{
	[RecordCtor]
	public CompilationAbortedException()
	{
	}

	[RecordCtor]
	public CompilationAbortedException(string message)
		: base(message)
	{
	}

	[RecordCtor]
	public CompilationAbortedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	[RecordCtor]
	public CompilationAbortedException(SerializationInfo info, StreamingContext context)
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
