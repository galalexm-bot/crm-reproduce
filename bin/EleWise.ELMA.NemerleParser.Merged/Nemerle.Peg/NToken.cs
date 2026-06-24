using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Peg;

public struct NToken : IToken, IEquatable<NToken>, IStructuralEquatable
{
	private readonly int _startPos;

	private readonly int _endPos;

	public bool IsEmpty => StartPos == EndPos;

	public int StartPos
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
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

	public int GetHashCode(IEqualityComparer _comparer)
	{
		return GetHashCode();
	}

	public bool Equals(object other, IEqualityComparer _comparer)
	{
		return Equals(other);
	}

	public static bool operator !=(NToken first, NToken second)
	{
		return !(first == second);
	}

	public static bool operator ==(NToken first, NToken second)
	{
		return first.Equals(second);
	}

	public override int GetHashCode()
	{
		int num = 0;
		num = 0;
		num += _startPos;
		num += num << 10;
		num = (num ^ (num >> 6)) + _endPos;
		num += num << 10;
		return num ^ (num >> 6);
	}

	public override bool Equals(object other)
	{
		return other is NToken && EqualsImpl((NToken)other);
	}

	public bool Equals(NToken other)
	{
		return EqualsImpl(other);
	}

	public override string ToString()
	{
		return "\"Start: " + Convert.ToString(_startPos) + " Len: " + Convert.ToString(checked(_endPos - _startPos)) + "\"";
	}

	private bool EqualsImpl(NToken other)
	{
		return _endPos == other._endPos && ((_startPos == other._startPos) ? true : false);
	}

	[RecordCtor]
	public NToken([MappedMember("_startPos")] int startPos, [MappedMember("_endPos")] int endPos)
	{
		_startPos = startPos;
		_endPos = endPos;
	}
}
