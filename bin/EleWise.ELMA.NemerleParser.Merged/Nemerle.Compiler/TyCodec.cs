using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

internal static class TyCodec
{
	[Variant("Nemerle.Compiler.TyCodec.Term.App")]
	private abstract class Term : ISupportRelocation
	{
		[VariantOption]
		public class App : Term
		{
			public readonly string name;

			public readonly list<Term> args;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			public App([MappedMember("name")] string name, [MappedMember("args")] list<Term> args)
			{
				this.name = name;
				this.args = args;
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
				list<Term> list = args;
				if (list != null)
				{
					list = list;
					while (list is list<Term>.Cons)
					{
						Term hd = ((list<Term>.Cons)list).hd;
						list = ((list<Term>.Cons)list).tl;
						((ISupportRelocation)hd).RelocateImpl(_info);
						list = list;
					}
				}
			}
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(Term x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is Term)) ? (-1) : ((Term)x)._N_GetVariantCode();
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

	private sealed class _N_closureOf_ParseTerm_52456
	{
		internal string _N_s_52461;

		internal _N_closureOf_ParseTerm_52456()
		{
		}
	}

	private sealed class _N_closureOf_decode_52539
	{
		internal LibraryReference _N_lib_52546;

		internal Map<string, StaticTypeVar> _N_tenv_52544;

		internal _N_closureOf_decode_52539()
		{
		}
	}

	private sealed class _N_self__52548 : Function<Term, TypeVar>
	{
		[SpecialName]
		private _N_closureOf_decode_52539 _N_decode_closure_52552;

		public _N_self__52548(_N_closureOf_decode_52539 _N_decode_closure_52552)
		{
			this._N_decode_closure_52552 = _N_decode_closure_52552;
		}

		[SpecialName]
		public sealed override TypeVar apply(Term t)
		{
			return decode(_N_decode_closure_52552._N_lib_52546, _N_decode_closure_52552._N_tenv_52544, t);
		}
	}

	private sealed class _N_closureOf_ReflectConstraints_52633
	{
		internal LibraryReference _N__lib_52644;

		internal Map<string, StaticTypeVar> _N_tenv_52642;

		internal Type _N_sys_type_52640;

		internal FixedType _N_self_type_52638;

		internal _N_closureOf_ReflectConstraints_52633()
		{
		}
	}

	private sealed class _N_set_constraints__52646 : FunctionVoid<Type, StaticTypeVar>
	{
		[SpecialName]
		private _N_closureOf_ReflectConstraints_52633 _N_ReflectConstraints_closure_52650;

		public _N_set_constraints__52646(_N_closureOf_ReflectConstraints_52633 _N_ReflectConstraints_closure_52650)
		{
			this._N_ReflectConstraints_closure_52650 = _N_ReflectConstraints_closure_52650;
		}

		[SpecialName]
		public sealed override void apply_void(Type t, StaticTypeVar tv)
		{
			Type[] genericParameterConstraints = t.GetGenericParameterConstraints();
			GenericParameterAttributes genericParameterAttributes = t.GenericParameterAttributes;
			Function<Type, FixedType> f = new _N__N_lambda__52627__52655(_N_ReflectConstraints_closure_52650);
			tv.SetConstraints(genericParameterAttributes, NList.MapFromArray(genericParameterConstraints, f));
		}
	}

	private sealed class _N__N_lambda__52627__52655 : Function<Type, FixedType>
	{
		[SpecialName]
		private _N_closureOf_ReflectConstraints_52633 _N_ReflectConstraints_closure_52659;

		public _N__N_lambda__52627__52655(_N_closureOf_ReflectConstraints_52633 _N_ReflectConstraints_closure_52659)
		{
			this._N_ReflectConstraints_closure_52659 = _N_ReflectConstraints_closure_52659;
		}

		[SpecialName]
		public sealed override FixedType apply(Type t)
		{
			return (!t.Equals(_N_ReflectConstraints_closure_52659._N_sys_type_52640)) ? _N_ReflectConstraints_closure_52659._N__lib_52644.TypeOfType(_N_ReflectConstraints_closure_52659._N_tenv_52642, t) : _N_ReflectConstraints_closure_52659._N_self_type_52638;
		}
	}

	private sealed class _N_closureOf_ReflectTypeBuilder_52722
	{
		internal LibraryReference _N_lib_52733;

		internal Map<string, StaticTypeVar> _N_tenv_52731;

		internal list<FixedType.Class> _N_st_52729;

		internal list<FixedType.Class> _N_st_unique_52727;

		internal _N_closureOf_ReflectTypeBuilder_52722()
		{
		}
	}

	private sealed class _N__N_lambda__52683__52749 : Function<Type, TypeVar>
	{
		[SpecialName]
		private _N_closureOf_ReflectTypeBuilder_52722 _N_ReflectTypeBuilder_closure_52753;

		public _N__N_lambda__52683__52749(_N_closureOf_ReflectTypeBuilder_52722 _N_ReflectTypeBuilder_closure_52753)
		{
			this._N_ReflectTypeBuilder_closure_52753 = _N_ReflectTypeBuilder_closure_52753;
		}

		[SpecialName]
		public sealed override TypeVar apply(Type x)
		{
			return _N_ReflectTypeBuilder_closure_52753._N_lib_52733.TypeOfType(_N_ReflectTypeBuilder_closure_52753._N_tenv_52731, x);
		}
	}

	private sealed class _N__N_lambda__52690__52758 : Function<Type, Type, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__52690__52758 Instance = new _N__N_lambda__52690__52758();

		[SpecialName]
		public sealed override bool apply(Type t1, Type t2)
		{
			return t2.IsAssignableFrom(t1);
		}
	}

	private sealed class _N_closureOf_ReflectTyparms_52826
	{
		internal LibraryReference _N_lib_52833;

		internal Map<string, StaticTypeVar> _N_tenv_52831;

		internal _N_closureOf_ReflectTyparms_52826()
		{
		}
	}

	private sealed class _N_set_constraints__52846 : FunctionVoid<Type, StaticTypeVar>
	{
		[SpecialName]
		private _N_closureOf_ReflectTyparms_52826 _N_ReflectTyparms_closure_52850;

		public _N_set_constraints__52846(_N_closureOf_ReflectTyparms_52826 _N_ReflectTyparms_closure_52850)
		{
			this._N_ReflectTyparms_closure_52850 = _N_ReflectTyparms_closure_52850;
		}

		[SpecialName]
		public sealed override void apply_void(Type t, StaticTypeVar tv)
		{
			Type[] genericParameterConstraints = t.GetGenericParameterConstraints();
			GenericParameterAttributes genericParameterAttributes = t.GenericParameterAttributes;
			Function<Type, FixedType> convert = new _N__N_lambda__52820__52855(_N_ReflectTyparms_closure_52850);
			tv.SetConstraints(genericParameterAttributes, ((IEnumerable<Type>)genericParameterConstraints).Map(convert));
		}
	}

	private sealed class _N__N_lambda__52820__52855 : Function<Type, FixedType>
	{
		[SpecialName]
		private _N_closureOf_ReflectTyparms_52826 _N_ReflectTyparms_closure_52859;

		public _N__N_lambda__52820__52855(_N_closureOf_ReflectTyparms_52826 _N_ReflectTyparms_closure_52859)
		{
			this._N_ReflectTyparms_closure_52859 = _N_ReflectTyparms_closure_52859;
		}

		[SpecialName]
		public sealed override FixedType apply(Type t)
		{
			return _N_ReflectTyparms_closure_52859._N_lib_52833.TypeOfType(_N_ReflectTyparms_closure_52859._N_tenv_52831, t);
		}
	}

	private sealed class _N_closureOf_FlattenTerm_52885
	{
		internal StringBuilder _N_ret_52890;

		internal _N_closureOf_FlattenTerm_52885()
		{
		}
	}

	private sealed class _N_static_proxy_52910 : Function<TypeVar, Term>
	{
		[SpecialName]
		public static readonly _N_static_proxy_52910 single_instance = new _N_static_proxy_52910();

		[SpecialName]
		public sealed override Term apply(TypeVar _N_sp_parm_52917)
		{
			return encode_tv(_N_sp_parm_52917);
		}

		private _N_static_proxy_52910()
		{
		}
	}

	private static Term ParseTerm(string s)
	{
		_N_closureOf_ParseTerm_52456 n_closureOf_ParseTerm_ = new _N_closureOf_ParseTerm_52456();
		n_closureOf_ParseTerm_._N_s_52461 = s;
		Nemerle.Builtins.Tuple<int, option<Term.App>> tuple = _N_maybe_get_52474(n_closureOf_ParseTerm_, 0);
		if (tuple.Field1 is option<Term.App>.Some)
		{
			int field = tuple.Field0;
			Term.App val = ((option<Term.App>.Some)tuple.Field1).val;
			if (field != n_closureOf_ParseTerm_._N_s_52461.Length)
			{
				throw new AssertionException("ncc\\external\\Codec.n", 85, "pos == s.Length", "");
			}
			return val;
		}
		if (tuple.Field1 == option<Term.App>.None._N_constant_object)
		{
			throw new AssertionException("ncc\\external\\Codec.n", 89, "", "");
		}
		throw new MatchFailureException();
	}

	private static FixedType decode(LibraryReference lib, Map<string, StaticTypeVar> tenv, Term t)
	{
		_N_closureOf_decode_52539 n_closureOf_decode_ = new _N_closureOf_decode_52539();
		n_closureOf_decode_._N_lib_52546 = lib;
		n_closureOf_decode_._N_tenv_52544 = tenv;
		Function<Term, TypeVar> convert = new _N_self__52548(n_closureOf_decode_);
		object result;
		if (t is Term.App)
		{
			string name = ((Term.App)t).name;
			list<Term> list = ((Term.App)t).args;
			if (name[0] != '.')
			{
				option<TypeInfo> option = n_closureOf_decode_._N_lib_52546.Manager.NameTree.LookupExactType(NString.Split(name, '.', '+'));
				if (option is option<TypeInfo>.Some)
				{
					TypeInfo val = ((option<TypeInfo>.Some)option).val;
					result = ((!(val.FullName == "System.Void")) ? new FixedType.Class(val, list.Map(convert)).Expand() : n_closureOf_decode_._N_lib_52546.Manager.InternalType.Void);
				}
				else
				{
					if (option != option<TypeInfo>.None._N_constant_object)
					{
						throw new MatchFailureException();
					}
					option = n_closureOf_decode_._N_lib_52546.LookupInternalType(name);
					if (option is option<TypeInfo>.Some)
					{
						TypeInfo val = ((option<TypeInfo>.Some)option).val;
						result = new FixedType.Class(val, list.Map(convert)).Expand();
					}
					else
					{
						if (option != option<TypeInfo>.None._N_constant_object)
						{
							throw new MatchFailureException();
						}
						Message.Error("unbound type name: " + Convert.ToString(name) + ", are you missing a reference?");
						result = n_closureOf_decode_._N_lib_52546.Manager.InternalType.Void;
					}
				}
				goto IL_074e;
			}
			if (((Term.App)t).name == ".a")
			{
				if (((Term.App)t).args is list<Term>.Cons && ((list<Term>.Cons)((Term.App)t).args).hd is Term.App && (object)((Term.App)((list<Term>.Cons)((Term.App)t).args).hd).args == list<Term>.Nil._N_constant_object)
				{
					name = ((Term.App)((list<Term>.Cons)((Term.App)t).args).hd).name;
					if (((list<Term>.Cons)((Term.App)t).args).tl is list<Term>.Cons && (object)((list<Term>.Cons)((list<Term>.Cons)((Term.App)t).args).tl).tl == list<Term>.Nil._N_constant_object)
					{
						Term hd = ((list<Term>.Cons)((list<Term>.Cons)((Term.App)t).args).tl).hd;
						result = new FixedType.Array(decode(n_closureOf_decode_._N_lib_52546, n_closureOf_decode_._N_tenv_52544, hd), int.Parse(name));
						goto IL_074e;
					}
				}
			}
			else if (((Term.App)t).name == ".r")
			{
				if (((Term.App)t).args is list<Term>.Cons && (object)((list<Term>.Cons)((Term.App)t).args).tl == list<Term>.Nil._N_constant_object)
				{
					Term hd = ((list<Term>.Cons)((Term.App)t).args).hd;
					result = new FixedType.Ref(decode(n_closureOf_decode_._N_lib_52546, n_closureOf_decode_._N_tenv_52544, hd));
					goto IL_074e;
				}
			}
			else if (((Term.App)t).name == ".o")
			{
				if (((Term.App)t).args is list<Term>.Cons && (object)((list<Term>.Cons)((Term.App)t).args).tl == list<Term>.Nil._N_constant_object)
				{
					Term hd = ((list<Term>.Cons)((Term.App)t).args).hd;
					result = new FixedType.Out(decode(n_closureOf_decode_._N_lib_52546, n_closureOf_decode_._N_tenv_52544, hd));
					goto IL_074e;
				}
			}
			else if (((Term.App)t).name == ".f")
			{
				if (((Term.App)t).args is list<Term>.Cons && ((list<Term>.Cons)((Term.App)t).args).tl is list<Term>.Cons)
				{
					Term hd = ((list<Term>.Cons)((Term.App)t).args).hd;
					if ((object)((list<Term>.Cons)((list<Term>.Cons)((Term.App)t).args).tl).tl == list<Term>.Nil._N_constant_object)
					{
						Term hd2 = ((list<Term>.Cons)((list<Term>.Cons)((Term.App)t).args).tl).hd;
						result = new FixedType.Fun(decode(n_closureOf_decode_._N_lib_52546, n_closureOf_decode_._N_tenv_52544, hd), decode(n_closureOf_decode_._N_lib_52546, n_closureOf_decode_._N_tenv_52544, hd2));
						goto IL_074e;
					}
				}
			}
			else if (((Term.App)t).name == ".v")
			{
				if (((Term.App)t).args is list<Term>.Cons && ((list<Term>.Cons)((Term.App)t).args).hd is Term.App && (object)((Term.App)((list<Term>.Cons)((Term.App)t).args).hd).args == list<Term>.Nil._N_constant_object)
				{
					name = ((Term.App)((list<Term>.Cons)((Term.App)t).args).hd).name;
					if ((object)((list<Term>.Cons)((Term.App)t).args).tl == list<Term>.Nil._N_constant_object)
					{
						option<StaticTypeVar> option2 = n_closureOf_decode_._N_tenv_52544.Find(name);
						if (option2 is option<StaticTypeVar>.Some)
						{
							StaticTypeVar val2 = ((option<StaticTypeVar>.Some)option2).val;
							result = new FixedType.StaticTypeVarRef(val2);
							goto IL_074e;
						}
						if (option2 == option<StaticTypeVar>.None._N_constant_object)
						{
							if (!Message.SeenError)
							{
								string text = ("unboud type variable in encoded type " + name).ToString();
								Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
							}
							throw new AssertionException("ncc\\external\\Codec.n", 124, "", ("unboud type variable in encoded type " + name).ToString());
						}
						throw new MatchFailureException();
					}
				}
			}
			else if (((Term.App)t).name == ".p")
			{
				list = ((Term.App)t).args;
				result = new FixedType.Tuple(list.Map(convert));
				goto IL_074e;
			}
			name = ((Term.App)t).name;
			if (!Message.SeenError)
			{
				string text = ("invalid encoded type opcode " + name).ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\external\\Codec.n", 128, "", ("invalid encoded type opcode " + name).ToString());
		}
		throw new MatchFailureException();
		IL_074e:
		return (FixedType)result;
	}

	private static Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>> reflect_typarms(LibraryReference _lib, Map<string, StaticTypeVar> tenv, Type _t)
	{
		list<StaticTypeVar> list = null;
		int num = 0;
		list = list<StaticTypeVar>.Nil._N_constant_object;
		Type[] genericArguments = _t.GetGenericArguments();
		for (num = 0; num < genericArguments.Length; num = checked(num + 1))
		{
			Type type = genericArguments[num];
			type = type;
			StaticTypeVar staticTypeVar = new StaticTypeVar(_lib.Manager, type.Name, type);
			list = new list<StaticTypeVar>.Cons(staticTypeVar, list);
			tenv = tenv.Replace(type.Name, staticTypeVar);
		}
		list = list.Rev();
		return new Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>>(list, tenv);
	}

	public static void ReflectConstraints(LibraryReference _lib, Map<string, StaticTypeVar> tenv, Type sys_type, FixedType self_type, list<StaticTypeVar> tyvars)
	{
		_N_closureOf_ReflectConstraints_52633 n_closureOf_ReflectConstraints_ = new _N_closureOf_ReflectConstraints_52633();
		n_closureOf_ReflectConstraints_._N__lib_52644 = _lib;
		n_closureOf_ReflectConstraints_._N_tenv_52642 = tenv;
		n_closureOf_ReflectConstraints_._N_sys_type_52640 = sys_type;
		n_closureOf_ReflectConstraints_._N_self_type_52638 = self_type;
		Type[] genericArguments = n_closureOf_ReflectConstraints_._N_sys_type_52640.GetGenericArguments();
		FunctionVoid<Type, StaticTypeVar> f = new _N_set_constraints__52646(n_closureOf_ReflectConstraints_);
		genericArguments.Iter2(tyvars, f);
	}

	public static FixedType DecodeType(LibraryReference lib, Map<string, StaticTypeVar> tenv, string tokens)
	{
		return decode(lib, tenv, ParseTerm(tokens));
	}

	public static Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>, list<FixedType.Class>, list<FixedType.Class>> ReflectTypeBuilder(LibraryReference lib, Map<string, StaticTypeVar> tenv, Type original)
	{
		list<FixedType.Class> list = null;
		int num = 0;
		_N_closureOf_ReflectTypeBuilder_52722 n_closureOf_ReflectTypeBuilder_ = new _N_closureOf_ReflectTypeBuilder_52722();
		n_closureOf_ReflectTypeBuilder_._N_lib_52733 = lib;
		Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>> tuple = reflect_typarms(n_closureOf_ReflectTypeBuilder_._N_lib_52733, tenv, original);
		list<StaticTypeVar> field = tuple.Field0;
		n_closureOf_ReflectTypeBuilder_._N_tenv_52731 = tuple.Field1;
		Type[] interfaces = original.GetInterfaces();
		list<Type> lst = NList.FromArray(interfaces);
		Function<Type, Type, bool> instance = _N__N_lambda__52690__52758.Instance;
		list<Type> minimal = Typer.GetMinimal(lst, instance);
		list = list<FixedType.Class>.Nil._N_constant_object;
		minimal = minimal;
		Type hd;
		while (minimal is list<Type>.Cons)
		{
			hd = ((list<Type>.Cons)minimal).hd;
			minimal = ((list<Type>.Cons)minimal).tl;
			list = new list<FixedType.Class>.Cons(_N_typeof_type_52740(n_closureOf_ReflectTypeBuilder_, hd), list);
			minimal = minimal;
		}
		hd = original.BaseType;
		if ((object)hd != null)
		{
			list = new list<FixedType.Class>.Cons(_N_typeof_type_52740(n_closureOf_ReflectTypeBuilder_, hd), list);
		}
		n_closureOf_ReflectTypeBuilder_._N_st_52729 = list<FixedType.Class>.Nil._N_constant_object;
		n_closureOf_ReflectTypeBuilder_._N_st_unique_52727 = list<FixedType.Class>.Nil._N_constant_object;
		_N_tryAddSuperType_52780(n_closureOf_ReflectTypeBuilder_, original.BaseType);
		for (num = 0; num < interfaces.Length; num = checked(num + 1))
		{
			hd = interfaces[num];
			_N_tryAddSuperType_52780(n_closureOf_ReflectTypeBuilder_, hd);
		}
		return new Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>, list<FixedType.Class>, list<FixedType.Class>>(field, n_closureOf_ReflectTypeBuilder_._N_tenv_52731, list, n_closureOf_ReflectTypeBuilder_._N_st_52729);
	}

	public static Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>> ReflectTyparms(LibraryReference lib, Map<string, StaticTypeVar> tenv, MethodBase meth)
	{
		list<StaticTypeVar> list = null;
		int num = 0;
		_N_closureOf_ReflectTyparms_52826 n_closureOf_ReflectTyparms_ = new _N_closureOf_ReflectTyparms_52826();
		n_closureOf_ReflectTyparms_._N_lib_52833 = lib;
		n_closureOf_ReflectTyparms_._N_tenv_52831 = tenv;
		Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>> result;
		if (meth.IsGenericMethodDefinition)
		{
			list = list<StaticTypeVar>.Nil._N_constant_object;
			Type[] genericArguments = meth.GetGenericArguments();
			for (num = 0; num < genericArguments.Length; num = checked(num + 1))
			{
				Type type = genericArguments[num];
				type = type;
				StaticTypeVar staticTypeVar = new StaticTypeVar(n_closureOf_ReflectTyparms_._N_lib_52833.Manager, type.Name, type);
				list = new list<StaticTypeVar>.Cons(staticTypeVar, list);
				n_closureOf_ReflectTyparms_._N_tenv_52831 = n_closureOf_ReflectTyparms_._N_tenv_52831.Replace(type.Name, staticTypeVar);
			}
			list = list.Reverse();
			FunctionVoid<Type, StaticTypeVar> f = new _N_set_constraints__52846(n_closureOf_ReflectTyparms_);
			genericArguments.Iter2(list, f);
			result = new Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>>(list, n_closureOf_ReflectTyparms_._N_tenv_52831);
		}
		else
		{
			result = new Nemerle.Builtins.Tuple<list<StaticTypeVar>, Map<string, StaticTypeVar>>(list<StaticTypeVar>.Nil._N_constant_object, n_closureOf_ReflectTyparms_._N_tenv_52831);
		}
		return result;
	}

	private static string FlattenTerm(Term t)
	{
		_N_closureOf_FlattenTerm_52885 n_closureOf_FlattenTerm_ = new _N_closureOf_FlattenTerm_52885();
		n_closureOf_FlattenTerm_._N_ret_52890 = new StringBuilder();
		_N_walk_52893(n_closureOf_FlattenTerm_, t);
		return n_closureOf_FlattenTerm_._N_ret_52890.ToString();
	}

	private static list<Term> encode_tvs(list<TypeVar> t)
	{
		return t.Map(_N_static_proxy_52910.single_instance);
	}

	private static Term encode_tv(TypeVar t)
	{
		return encode(t.Fix());
	}

	private static Term encode(FixedType t)
	{
		Term.App result;
		if (t is FixedType.Class)
		{
			TypeInfo tycon = ((FixedType.Class)t).tycon;
			list<TypeVar> t2 = ((FixedType.Class)t).args;
			result = new Term.App(tycon.FrameworkTypeName, encode_tvs(t2));
		}
		else if (t is FixedType.StaticTypeVarRef)
		{
			StaticTypeVar tyvar = ((FixedType.StaticTypeVarRef)t).tyvar;
			result = new Term.App(".v", new list<Term>.Cons(new Term.App(tyvar.Name.ToString(), list<Term>.Nil._N_constant_object), list<Term>.Nil._N_constant_object));
		}
		else if (t is FixedType.Fun)
		{
			TypeVar from = ((FixedType.Fun)t).from;
			TypeVar to = ((FixedType.Fun)t).to;
			result = new Term.App(".f", new list<Term>.Cons(encode_tv(from), new list<Term>.Cons(encode_tv(to), list<Term>.Nil._N_constant_object)));
		}
		else if (t is FixedType.Tuple)
		{
			list<TypeVar> t2 = ((FixedType.Tuple)t).args;
			result = new Term.App(".p", encode_tvs(t2));
		}
		else if (t is FixedType.Array)
		{
			TypeVar from = ((FixedType.Array)t).t;
			result = new Term.App(".a", new list<Term>.Cons(new Term.App(((FixedType.Array)t).rank.ToString(), list<Term>.Nil._N_constant_object), new list<Term>.Cons(encode_tv(from), list<Term>.Nil._N_constant_object)));
		}
		else if (t is FixedType.Ref)
		{
			TypeVar from = ((FixedType.Ref)t).t;
			result = new Term.App(".r", new list<Term>.Cons(encode_tv(from), list<Term>.Nil._N_constant_object));
		}
		else if (t is FixedType.Out)
		{
			TypeVar from = ((FixedType.Out)t).t;
			result = new Term.App(".o", new list<Term>.Cons(encode_tv(from), list<Term>.Nil._N_constant_object));
		}
		else
		{
			if (!(t is FixedType.Void))
			{
				if (t is FixedType.Intersection)
				{
					throw new AssertionException("ncc\\external\\Codec.n", 307, "", "");
				}
				throw new MatchFailureException();
			}
			result = new Term.App("System.Void", list<Term>.Nil._N_constant_object);
		}
		return result;
	}

	public static string EncodeType(FixedType t)
	{
		return FlattenTerm(encode(t));
	}

	private static Nemerle.Builtins.Tuple<int, string> _N_get_name_52464(_N_closureOf_ParseTerm_52456 _N_ParseTerm_cp_52463, int pos)
	{
		int num = _N_ParseTerm_cp_52463._N_s_52461.IndexOf('(', pos);
		if (num == -1)
		{
			throw new AssertionException("ncc\\external\\Codec.n", 59, "idx != -1", "");
		}
		return checked(new Nemerle.Builtins.Tuple<int, string>(num + 1, _N_ParseTerm_cp_52463._N_s_52461.Substring(pos, num - pos)));
	}

	private static Nemerle.Builtins.Tuple<int, option<Term.App>> _N_maybe_get_52474(_N_closureOf_ParseTerm_52456 _N_ParseTerm_cp_52473, int pos)
	{
		Nemerle.Builtins.Tuple<int, option<Term.App>> result;
		if (_N_ParseTerm_cp_52473._N_s_52461[pos] == ')')
		{
			result = new Nemerle.Builtins.Tuple<int, option<Term.App>>(checked(pos + 1), option<Term.App>.None._N_constant_object);
		}
		else
		{
			Nemerle.Builtins.Tuple<int, string> tuple = _N_get_name_52464(_N_ParseTerm_cp_52473, pos);
			int field = tuple.Field0;
			string field2 = tuple.Field1;
			Nemerle.Builtins.Tuple<int, list<Term>> tuple2 = _N_get_list_52480(_N_ParseTerm_cp_52473, list<Term>.Nil._N_constant_object, field);
			field = tuple2.Field0;
			list<Term> args = tuple2.Field1;
			result = new Nemerle.Builtins.Tuple<int, option<Term.App>>(field, new option<Term.App>.Some(new Term.App(field2, args)));
		}
		return result;
	}

	private static Nemerle.Builtins.Tuple<int, list<Term>> _N_get_list_52480(_N_closureOf_ParseTerm_52456 _N_ParseTerm_cp_52479, list<Term> acc, int pos)
	{
		while (true)
		{
			Nemerle.Builtins.Tuple<int, option<Term.App>> tuple = _N_maybe_get_52474(_N_ParseTerm_cp_52479, pos);
			int field;
			if (tuple.Field1 == option<Term.App>.None._N_constant_object)
			{
				field = tuple.Field0;
				return new Nemerle.Builtins.Tuple<int, list<Term>>(field, acc.Rev());
			}
			if (!(tuple.Field1 is option<Term.App>.Some))
			{
				break;
			}
			field = tuple.Field0;
			Term.App val = ((option<Term.App>.Some)tuple.Field1).val;
			list<Term> obj = new list<Term>.Cons(val, acc);
			pos = field;
			acc = obj;
		}
		throw new MatchFailureException();
	}

	private static FixedType.Class _N_typeof_type_52740(_N_closureOf_ReflectTypeBuilder_52722 _N_ReflectTypeBuilder_cp_52739, Type framework_type)
	{
		TypeInfo tycon = _N_ReflectTypeBuilder_cp_52739._N_lib_52733.TypeInfoOfType(framework_type);
		FixedType.Class result;
		if (framework_type.IsGenericType)
		{
			Type[] genericArguments = framework_type.GetGenericArguments();
			Function<Type, TypeVar> convert = new _N__N_lambda__52683__52749(_N_ReflectTypeBuilder_cp_52739);
			list<TypeVar> args = genericArguments.MapToList(convert);
			result = new FixedType.Class(tycon, args);
		}
		else
		{
			result = new FixedType.Class(tycon, list<TypeVar>.Nil._N_constant_object);
		}
		return result;
	}

	private static void _N_tryAddSuperType_52780(_N_closureOf_ReflectTypeBuilder_52722 _N_ReflectTypeBuilder_cp_52779, Type t)
	{
		while ((object)t != null)
		{
			FixedType.Class @class = _N_typeof_type_52740(_N_ReflectTypeBuilder_cp_52779, t);
			if (!_N_ReflectTypeBuilder_cp_52779._N_st_unique_52727.Contains(@class))
			{
				_N_ReflectTypeBuilder_cp_52779._N_st_52729 = new list<FixedType.Class>.Cons(@class, _N_ReflectTypeBuilder_cp_52779._N_st_52729);
				_N_ReflectTypeBuilder_cp_52779._N_st_unique_52727 = new list<FixedType.Class>.Cons(@class, _N_ReflectTypeBuilder_cp_52779._N_st_unique_52727);
				t = t.BaseType;
				continue;
			}
			break;
		}
	}

	private static void _N_walk_52893(_N_closureOf_FlattenTerm_52885 _N_FlattenTerm_cp_52892, Term t)
	{
		if (t is Term.App)
		{
			string name = ((Term.App)t).name;
			list<Term> list = ((Term.App)t).args;
			StringBuilder stringBuilder = _N_FlattenTerm_cp_52892._N_ret_52890.Append(name);
			stringBuilder = _N_FlattenTerm_cp_52892._N_ret_52890.Append('(');
			list = list;
			while (list is list<Term>.Cons)
			{
				Term hd = ((list<Term>.Cons)list).hd;
				list = ((list<Term>.Cons)list).tl;
				_N_walk_52893(_N_FlattenTerm_cp_52892, hd);
				list = list;
			}
			stringBuilder = _N_FlattenTerm_cp_52892._N_ret_52890.Append(')');
			return;
		}
		throw new MatchFailureException();
	}
}
