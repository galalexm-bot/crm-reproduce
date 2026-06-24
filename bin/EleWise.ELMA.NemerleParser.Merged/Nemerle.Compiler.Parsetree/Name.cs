using System;
using System.Diagnostics;

namespace Nemerle.Compiler.Parsetree;

public class Name : ParsedBase, IComparable<Name>, IEquatable<Name>
{
	public readonly string idl;

	public readonly int color;

	public readonly GlobalEnv context;

	public readonly string ParsedId;

	public string Id
	{
		[DebuggerNonUserCode]
		get
		{
			return idl;
		}
	}

	public Name(Name other)
		: base(other.Location)
	{
		idl = other.idl;
		color = other.color;
		context = other.context;
		ParsedId = other.ParsedId;
	}

	public Name(string id)
		: this(id, LocationStack.Top())
	{
	}

	public Name(string id, Location loc)
		: this(id, loc, id)
	{
	}

	public Name(string id, int color, GlobalEnv context)
		: this(id, LocationStack.Top(), color, context, id)
	{
	}

	public Name(string id, Location loc, int color, GlobalEnv context)
		: this(id, loc, color, context, id)
	{
	}

	public Name(string id, Location loc, string parsedId)
		: this(id, loc, ManagerClass.Instance.MacroColors.Color, null, parsedId)
	{
	}

	public Name(string id, Location loc, int color, GlobalEnv context, string parsedId)
		: base(loc)
	{
		this.color = color;
		this.context = context;
		idl = id;
		ParsedId = parsedId;
	}

	public static Name NameInCurrentColor(string id, GlobalEnv context)
	{
		return new Name(id, context.Manager.MacroColors.Color, context);
	}

	public static Name NameInCurrentColor(string id, Location loc, GlobalEnv context)
	{
		return new Name(id, loc, context.Manager.MacroColors.Color, context);
	}

	public static Name NameInCurrentColor(string id, string parsedId, Location loc, GlobalEnv context)
	{
		return new Name(id, loc, context.Manager.MacroColors.Color, context, parsedId);
	}

	public static Name Global(ManagerClass mgr, string id)
	{
		return new Name(id, 1, mgr.CoreEnv);
	}

	public Name NewName(string id)
	{
		return new Name(id, color, context);
	}

	public override string ToString()
	{
		return Id;
	}

	public override int GetHashCode()
	{
		return idl.GetHashCode() * (color + 1);
	}

	public bool Equals(Name other)
	{
		return CompareTo(other) == 0;
	}

	public int CompareTo(Name other)
	{
		int num = string.CompareOrdinal(idl, other.idl);
		return (num != 0) ? num : ((color >= 0 && other.color >= 0) ? checked(color - other.color) : 0);
	}

	public GlobalEnv GetEnv(GlobalEnv @default)
	{
		return (context == null) ? @default : context;
	}

	public override bool Equals(object other)
	{
		return other == this || (other is Name && Equals((Name)other));
	}
}
