using System;
using Nemerle.Internal;

namespace Nemerle.Peg;

internal class Usage : Attribute
{
	public string Text { get; private set; }

	[RecordCtor]
	public Usage([MappedMember("Text")] string text)
	{
		Text = text;
	}
}
