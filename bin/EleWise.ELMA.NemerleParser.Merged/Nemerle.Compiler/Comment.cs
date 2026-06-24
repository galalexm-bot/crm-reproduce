using Nemerle.Internal;

namespace Nemerle.Compiler;

public struct Comment
{
	public readonly int Position;

	public readonly int Length;

	public readonly bool IsMultiline;

	public readonly bool IsDocument;

	[RecordCtor]
	public Comment([MappedMember("Position")] int position, [MappedMember("Length")] int length, [MappedMember("IsMultiline")] bool isMultiline, [MappedMember("IsDocument")] bool isDocument)
	{
		Position = position;
		Length = length;
		IsMultiline = isMultiline;
		IsDocument = isDocument;
	}
}
