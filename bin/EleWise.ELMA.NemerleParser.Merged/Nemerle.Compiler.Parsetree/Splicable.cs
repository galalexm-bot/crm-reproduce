using System;
using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

[Variant("Nemerle.Compiler.Parsetree.Splicable.Name,Nemerle.Compiler.Parsetree.Splicable.Expression,Nemerle.Compiler.Parsetree.Splicable.HalfId")]
public abstract class Splicable : ParsedBase, IEquatable<Splicable>
{
	[VariantOption]
	public class Name : Splicable
	{
		public readonly Nemerle.Compiler.Parsetree.Name body;

		public Name(PExpr.Ref nameRef)
			: base(nameRef?.Location ?? Location.Default)
		{
			body = nameRef.name;
		}

		public Name(Nemerle.Compiler.Parsetree.Name body)
			: base(body?.Location ?? Location.Default)
		{
			this.body = body;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Name(Location loc, [MappedMember("body")] Nemerle.Compiler.Parsetree.Name body)
			: base(loc)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Expression : Splicable
	{
		public readonly PExpr expr;

		[IgnoreField]
		public GlobalEnv env;

		public Expression(PExpr expr, GlobalEnv env)
			: base(expr?.Location ?? Location.Default)
		{
			this.expr = expr;
			this.env = env;
		}

		public Expression(Location loc, PExpr expr, GlobalEnv env)
			: base(loc)
		{
			this.expr = expr;
			this.env = env;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Expression([MappedMember("expr")] PExpr expr)
		{
			this.expr = expr;
		}

		[RecordCtor]
		public Expression(Location loc, [MappedMember("expr")] PExpr expr)
			: base(loc)
		{
			this.expr = expr;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				expr?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class HalfId : Splicable
	{
		public readonly Nemerle.Compiler.Parsetree.Name prefix;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public HalfId([MappedMember("prefix")] Nemerle.Compiler.Parsetree.Name prefix)
		{
			this.prefix = prefix;
		}

		[RecordCtor]
		public HalfId(Location loc, [MappedMember("prefix")] Nemerle.Compiler.Parsetree.Name prefix)
			: base(loc)
		{
			this.prefix = prefix;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				prefix?.RelocateImplInternal(_info);
			}
		}
	}

	public Nemerle.Compiler.Parsetree.Name GetName()
	{
		if (this is Name)
		{
			return ((Name)this).body;
		}
		throw new ArgumentException("GetName () called for option " + ToString());
	}

	public bool Equals(Splicable other)
	{
		Splicable splicable = null;
		splicable = this;
		Nemerle.Compiler.Parsetree.Name name;
		Nemerle.Compiler.Parsetree.Name other2;
		if (splicable is HalfId)
		{
			if (other is HalfId)
			{
				name = ((HalfId)splicable).prefix;
				other2 = ((HalfId)other).prefix;
				goto IL_0032;
			}
		}
		else if (splicable is Name && other is Name)
		{
			name = ((Name)splicable).body;
			other2 = ((Name)other).body;
			goto IL_0032;
		}
		int result = 0;
		goto IL_0078;
		IL_0078:
		return (byte)result != 0;
		IL_0032:
		result = (name.Equals(other2) ? 1 : 0);
		goto IL_0078;
	}

	public string GetIdentifier()
	{
		if (this is Name)
		{
			Nemerle.Compiler.Parsetree.Name body = ((Name)this).body;
			return body.Id;
		}
		throw new ArgumentException("GetIdList () called for option " + ToString());
	}

	public override string ToString()
	{
		object result;
		if (this is Name)
		{
			Nemerle.Compiler.Parsetree.Name body = ((Name)this).body;
			result = body.Id;
		}
		else if (this is Expression)
		{
			PExpr expr = ((Expression)this).expr;
			result = expr.ToString();
		}
		else if (this is HalfId)
		{
			Nemerle.Compiler.Parsetree.Name body = ((HalfId)this).prefix;
			result = body.Id;
		}
		else
		{
			result = "";
		}
		return (string)result;
	}

	public override bool Equals(object other)
	{
		return other == this || (other is Splicable && Equals((Splicable)other));
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(Splicable x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is Splicable)) ? (-1) : ((Splicable)x)._N_GetVariantCode();
	}

	[RecordCtor]
	protected Splicable()
	{
	}

	[RecordCtor]
	protected Splicable(Location loc)
		: base(loc)
	{
	}
}
