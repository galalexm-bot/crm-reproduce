using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Internal;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class ExtensionPatternEncodingAttribute : NemerleAttribute
{
	private readonly string name;

	private readonly string identifiers;

	private readonly string pattern;

	public string Name
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return name;
		}
	}

	public string Identifiers
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return identifiers;
		}
	}

	public string Pattern
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return pattern;
		}
	}

	public override string ToString()
	{
		return Convert.ToString(GetType().Name) + ": " + Convert.ToString(name) + ", Pattern:(" + Convert.ToString(pattern) + "), Identifiers:(" + Convert.ToString(identifiers) + ")";
	}

	[RecordCtor]
	public ExtensionPatternEncodingAttribute([MappedMember("name")] string name, [MappedMember("identifiers")] string identifiers, [MappedMember("pattern")] string pattern)
	{
		this.name = name;
		this.identifiers = identifiers;
		this.pattern = pattern;
	}
}
