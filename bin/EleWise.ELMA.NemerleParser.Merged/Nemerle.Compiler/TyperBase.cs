using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Compiler.Typedtree;

namespace Nemerle.Compiler;

public abstract class TyperBase : ISupportRelocation
{
	public static bool DebugOut;

	public readonly ManagerClass Manager;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	static TyperBase()
	{
		DebugOut = false;
		Debug.IndentSize = 2;
	}

	public static string RemoveNL(object obj)
	{
		string text = obj.ToString().Replace("\n", " ").Replace("\r", " ")
			.Replace("\t", " ");
		text = text;
		while (text.Contains("  "))
		{
			text = text.Replace("  ", " ");
		}
		return text;
	}

	protected TyperBase(ManagerClass manager)
	{
		Manager = manager;
	}

	internal TExpr VoidLiteral()
	{
		return new TExpr.Literal(InternalType.Void, new Literal.Void());
	}

	private void __fake()
	{
		__fake();
		SystemTypeClass systemTypeCache = SystemTypeCache;
		InternalTypeClass internalType = InternalType;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
