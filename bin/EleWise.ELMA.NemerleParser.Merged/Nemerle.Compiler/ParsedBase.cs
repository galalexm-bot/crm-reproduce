using Nemerle.Internal;

namespace Nemerle.Compiler;

public class ParsedBase : Located
{
	[IgnoreField]
	[field: IgnoreField]
	public TypedBase TypedObject { get; private set; }

	internal void ResetTypedObject()
	{
		TypedObject = null;
	}

	internal void SetTypedObject(TypedBase related)
	{
		if (TypedObject != related)
		{
			TypedObject = related;
		}
	}

	[RecordCtor]
	public ParsedBase()
	{
	}

	[RecordCtor]
	public ParsedBase(Location loc)
		: base(loc)
	{
	}
}
