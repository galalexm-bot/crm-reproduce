using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

[Variant("Nemerle.Compiler.GrammarElement.Operator,Nemerle.Compiler.GrammarElement.Keyword,Nemerle.Compiler.GrammarElement.Expression,Nemerle.Compiler.GrammarElement.Parameter,Nemerle.Compiler.GrammarElement.RawToken,Nemerle.Compiler.GrammarElement.ExpressionList,Nemerle.Compiler.GrammarElement.Optional,Nemerle.Compiler.GrammarElement.Branch,Nemerle.Compiler.GrammarElement.End")]
public abstract class GrammarElement : IEquatable<GrammarElement>, ISupportRelocation
{
	[VariantOption]
	public class Operator : GrammarElement
	{
		public readonly string name;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Operator([MappedMember("name")] string name)
		{
			this.name = name;
		}

		[RecordCtor]
		public Operator(GrammarElement next, [MappedMember("name")] string name)
			: base(next)
		{
			this.name = name;
		}

		[RecordCtor]
		public Operator(GrammarElement next, AttributeTargets target, [MappedMember("name")] string name)
			: base(next, target)
		{
			this.name = name;
		}
	}

	[VariantOption]
	public class Keyword : GrammarElement
	{
		public readonly string name;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Keyword([MappedMember("name")] string name)
		{
			this.name = name;
		}

		[RecordCtor]
		public Keyword(GrammarElement next, [MappedMember("name")] string name)
			: base(next)
		{
			this.name = name;
		}

		[RecordCtor]
		public Keyword(GrammarElement next, AttributeTargets target, [MappedMember("name")] string name)
			: base(next, target)
		{
			this.name = name;
		}
	}

	[VariantOption]
	public class Expression : GrammarElement
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public Expression()
		{
		}

		[RecordCtor]
		public Expression(GrammarElement next)
			: base(next)
		{
		}

		[RecordCtor]
		public Expression(GrammarElement next, AttributeTargets target)
			: base(next, target)
		{
		}
	}

	[VariantOption]
	public class Parameter : GrammarElement
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		public Parameter()
		{
		}

		[RecordCtor]
		public Parameter(GrammarElement next)
			: base(next)
		{
		}

		[RecordCtor]
		public Parameter(GrammarElement next, AttributeTargets target)
			: base(next, target)
		{
		}
	}

	[VariantOption]
	public class RawToken : GrammarElement
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		public RawToken()
		{
		}

		[RecordCtor]
		public RawToken(GrammarElement next)
			: base(next)
		{
		}

		[RecordCtor]
		public RawToken(GrammarElement next, AttributeTargets target)
			: base(next, target)
		{
		}
	}

	[VariantOption]
	public class ExpressionList : GrammarElement
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
		}

		[RecordCtor]
		public ExpressionList()
		{
		}

		[RecordCtor]
		public ExpressionList(GrammarElement next)
			: base(next)
		{
		}

		[RecordCtor]
		public ExpressionList(GrammarElement next, AttributeTargets target)
			: base(next, target)
		{
		}
	}

	[VariantOption]
	public class Optional : GrammarElement
	{
		public readonly GrammarElement body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 6;
		}

		[RecordCtor]
		public Optional([MappedMember("body")] GrammarElement body)
		{
			this.body = body;
		}

		[RecordCtor]
		public Optional(GrammarElement next, [MappedMember("body")] GrammarElement body)
			: base(next)
		{
			this.body = body;
		}

		[RecordCtor]
		public Optional(GrammarElement next, AttributeTargets target, [MappedMember("body")] GrammarElement body)
			: base(next, target)
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
	public class Branch : GrammarElement
	{
		public readonly list<GrammarElement> options;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 7;
		}

		[RecordCtor]
		public Branch([MappedMember("options")] list<GrammarElement> options)
		{
			this.options = options;
		}

		[RecordCtor]
		public Branch(GrammarElement next, [MappedMember("options")] list<GrammarElement> options)
			: base(next)
		{
			this.options = options;
		}

		[RecordCtor]
		public Branch(GrammarElement next, AttributeTargets target, [MappedMember("options")] list<GrammarElement> options)
			: base(next, target)
		{
			this.options = options;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (_info.VisitedObjects.ContainsKey(this))
			{
				return;
			}
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			list<GrammarElement> list = options;
			if (list != null)
			{
				list = list;
				while (list is list<GrammarElement>.Cons)
				{
					GrammarElement hd = ((list<GrammarElement>.Cons)list).hd;
					list = ((list<GrammarElement>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}
	}

	[VariantOption]
	public class End : GrammarElement
	{
		public readonly SyntaxDefinition define;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 8;
		}

		[RecordCtor]
		public End([MappedMember("define")] SyntaxDefinition define)
		{
			this.define = define;
		}

		[RecordCtor]
		public End(GrammarElement next, [MappedMember("define")] SyntaxDefinition define)
			: base(next)
		{
			this.define = define;
		}

		[RecordCtor]
		public End(GrammarElement next, AttributeTargets target, [MappedMember("define")] SyntaxDefinition define)
			: base(next, target)
		{
			this.define = define;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				define?.RelocateImplInternal(_info);
			}
		}
	}

	private sealed class _N__N_lambda__34684__34704 : Function<GrammarElement, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__34684__34704 Instance = new _N__N_lambda__34684__34704();

		[SpecialName]
		public sealed override string apply(GrammarElement x)
		{
			return "`" + Convert.ToString(x) + "'";
		}
	}

	public readonly GrammarElement Next;

	internal readonly AttributeTargets Target;

	public GrammarElement()
	{
	}

	internal GrammarElement(GrammarElement next)
	{
		Next = next;
	}

	internal GrammarElement(GrammarElement next, AttributeTargets target)
		: this(next)
	{
		Target = target;
	}

	internal GrammarElement CloneWithNext(GrammarElement other)
	{
		if (other == null)
		{
			throw new AssertionException("ncc\\parsing\\MainParser-Extensions.n", 72, "other != null", "");
		}
		object result;
		if (this is Operator)
		{
			string name = ((Operator)this).name;
			result = new Operator(other, other.Target, name);
		}
		else if (this is Keyword)
		{
			string name = ((Keyword)this).name;
			result = new Keyword(other, other.Target, name);
		}
		else if (this is Expression)
		{
			result = new Expression(other, other.Target);
		}
		else if (this is Parameter)
		{
			result = new Parameter(other, other.Target);
		}
		else if (this is RawToken)
		{
			result = new RawToken(other, other.Target);
		}
		else if (this is ExpressionList)
		{
			result = new ExpressionList(other, other.Target);
		}
		else
		{
			if (!(this is Optional))
			{
				if (this is Branch || this is End)
				{
					if (!Message.SeenError)
					{
						string name = "tree like elements are not allowed to be cloned".ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(name) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\parsing\\MainParser-Extensions.n", 81, "", "tree like elements are not allowed to be cloned");
				}
				throw new MatchFailureException();
			}
			GrammarElement body = ((Optional)this).body;
			result = new Optional(other, other.Target, body);
		}
		return (GrammarElement)result;
	}

	internal GrammarElement AddBranch(GrammarElement next)
	{
		Branch result;
		if (this is Branch)
		{
			list<GrammarElement> tl = ((Branch)this).options;
			result = new Branch(null, Target | next.Target, new list<GrammarElement>.Cons(next, tl));
		}
		else
		{
			result = new Branch(null, Target | next.Target, new list<GrammarElement>.Cons(next, new list<GrammarElement>.Cons(this, list<GrammarElement>.Nil._N_constant_object)));
		}
		return result;
	}

	public bool Equals(GrammarElement other)
	{
		GrammarElement grammarElement = null;
		int result;
		string name;
		string name2;
		if (other == null)
		{
			result = 1;
		}
		else
		{
			grammarElement = this;
			if (grammarElement is Operator)
			{
				if (other is Operator)
				{
					name = ((Operator)grammarElement).name;
					name2 = ((Operator)other).name;
					goto IL_0079;
				}
			}
			else if (grammarElement is Keyword)
			{
				if (other is Keyword)
				{
					name = ((Keyword)grammarElement).name;
					name2 = ((Keyword)other).name;
					goto IL_0079;
				}
			}
			else if (grammarElement is Expression)
			{
				if (other is Expression)
				{
					goto IL_0105;
				}
			}
			else if (grammarElement is Parameter)
			{
				if (other is Parameter)
				{
					goto IL_0105;
				}
			}
			else if (grammarElement is RawToken)
			{
				if (other is RawToken)
				{
					goto IL_0105;
				}
			}
			else if (grammarElement is ExpressionList)
			{
				if (other is ExpressionList)
				{
					goto IL_0105;
				}
			}
			else if (grammarElement is Optional && other is Optional)
			{
				grammarElement = ((Optional)grammarElement).body;
				GrammarElement body = ((Optional)other).body;
				result = (grammarElement.Equals(body) ? 1 : 0);
				goto IL_015a;
			}
			result = 0;
		}
		goto IL_015a;
		IL_0105:
		result = 1;
		goto IL_015a;
		IL_0079:
		result = ((name == name2) ? 1 : 0);
		goto IL_015a;
		IL_015a:
		return (byte)result != 0;
	}

	public string ToStringWhole()
	{
		return (Next == null) ? ToString() : string.Concat(ToString() + " ", Next.ToStringWhole());
	}

	public override string ToString()
	{
		object result;
		if (this is Operator)
		{
			string name = ((Operator)this).name;
			result = name;
		}
		else if (this is Keyword)
		{
			string name = ((Keyword)this).name;
			result = name;
		}
		else if (this is Expression)
		{
			result = "PExpr";
		}
		else if (this is Parameter)
		{
			result = "Parameter";
		}
		else if (this is RawToken)
		{
			result = "Token";
		}
		else if (this is ExpressionList)
		{
			result = "PExpr*";
		}
		else if (this is Optional)
		{
			GrammarElement body = ((Optional)this).body;
			result = body.ToString() + "?";
		}
		else if (this is Branch)
		{
			list<GrammarElement> lst = ((Branch)this).options;
			Function<GrammarElement, string> instance = _N__N_lambda__34684__34704.Instance;
			result = string.Concat("(" + NList.Map(lst, instance).ToString(" | "), ")");
		}
		else
		{
			if (!(this is End))
			{
				throw new MatchFailureException();
			}
			SyntaxDefinition define = ((End)this).define;
			result = define.MacroNamespace.GetDisplayName();
		}
		return (string)result;
	}

	public override bool Equals(object other)
	{
		return other == this || (other is GrammarElement && Equals((GrammarElement)other));
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(GrammarElement x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is GrammarElement)) ? (-1) : ((GrammarElement)x)._N_GetVariantCode();
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			Next?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
