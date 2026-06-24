using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Peg;

[Variant("Nemerle.Peg.Rule.Choice,Nemerle.Peg.Rule.Sequence,Nemerle.Peg.Rule.Call,Nemerle.Peg.Rule.RepeatMin,Nemerle.Peg.Rule.RepeatMinMax,Nemerle.Peg.Rule.Chars,Nemerle.Peg.Rule.Fsm,Nemerle.Peg.Rule.Not,Nemerle.Peg.Rule.And,Nemerle.Peg.Rule.Capture,Nemerle.Peg.Rule.Scope,Nemerle.Peg.Rule.Cut")]
public abstract class Rule : Nemerle.Compiler.Located
{
	[VariantOption]
	public class Choice : Rule
	{
		public readonly list<Rule> rules;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Choice([MappedMember("rules")] list<Rule> rules)
		{
			this.rules = rules;
		}

		[RecordCtor]
		public Choice(Nemerle.Compiler.Location loc, [MappedMember("rules")] list<Rule> rules)
			: base(loc)
		{
			this.rules = rules;
		}
	}

	[VariantOption]
	public class Sequence : Rule
	{
		public readonly list<Rule> rules;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Sequence([MappedMember("rules")] list<Rule> rules)
		{
			this.rules = rules;
		}

		[RecordCtor]
		public Sequence(Nemerle.Compiler.Location loc, [MappedMember("rules")] list<Rule> rules)
			: base(loc)
		{
			this.rules = rules;
		}
	}

	[VariantOption]
	public class Call : Rule
	{
		public readonly NameRef name;

		public readonly int bindingPower;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public Call([MappedMember("name")] NameRef name, [MappedMember("bindingPower")] int bindingPower)
		{
			this.name = name;
			this.bindingPower = bindingPower;
		}

		[RecordCtor]
		public Call(Nemerle.Compiler.Location loc, [MappedMember("name")] NameRef name, [MappedMember("bindingPower")] int bindingPower)
			: base(loc)
		{
			this.name = name;
			this.bindingPower = bindingPower;
		}
	}

	[VariantOption]
	public class RepeatMin : Rule
	{
		public readonly int minCount;

		public readonly Rule rule;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		public RepeatMin([MappedMember("minCount")] int minCount, [MappedMember("rule")] Rule rule)
		{
			this.minCount = minCount;
			this.rule = rule;
		}

		[RecordCtor]
		public RepeatMin(Nemerle.Compiler.Location loc, [MappedMember("minCount")] int minCount, [MappedMember("rule")] Rule rule)
			: base(loc)
		{
			this.minCount = minCount;
			this.rule = rule;
		}
	}

	[VariantOption]
	public class RepeatMinMax : Rule
	{
		public readonly int minCount;

		public readonly int maxCount;

		public readonly Rule rule;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		public RepeatMinMax([MappedMember("minCount")] int minCount, [MappedMember("maxCount")] int maxCount, [MappedMember("rule")] Rule rule)
		{
			this.minCount = minCount;
			this.maxCount = maxCount;
			this.rule = rule;
		}

		[RecordCtor]
		public RepeatMinMax(Nemerle.Compiler.Location loc, [MappedMember("minCount")] int minCount, [MappedMember("maxCount")] int maxCount, [MappedMember("rule")] Rule rule)
			: base(loc)
		{
			this.minCount = minCount;
			this.maxCount = maxCount;
			this.rule = rule;
		}
	}

	[VariantOption]
	public class Chars : Rule
	{
		private sealed class _N__N_lambda__19985__19992 : Function<RangeSet, bool>
		{
			[SpecialName]
			public static readonly _N__N_lambda__19985__19992 Instance = new _N__N_lambda__19985__19992();

			[SpecialName]
			public sealed override bool apply(RangeSet _N__19984)
			{
				return _N__19984.IsSinglChar;
			}
		}

		public readonly list<RangeSet> chars;

		public bool IsString
		{
			get
			{
				list<RangeSet> list = chars;
				Function<RangeSet, bool> instance = _N__N_lambda__19985__19992.Instance;
				return list.ForAll(instance);
			}
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
		}

		[RecordCtor]
		public Chars([MappedMember("chars")] list<RangeSet> chars)
		{
			this.chars = chars;
		}

		[RecordCtor]
		public Chars(Nemerle.Compiler.Location loc, [MappedMember("chars")] list<RangeSet> chars)
			: base(loc)
		{
			this.chars = chars;
		}
	}

	[VariantOption]
	public class Fsm : Rule
	{
		public readonly FSM fsm;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 6;
		}

		[RecordCtor]
		public Fsm([MappedMember("fsm")] FSM fsm)
		{
			this.fsm = fsm;
		}

		[RecordCtor]
		public Fsm(Nemerle.Compiler.Location loc, [MappedMember("fsm")] FSM fsm)
			: base(loc)
		{
			this.fsm = fsm;
		}
	}

	[VariantOption]
	public class Not : Rule
	{
		public readonly Rule rule;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 7;
		}

		[RecordCtor]
		public Not([MappedMember("rule")] Rule rule)
		{
			this.rule = rule;
		}

		[RecordCtor]
		public Not(Nemerle.Compiler.Location loc, [MappedMember("rule")] Rule rule)
			: base(loc)
		{
			this.rule = rule;
		}
	}

	[VariantOption]
	public class And : Rule
	{
		public readonly Rule rule;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 8;
		}

		[RecordCtor]
		public And([MappedMember("rule")] Rule rule)
		{
			this.rule = rule;
		}

		[RecordCtor]
		public And(Nemerle.Compiler.Location loc, [MappedMember("rule")] Rule rule)
			: base(loc)
		{
			this.rule = rule;
		}
	}

	[VariantOption]
	public class Capture : Rule
	{
		public readonly CaptureKind kind;

		public readonly Rule rule;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 9;
		}

		[RecordCtor]
		public Capture([MappedMember("kind")] CaptureKind kind, [MappedMember("rule")] Rule rule)
		{
			this.kind = kind;
			this.rule = rule;
		}

		[RecordCtor]
		public Capture(Nemerle.Compiler.Location loc, [MappedMember("kind")] CaptureKind kind, [MappedMember("rule")] Rule rule)
			: base(loc)
		{
			this.kind = kind;
			this.rule = rule;
		}
	}

	[VariantOption]
	public class Scope : Rule
	{
		public readonly NameRef name;

		public readonly Rule rule;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 10;
		}

		[RecordCtor]
		public Scope([MappedMember("name")] NameRef name, [MappedMember("rule")] Rule rule)
		{
			this.name = name;
			this.rule = rule;
		}

		[RecordCtor]
		public Scope(Nemerle.Compiler.Location loc, [MappedMember("name")] NameRef name, [MappedMember("rule")] Rule rule)
			: base(loc)
		{
			this.name = name;
			this.rule = rule;
		}
	}

	[VariantOption]
	public class Cut : Rule
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 11;
		}

		[RecordCtor]
		public Cut()
		{
		}

		[RecordCtor]
		public Cut(Nemerle.Compiler.Location loc)
			: base(loc)
		{
		}
	}

	private sealed class _N_closureOf_ToString_19838
	{
		internal Rule _N__N_closurised_this_ptr_19843;

		internal _N_closureOf_ToString_19838()
		{
		}
	}

	private sealed class _N_p__19845 : Function<Rule, string>
	{
		[SpecialName]
		private _N_closureOf_ToString_19838 _N_ToString_closure_19849;

		public _N_p__19845(_N_closureOf_ToString_19838 _N_ToString_closure_19849)
		{
			this._N_ToString_closure_19849 = _N_ToString_closure_19849;
		}

		[SpecialName]
		public sealed override string apply(Rule rule)
		{
			return (rule.Priority > _N_ToString_closure_19849._N__N_closurised_this_ptr_19843.Priority) ? rule.ToString() : ("(" + Convert.ToString(rule) + ")");
		}
	}

	private sealed class _N__N_lambda__19818__19882 : Function<RangeSet, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__19818__19882 Instance = new _N__N_lambda__19818__19882();

		[SpecialName]
		public sealed override string apply(RangeSet r)
		{
			return string.Concat(Convert.ToString(r.Ranges.Head.from));
		}
	}

	private sealed class _N__N_lambda__19825__19892 : Function<RangeSet, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__19825__19892 Instance = new _N__N_lambda__19825__19892();

		[SpecialName]
		public sealed override string apply(RangeSet ch)
		{
			return "[" + Convert.ToString(ch) + "]";
		}
	}

	public int Priority => _N_GetVariantCodeSafe(this) switch
	{
		0 => 1, 
		1 => 2, 
		2 => 5, 
		3 => 4, 
		4 => 4, 
		5 => 5, 
		6 => 5, 
		7 => 3, 
		8 => 3, 
		9 => 5, 
		10 => 5, 
		11 => 5, 
		_ => throw new MatchFailureException(), 
	};

	public override string ToString()
	{
		_N_closureOf_ToString_19838 n_closureOf_ToString_ = new _N_closureOf_ToString_19838();
		n_closureOf_ToString_._N__N_closurised_this_ptr_19843 = this;
		Function<Rule, string> function = new _N_p__19845(n_closureOf_ToString_);
		object result;
		switch (_N_GetVariantCodeSafe(this))
		{
		default:
			throw new MatchFailureException();
		case 0:
		{
			list<Rule> list = ((Choice)this).rules;
			result = string.Concat(string.Join(" / ", NCollectionsExtensions.MapToArray(list, function)));
			break;
		}
		case 1:
		{
			list<Rule> list = ((Sequence)this).rules;
			result = string.Concat(string.Join(" ", NCollectionsExtensions.MapToArray(list, function)));
			break;
		}
		case 2:
			if (((Call)this).bindingPower == 0)
			{
				NameRef name = ((Call)this).name;
				result = name.Id;
			}
			else
			{
				NameRef name = ((Call)this).name;
				int minCount = ((Call)this).bindingPower;
				result = Convert.ToString(name.Id) + " : " + Convert.ToString(minCount);
			}
			break;
		case 3:
		{
			Rule rule;
			if (((RepeatMin)this).minCount == 0)
			{
				rule = ((RepeatMin)this).rule;
				result = Convert.ToString(function.apply(rule)) + "*";
				break;
			}
			if (((RepeatMin)this).minCount == 1)
			{
				rule = ((RepeatMin)this).rule;
				result = Convert.ToString(function.apply(rule)) + "+";
				break;
			}
			int minCount = ((RepeatMin)this).minCount;
			rule = ((RepeatMin)this).rule;
			result = "RepeatMin(" + Convert.ToString(minCount) + ", " + Convert.ToString(rule) + ")";
			break;
		}
		case 4:
		{
			Rule rule;
			if (((RepeatMinMax)this).minCount == 0 && ((RepeatMinMax)this).maxCount == 1)
			{
				rule = ((RepeatMinMax)this).rule;
				result = Convert.ToString(function.apply(rule)) + "?";
				break;
			}
			int minCount2 = ((RepeatMinMax)this).minCount;
			int minCount = ((RepeatMinMax)this).maxCount;
			rule = ((RepeatMinMax)this).rule;
			result = "RepeatMinMax(" + Convert.ToString(minCount2) + ", " + Convert.ToString(minCount) + ", " + Convert.ToString(rule) + ")";
			break;
		}
		case 5:
		{
			Chars chars = (Chars)this;
			list<RangeSet> list2 = ((Chars)this).chars;
			if (chars.IsString)
			{
				IEnumerable<RangeSet> source = list2;
				Function<RangeSet, string> instance = _N__N_lambda__19818__19882.Instance;
				result = "'" + string.Join("", source.MapToArray(instance)) + "'";
			}
			else if (((Chars)this).chars is list<RangeSet>.Cons && (object)((list<RangeSet>.Cons)((Chars)this).chars).tl == list<RangeSet>.Nil._N_constant_object)
			{
				RangeSet hd = ((list<RangeSet>.Cons)((Chars)this).chars).hd;
				result = "[" + Convert.ToString(hd) + "]";
			}
			else
			{
				list2 = ((Chars)this).chars;
				IEnumerable<RangeSet> source2 = list2;
				Function<RangeSet, string> instance = _N__N_lambda__19825__19892.Instance;
				result = "(" + string.Join(", ", source2.MapToArray(instance)) + ")";
			}
			break;
		}
		case 6:
			result = "FSM";
			break;
		case 7:
		{
			Rule rule = ((Not)this).rule;
			result = "!" + Convert.ToString(function.apply(rule));
			break;
		}
		case 8:
		{
			Rule rule = ((And)this).rule;
			result = "&" + Convert.ToString(function.apply(rule));
			break;
		}
		case 9:
			if (((Capture)this).kind is CaptureKind.Argument)
			{
				RuleType retType = ((CaptureKind.Argument)((Capture)this).kind).retType;
				Rule rule = ((Capture)this).rule;
				result = "CaptureA[" + Convert.ToString(retType) + "](" + Convert.ToString(rule) + ")";
				break;
			}
			if (((Capture)this).kind is CaptureKind.Handler)
			{
				NameRef name = ((CaptureKind.Handler)((Capture)this).kind).name;
				Rule rule = ((Capture)this).rule;
				result = "CaptureH[" + Convert.ToString(name) + "](" + Convert.ToString(rule) + ")";
				break;
			}
			throw new MatchFailureException();
		case 10:
		{
			NameRef name = ((Scope)this).name;
			Rule rule = ((Scope)this).rule;
			result = Convert.ToString(name) + " { " + Convert.ToString(rule) + " }";
			break;
		}
		case 11:
			result = "#";
			break;
		}
		return (string)result;
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(Rule x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is Rule)) ? (-1) : ((Rule)x)._N_GetVariantCode();
	}

	[RecordCtor]
	protected Rule()
	{
	}

	[RecordCtor]
	protected Rule(Nemerle.Compiler.Location loc)
		: base(loc)
	{
	}
}
