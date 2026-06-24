using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Internal;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class ContainsMacroAttribute : NemerleAttribute
{
	private readonly string name;

	public string Name
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return name;
		}
	}

	public override string ToString()
	{
		return Convert.ToString(GetType().Name) + ": " + Convert.ToString(name);
	}

	[RecordCtor]
	public ContainsMacroAttribute([MappedMember("name")] string name)
	{
		this.name = name;
	}
}
