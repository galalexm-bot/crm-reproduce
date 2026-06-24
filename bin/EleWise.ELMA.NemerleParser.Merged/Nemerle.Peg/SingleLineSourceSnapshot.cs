using System;
using Nemerle.Internal;

namespace Nemerle.Peg;

public class SingleLineSourceSnapshot : SourceSnapshot
{
	public SingleLineSourceSnapshot([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] string text, int fileIndex = 0, string fileName = "")
	{
		if (text == null)
		{
			throw new ArgumentNullException("text", "The ``NotNull'' contract of parameter ``text'' has been violated. See SingleLineSourceSnapshot.n:12:27:12:31: .");
		}
		base._002Ector(text, text, fileIndex, fileName, new int[2] { 0, text.Length });
	}
}
