using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public static class ConstantFolder
{
	private sealed class _N_closureOf_FoldLiterals_94920
	{
		internal Literal.Integer _N_lit1_94931;

		internal ulong _N_val1_94929;

		internal ulong _N_val2_94927;

		internal FixedType.Class _N_result_ty_94925;

		internal _N_closureOf_FoldLiterals_94920()
		{
		}
	}

	private sealed class _N__N_lambda__94913__94971 : Function<Literal.Integer>
	{
		[SpecialName]
		private _N_closureOf_FoldLiterals_94920 _N_FoldLiterals_closure_94975;

		public _N__N_lambda__94913__94971(_N_closureOf_FoldLiterals_94920 _N_FoldLiterals_closure_94975)
		{
			this._N_FoldLiterals_closure_94975 = _N_FoldLiterals_closure_94975;
		}

		[SpecialName]
		public sealed override Literal.Integer apply()
		{
			return checked((_N_FoldLiterals_closure_94975._N_val1_94929 < _N_FoldLiterals_closure_94975._N_val2_94927) ? new Literal.Integer(_N_FoldLiterals_closure_94975._N_val2_94927 - _N_FoldLiterals_closure_94975._N_val1_94929, !_N_FoldLiterals_closure_94975._N_lit1_94931.is_negative, _N_FoldLiterals_closure_94975._N_result_ty_94925) : new Literal.Integer(_N_FoldLiterals_closure_94975._N_val1_94929 - _N_FoldLiterals_closure_94975._N_val2_94927, _N_FoldLiterals_closure_94975._N_lit1_94931.is_negative, _N_FoldLiterals_closure_94975._N_result_ty_94925));
		}
	}

	private sealed class _N_closureOf_convert_integer_literal_95330
	{
		internal Literal.Integer _N_lit_95337;

		internal string _N_target_95335;

		internal _N_closureOf_convert_integer_literal_95330()
		{
		}
	}

	private sealed class _N_static_proxy_95361 : Function<Literal.Integer, option<Literal.Integer>.Some>
	{
		[SpecialName]
		public static readonly _N_static_proxy_95361 single_instance = new _N_static_proxy_95361();

		[SpecialName]
		public sealed override option<Literal.Integer>.Some apply(Literal.Integer _N_sp_parm_95368)
		{
			return new option<Literal.Integer>.Some(_N_sp_parm_95368);
		}

		private _N_static_proxy_95361()
		{
		}
	}

	private sealed class _N_static_proxy_95376 : Function<Literal.Integer, option<Literal.Integer>.Some>
	{
		[SpecialName]
		public static readonly _N_static_proxy_95376 single_instance = new _N_static_proxy_95376();

		[SpecialName]
		public sealed override option<Literal.Integer>.Some apply(Literal.Integer _N_sp_parm_95383)
		{
			return new option<Literal.Integer>.Some(_N_sp_parm_95383);
		}

		private _N_static_proxy_95376()
		{
		}
	}

	private sealed class _N_static_proxy_95391 : Function<Literal.Integer, option<Literal.Integer>.Some>
	{
		[SpecialName]
		public static readonly _N_static_proxy_95391 single_instance = new _N_static_proxy_95391();

		[SpecialName]
		public sealed override option<Literal.Integer>.Some apply(Literal.Integer _N_sp_parm_95398)
		{
			return new option<Literal.Integer>.Some(_N_sp_parm_95398);
		}

		private _N_static_proxy_95391()
		{
		}
	}

	private sealed class _N_static_proxy_95406 : Function<Literal.Integer, option<Literal.Integer>.Some>
	{
		[SpecialName]
		public static readonly _N_static_proxy_95406 single_instance = new _N_static_proxy_95406();

		[SpecialName]
		public sealed override option<Literal.Integer>.Some apply(Literal.Integer _N_sp_parm_95413)
		{
			return new option<Literal.Integer>.Some(_N_sp_parm_95413);
		}

		private _N_static_proxy_95406()
		{
		}
	}

	private sealed class _N_static_proxy_95421 : Function<Literal.Integer, option<Literal.Integer>.Some>
	{
		[SpecialName]
		public static readonly _N_static_proxy_95421 single_instance = new _N_static_proxy_95421();

		[SpecialName]
		public sealed override option<Literal.Integer>.Some apply(Literal.Integer _N_sp_parm_95428)
		{
			return new option<Literal.Integer>.Some(_N_sp_parm_95428);
		}

		private _N_static_proxy_95421()
		{
		}
	}

	private sealed class _N_static_proxy_95436 : Function<Literal.Integer, option<Literal.Integer>.Some>
	{
		[SpecialName]
		public static readonly _N_static_proxy_95436 single_instance = new _N_static_proxy_95436();

		[SpecialName]
		public sealed override option<Literal.Integer>.Some apply(Literal.Integer _N_sp_parm_95443)
		{
			return new option<Literal.Integer>.Some(_N_sp_parm_95443);
		}

		private _N_static_proxy_95436()
		{
		}
	}

	private sealed class _N_static_proxy_95451 : Function<Literal.Integer, option<Literal.Integer>.Some>
	{
		[SpecialName]
		public static readonly _N_static_proxy_95451 single_instance = new _N_static_proxy_95451();

		[SpecialName]
		public sealed override option<Literal.Integer>.Some apply(Literal.Integer _N_sp_parm_95458)
		{
			return new option<Literal.Integer>.Some(_N_sp_parm_95458);
		}

		private _N_static_proxy_95451()
		{
		}
	}

	private sealed class _N_static_proxy_95466 : Function<Literal.Integer, option<Literal.Integer>.Some>
	{
		[SpecialName]
		public static readonly _N_static_proxy_95466 single_instance = new _N_static_proxy_95466();

		[SpecialName]
		public sealed override option<Literal.Integer>.Some apply(Literal.Integer _N_sp_parm_95473)
		{
			return new option<Literal.Integer>.Some(_N_sp_parm_95473);
		}

		private _N_static_proxy_95466()
		{
		}
	}

	private sealed class _N_closureOf_fold_type_conversion_95490
	{
		internal GlobalEnv _N_env_95497;

		internal PExpr _N_t_95495;

		internal _N_closureOf_fold_type_conversion_95490()
		{
		}
	}

	private sealed class _N_static_proxy_95529 : Function<PExpr, option<PExpr>.Some>
	{
		[SpecialName]
		public static readonly _N_static_proxy_95529 single_instance = new _N_static_proxy_95529();

		[SpecialName]
		public sealed override option<PExpr>.Some apply(PExpr _N_sp_parm_95536)
		{
			return new option<PExpr>.Some(_N_sp_parm_95536);
		}

		private _N_static_proxy_95529()
		{
		}
	}

	private sealed class _N_closureOf_FoldTyped_95628
	{
		internal string _N_name_95637;

		internal bool _N_is_checked_95635;

		internal Literal.Integer _N_lit_95633;

		internal _N_closureOf_FoldTyped_95628()
		{
		}
	}

	private sealed class _N__N_lambda__95622__95644 : Function<Literal.Integer>
	{
		[SpecialName]
		private _N_closureOf_FoldTyped_95628 _N_FoldTyped_closure_95648;

		public _N__N_lambda__95622__95644(_N_closureOf_FoldTyped_95628 _N_FoldTyped_closure_95648)
		{
			this._N_FoldTyped_closure_95648 = _N_FoldTyped_closure_95648;
		}

		[SpecialName]
		public sealed override Literal.Integer apply()
		{
			return FoldLiteral(_N_FoldTyped_closure_95648._N_is_checked_95635, _N_FoldTyped_closure_95648._N_name_95637, _N_FoldTyped_closure_95648._N_lit_95633);
		}
	}

	private sealed class _N_closureOf_FoldTyped_95671
	{
		internal string _N_name_95682;

		internal bool _N_is_checked_95680;

		internal Literal _N_l1_95678;

		internal Literal _N_l2_95676;

		internal _N_closureOf_FoldTyped_95671()
		{
		}
	}

	private sealed class _N__N_lambda__95663__95689 : Function<Literal>
	{
		[SpecialName]
		private _N_closureOf_FoldTyped_95671 _N_FoldTyped_closure_95693;

		public _N__N_lambda__95663__95689(_N_closureOf_FoldTyped_95671 _N_FoldTyped_closure_95693)
		{
			this._N_FoldTyped_closure_95693 = _N_FoldTyped_closure_95693;
		}

		[SpecialName]
		public sealed override Literal apply()
		{
			return FoldLiterals(_N_FoldTyped_closure_95693._N_is_checked_95680, _N_FoldTyped_closure_95693._N_name_95682, _N_FoldTyped_closure_95693._N_l1_95678, _N_FoldTyped_closure_95693._N_l2_95676);
		}
	}

	private static readonly Hashtable<string, object> known_operators;

	private static readonly Hashtable<string, Nemerle.Builtins.Tuple<int, bool>> wide_rank;

	static ConstantFolder()
	{
		known_operators = new Hashtable<string, object>(new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("+", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("-", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("*", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("/", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("%", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("%^", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("%|", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("&", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("^", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("|", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("%&", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("&&", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("||", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("!", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>(">>", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("<<", null), new list<Nemerle.Builtins.Tuple<string, object>>.Cons(new Nemerle.Builtins.Tuple<string, object>("~", null), list<Nemerle.Builtins.Tuple<string, object>>.Nil._N_constant_object))))))))))))))))));
		wide_rank = new Hashtable<string, Nemerle.Builtins.Tuple<int, bool>>(new list<Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>>.Cons(new Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>("System.Byte", new Nemerle.Builtins.Tuple<int, bool>(1, field1: false)), new list<Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>>.Cons(new Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>("System.SByte", new Nemerle.Builtins.Tuple<int, bool>(1, field1: true)), new list<Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>>.Cons(new Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>("System.UInt16", new Nemerle.Builtins.Tuple<int, bool>(2, field1: false)), new list<Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>>.Cons(new Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>("System.Int16", new Nemerle.Builtins.Tuple<int, bool>(2, field1: true)), new list<Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>>.Cons(new Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>("System.UInt32", new Nemerle.Builtins.Tuple<int, bool>(3, field1: false)), new list<Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>>.Cons(new Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>("System.Int32", new Nemerle.Builtins.Tuple<int, bool>(3, field1: true)), new list<Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>>.Cons(new Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>("System.UInt64", new Nemerle.Builtins.Tuple<int, bool>(4, field1: false)), new list<Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>>.Cons(new Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>("System.Int64", new Nemerle.Builtins.Tuple<int, bool>(4, field1: true)), list<Nemerle.Builtins.Tuple<string, Nemerle.Builtins.Tuple<int, bool>>>.Nil._N_constant_object)))))))));
	}

	internal static bool is_known_operator(string name)
	{
		return known_operators.ContainsKey(name);
	}

	private static ulong UnsignedValue(Literal.Integer lit)
	{
		return (!lit.is_negative) ? lit.val : ((0L - lit.val) & MaxValueMask(lit.treat_as));
	}

	private static Literal.Integer CheckInteger(Literal.Integer l)
	{
		if (l.is_negative && l.val > 9223372036854775808uL)
		{
			Message.Error("the operation overflows at compile-time during constants folding in checked mode");
		}
		return l;
	}

	internal static Literal FoldLiterals(bool is_checked, string op, Literal lit1, Literal lit2)
	{
		object result;
		if (lit1 is Literal.Integer)
		{
			if (lit2 is Literal.Integer)
			{
				result = FoldLiterals(is_checked, op, (Literal.Integer)lit1, (Literal.Integer)lit2);
				goto IL_0093;
			}
		}
		else if (lit1 is Literal.String && lit2 is Literal.String)
		{
			string val = ((Literal.String)lit1).val;
			string val2 = ((Literal.String)lit2).val;
			if (op == "+")
			{
				result = new Literal.String(val + val2);
				goto IL_0093;
			}
		}
		result = null;
		goto IL_0093;
		IL_0093:
		return (Literal)result;
	}

	private static Literal.Integer CheckAndNormalizeInteger(Literal.Integer lit)
	{
		Literal.Integer integer = CheckInteger(lit);
		object result;
		if (null == integer.treat_as)
		{
			result = (Literal.Integer)integer.WithProperType();
		}
		else
		{
			ulong num = MaxSignedValueMask(integer.treat_as);
			option<Nemerle.Builtins.Tuple<int, bool>> option = wide_rank.Get(integer.treat_as.tycon.FullName);
			if (!(option is option<Nemerle.Builtins.Tuple<int, bool>>.Some))
			{
				throw new AssertionException("ncc\\typing\\ConstantFolder.n", 109, "", "");
			}
			bool field = ((option<Nemerle.Builtins.Tuple<int, bool>>.Some)option).val.Field1;
			field = field;
			result = (((!integer.is_negative || field) && (!integer.is_negative || integer.val <= num + 1) && (integer.is_negative || integer.val <= num)) ? integer : ((Literal.Integer)integer.WithProperType()));
		}
		return (Literal.Integer)result;
	}

	private static FixedType.Class SelectWideType(FixedType.Class a, FixedType.Class b)
	{
		option<Nemerle.Builtins.Tuple<int, bool>> option = null;
		option<Nemerle.Builtins.Tuple<int, bool>> option2 = null;
		object result;
		if ((object)a == null || (object)b == null)
		{
			result = null;
		}
		else
		{
			FixedType.Class @class = a;
			if (@class.Equals(b))
			{
				result = @class;
			}
			else
			{
				@class = a;
				option2 = wide_rank.Get(@class.tycon.FullName);
				option = wide_rank.Get(b.tycon.FullName);
				if (option2 is option<Nemerle.Builtins.Tuple<int, bool>>.Some && option is option<Nemerle.Builtins.Tuple<int, bool>>.Some)
				{
					int field = ((option<Nemerle.Builtins.Tuple<int, bool>>.Some)option2).val.Field0;
					bool field2 = ((option<Nemerle.Builtins.Tuple<int, bool>>.Some)option2).val.Field1;
					int field3 = ((option<Nemerle.Builtins.Tuple<int, bool>>.Some)option).val.Field0;
					bool field4 = ((option<Nemerle.Builtins.Tuple<int, bool>>.Some)option).val.Field1;
					FixedType.Class class2 = ((field <= field3) ? b : @class);
					result = ((field2 && field4) ? class2 : (field2 ? @class : ((!field4) ? class2 : b)));
				}
				else
				{
					result = null;
				}
			}
		}
		return (FixedType.Class)result;
	}

	internal static Literal.Integer FoldLiterals(bool is_checked, string op, Literal.Integer lit1, Literal.Integer lit2)
	{
		_N_closureOf_FoldLiterals_94920 n_closureOf_FoldLiterals_ = new _N_closureOf_FoldLiterals_94920();
		n_closureOf_FoldLiterals_._N_lit1_94931 = lit1;
		n_closureOf_FoldLiterals_._N_val1_94929 = n_closureOf_FoldLiterals_._N_lit1_94931.val;
		n_closureOf_FoldLiterals_._N_val2_94927 = lit2.val;
		ulong num = UnsignedValue(n_closureOf_FoldLiterals_._N_lit1_94931);
		ulong num2 = UnsignedValue(lit2);
		bool is_negative = (n_closureOf_FoldLiterals_._N_lit1_94931.is_negative || lit2.is_negative) && (!n_closureOf_FoldLiterals_._N_lit1_94931.is_negative || !lit2.is_negative);
		n_closureOf_FoldLiterals_._N_result_ty_94925 = SelectWideType(n_closureOf_FoldLiterals_._N_lit1_94931.treat_as, lit2.treat_as);
		checked
		{
			object obj;
			switch (op)
			{
			case "+":
				obj = ((!lit2.is_negative) ? ((!n_closureOf_FoldLiterals_._N_lit1_94931.is_negative) ? new Literal.Integer(n_closureOf_FoldLiterals_._N_val1_94929 + n_closureOf_FoldLiterals_._N_val2_94927, is_negative: false, n_closureOf_FoldLiterals_._N_result_ty_94925) : FoldLiterals(is_checked, "-", lit2, _N_positive_94933(n_closureOf_FoldLiterals_._N_lit1_94931))) : FoldLiterals(is_checked, "-", n_closureOf_FoldLiterals_._N_lit1_94931, _N_positive_94933(lit2)));
				break;
			case "-":
			{
				if (lit2.is_negative)
				{
					obj = FoldLiterals(is_checked, "+", n_closureOf_FoldLiterals_._N_lit1_94931, _N_positive_94933(lit2));
					break;
				}
				if (n_closureOf_FoldLiterals_._N_lit1_94931.is_negative)
				{
					obj = new Literal.Integer(n_closureOf_FoldLiterals_._N_val1_94929 + n_closureOf_FoldLiterals_._N_val2_94927, is_negative: true, n_closureOf_FoldLiterals_._N_result_ty_94925);
					break;
				}
				Function<Literal.Integer> f = new _N__N_lambda__94913__94971(n_closureOf_FoldLiterals_);
				obj = perform_check(is_checked, f);
				break;
			}
			case "*":
				num2 = n_closureOf_FoldLiterals_._N_val1_94929 * n_closureOf_FoldLiterals_._N_val2_94927;
				obj = new Literal.Integer(num2, is_negative, n_closureOf_FoldLiterals_._N_result_ty_94925);
				break;
			case "/":
				obj = new Literal.Integer(unchecked(n_closureOf_FoldLiterals_._N_val1_94929 / n_closureOf_FoldLiterals_._N_val2_94927), is_negative, n_closureOf_FoldLiterals_._N_lit1_94931.treat_as);
				break;
			case "%":
				obj = new Literal.Integer(unchecked(n_closureOf_FoldLiterals_._N_val1_94929 % n_closureOf_FoldLiterals_._N_val2_94927), is_negative, n_closureOf_FoldLiterals_._N_lit1_94931.treat_as);
				break;
			case "%^":
			case "^":
				obj = ConvertSignTo(num ^ num2, n_closureOf_FoldLiterals_._N_result_ty_94925);
				break;
			case "|":
			case "%|":
				obj = ConvertSignTo(num | num2, n_closureOf_FoldLiterals_._N_result_ty_94925);
				break;
			case "&":
			case "%&":
				obj = ConvertSignTo(num & num2, n_closureOf_FoldLiterals_._N_result_ty_94925);
				break;
			case ">>":
				obj = ConvertSignTo(num >> (int)(num2 & 0x3FuL), n_closureOf_FoldLiterals_._N_lit1_94931.treat_as);
				break;
			case "<<":
				obj = ConvertSignTo(num << (int)(num2 & 0x3FuL), n_closureOf_FoldLiterals_._N_lit1_94931.treat_as);
				break;
			default:
				obj = null;
				break;
			}
			Literal.Integer integer = (Literal.Integer)obj;
			return (integer == null) ? null : CheckAndNormalizeInteger(integer);
		}
	}

	private static ulong MaxValueMask(FixedType t)
	{
		long result;
		if (t.Equals(t.InternalType.SByte))
		{
			result = 255L;
		}
		else if (t.Equals(t.InternalType.Byte))
		{
			result = 255L;
		}
		else if (t.Equals(t.InternalType.Int16))
		{
			result = 65535L;
		}
		else if (t.Equals(t.InternalType.UInt16))
		{
			result = 65535L;
		}
		else if (t.Equals(t.InternalType.Int32))
		{
			result = 4294967295L;
		}
		else if (t.Equals(t.InternalType.UInt32))
		{
			result = 4294967295L;
		}
		else if (t.Equals(t.InternalType.Int64))
		{
			result = -1L;
		}
		else
		{
			if (!t.Equals(t.InternalType.UInt64))
			{
				throw new AssertionException("ncc\\typing\\ConstantFolder.n", 244, "", "");
			}
			result = -1L;
		}
		return (ulong)result;
	}

	private static ulong MaxSignedValueMask(FixedType t)
	{
		long result;
		if (t.Equals(t.InternalType.SByte))
		{
			result = 127L;
		}
		else if (t.Equals(t.InternalType.Byte))
		{
			result = 255L;
		}
		else if (t.Equals(t.InternalType.Int16))
		{
			result = 32767L;
		}
		else if (t.Equals(t.InternalType.UInt16))
		{
			result = 65535L;
		}
		else if (t.Equals(t.InternalType.Int32))
		{
			result = 2147483647L;
		}
		else if (t.Equals(t.InternalType.UInt32))
		{
			result = 4294967295L;
		}
		else if (t.Equals(t.InternalType.Int64))
		{
			result = long.MaxValue;
		}
		else
		{
			if (!t.Equals(t.InternalType.UInt64))
			{
				throw new AssertionException("ncc\\typing\\ConstantFolder.n", 265, "", "");
			}
			result = -1L;
		}
		return (ulong)result;
	}

	private static Literal.Integer ConvertSignTo(ulong val, FixedType.Class t)
	{
		bool flag = false;
		flag = false;
		long num;
		if (t.Equals(t.InternalType.SByte))
		{
			num = (sbyte)val;
		}
		else if (t.Equals(t.InternalType.Int16))
		{
			num = (short)val;
		}
		else if (t.Equals(t.InternalType.Int32))
		{
			num = (int)val;
		}
		else if (t.Equals(t.InternalType.Int64))
		{
			num = (long)val;
		}
		else
		{
			flag = true;
			num = 0L;
		}
		long num2 = num;
		object result;
		if (!flag)
		{
			result = ((num2 != long.MinValue) ? new Literal.Integer((ulong)Math.Abs(num2), num2 < 0, t) : new Literal.Integer(9223372036854775808uL, is_negative: true, t));
		}
		else
		{
			long num3;
			if (t.Equals(t.InternalType.Byte))
			{
				num3 = (byte)val;
			}
			else if (t.Equals(t.InternalType.UInt16))
			{
				num3 = (ushort)val;
			}
			else if (t.Equals(t.InternalType.UInt32))
			{
				num3 = (uint)val;
			}
			else
			{
				if (!t.Equals(t.InternalType.UInt64))
				{
					throw new AssertionException("ncc\\typing\\ConstantFolder.n", 296, "", "");
				}
				num3 = (long)val;
			}
			ulong val2 = (ulong)num3;
			result = new Literal.Integer(val2, is_negative: false, t);
		}
		return (Literal.Integer)result;
	}

	internal static Literal FoldLiteral(bool _is_checked, string op, Literal lit)
	{
		bool flag = op == "-";
		object result;
		if (lit is Literal.Float)
		{
			float val = ((Literal.Float)lit).val;
			if (!flag)
			{
				goto IL_00c6;
			}
			result = new Literal.Float(0f - val);
		}
		else if (lit is Literal.Double)
		{
			double val2 = ((Literal.Double)lit).val;
			if (!flag)
			{
				goto IL_00c6;
			}
			result = new Literal.Double(0.0 - val2);
		}
		else if (lit is Literal.Decimal)
		{
			decimal val3 = ((Literal.Decimal)lit).val;
			if (!flag)
			{
				goto IL_00c6;
			}
			result = new Literal.Decimal(-val3);
		}
		else
		{
			if (!(lit is Literal.Integer))
			{
				goto IL_00c6;
			}
			result = FoldLiteral(_is_checked, op, (Literal.Integer)lit);
		}
		goto IL_00c7;
		IL_00c7:
		return (Literal)result;
		IL_00c6:
		result = lit;
		goto IL_00c7;
	}

	internal static Literal.Integer FoldLiteral(bool _is_checked, string op, Literal.Integer lit)
	{
		object result;
		switch (op)
		{
		case "-":
			result = CheckAndNormalizeInteger(new Literal.Integer(lit.val, !lit.is_negative, lit.treat_as));
			break;
		case "~":
		{
			FixedType.Class treat_as = lit.treat_as;
			ulong val = lit.val;
			if (MaxSignedValueMask(treat_as) == MaxValueMask(treat_as))
			{
				if (lit.is_negative)
				{
					throw new AssertionException("ncc\\typing\\ConstantFolder.n", 332, "!lit.is_negative", "");
				}
				result = CheckInteger(new Literal.Integer(~val & MaxValueMask(treat_as), is_negative: false, treat_as));
			}
			else
			{
				val = ((!lit.is_negative) ? (val + 1) : (val - 1));
				result = CheckInteger(new Literal.Integer(val & MaxValueMask(treat_as), !lit.is_negative, treat_as));
			}
			break;
		}
		case "+":
			result = lit;
			break;
		default:
			result = null;
			break;
		}
		return (Literal.Integer)result;
	}

	private static void emit_flag_warning(TypeInfo t)
	{
		TypeDeclaration tydecl = t.GetTydecl();
		if (tydecl is TypeDeclaration.Enum && !t.HasAttribute(t.InternalType.FlagsAttribute_tc))
		{
			Message.Warning(10004, string.Concat("using bitwise operator on enum type `" + Convert.ToString(t) + "' ", "that hasn't got [Flags] attribute"));
		}
	}

	internal static option<Literal> FieldValueAsLiteral(IField field, bool triggerObsoleteWarn)
	{
		TypeInfo declaringType = field.DeclaringType;
		TypeDeclaration tydecl = declaringType.GetTydecl();
		option<TypeInfo> option = ((tydecl != TypeDeclaration.Enum._N_constant_object) ? ((option<TypeInfo>)option<TypeInfo>.None._N_constant_object) : ((option<TypeInfo>)new option<TypeInfo>.Some(declaringType)));
		Literal value = field.GetValue();
		declaringType.Manager.MarkAsUsed(field, triggerObsoleteWarn);
		option<Literal>.Some result;
		if (option is option<TypeInfo>.Some)
		{
			declaringType = ((option<TypeInfo>.Some)option).val;
			if (!(value is Literal.Enum))
			{
				result = new option<Literal>.Some(new Literal.Enum((Literal.Integer)value, declaringType, field));
				goto IL_0090;
			}
		}
		result = new option<Literal>.Some(value);
		goto IL_0090;
		IL_0090:
		return result;
	}

	internal static Literal FieldValueAsPureLiteral(IField field, bool triggerObsoleteWarn)
	{
		TypeInfo declaringType = field.DeclaringType;
		declaringType.Manager.MarkAsUsed(field, triggerObsoleteWarn);
		return field.GetValue();
	}

	private static PExpr literal_field_value(GlobalEnv env, TypeBuilder tb, PExpr expr, bool triggerObsoleteWarn)
	{
		option<Nemerle.Builtins.Tuple<list<string>, Name>> option = Util.QidOfExpr(expr);
		object result;
		if (option is option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)
		{
			list<string> field = ((option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)option).val.Field0;
			Name field2 = ((option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)option).val.Field1;
			list<IMember> list = field2.GetEnv(env).LookupSymbol(field, tb);
			if (list is list<IMember>.Cons && ((list<IMember>.Cons)list).hd is IField)
			{
				IField field3 = (IField)((list<IMember>.Cons)list).hd;
				if ((object)((list<IMember>.Cons)list).tl == list<IMember>.Nil._N_constant_object && field3.IsLiteral)
				{
					option<Literal> option2 = FieldValueAsLiteral(field3, triggerObsoleteWarn);
					if (option2 == option<Literal>.None._N_constant_object)
					{
						result = expr;
					}
					else
					{
						if (!(option2 is option<Literal>.Some))
						{
							throw new MatchFailureException();
						}
						Literal val = ((option<Literal>.Some)option2).val;
						result = new PExpr.Literal(expr.Location, val);
					}
					goto IL_011c;
				}
			}
			result = expr;
		}
		else
		{
			if (option != option<Nemerle.Builtins.Tuple<list<string>, Name>>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = expr;
		}
		goto IL_011c;
		IL_011c:
		return (PExpr)result;
	}

	private static Literal get_literal(TExpr expr)
	{
		object result;
		if (expr is TExpr.Literal)
		{
			Literal val = ((TExpr.Literal)expr).val;
			result = ((!(val is Literal.Integer) && !(val is Literal.String)) ? null : val);
		}
		else
		{
			if (expr is TExpr.TypeConversion)
			{
				TExpr expr2 = ((TExpr.TypeConversion)expr).expr;
				TypeVar target_type = ((TExpr.TypeConversion)expr).target_type;
				if (target_type.IsFixed)
				{
					Literal val = get_literal(expr2);
					if (val is Literal.Integer)
					{
						option<Literal.Integer> option = convert_integer_literal((Literal.Integer)val, target_type.FixedValue.TypeInfo.FullName);
						if (option is option<Literal.Integer>.Some)
						{
							Literal.Integer val2 = ((option<Literal.Integer>.Some)option).val;
							result = val2;
						}
						else
						{
							result = null;
						}
					}
					else
					{
						result = null;
					}
					goto IL_00ca;
				}
			}
			result = null;
		}
		goto IL_00ca;
		IL_00ca:
		return (Literal)result;
	}

	private static option<Literal> literal_of_expr(PExpr e)
	{
		object result;
		if (e is PExpr.Literal)
		{
			Literal val = ((PExpr.Literal)e).val;
			result = new option<Literal>.Some(val);
		}
		else if (e is PExpr.Typed && ((PExpr.Typed)e).body is TExpr.Literal)
		{
			Literal val = ((TExpr.Literal)((PExpr.Typed)e).body).val;
			result = new option<Literal>.Some(val);
		}
		else
		{
			result = option<Literal>.None._N_constant_object;
		}
		return (option<Literal>)result;
	}

	private static PExpr fold_unary_operator(bool is_checked, string name, PExpr e1, PExpr expr)
	{
		option<Literal> option = literal_of_expr(e1);
		object result;
		Literal val2;
		if (option is option<Literal>.Some)
		{
			if (((option<Literal>.Some)option).val is Literal.Enum)
			{
				Literal.Integer val = ((Literal.Enum)((option<Literal>.Some)option).val).val;
				TypeInfo ty = ((Literal.Enum)((option<Literal>.Some)option).val).ty;
				IField field = ((Literal.Enum)((option<Literal>.Some)option).val).field;
				if (name == "~")
				{
					emit_flag_warning(ty);
					val = FoldLiteral(is_checked, name, val);
					result = new PExpr.Literal(expr.Location, new Literal.Enum(val, ty, field));
					goto IL_0112;
				}
				val2 = ((option<Literal>.Some)option).val;
				if (is_known_operator(name))
				{
					goto IL_00b8;
				}
			}
			else
			{
				val2 = ((option<Literal>.Some)option).val;
				if (is_known_operator(name))
				{
					goto IL_00b8;
				}
			}
		}
		result = expr;
		goto IL_0112;
		IL_0112:
		return (PExpr)result;
		IL_00b8:
		Literal literal = FoldLiteral(is_checked, name, val2);
		result = ((literal == val2) ? expr : new PExpr.Literal(expr.Location, literal));
		goto IL_0112;
	}

	private static PExpr fold_binary_operator(bool is_checked, string name, PExpr e1, PExpr e2, PExpr expr)
	{
		option<Literal> option = null;
		option<Literal> option2 = null;
		option2 = literal_of_expr(e1);
		option = literal_of_expr(e2);
		Nemerle.Builtins.Tuple<Literal, Literal, option<TypeInfo>> tuple;
		Literal val2;
		Literal val;
		if (option2 is option<Literal>.Some && option is option<Literal>.Some)
		{
			val = ((option<Literal>.Some)option2).val;
			val2 = ((option<Literal>.Some)option).val;
			if (val is Literal.Enum && val2 is Literal.Enum)
			{
				Literal field = ((Literal.Enum)val).val;
				TypeInfo ty = ((Literal.Enum)val).ty;
				Literal field2 = ((Literal.Enum)val2).val;
				TypeInfo ty2 = ((Literal.Enum)val2).ty;
				if (ty.Equals(ty2))
				{
					tuple = new Nemerle.Builtins.Tuple<Literal, Literal, option<TypeInfo>>(field, field2, new option<TypeInfo>.Some(ty));
					goto IL_00db;
				}
			}
			tuple = new Nemerle.Builtins.Tuple<Literal, Literal, option<TypeInfo>>(val, val2, option<TypeInfo>.None._N_constant_object);
			goto IL_00db;
		}
		object result = expr;
		goto IL_025a;
		IL_00db:
		Nemerle.Builtins.Tuple<Literal, Literal, option<TypeInfo>> tuple2 = tuple;
		val2 = tuple2.Field0;
		val = tuple2.Field1;
		option<TypeInfo> option3 = tuple2.Field2;
		val = FoldLiterals(is_checked, name, val2, val);
		if (val == null)
		{
			result = expr;
		}
		else if (option3 == option<TypeInfo>.None._N_constant_object)
		{
			result = new PExpr.Literal(expr.Location, val);
		}
		else
		{
			if (!(option3 is option<TypeInfo>.Some))
			{
				throw new MatchFailureException();
			}
			TypeInfo ty;
			switch (name)
			{
			case "|":
				ty = ((option<TypeInfo>.Some)option3).val;
				goto IL_015d;
			case "&":
				ty = ((option<TypeInfo>.Some)option3).val;
				goto IL_015d;
			case "^":
				ty = ((option<TypeInfo>.Some)option3).val;
				goto IL_015d;
			case "%|":
				ty = ((option<TypeInfo>.Some)option3).val;
				goto IL_015d;
			case "%&":
				ty = ((option<TypeInfo>.Some)option3).val;
				goto IL_015d;
			case "%^":
				ty = ((option<TypeInfo>.Some)option3).val;
				goto IL_015d;
			default:
				{
					result = expr;
					break;
				}
				IL_015d:
				emit_flag_warning(ty);
				val = ((!(val is Literal.Enum)) ? new Literal.Enum((Literal.Integer)val, ty, null) : val);
				result = new PExpr.Literal(expr.Location, val);
				break;
			}
		}
		goto IL_025a;
		IL_025a:
		return (PExpr)result;
	}

	public static option<Literal> ConvertLiteral(Literal lit, FixedType targetType)
	{
		string target = null;
		object result;
		if (lit is Literal.Integer)
		{
			Literal.Integer lit2 = (Literal.Integer)lit;
			TypeInfo typeInfo = targetType.TypeInfo;
			if (typeInfo != null)
			{
				target = typeInfo.FullName;
			}
			option<Literal.Integer> option = convert_integer_literal(lit2, target);
			if (option is option<Literal.Integer>.Some)
			{
				Literal.Integer val = ((option<Literal.Integer>.Some)option).val;
				result = new option<Literal>.Some(val);
			}
			else
			{
				result = option<Literal>.None._N_constant_object;
			}
		}
		else
		{
			result = option<Literal>.None._N_constant_object;
		}
		return (option<Literal>)result;
	}

	private static option<Literal.Integer> convert_integer_literal(Literal.Integer lit, string target)
	{
		_N_closureOf_convert_integer_literal_95330 n_closureOf_convert_integer_literal_ = new _N_closureOf_convert_integer_literal_95330();
		n_closureOf_convert_integer_literal_._N_lit_95337 = lit;
		n_closureOf_convert_integer_literal_._N_target_95335 = target;
		object result;
		if (n_closureOf_convert_integer_literal_._N_target_95335 == "Nemerle.Core.sbyte" || n_closureOf_convert_integer_literal_._N_target_95335 == "System.SByte")
		{
			option<sbyte> asSByte = n_closureOf_convert_integer_literal_._N_lit_95337.AsSByte;
			if (asSByte is option<sbyte>.Some)
			{
				sbyte val = ((option<sbyte>.Some)asSByte).val;
				result = Function<Literal.Integer, option<Literal.Integer>.Some>._007C_003E(Literal.FromSByte(val), _N_static_proxy_95361.single_instance);
			}
			else
			{
				result = _N_report_conversion_failure_95340(n_closureOf_convert_integer_literal_);
			}
		}
		else if (n_closureOf_convert_integer_literal_._N_target_95335 == "Nemerle.Core.byte" || n_closureOf_convert_integer_literal_._N_target_95335 == "System.Byte")
		{
			option<byte> asByte = n_closureOf_convert_integer_literal_._N_lit_95337.AsByte;
			if (asByte is option<byte>.Some)
			{
				byte val2 = ((option<byte>.Some)asByte).val;
				result = Function<Literal.Integer, option<Literal.Integer>.Some>._007C_003E(Literal.FromByte(val2), _N_static_proxy_95376.single_instance);
			}
			else
			{
				result = _N_report_conversion_failure_95340(n_closureOf_convert_integer_literal_);
			}
		}
		else if (n_closureOf_convert_integer_literal_._N_target_95335 == "Nemerle.Core.short" || n_closureOf_convert_integer_literal_._N_target_95335 == "System.Int16")
		{
			option<short> asShort = n_closureOf_convert_integer_literal_._N_lit_95337.AsShort;
			if (asShort is option<short>.Some)
			{
				short val3 = ((option<short>.Some)asShort).val;
				result = Function<Literal.Integer, option<Literal.Integer>.Some>._007C_003E(Literal.FromShort(val3), _N_static_proxy_95391.single_instance);
			}
			else
			{
				result = _N_report_conversion_failure_95340(n_closureOf_convert_integer_literal_);
			}
		}
		else if (n_closureOf_convert_integer_literal_._N_target_95335 == "Nemerle.Core.ushort" || n_closureOf_convert_integer_literal_._N_target_95335 == "System.UInt16")
		{
			option<ushort> asUShort = n_closureOf_convert_integer_literal_._N_lit_95337.AsUShort;
			if (asUShort is option<ushort>.Some)
			{
				ushort val4 = ((option<ushort>.Some)asUShort).val;
				result = Function<Literal.Integer, option<Literal.Integer>.Some>._007C_003E(Literal.FromUShort(val4), _N_static_proxy_95406.single_instance);
			}
			else
			{
				result = _N_report_conversion_failure_95340(n_closureOf_convert_integer_literal_);
			}
		}
		else if (n_closureOf_convert_integer_literal_._N_target_95335 == "Nemerle.Core.int" || n_closureOf_convert_integer_literal_._N_target_95335 == "System.Int32")
		{
			option<int> asInt = n_closureOf_convert_integer_literal_._N_lit_95337.AsInt;
			if (asInt is option<int>.Some)
			{
				int val5 = ((option<int>.Some)asInt).val;
				result = Function<Literal.Integer, option<Literal.Integer>.Some>._007C_003E(Literal.FromInt(val5), _N_static_proxy_95421.single_instance);
			}
			else
			{
				result = _N_report_conversion_failure_95340(n_closureOf_convert_integer_literal_);
			}
		}
		else if (n_closureOf_convert_integer_literal_._N_target_95335 == "Nemerle.Core.uint" || n_closureOf_convert_integer_literal_._N_target_95335 == "System.UInt32")
		{
			option<uint> asUInt = n_closureOf_convert_integer_literal_._N_lit_95337.AsUInt;
			if (asUInt is option<uint>.Some)
			{
				uint val6 = ((option<uint>.Some)asUInt).val;
				result = Function<Literal.Integer, option<Literal.Integer>.Some>._007C_003E(Literal.FromUInt(val6), _N_static_proxy_95436.single_instance);
			}
			else
			{
				result = _N_report_conversion_failure_95340(n_closureOf_convert_integer_literal_);
			}
		}
		else if (n_closureOf_convert_integer_literal_._N_target_95335 == "Nemerle.Core.long" || n_closureOf_convert_integer_literal_._N_target_95335 == "System.Int64")
		{
			option<long> asLong = n_closureOf_convert_integer_literal_._N_lit_95337.AsLong;
			if (asLong is option<long>.Some)
			{
				long val7 = ((option<long>.Some)asLong).val;
				result = Function<Literal.Integer, option<Literal.Integer>.Some>._007C_003E(Literal.FromLong(val7), _N_static_proxy_95451.single_instance);
			}
			else
			{
				result = _N_report_conversion_failure_95340(n_closureOf_convert_integer_literal_);
			}
		}
		else if (n_closureOf_convert_integer_literal_._N_target_95335 == "Nemerle.Core.ulong" || n_closureOf_convert_integer_literal_._N_target_95335 == "System.UInt64")
		{
			option<ulong> asULong = n_closureOf_convert_integer_literal_._N_lit_95337.AsULong;
			if (asULong is option<ulong>.Some)
			{
				ulong val8 = ((option<ulong>.Some)asULong).val;
				result = Function<Literal.Integer, option<Literal.Integer>.Some>._007C_003E(Literal.FromULong(val8), _N_static_proxy_95466.single_instance);
			}
			else
			{
				result = _N_report_conversion_failure_95340(n_closureOf_convert_integer_literal_);
			}
		}
		else
		{
			result = option<Literal.Integer>.None._N_constant_object;
		}
		return (option<Literal.Integer>)result;
	}

	private static option<PExpr> fold_type_conversion(GlobalEnv env, PExpr e, PExpr t)
	{
		_N_closureOf_fold_type_conversion_95490 n_closureOf_fold_type_conversion_ = new _N_closureOf_fold_type_conversion_95490();
		n_closureOf_fold_type_conversion_._N_env_95497 = env;
		n_closureOf_fold_type_conversion_._N_t_95495 = t;
		object result;
		if (e is PExpr.Literal)
		{
			if (((PExpr.Literal)e).val is Literal.Double)
			{
				Literal.Double @double = (Literal.Double)((PExpr.Literal)e).val;
				option<TypeInfo> option = _N_lookup_type_95500(n_closureOf_fold_type_conversion_);
				if (option is option<TypeInfo>.Some)
				{
					TypeInfo val = ((option<TypeInfo>.Some)option).val;
					if (val.FullName == "Nemerle.Core.float" && (double)(float)@double.val == @double.val)
					{
						result = new option<PExpr>.Some(new PExpr.Literal(e.Location, new Literal.Float((float)@double.val)));
						goto IL_016e;
					}
				}
				result = option<PExpr>.None._N_constant_object;
			}
			else
			{
				if (!(((PExpr.Literal)e).val is Literal.Integer))
				{
					goto IL_0162;
				}
				Literal.Integer lit = (Literal.Integer)((PExpr.Literal)e).val;
				option<TypeInfo> option = _N_lookup_type_95500(n_closureOf_fold_type_conversion_);
				if (option is option<TypeInfo>.Some)
				{
					TypeInfo val = ((option<TypeInfo>.Some)option).val;
					option<Literal.Integer> option2 = convert_integer_literal(lit, val.FullName);
					if (option2 is option<Literal.Integer>.Some)
					{
						lit = ((option<Literal.Integer>.Some)option2).val;
						result = Function<PExpr, option<PExpr>.Some>._007C_003E(new PExpr.Literal(e.Location, lit), _N_static_proxy_95529.single_instance);
					}
					else
					{
						result = option<PExpr>.None._N_constant_object;
					}
				}
				else
				{
					result = option<PExpr>.None._N_constant_object;
				}
			}
			goto IL_016e;
		}
		goto IL_0162;
		IL_016e:
		return (option<PExpr>)result;
		IL_0162:
		result = option<PExpr>.None._N_constant_object;
		goto IL_016e;
	}

	private static PExpr fold_constants(bool is_checked, GlobalEnv env, TypeBuilder tb, PExpr expr, bool triggerObsoleteWarn, bool recurse)
	{
		try
		{
			object result;
			if (!(expr is PExpr.Ref))
			{
				if (!(expr is PExpr.Member))
				{
					if (expr is PExpr.Call)
					{
						if (((PExpr.Call)expr).func is PExpr.Ref && ((PExpr.Call)expr).parms is list<PExpr>.Cons)
						{
							string idl = ((PExpr.Ref)((PExpr.Call)expr).func).name.idl;
							if (((list<PExpr>.Cons)((PExpr.Call)expr).parms).tl is list<PExpr>.Cons)
							{
								PExpr hd = ((list<PExpr>.Cons)((PExpr.Call)expr).parms).hd;
								if ((object)((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)expr).parms).tl).tl == list<PExpr>.Nil._N_constant_object)
								{
									PExpr hd2 = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)expr).parms).tl).hd;
									if (is_known_operator(idl))
									{
										result = ((!recurse) ? fold_binary_operator(is_checked, idl, hd, hd2, expr) : fold_binary_operator(is_checked, idl, fold_constants(is_checked, env, tb, hd, triggerObsoleteWarn, recurse: true), fold_constants(is_checked, env, tb, hd2, triggerObsoleteWarn, recurse: true), expr));
										goto IL_0312;
									}
								}
							}
							else if ((object)((list<PExpr>.Cons)((PExpr.Call)expr).parms).tl == list<PExpr>.Nil._N_constant_object)
							{
								string idl2 = ((PExpr.Ref)((PExpr.Call)expr).func).name.idl;
								PExpr hd3 = ((list<PExpr>.Cons)((PExpr.Call)expr).parms).hd;
								if (is_known_operator(idl2))
								{
									result = ((!recurse) ? fold_unary_operator(is_checked, idl2, hd3, expr) : fold_unary_operator(is_checked, idl2, fold_constants(is_checked, env, tb, hd3, triggerObsoleteWarn, recurse: true), expr));
									goto IL_0312;
								}
							}
						}
						goto IL_0311;
					}
					if (expr is PExpr.TypeConversion)
					{
						PExpr expr2 = ((PExpr.TypeConversion)expr).expr;
						PExpr ty = ((PExpr.TypeConversion)expr).ty;
						PExpr pExpr = fold_constants(is_checked, env, tb, expr2, triggerObsoleteWarn, recurse);
						option<PExpr> option = fold_type_conversion(env, pExpr, ty);
						if (option is option<PExpr>.Some)
						{
							PExpr val = ((option<PExpr>.Some)option).val;
							result = val;
						}
						else
						{
							result = new PExpr.TypeConversion(expr.Location, pExpr, ty);
						}
					}
					else
					{
						if (!(expr is PExpr.TypeEnforcement))
						{
							goto IL_0311;
						}
						PExpr expr3 = ((PExpr.TypeEnforcement)expr).expr;
						PExpr ty2 = ((PExpr.TypeEnforcement)expr).ty;
						PExpr pExpr2 = fold_constants(is_checked, env, tb, expr3, triggerObsoleteWarn, recurse);
						option<PExpr> option2 = fold_type_conversion(env, pExpr2, ty2);
						if (option2 is option<PExpr>.Some)
						{
							PExpr val2 = ((option<PExpr>.Some)option2).val;
							result = val2;
						}
						else
						{
							result = new PExpr.TypeEnforcement(expr.Location, pExpr2, ty2);
						}
					}
					goto IL_0312;
				}
				PExpr obj = ((PExpr.Member)expr).obj;
				Splicable member = ((PExpr.Member)expr).member;
			}
			result = literal_field_value(env, tb, expr, triggerObsoleteWarn);
			goto IL_0312;
			IL_0311:
			result = expr;
			goto IL_0312;
			IL_0312:
			return (PExpr)result;
		}
		catch (DivideByZeroException)
		{
			Message.Error("division by zero during constants folding");
			return null;
		}
		catch (OverflowException)
		{
			if (is_checked)
			{
				Message.Error("the operation overflows at compile-time during constants folding in checked mode");
				return null;
			}
			if (!Message.SeenError)
			{
				string text = "overflow exception".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\typing\\ConstantFolder.n", 645, "", "overflow exception");
		}
	}

	private static _0027a perform_check<_0027a>(bool is_checked, Function<_0027a> f) where _0027a : class
	{
		try
		{
			return f.apply();
		}
		catch (DivideByZeroException)
		{
			Message.Error("division by zero during constants folding");
			return null;
		}
		catch (OverflowException)
		{
			if (is_checked)
			{
				Message.Error("the operation overflows at compile-time during constants folding in checked mode");
				return null;
			}
			if (!Message.SeenError)
			{
				string text = "overflow exception".ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\typing\\ConstantFolder.n", 666, "", "overflow exception");
		}
	}

	public static TExpr FoldTyped(string name, TExpr p, bool is_checked)
	{
		_N_closureOf_FoldTyped_95628 n_closureOf_FoldTyped_ = new _N_closureOf_FoldTyped_95628();
		n_closureOf_FoldTyped_._N_name_95637 = name;
		n_closureOf_FoldTyped_._N_is_checked_95635 = is_checked;
		Literal literal = get_literal(p);
		object result;
		if (literal is Literal.Integer)
		{
			n_closureOf_FoldTyped_._N_lit_95633 = (Literal.Integer)literal;
			bool n_is_checked_ = n_closureOf_FoldTyped_._N_is_checked_95635;
			Function<Literal.Integer> f = new _N__N_lambda__95622__95644(n_closureOf_FoldTyped_);
			Literal.Integer integer = perform_check(n_is_checked_, f);
			result = ((integer != null) ? new TExpr.Literal(integer.treat_as, integer) : null);
		}
		else
		{
			result = null;
		}
		return (TExpr)result;
	}

	public static TExpr FoldTyped(string name, TExpr p1, TExpr p2, bool is_checked)
	{
		Literal literal = null;
		_N_closureOf_FoldTyped_95671 n_closureOf_FoldTyped_ = new _N_closureOf_FoldTyped_95671();
		n_closureOf_FoldTyped_._N_name_95682 = name;
		n_closureOf_FoldTyped_._N_is_checked_95680 = is_checked;
		Literal literal2 = get_literal(p1);
		literal = get_literal(p2);
		object result;
		if ((object)literal2 == null || (object)literal == null)
		{
			result = null;
		}
		else
		{
			n_closureOf_FoldTyped_._N_l1_95678 = literal2;
			n_closureOf_FoldTyped_._N_l2_95676 = literal;
			bool n_is_checked_ = n_closureOf_FoldTyped_._N_is_checked_95680;
			Function<Literal> f = new _N__N_lambda__95663__95689(n_closureOf_FoldTyped_);
			literal2 = perform_check(n_is_checked_, f);
			if (literal2 == null)
			{
				result = null;
			}
			else
			{
				object obj;
				if (literal2 is Literal.Integer)
				{
					FixedType.Class treat_as = ((Literal.Integer)literal2).treat_as;
					obj = treat_as;
				}
				else
				{
					obj = p1.Type;
				}
				TypeVar ty = (TypeVar)obj;
				result = new TExpr.Literal(ty, literal2);
			}
		}
		return (TExpr)result;
	}

	public static PExpr FoldConstants(Typer typer, PExpr expr)
	{
		return fold_constants(is_checked: false, typer.Env, typer.CurrentTypeBuilder, expr, typer.TriggerObsoleteWarning, recurse: true);
	}

	public static PExpr FoldConstants(GlobalEnv env, PExpr expr, TypeBuilder tb = null)
	{
		return fold_constants(is_checked: false, env, tb, expr, triggerObsoleteWarn: true, recurse: true);
	}

	public static PExpr FoldConstants(TypeBuilder tb, PExpr expr)
	{
		return fold_constants(is_checked: false, tb.GlobalEnv, tb, expr, triggerObsoleteWarn: true, recurse: true);
	}

	private static Literal.Integer _N_positive_94933(Literal.Integer lit)
	{
		return new Literal.Integer(lit.val, is_negative: false, lit.treat_as);
	}

	private static option<Literal.Integer>.None _N_report_conversion_failure_95340(_N_closureOf_convert_integer_literal_95330 _N_convert_integer_literal_cp_95339)
	{
		Message.Error("value `" + Convert.ToString(_N_convert_integer_literal_cp_95339._N_lit_95337) + "' can't be converted to `" + Convert.ToString(_N_convert_integer_literal_cp_95339._N_target_95335) + "'");
		return option<Literal.Integer>.None._N_constant_object;
	}

	private static option<TypeInfo> _N_lookup_type_95500(_N_closureOf_fold_type_conversion_95490 _N_fold_type_conversion_cp_95499)
	{
		list<string> name = NList.ToList(_N_fold_type_conversion_cp_95499._N_t_95495.ToString().Split('.'));
		return _N_fold_type_conversion_cp_95499._N_env_95497.LookupType(name);
	}
}
