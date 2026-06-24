using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Internal;

public sealed class TypeAliasAttribute : NemerleAttribute
{
	private readonly string aliasedType;

	public string AliasedType
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return aliasedType;
		}
	}

	public override string ToString()
	{
		return Convert.ToString(GetType().Name) + ": " + Convert.ToString(aliasedType);
	}

	[RecordCtor]
	public TypeAliasAttribute([MappedMember("aliasedType")] string aliasedType)
	{
		this.aliasedType = aliasedType;
	}
}
