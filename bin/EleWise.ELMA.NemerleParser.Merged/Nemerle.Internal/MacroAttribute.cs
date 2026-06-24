using System;

namespace Nemerle.Internal;

[AttributeUsage(AttributeTargets.All)]
public sealed class MacroAttribute : NemerleAttribute
{
	public readonly string name;

	public readonly int global_ctx;

	public readonly string parameters;

	public override string ToString()
	{
		return Convert.ToString(GetType().Name) + ": " + Convert.ToString(name) + " (" + Convert.ToString(parameters) + ")";
	}

	[RecordCtor]
	public MacroAttribute([MappedMember("name")] string name, [MappedMember("global_ctx")] int global_ctx, [MappedMember("parameters")] string parameters)
	{
		this.name = name;
		this.global_ctx = global_ctx;
		this.parameters = parameters;
	}
}
