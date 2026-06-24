using System;
using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Compiler.Typedtree;

public class Parm : ISupportRelocation
{
	public readonly ParmKind kind;

	public TExpr expr;

	public readonly string name;

	[IgnoreField]
	public readonly bool IsByDefault;

	public TypeVar required_type;

	[IgnoreField]
	[field: IgnoreField]
	public string NameToComplete { get; set; }

	public Parm(TExpr expr, bool is_default)
		: this(expr)
	{
		IsByDefault = is_default;
	}

	public Parm(TExpr expr)
	{
		kind = ParmKind.Normal;
		this.expr = expr;
		name = "";
	}

	public override string ToString()
	{
		return Convert.ToString((!(name == "")) ? (name + "=") : "") + " " + Convert.ToString(expr);
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			expr?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	[RecordCtor]
	public Parm([MappedMember("kind")] ParmKind kind, [MappedMember("expr")] TExpr expr, [MappedMember("name")] string name, [MappedMember("required_type")] TypeVar required_type)
	{
		this.kind = kind;
		this.expr = expr;
		this.name = name;
		this.required_type = required_type;
	}
}
