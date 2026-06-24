using Nemerle.Internal;

namespace Nemerle.Compiler;

public struct Directive
{
	public readonly int Position;

	public readonly int Length;

	[RecordCtor]
	public Directive([MappedMember("Position")] int position, [MappedMember("Length")] int length)
	{
		Position = position;
		Length = length;
	}
}
