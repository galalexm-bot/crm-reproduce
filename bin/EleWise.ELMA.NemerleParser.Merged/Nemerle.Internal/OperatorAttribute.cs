using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nemerle.Internal;

public sealed class OperatorAttribute : NemerleAttribute
{
	private readonly string env;

	private readonly string name;

	private readonly bool isUnary;

	private readonly int left;

	private readonly int right;

	public string Env
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return env;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return name;
		}
	}

	public bool IsUnary
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return isUnary;
		}
	}

	public int Left
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return left;
		}
	}

	public int Right
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return right;
		}
	}

	public override string ToString()
	{
		return "OperatorAttribute: " + Convert.ToString(name) + " (Env=" + Convert.ToString(env) + ", IsUnary=" + Convert.ToString(isUnary) + ", Left=" + Convert.ToString(left) + ", Right=" + Convert.ToString(right) + ")";
	}

	[RecordCtor]
	public OperatorAttribute([MappedMember("env")] string env, [MappedMember("name")] string name, [MappedMember("isUnary")] bool isUnary, [MappedMember("left")] int left, [MappedMember("right")] int right)
	{
		this.env = env;
		this.name = name;
		this.isUnary = isUnary;
		this.left = left;
		this.right = right;
	}
}
