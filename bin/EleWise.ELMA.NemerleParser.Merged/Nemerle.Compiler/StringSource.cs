using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public sealed class StringSource : ISource, ISupportRelocation
{
	private readonly string text;

	public int FileIndex { get; }

	public string GetText()
	{
		return text;
	}

	[RecordCtor]
	public StringSource([MappedMember("FileIndex")] int fileIndex, [MappedMember("text")] string text)
	{
		_N_FileIndex_8753 = fileIndex;
		this.text = text;
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
