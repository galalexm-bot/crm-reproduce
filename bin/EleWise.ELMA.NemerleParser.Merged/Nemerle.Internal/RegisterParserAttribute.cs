using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Internal;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class RegisterParserAttribute : NemerleAttribute
{
	private readonly string name;

	private readonly string extension;

	public string Name
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return name;
		}
	}

	public string Extension
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return extension;
		}
	}

	public override string ToString()
	{
		return Convert.ToString(GetType().Name) + ": " + Convert.ToString(name) + ", Extension:(" + Convert.ToString(extension) + ")";
	}

	[RecordCtor]
	public RegisterParserAttribute([MappedMember("name")] string name, [MappedMember("extension")] string extension)
	{
		this.name = name;
		this.extension = extension;
	}
}
