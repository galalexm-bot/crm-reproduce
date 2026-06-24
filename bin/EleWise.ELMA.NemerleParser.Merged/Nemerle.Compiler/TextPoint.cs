using System;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public struct TextPoint : IComparable<TextPoint>
{
	public readonly int Line;

	public readonly int Column;

	public static bool operator ==(TextPoint x, TextPoint y)
	{
		return x.Line == y.Line && x.Column == y.Column;
	}

	public static bool operator !=(TextPoint x, TextPoint y)
	{
		return !(x == y);
	}

	public static bool operator <(TextPoint x, TextPoint y)
	{
		return x.Line < y.Line || (x.Line == y.Line && x.Column < y.Column);
	}

	public static bool operator >(TextPoint x, TextPoint y)
	{
		return y < x;
	}

	public static bool operator <=(TextPoint x, TextPoint y)
	{
		return !(y < x);
	}

	public static bool operator >=(TextPoint x, TextPoint y)
	{
		return !(x < y);
	}

	public TextPoint Offcet(TextPoint other)
	{
		return checked(Offcet(other.Line - 1, other.Column - 1));
	}

	public TextPoint Offcet(int lineOffset, int columnOffset)
	{
		return checked(new TextPoint(Line + lineOffset, (lineOffset <= 0) ? (Column + columnOffset) : (columnOffset + 1)));
	}

	public int CompareTo(TextPoint other)
	{
		return (!(this == other)) ? ((this > other) ? 1 : (-1)) : 0;
	}

	public override string ToString()
	{
		return Convert.ToString(Line) + ":" + Convert.ToString(Column);
	}

	[RecordCtor]
	public TextPoint([MappedMember("Line")] int line, [MappedMember("Column")] int column)
	{
		Line = line;
		Column = column;
	}
}
