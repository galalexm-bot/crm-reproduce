using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Compiler;
using Nemerle.Internal;

namespace Nemerle.Peg;

public class NameRef : Nemerle.Compiler.Located, IComparable<NameRef>
{
	private readonly string id;

	public string Id
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return id;
		}
	}

	public override string ToString()
	{
		return id;
	}

	public override int GetHashCode()
	{
		int result = 0;
		string text = id;
		if (text != null)
		{
			result = text.GetHashCode();
		}
		return result;
	}

	public int CompareTo(NameRef other)
	{
		string y = null;
		StringComparer ordinal = StringComparer.Ordinal;
		string x = id;
		if (other != null)
		{
			y = other.id;
		}
		return ordinal.Compare(x, y);
	}

	public bool Equals(NameRef _N_wildcard_4198)
	{
		return (object)_N_wildcard_4198 != null && _N_wildcard_4198.id == id;
	}

	public override bool Equals(object other)
	{
		return other == this || (other is NameRef && Equals((NameRef)other));
	}

	[RecordCtor]
	public NameRef([MappedMember("id")] string id)
	{
		this.id = id;
	}

	[RecordCtor]
	public NameRef(Nemerle.Compiler.Location loc, [MappedMember("id")] string id)
		: base(loc)
	{
		this.id = id;
	}
}
