using System;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class TypedBase : Located
{
	[IgnoreField]
	[field: IgnoreField]
	public ParsedBase ParsedObject { get; private set; }

	public override void SetParsedObject([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] ParsedBase related)
	{
		if (related == null)
		{
			throw new ArgumentNullException("related", "The ``NotNull'' contract of parameter ``related'' has been violated. See ncc\\parsing\\AST.n:642:46:642:53: .");
		}
		bool isGenerated = related.Location.IsGenerated;
		if (ParsedObject == null || (ParsedObject.Location.IsGenerated && !isGenerated))
		{
			related.SetTypedObject(this);
			ParsedObject = related;
		}
		if (!related.Location.IsEmpty && (Location.IsEmpty || (Location.IsGenerated && !isGenerated)))
		{
			Location = related.Location;
		}
	}

	public void UpdateRelatedParsedObject()
	{
		ParsedObject?.SetTypedObject(this);
	}

	[RecordCtor]
	public TypedBase()
	{
	}

	[RecordCtor]
	public TypedBase(Location loc)
		: base(loc)
	{
	}
}
