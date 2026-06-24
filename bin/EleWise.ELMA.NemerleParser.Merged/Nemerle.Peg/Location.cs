using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Internal;

namespace Nemerle.Peg;

public struct Location
{
	private readonly SourceSnapshot _source;

	private readonly int _startPos;

	private readonly int _endPos;

	public bool IsEmpty => _startPos >= _endPos;

	public Nemerle.Builtins.Tuple<int, int> StartLineColumn => _source.PositionToLineColumn(_startPos);

	public Nemerle.Builtins.Tuple<int, int> EndLineColumn => _source.PositionToLineColumn(_endPos);

	public SourceSnapshot Source
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _source;
		}
	}

	public int StartPos
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _startPos;
		}
	}

	public int EndPos
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _endPos;
		}
	}

	public string GetText()
	{
		return _source.OriginalText.Substring(_startPos, checked(_endPos - _startPos));
	}

	public override string ToString()
	{
		return "Start: " + Convert.ToString(_startPos) + " Len: " + Convert.ToString(checked(_endPos - _startPos));
	}

	public Location Combine(Location other)
	{
		return new Location(Source, Math.Min(StartPos, other.StartPos), Math.Max(EndPos, other.EndPos));
	}

	public static Location operator +(Location a, Location b)
	{
		return a.Combine(b);
	}

	public static Location FromToken(SourceSnapshot source, NToken tok)
	{
		return new Location(source, tok.StartPos, tok.EndPos);
	}

	public static Location FromToken(SourceSnapshot source, IToken tok)
	{
		return new Location(source, tok.StartPos, tok.EndPos);
	}

	public static Location FromToken(SourceSnapshot source, NToken a, NToken b)
	{
		return new Location(source, Math.Min(a.StartPos, b.StartPos), Math.Max(a.EndPos, b.EndPos));
	}

	public static Location FromToken(SourceSnapshot source, IToken a, IToken b)
	{
		return new Location(source, Math.Min(a.StartPos, b.StartPos), Math.Max(a.EndPos, b.EndPos));
	}

	[RecordCtor]
	public Location([MappedMember("_source")] SourceSnapshot source, [MappedMember("_startPos")] int startPos, [MappedMember("_endPos")] int endPos)
	{
		_source = source;
		_startPos = startPos;
		_endPos = endPos;
	}
}
