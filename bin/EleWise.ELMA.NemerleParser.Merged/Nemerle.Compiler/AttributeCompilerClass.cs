using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler;

internal class AttributeCompilerClass : ISupportRelocation
{
	private sealed class _N_closureOf_ResolveAttribute_82197
	{
		internal TypeInfo _N_expect_exact_82204;

		internal AttributeCompilerClass _N__N_closurised_this_ptr_82202;

		internal _N_closureOf_ResolveAttribute_82197()
		{
		}
	}

	private sealed class _N_closureOf_CheckAttribute_82284
	{
		internal GlobalEnv _N_env_82289;

		internal _N_closureOf_CheckAttribute_82284()
		{
		}
	}

	private sealed class _N__N_lambda__82277__82299 : Function<PExpr, PExpr>
	{
		[SpecialName]
		private _N_closureOf_CheckAttribute_82284 _N_CheckAttribute_closure_82303;

		public _N__N_lambda__82277__82299(_N_closureOf_CheckAttribute_82284 _N_CheckAttribute_closure_82303)
		{
			this._N_CheckAttribute_closure_82303 = _N_CheckAttribute_closure_82303;
		}

		[SpecialName]
		public sealed override PExpr apply(PExpr parm)
		{
			return ConstantFolder.FoldConstants(_N_CheckAttribute_closure_82303._N_env_82289, parm);
		}
	}

	private sealed class _N_closureOf_GetPermissionSets_82606
	{
		internal GlobalEnv _N_env_82611;

		internal _N_closureOf_GetPermissionSets_82606()
		{
		}
	}

	private sealed class _N__N_lambda__82599__82613 : Function<PExpr, Nemerle.Builtins.Tuple<GlobalEnv, PExpr>>
	{
		[SpecialName]
		private _N_closureOf_GetPermissionSets_82606 _N_GetPermissionSets_closure_82617;

		public _N__N_lambda__82599__82613(_N_closureOf_GetPermissionSets_82606 _N_GetPermissionSets_closure_82617)
		{
			this._N_GetPermissionSets_closure_82617 = _N_GetPermissionSets_closure_82617;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<GlobalEnv, PExpr> apply(PExpr attr)
		{
			return new Nemerle.Builtins.Tuple<GlobalEnv, PExpr>(_N_GetPermissionSets_closure_82617._N_env_82611, attr);
		}
	}

	private sealed class _N_closureOf_loop_82727
	{
		internal PExpr _N_expr_82732;

		internal _N_closureOf_loop_82727()
		{
		}
	}

	private sealed class _N__N_lambda__82719__82829 : Function<PExpr, bool>
	{
		[SpecialName]
		private _N_closureOf_loop_82727 _N_loop_closure_82833;

		public _N__N_lambda__82719__82829(_N_closureOf_loop_82727 _N_loop_closure_82833)
		{
			this._N_loop_closure_82833 = _N_loop_closure_82833;
		}

		[SpecialName]
		public sealed override bool apply(PExpr x)
		{
			return x != _N_loop_closure_82833._N_expr_82732;
		}
	}

	private sealed class _N_closureOf_CheckConditional_82863
	{
		internal MethodBuilder _N_mb_82870;

		internal AttributeCompilerClass _N__N_closurised_this_ptr_82868;

		internal _N_closureOf_CheckConditional_82863()
		{
		}
	}

	private sealed class _N_closureOf_compile_expr_82961
	{
		internal PExpr _N_expr_82968;

		internal AttributeCompilerClass _N__N_closurised_this_ptr_82966;

		internal _N_closureOf_compile_expr_82961()
		{
		}
	}

	private sealed class _N__N_lambda__82952__83014 : Function<TExpr, object>
	{
		[SpecialName]
		private _N_closureOf_compile_expr_82961 _N_compile_expr_closure_83018;

		public _N__N_lambda__82952__83014(_N_closureOf_compile_expr_82961 _N_compile_expr_closure_83018)
		{
			this._N_compile_expr_closure_83018 = _N_compile_expr_closure_83018;
		}

		[SpecialName]
		public sealed override object apply(TExpr e)
		{
			return _N_compile_expr_closure_83018._N__N_closurised_this_ptr_82966._N_convert_82989(_N_compile_expr_closure_83018, e).Field0;
		}
	}

	private sealed class _N_closureOf_pre_compile_83095
	{
		internal string _N_name_83104;

		internal TypeInfo _N_attr_83102;

		internal int _N_count_83100;

		internal _N_closureOf_pre_compile_83095()
		{
		}
	}

	private sealed class _N__N_lambda__83072__83170 : Function<FixedType, Parm>
	{
		[SpecialName]
		public static readonly _N__N_lambda__83072__83170 Instance = new _N__N_lambda__83072__83170();

		[SpecialName]
		public sealed override Parm apply(FixedType ty)
		{
			return new Parm(new TExpr.DefaultValue(ty));
		}
	}

	private sealed class _N__N_lambda__83084__83194 : Function<object, bool>
	{
		[SpecialName]
		private _N_closureOf_pre_compile_83095 _N_pre_compile_closure_83198;

		public _N__N_lambda__83084__83194(_N_closureOf_pre_compile_83095 _N_pre_compile_closure_83198)
		{
			this._N_pre_compile_closure_83198 = _N_pre_compile_closure_83198;
		}

		[SpecialName]
		public sealed override bool apply(object _N_wildcard_3371)
		{
			bool result = _N_pre_compile_closure_83198._N_count_83100 >= 0;
			_N_pre_compile_closure_83198._N_count_83100 = checked(_N_pre_compile_closure_83198._N_count_83100 - 1);
			return result;
		}
	}

	private sealed class _N_closureOf_create_instance_83253
	{
		internal object _N_obj_83258;

		internal _N_closureOf_create_instance_83253()
		{
		}
	}

	private sealed class _N__N_lambda__83239__83264 : FunctionVoid<PropertyInfo, object>
	{
		[SpecialName]
		private _N_closureOf_create_instance_83253 _N_create_instance_closure_83268;

		public _N__N_lambda__83239__83264(_N_closureOf_create_instance_83253 _N_create_instance_closure_83268)
		{
			this._N_create_instance_closure_83268 = _N_create_instance_closure_83268;
		}

		[SpecialName]
		public sealed override void apply_void(PropertyInfo prop, object val)
		{
			prop.SetValue(_N_create_instance_closure_83268._N_obj_83258, val, null);
		}
	}

	private sealed class _N__N_lambda__83245__83273 : FunctionVoid<FieldInfo, object>
	{
		[SpecialName]
		private _N_closureOf_create_instance_83253 _N_create_instance_closure_83277;

		public _N__N_lambda__83245__83273(_N_closureOf_create_instance_83253 _N_create_instance_closure_83277)
		{
			this._N_create_instance_closure_83277 = _N_create_instance_closure_83277;
		}

		[SpecialName]
		public sealed override void apply_void(FieldInfo field, object val)
		{
			field.SetValue(_N_create_instance_closure_83277._N_obj_83258, val);
		}
	}

	public readonly ManagerClass Manager;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	internal AttributeCompilerClass(ManagerClass man)
	{
		Manager = man;
	}

	internal Nemerle.Builtins.Tuple<AttributeTargets, CustomAttributeBuilder, bool> CompileAttribute(GlobalEnv env, TypeBuilder ti, PExpr expr)
	{
		Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>> tuple = CheckAttribute(env, expr);
		TypeInfo field = tuple.Field0;
		list<PExpr> parms = tuple.Field1;
		Nemerle.Builtins.Tuple<AttributeTargets, CustomAttributeBuilder, bool> result;
		if (is_security_attribute(field))
		{
			result = new Nemerle.Builtins.Tuple<AttributeTargets, CustomAttributeBuilder, bool>((AttributeTargets)0, null, field2: true);
		}
		else
		{
			Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool> tuple2 = do_compile(env, ti, field, parms);
			CustomAttributeBuilder field2 = tuple2.Field0;
			bool field3 = tuple2.Field1;
			result = new Nemerle.Builtins.Tuple<AttributeTargets, CustomAttributeBuilder, bool>(field.AttributeTargets, field2, field3);
		}
		return result;
	}

	internal option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>> ResolveAttribute(GlobalEnv env, PExpr expr, TypeInfo expect_exact = null)
	{
		_N_closureOf_ResolveAttribute_82197 n_closureOf_ResolveAttribute_;
		while (true)
		{
			n_closureOf_ResolveAttribute_ = new _N_closureOf_ResolveAttribute_82197();
			n_closureOf_ResolveAttribute_._N_expect_exact_82204 = expect_exact;
			n_closureOf_ResolveAttribute_._N__N_closurised_this_ptr_82202 = this;
			if (!(expr is PExpr.Ref))
			{
				if (!(expr is PExpr.Member))
				{
					break;
				}
				PExpr obj = ((PExpr.Member)expr).obj;
				Splicable member = ((PExpr.Member)expr).member;
			}
			GlobalEnv globalEnv = env;
			PExpr obj2 = new PExpr.Call(Macros.QuotationChoose(expr), list<PExpr>.Nil._N_constant_object);
			expect_exact = n_closureOf_ResolveAttribute_._N_expect_exact_82204;
			expr = obj2;
			env = globalEnv;
		}
		list<PExpr> field;
		TypeInfo val;
		object result;
		if (expr is PExpr.Call)
		{
			PExpr obj = ((PExpr.Call)expr).func;
			field = ((PExpr.Call)expr).parms;
			option<Nemerle.Builtins.Tuple<list<string>, Name>> option = Util.QidOfExpr(obj);
			if (option is option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)
			{
				list<string> field2 = ((option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)option).val.Field0;
				Name field3 = ((option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)option).val.Field1;
				GlobalEnv env2 = field3.GetEnv(env);
				option<TypeInfo> option2 = env2.LookupType(field2);
				option<TypeInfo> option3 = env2.LookupType(_N_add_end_82207(n_closureOf_ResolveAttribute_, field2, "Attribute"));
				if (option2 is option<TypeInfo>.Some)
				{
					if (option3 == option<TypeInfo>.None._N_constant_object)
					{
						val = ((option<TypeInfo>.Some)option2).val;
						goto IL_011f;
					}
					if (option3 is option<TypeInfo>.Some)
					{
						TypeInfo val2 = ((option<TypeInfo>.Some)option2).val;
						val = ((option<TypeInfo>.Some)option3).val;
						if (_N_is_attribute_82233(n_closureOf_ResolveAttribute_, val2))
						{
							if (_N_is_attribute_82233(n_closureOf_ResolveAttribute_, val))
							{
								Message.Error(Location.Default, string.Concat("ambiguous attribute type name,", " it could be `" + Convert.ToString(val2) + "' or `" + Convert.ToString(val) + "'"));
								throw new Recovery();
							}
							result = new option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some(new Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>(val2, field));
						}
						else if (_N_is_attribute_82233(n_closureOf_ResolveAttribute_, val))
						{
							result = new option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some(new Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>(val, field));
						}
						else
						{
							if (n_closureOf_ResolveAttribute_._N_expect_exact_82204 == null)
							{
								Message.Error(Location.Default, "neither `" + Convert.ToString(val2) + "' nor `" + Convert.ToString(val) + "' is an attribute class");
								throw new Recovery();
							}
							result = option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.None._N_constant_object;
						}
						goto IL_02f5;
					}
				}
				else if (option2 == option<TypeInfo>.None._N_constant_object && option3 is option<TypeInfo>.Some)
				{
					val = ((option<TypeInfo>.Some)option3).val;
					goto IL_011f;
				}
				result = option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.None._N_constant_object;
			}
			else
			{
				result = option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.None._N_constant_object;
			}
		}
		else
		{
			result = option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.None._N_constant_object;
		}
		goto IL_02f5;
		IL_02f5:
		return (option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>)result;
		IL_011f:
		if (_N_is_attribute_82233(n_closureOf_ResolveAttribute_, val))
		{
			result = new option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some(new Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>(val, field));
		}
		else
		{
			if (n_closureOf_ResolveAttribute_._N_expect_exact_82204 == null)
			{
				Message.Error(Location.Default, "`" + Convert.ToString(val.FullName) + "' is not an attribute class");
				throw new Recovery();
			}
			result = option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.None._N_constant_object;
		}
		goto IL_02f5;
	}

	internal Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>> CheckAttribute(GlobalEnv env, PExpr expr)
	{
		_N_closureOf_CheckAttribute_82284 n_closureOf_CheckAttribute_ = new _N_closureOf_CheckAttribute_82284();
		n_closureOf_CheckAttribute_._N_env_82289 = env;
		Location location = expr.Location;
		bool flag = location.FileIndex != 0;
		if (flag)
		{
			LocationStack.Push(location);
		}
		try
		{
			option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>> option = ResolveAttribute(n_closureOf_CheckAttribute_._N_env_82289, expr);
			if (option is option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)
			{
				TypeInfo field = ((option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)option).val.Field0;
				list<PExpr> list = ((option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)option).val.Field1;
				Function<PExpr, PExpr> convert = new _N__N_lambda__82277__82299(n_closureOf_CheckAttribute_);
				return new Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>(field, list.Map(convert));
			}
			if (option == option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.None._N_constant_object)
			{
				Message.Error(Location.Default, "the custom attribute `" + Convert.ToString(PrettyPrint.SprintExpr(option<Typer>.None._N_constant_object, expr)) + "' could not be found or is invalid");
				throw new Recovery();
			}
			throw new MatchFailureException();
		}
		finally
		{
			if (flag)
			{
				LocationStack.RemoveTop();
			}
		}
	}

	internal list<Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool>> GetCompiledAssemblyAttributes(List<Nemerle.Builtins.Tuple<GlobalEnv, PExpr>> attrs)
	{
		list<Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool>> list = list<Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool>>.Nil._N_constant_object;
		foreach (Nemerle.Builtins.Tuple<GlobalEnv, PExpr> attr in attrs)
		{
			GlobalEnv field = attr.Field0;
			PExpr field2 = attr.Field1;
			Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>> tuple = CheckAttribute(field, field2);
			TypeInfo field3 = tuple.Field0;
			list<PExpr> parms = tuple.Field1;
			if (!field3.Equals(InternalType.AssemblyVersionAttribute_tc) && !is_security_attribute(field3))
			{
				list = new list<Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool>>.Cons(do_compile(field, null, field3, parms), list);
			}
		}
		return list;
	}

	internal list<Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>> GetPermissionSets(IEnumerable<Nemerle.Builtins.Tuple<GlobalEnv, PExpr>> attrs)
	{
		list<Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>> list = list<Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>>.Nil._N_constant_object;
		IEnumerator<Nemerle.Builtins.Tuple<GlobalEnv, PExpr>> enumerator = attrs.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Nemerle.Builtins.Tuple<GlobalEnv, PExpr> current = enumerator.Current;
				GlobalEnv field = current.Field0;
				PExpr field2 = current.Field1;
				Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>> tuple = CheckAttribute(field, field2);
				TypeInfo field3 = tuple.Field0;
				list<PExpr> parms = tuple.Field1;
				if (!is_security_attribute(field3))
				{
					continue;
				}
				object obj = create_instance(field, field3, parms);
				if (obj is PermissionSetAttribute)
				{
					PermissionSetAttribute permissionSetAttribute = (PermissionSetAttribute)obj;
					list = new list<Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>>.Cons(new Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>(permissionSetAttribute.Action, permissionSetAttribute.CreatePermissionSet()), list);
					continue;
				}
				if (obj is SecurityAttribute)
				{
					SecurityAttribute securityAttribute = (SecurityAttribute)obj;
					PermissionSet permissionSet = new PermissionSet(PermissionState.None);
					permissionSet.AddPermission(securityAttribute.CreatePermission());
					list = new list<Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>>.Cons(new Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>(securityAttribute.Action, permissionSet), list);
					continue;
				}
				Message.Error(field2.Location, "given attribute must be a System.Security.Permissions.SecurityAttribute");
				throw new Recovery();
			}
			return list;
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	internal list<Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>> GetPermissionSets(GlobalEnv env, IEnumerable<PExpr> attrs)
	{
		_N_closureOf_GetPermissionSets_82606 n_closureOf_GetPermissionSets_ = new _N_closureOf_GetPermissionSets_82606();
		n_closureOf_GetPermissionSets_._N_env_82611 = env;
		Function<PExpr, Nemerle.Builtins.Tuple<GlobalEnv, PExpr>> convert = new _N__N_lambda__82599__82613(n_closureOf_GetPermissionSets_);
		return GetPermissionSets(attrs.Map(convert));
	}

	internal CustomAttributeBuilder MakeEmittedAttribute(Type attr_type, string value)
	{
		return MakeEmittedAttribute(attr_type, new Type[1] { SystemTypeCache.String }, value);
	}

	internal CustomAttributeBuilder MakeEmittedAttribute(Type attr_type)
	{
		ConstructorInfo constructor = attr_type.GetConstructor(Type.EmptyTypes);
		return new CustomAttributeBuilder(constructor, new object[0]);
	}

	internal CustomAttributeBuilder MakeEmittedAttribute(Type attr_type, int value)
	{
		return MakeEmittedAttribute(attr_type, new Type[1] { SystemTypeCache.Int32 }, value);
	}

	internal CustomAttributeBuilder MakeEmittedAttribute(Type attr_type, Type[] param_types, object value)
	{
		ConstructorInfo constructor = attr_type.GetConstructor(param_types);
		if (!(constructor != null))
		{
			throw new AssertionException("ncc\\hierarchy\\CustomAttribute.n", 212, "constructor_info != null", "");
		}
		object[] constructorArgs = new object[1] { value };
		return new CustomAttributeBuilder(constructor, constructorArgs);
	}

	internal System.Reflection.Emit.MethodBuilder CheckPInvoking(MethodBuilder meth, System.Reflection.Emit.TypeBuilder tb, MethodAttributes attrs, Type[] parm_types_array)
	{
		PExpr pExpr = null;
		bool flag = false;
		bool flag2 = false;
		CharSet charSet = default(CharSet);
		bool flag3 = false;
		bool flag4 = false;
		bool flag5 = false;
		MethodInfo methodInfo = null;
		MethodInfo methodInfo2 = null;
		MethodInfo methodInfo3 = null;
		MethodInfo methodInfo4 = null;
		bool flag6 = false;
		bool flag7 = false;
		bool flag8 = false;
		bool flag9 = false;
		CallingConvention callingConvention = default(CallingConvention);
		string text = null;
		list<PExpr> list = meth.GetModifiers().GetCustomAttributes();
		object result;
		while (true)
		{
			_N_closureOf_loop_82727 n_closureOf_loop_ = new _N_closureOf_loop_82727();
			if (list is list<PExpr>.Cons)
			{
				n_closureOf_loop_._N_expr_82732 = ((list<PExpr>.Cons)list).hd;
				list = ((list<PExpr>.Cons)list).tl;
				GlobalEnv globalEnv = meth.DeclaringType.GlobalEnv;
				option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>> option = ResolveAttribute(globalEnv, n_closureOf_loop_._N_expr_82732);
				if (option is option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some && ((option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)option).val.Field1 is list<PExpr>.Cons)
				{
					TypeInfo field = ((option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)option).val.Field0;
					PExpr hd = ((list<PExpr>.Cons)((option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)option).val.Field1).hd;
					list<PExpr> list2 = ((list<PExpr>.Cons)((option<Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>>>.Some)option).val.Field1).tl;
					if (field.Equals(InternalType.DllImport_tc))
					{
						if ((meth.Attributes & NemerleModifiers.Extern) == 0)
						{
							Message.Error(n_closureOf_loop_._N_expr_82732.Location, "only methods marked with `extern' modifier can have `System.Runtime.InteropServices.DllImport' attribute");
						}
						pExpr = ConstantFolder.FoldConstants(globalEnv, hd, meth.DeclaringType);
						object obj;
						if (pExpr is PExpr.Literal && ((PExpr.Literal)pExpr).val is Literal.String)
						{
							string val = ((Literal.String)((PExpr.Literal)pExpr).val).val;
							obj = val;
						}
						else
						{
							Message.Error(hd.Location, "in argument #1 (dllName), constant expression of type `" + Convert.ToString(InternalType.String_tc) + "' required");
							obj = "error";
						}
						string dllName = (string)obj;
						callingConvention = CallingConvention.Winapi;
						charSet = CharSet.Ansi;
						flag5 = true;
						text = meth.Name;
						flag9 = false;
						flag8 = false;
						flag7 = false;
						flag4 = false;
						flag2 = false;
						flag = false;
						flag3 = false;
						flag6 = false;
						methodInfo4 = null;
						methodInfo3 = null;
						methodInfo2 = null;
						methodInfo = null;
						list = list2;
						while (list is list<PExpr>.Cons)
						{
							pExpr = ((list<PExpr>.Cons)list).hd;
							list = ((list<PExpr>.Cons)list).tl;
							pExpr = pExpr;
							if (pExpr is PExpr.Assign && ((PExpr.Assign)pExpr).target is PExpr.Ref)
							{
								string val = ((PExpr.Ref)((PExpr.Assign)pExpr).target).name.idl;
								pExpr = ((PExpr.Assign)pExpr).source;
								pExpr = ConstantFolder.FoldConstants(globalEnv, pExpr);
								switch (val)
								{
								case "BestFitMapping":
									if (pExpr is PExpr.Literal && ((PExpr.Literal)pExpr).val is Literal.Bool)
									{
										flag2 = ((Literal.Bool)((PExpr.Literal)pExpr).val).val;
										flag9 = flag2;
										flag2 = true;
										break;
									}
									goto default;
								default:
									Message.Error(pExpr.Location, "value is not valid for parameter " + Convert.ToString(val));
									break;
								case "CallingConvention":
									if (pExpr is PExpr.Literal && ((PExpr.Literal)pExpr).val is Literal.Enum)
									{
										Literal.Integer val2 = ((Literal.Enum)((PExpr.Literal)pExpr).val).val;
										callingConvention = (CallingConvention)val2.AsObject(InternalType);
										break;
									}
									goto default;
								case "CharSet":
									if (pExpr is PExpr.Literal && ((PExpr.Literal)pExpr).val is Literal.Enum)
									{
										Literal.Integer val2 = ((Literal.Enum)((PExpr.Literal)pExpr).val).val;
										charSet = (CharSet)val2.AsObject(InternalType);
										break;
									}
									goto default;
								case "EntryPoint":
									if (pExpr is PExpr.Literal && ((PExpr.Literal)pExpr).val is Literal.String)
									{
										val = ((Literal.String)((PExpr.Literal)pExpr).val).val;
										text = val;
										break;
									}
									goto default;
								case "ExactSpelling":
									if (pExpr is PExpr.Literal && ((PExpr.Literal)pExpr).val is Literal.Bool)
									{
										flag3 = ((Literal.Bool)((PExpr.Literal)pExpr).val).val;
										flag7 = flag3;
										flag3 = true;
										break;
									}
									goto default;
								case "PreserveSig":
									if (pExpr is PExpr.Literal && ((PExpr.Literal)pExpr).val is Literal.Bool)
									{
										flag5 = ((Literal.Bool)((PExpr.Literal)pExpr).val).val;
										flag5 = flag5;
										break;
									}
									goto default;
								case "SetLastError":
									if (pExpr is PExpr.Literal && ((PExpr.Literal)pExpr).val is Literal.Bool)
									{
										flag4 = ((Literal.Bool)((PExpr.Literal)pExpr).val).val;
										flag4 = flag4;
										flag6 = true;
										break;
									}
									goto default;
								case "ThrowOnUnmappableChar":
									if (pExpr is PExpr.Literal && ((PExpr.Literal)pExpr).val is Literal.Bool)
									{
										flag = ((Literal.Bool)((PExpr.Literal)pExpr).val).val;
										flag8 = flag;
										flag = true;
										break;
									}
									goto default;
								}
							}
							else
							{
								Message.Error(pExpr.Location, "unnamed DllImport parameter");
							}
							list = list;
						}
						if (flag || flag2 || flag3 || flag6)
						{
							methodInfo4 = typeof(System.Reflection.Emit.MethodBuilder).GetMethod("set_BestFitMapping", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
							methodInfo3 = typeof(System.Reflection.Emit.MethodBuilder).GetMethod("set_ThrowOnUnmappableChar", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
							methodInfo2 = typeof(System.Reflection.Emit.MethodBuilder).GetMethod("set_ExactSpelling", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
							methodInfo = typeof(System.Reflection.Emit.MethodBuilder).GetMethod("set_SetLastError", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
						}
						if ((flag || flag2) && (methodInfo4 == null || methodInfo3 == null))
						{
							Message.Error("The ThrowOnUnmappableChar and BestFitMapping attributes can only be emitted when running on the mono runtime.");
						}
						if (flag7 && methodInfo2 == null)
						{
							charSet |= CharSet.None;
						}
						if (flag4 && methodInfo == null)
						{
							charSet |= (CharSet)64;
						}
						System.Reflection.Emit.MethodBuilder methodBuilder = tb.DefinePInvokeMethod(meth.Name, dllName, text, attrs | MethodAttributes.HideBySig | MethodAttributes.PinvokeImpl, CallingConventions.Standard, meth.ReturnType.GetSystemType(), parm_types_array, callingConvention, charSet);
						if (flag5)
						{
							methodBuilder.SetImplementationFlags(MethodImplAttributes.PreserveSig);
						}
						if (flag)
						{
							object obj2 = methodInfo3.Invoke(methodBuilder, System.Reflection.BindingFlags.Default, null, new object[1] { flag8 }, null);
						}
						if (flag2)
						{
							object obj2 = methodInfo4.Invoke(methodBuilder, System.Reflection.BindingFlags.Default, null, new object[1] { flag9 }, null);
						}
						if (flag3 && methodInfo2 != null)
						{
							object obj2 = methodInfo2.Invoke(methodBuilder, System.Reflection.BindingFlags.Default, null, new object[1] { flag7 }, null);
						}
						if (flag6 && methodInfo != null)
						{
							object obj2 = methodInfo.Invoke(methodBuilder, System.Reflection.BindingFlags.Default, null, new object[1] { flag4 }, null);
						}
						AttributesAndModifiers modifiers = meth.GetModifiers();
						list<PExpr> custom_attrs = meth.GetModifiers().custom_attrs;
						Function<PExpr, bool> f = new _N__N_lambda__82719__82829(n_closureOf_loop_);
						modifiers.custom_attrs = custom_attrs.Filter(f);
						result = methodBuilder;
						break;
					}
				}
				list = list;
				continue;
			}
			if ((object)list == list<PExpr>.Nil._N_constant_object)
			{
				result = null;
				break;
			}
			throw new MatchFailureException();
		}
		return (System.Reflection.Emit.MethodBuilder)result;
	}

	internal void CheckConditional(MethodBuilder mb)
	{
		_N_closureOf_CheckConditional_82863 n_closureOf_CheckConditional_ = new _N_closureOf_CheckConditional_82863();
		n_closureOf_CheckConditional_._N_mb_82870 = mb;
		n_closureOf_CheckConditional_._N__N_closurised_this_ptr_82868 = this;
		if (n_closureOf_CheckConditional_._N_mb_82870.DeclaringType.IsInterface)
		{
			Message.Error(_N_getErrorLocation_82873(n_closureOf_CheckConditional_), "Conditional attribute is not valid on interface members");
			return;
		}
		if (n_closureOf_CheckConditional_._N_mb_82870.IsConstructor || ((n_closureOf_CheckConditional_._N_mb_82870.GetModifiers().mods & NemerleModifiers.SpecialName) != 0 && n_closureOf_CheckConditional_._N_mb_82870.Header.Name.StartsWith("op_")))
		{
			Message.Error(_N_getErrorLocation_82873(n_closureOf_CheckConditional_), "Conditional attribute is not valid on constructor, operator, or explicit interface implementation");
			return;
		}
		list<Nemerle.Builtins.Tuple<FixedType.Class, IMethod>> implementedMethods = n_closureOf_CheckConditional_._N_mb_82870.ImplementedMethods;
		if (implementedMethods is list<Nemerle.Builtins.Tuple<FixedType.Class, IMethod>>.Cons)
		{
			IMethod field = ((list<Nemerle.Builtins.Tuple<FixedType.Class, IMethod>>.Cons)implementedMethods).hd.Field1;
			Message.Error(_N_getErrorLocation_82873(n_closureOf_CheckConditional_), "Conditional member `" + Convert.ToString(n_closureOf_CheckConditional_._N_mb_82870) + "' cannot implement interface member `" + Convert.ToString(field) + "'");
			return;
		}
		if ((n_closureOf_CheckConditional_._N_mb_82870.GetModifiers().mods & NemerleModifiers.Override) != 0)
		{
			Message.Error(_N_getErrorLocation_82873(n_closureOf_CheckConditional_), "Conditional attribute is not valid on `" + Convert.ToString(n_closureOf_CheckConditional_._N_mb_82870) + "' because it is an override method");
			return;
		}
		if (!n_closureOf_CheckConditional_._N_mb_82870.ReturnType.Equals(new FixedType.Void()))
		{
			Message.Error(_N_getErrorLocation_82873(n_closureOf_CheckConditional_), "Conditional attribute is not valid on `" + Convert.ToString(n_closureOf_CheckConditional_._N_mb_82870) + "' because its return type is not void");
			return;
		}
		list<TParameter> list = n_closureOf_CheckConditional_._N_mb_82870.GetParameters();
		while (list is list<TParameter>.Cons)
		{
			TParameter hd = ((list<TParameter>.Cons)list).hd;
			list = ((list<TParameter>.Cons)list).tl;
			if (hd.kind == ParmKind.Out)
			{
				Message.Error(_N_getErrorLocation_82873(n_closureOf_CheckConditional_), "conditional member `" + Convert.ToString(n_closureOf_CheckConditional_._N_mb_82870) + "' cannot have an out parameter");
				break;
			}
			list = list;
		}
	}

	private static bool is_security_attribute(TypeInfo ti)
	{
		if (ti is LibraryReference.ExternalTypeInfo)
		{
			if (true)
			{
				goto IL_001c;
			}
		}
		else if (false)
		{
			goto IL_001c;
		}
		int result = 0;
		goto IL_003c;
		IL_001c:
		result = (typeof(SecurityAttribute).IsAssignableFrom(((LibraryReference.ExternalTypeInfo)ti).SystemType) ? 1 : 0);
		goto IL_003c;
		IL_003c:
		return (byte)result != 0;
	}

	private Nemerle.Builtins.Tuple<object, FixedType> compile_expr(GlobalEnv env, PExpr expr, Typer typer, TypeVar expected = null)
	{
		_N_closureOf_compile_expr_82961 n_closureOf_compile_expr_ = new _N_closureOf_compile_expr_82961();
		n_closureOf_compile_expr_._N_expr_82968 = expr;
		n_closureOf_compile_expr_._N__N_closurised_this_ptr_82966 = this;
		PExpr pExpr = ConstantFolder.FoldConstants(env, n_closureOf_compile_expr_._N_expr_82968);
		if (pExpr == null)
		{
			throw new Recovery();
		}
		if (expected == null)
		{
			expected = typer.FreshTypeVar();
		}
		TExpr tExpr = typer.TypeExpr(pExpr, expected);
		return _N_convert_82989(n_closureOf_compile_expr_, tExpr);
	}

	private Nemerle.Builtins.Tuple<ConstructorInfo, list<object>, list<PropertyInfo>, list<object>, list<FieldInfo>, list<object>> pre_compile(GlobalEnv env, TypeBuilder ti, TypeInfo attr, list<PExpr> parms)
	{
		list<OverloadPossibility> list = null;
		list<object> list2 = null;
		list<FixedType> list3 = null;
		list<object> list4 = null;
		list<object> list5 = null;
		list<PropertyInfo> list6 = null;
		list<FieldInfo> list7 = null;
		_N_closureOf_pre_compile_83095 n_closureOf_pre_compile_ = new _N_closureOf_pre_compile_83095();
		n_closureOf_pre_compile_._N_attr_83102 = attr;
		Typer typer = new Typer(env, ti);
		list3 = list<FixedType>.Nil._N_constant_object;
		list2 = list<object>.Nil._N_constant_object;
		list7 = list<FieldInfo>.Nil._N_constant_object;
		list5 = list<object>.Nil._N_constant_object;
		list6 = list<PropertyInfo>.Nil._N_constant_object;
		list4 = list<object>.Nil._N_constant_object;
		list<PExpr> list8 = parms;
		list<IMember> list9;
		while (list8 is list<PExpr>.Cons)
		{
			PExpr hd = ((list<PExpr>.Cons)list8).hd;
			list8 = ((list<PExpr>.Cons)list8).tl;
			if (hd is PExpr.Assign && ((PExpr.Assign)hd).target is PExpr.Ref)
			{
				Name name = ((PExpr.Ref)((PExpr.Assign)hd).target).name;
				hd = ((PExpr.Assign)hd).source;
				n_closureOf_pre_compile_._N_name_83104 = name.Id;
				hd = ConstantFolder.FoldConstants(env, hd);
				Nemerle.Builtins.Tuple<object, FixedType> tuple = compile_expr(env, hd, typer);
				object field = tuple.Field0;
				FixedType field2 = tuple.Field1;
				list9 = n_closureOf_pre_compile_._N_attr_83102.LookupMember(n_closureOf_pre_compile_._N_name_83104);
				Nemerle.Builtins.Tuple<bool, IMember> obj;
				IMember hd2;
				if (list9 is list<IMember>.Cons && (object)((list<IMember>.Cons)list9).tl == list<IMember>.Nil._N_constant_object)
				{
					hd2 = ((list<IMember>.Cons)list9).hd;
					obj = hd2.MemberKind switch
					{
						MemberTypes.Field => new Nemerle.Builtins.Tuple<bool, IMember>(field0: false, hd2), 
						MemberTypes.Property => new Nemerle.Builtins.Tuple<bool, IMember>(field0: true, hd2), 
						_ => _N_problem_83118(n_closureOf_pre_compile_), 
					};
				}
				else
				{
					obj = _N_problem_83118(n_closureOf_pre_compile_);
				}
				Nemerle.Builtins.Tuple<bool, IMember> tuple2 = obj;
				bool field3 = tuple2.Field0;
				hd2 = tuple2.Field1;
				System.Reflection.MemberInfo handle = hd2.GetHandle();
				if (!(handle != null))
				{
					throw new AssertionException("ncc\\hierarchy\\CustomAttribute.n", 512, "handle != null", "");
				}
				TypeInfo declaringType = hd2.DeclaringType;
				if (declaringType is TypeBuilder)
				{
					((TypeBuilder)declaringType).EmitImplementation();
				}
				FixedType memType = hd2.GetMemType();
				if (!field2.Require(memType))
				{
					Message.Error(Location.Default, "the member `" + Convert.ToString(n_closureOf_pre_compile_._N_name_83104) + "' has type " + Convert.ToString(hd2.GetMemType()) + " while the value assigned has type " + Convert.ToString(field2));
					throw new Recovery();
				}
				if (field3)
				{
					list6 = new list<PropertyInfo>.Cons((PropertyInfo)handle, list6);
					list4 = new list<object>.Cons(field, list4);
				}
				else
				{
					list7 = new list<FieldInfo>.Cons((FieldInfo)handle, list7);
					list5 = new list<object>.Cons(field, list5);
				}
			}
			else
			{
				Nemerle.Builtins.Tuple<object, FixedType> tuple = compile_expr(env, hd, typer);
				object field = tuple.Field0;
				FixedType field2 = tuple.Field1;
				list3 = new list<FixedType>.Cons(field2, list3);
				list2 = new list<object>.Cons(field, list2);
			}
			list8 = list8;
		}
		list = list<OverloadPossibility>.Nil._N_constant_object;
		list9 = n_closureOf_pre_compile_._N_attr_83102.LookupMember(".ctor");
		IMethod method;
		while (list9 is list<IMember>.Cons)
		{
			IMember hd2 = ((list<IMember>.Cons)list9).hd;
			list9 = ((list<IMember>.Cons)list9).tl;
			if (hd2 is IMethod)
			{
				method = (IMethod)hd2;
				if (method.IsConstructor && !method.IsPrivate)
				{
					FixedType.Fun memType2 = method.GetMemType();
					FixedType.Class memType3 = n_closureOf_pre_compile_._N_attr_83102.GetMemType();
					list = new list<OverloadPossibility>.Cons(new OverloadPossibility(typer, memType2, null, memType3, method), list);
					if (method.IsVarArgs)
					{
						OverloadPossibility overloadPossibility = new OverloadPossibility(typer, memType2, null, memType3, method);
						overloadPossibility.VarArgs = true;
						list = new list<OverloadPossibility>.Cons(overloadPossibility, list);
					}
				}
			}
			list9 = list9;
		}
		list<FixedType> list10 = list3;
		Function<FixedType, Parm> instance = _N__N_lambda__83072__83170.Instance;
		list<Parm> parms2 = list10.RevMap(instance);
		list = typer.ResolveOverload(list, parms2, Manager.InternalType.Void, speculative: false, LocationStack.Top());
		if ((object)list == list<OverloadPossibility>.Nil._N_constant_object)
		{
			Message.Error(Location.Default, "none of the constructors of `" + Convert.ToString(n_closureOf_pre_compile_._N_attr_83102.FullName) + "'matches positional argument types " + Convert.ToString(list3.Rev()));
			throw new Recovery();
		}
		object obj2;
		if (list is list<OverloadPossibility>.Cons && (object)((list<OverloadPossibility>.Cons)list).tl == list<OverloadPossibility>.Nil._N_constant_object)
		{
			OverloadPossibility overloadPossibility = ((list<OverloadPossibility>.Cons)list).hd;
			obj2 = (IMethod)overloadPossibility.Member;
		}
		else
		{
			list = list;
			Message.Error("ambiguity between custom attribute constructors " + Convert.ToString(list));
			obj2 = (IMethod)list.Head.Member;
		}
		method = (IMethod)obj2;
		if (method.IsVarArgs)
		{
			list<object> l = list2;
			int length = method.GetParameters().Length;
			int length2 = list2.Length;
			n_closureOf_pre_compile_._N_count_83100 = checked(length2 - length);
			Function<object, bool> pred = new _N__N_lambda__83084__83194(n_closureOf_pre_compile_);
			Nemerle.Builtins.Tuple<list<object>, list<object>> tuple3 = NList.Partition(l, pred);
			list<object> field4 = tuple3.Field0;
			list2 = tuple3.Field1;
			list2 = new list<object>.Cons(field4.Rev().ToArray(), list2);
		}
		if (method is MethodBuilder)
		{
			((MethodBuilder)method).HasBeenUsed = true;
		}
		return new Nemerle.Builtins.Tuple<ConstructorInfo, list<object>, list<PropertyInfo>, list<object>, list<FieldInfo>, list<object>>(method.GetConstructorInfo(), list2, list6, list4, list7, list5);
	}

	private Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool> do_compile(GlobalEnv env, TypeBuilder ti, TypeInfo attr, list<PExpr> parms)
	{
		Nemerle.Builtins.Tuple<ConstructorInfo, list<object>, list<PropertyInfo>, list<object>, list<FieldInfo>, list<object>> tuple = pre_compile(env, ti, attr, parms);
		ConstructorInfo field = tuple.Field0;
		list<object> field2 = tuple.Field1;
		list<PropertyInfo> field3 = tuple.Field2;
		list<object> field4 = tuple.Field3;
		list<FieldInfo> field5 = tuple.Field4;
		list<object> field6 = tuple.Field5;
		CustomAttributeBuilder field7 = new CustomAttributeBuilder(field, field2.Reverse().ToArray(), field3.Reverse().ToArray(), field4.Reverse().ToArray(), field5.Reverse().ToArray(), field6.Reverse().ToArray());
		bool field8 = !attr.IsConditional || attr.EvalConditions(env);
		return new Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool>(field7, field8);
	}

	private object create_instance(GlobalEnv env, TypeInfo ti, list<PExpr> parms)
	{
		_N_closureOf_create_instance_83253 n_closureOf_create_instance_ = new _N_closureOf_create_instance_83253();
		Nemerle.Builtins.Tuple<ConstructorInfo, list<object>, list<PropertyInfo>, list<object>, list<FieldInfo>, list<object>> tuple = pre_compile(env, null, ti, parms);
		ConstructorInfo field = tuple.Field0;
		list<object> field2 = tuple.Field1;
		list<PropertyInfo> field3 = tuple.Field2;
		list<object> field4 = tuple.Field3;
		list<FieldInfo> field5 = tuple.Field4;
		list<object> field6 = tuple.Field5;
		n_closureOf_create_instance_._N_obj_83258 = field.Invoke(field2.Reverse().ToArray());
		FunctionVoid<PropertyInfo, object> f = new _N__N_lambda__83239__83264(n_closureOf_create_instance_);
		NList.Iter2(field3, field4, f);
		FunctionVoid<FieldInfo, object> f2 = new _N__N_lambda__83245__83273(n_closureOf_create_instance_);
		NList.Iter2(field5, field6, f2);
		return n_closureOf_create_instance_._N_obj_83258;
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

	private list<string>.Cons _N_add_end_82207(_N_closureOf_ResolveAttribute_82197 _N_ResolveAttribute_cp_82206, list<string> l, string suff)
	{
		if (l is list<string>.Cons)
		{
			list<string>.Cons result;
			if ((object)((list<string>.Cons)l).tl == list<string>.Nil._N_constant_object)
			{
				string hd = ((list<string>.Cons)l).hd;
				result = new list<string>.Cons(hd + suff, list<string>.Nil._N_constant_object);
			}
			else
			{
				string hd = ((list<string>.Cons)l).hd;
				list<string> tl = ((list<string>.Cons)l).tl;
				result = new list<string>.Cons(hd, _N_add_end_82207(_N_ResolveAttribute_cp_82206, tl, suff));
			}
			return result;
		}
		if (!Message.SeenError)
		{
			string hd = "empty".ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(hd) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\hierarchy\\CustomAttribute.n", 76, "", "empty");
	}

	private bool _N_is_attribute_82233(_N_closureOf_ResolveAttribute_82197 _N_ResolveAttribute_cp_82232, TypeInfo t)
	{
		return (_N_ResolveAttribute_cp_82232._N_expect_exact_82204 == null) ? t.IsDerivedFrom(InternalType.Attribute_tc) : t.Equals(_N_ResolveAttribute_cp_82232._N_expect_exact_82204);
	}

	private Location _N_getErrorLocation_82873(_N_closureOf_CheckConditional_82863 _N_CheckConditional_cp_82872)
	{
		option<PExpr> option = _N_CheckConditional_cp_82872._N_mb_82870.GetModifiers().FindAttribute(InternalType.Conditional_tc, _N_CheckConditional_cp_82872._N_mb_82870.GlobalEnv);
		if (option is option<PExpr>.Some)
		{
			PExpr val = ((option<PExpr>.Some)option).val;
			return val.Location;
		}
		if (!Message.SeenError)
		{
			string text = ("Conditional attribute not found in `" + Convert.ToString(_N_CheckConditional_cp_82872._N_mb_82870) + "'").ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\hierarchy\\CustomAttribute.n", 371, "", ("Conditional attribute not found in `" + Convert.ToString(_N_CheckConditional_cp_82872._N_mb_82870) + "'").ToString());
	}

	private Nemerle.Builtins.Tuple<object, FixedType> _N_compile_type_82971(_N_closureOf_compile_expr_82961 _N_compile_expr_cp_82970, Location loc, FixedType fixedType)
	{
		if (fixedType is FixedType.Class || fixedType is FixedType.Fun || fixedType is FixedType.Tuple || fixedType is FixedType.Array || fixedType is FixedType.Void)
		{
			return new Nemerle.Builtins.Tuple<object, FixedType>(fixedType.GetSystemType(), InternalType.Type);
		}
		Message.Error(loc, "invalid type in attribute parameter");
		throw new Recovery();
	}

	private Nemerle.Builtins.Tuple<object, FixedType> _N_convert_82989(_N_closureOf_compile_expr_82961 _N_compile_expr_cp_82988, TExpr tExpr)
	{
		Nemerle.Builtins.Tuple<object, FixedType> result;
		while (true)
		{
			if (tExpr is TExpr.Literal)
			{
				if (((TExpr.Literal)tExpr).val is Literal.Decimal)
				{
					Message.Error(tExpr.Location, "An attribute argument cannot be number of type decimal");
					throw new Recovery();
				}
				Literal val = ((TExpr.Literal)tExpr).val;
				result = new Nemerle.Builtins.Tuple<object, FixedType>(val.AsObject(InternalType), val.GetInternalType(InternalType));
				break;
			}
			if (tExpr is TExpr.TypeConversion)
			{
				if (((TExpr.TypeConversion)tExpr).kind == ConversionKind.UpCast._N_constant_object)
				{
					TExpr expr = ((TExpr.TypeConversion)tExpr).expr;
					TypeVar target_type = ((TExpr.TypeConversion)tExpr).target_type;
					if (expr.Type.TryRequire(target_type))
					{
						tExpr = expr;
						continue;
					}
					if (((TExpr.TypeConversion)tExpr).expr is TExpr.Literal)
					{
						TExpr.Literal literal = (TExpr.Literal)((TExpr.TypeConversion)tExpr).expr;
						Literal val = ((TExpr.Literal)((TExpr.TypeConversion)tExpr).expr).val;
						target_type = ((TExpr.TypeConversion)tExpr).target_type;
						option<Literal> option = ConstantFolder.ConvertLiteral(val, target_type.Fix());
						if (option is option<Literal>.Some)
						{
							val = ((option<Literal>.Some)option).val;
							tExpr = new TExpr.Literal(literal.Location, target_type, val);
							continue;
						}
						Message.Error(tExpr.Location, "Type conversion from " + Convert.ToString(literal.Type) + " to " + Convert.ToString(target_type) + " in attribute a argument is unsupported.");
						throw new Recovery();
					}
				}
				else if (!(((TExpr.TypeConversion)tExpr).expr is TExpr.Literal))
				{
				}
			}
			else
			{
				if (tExpr is TExpr.Array)
				{
					if (((TExpr.Array)tExpr).dimensions is list<TExpr>.Cons)
					{
						list<TExpr> list = ((TExpr.Array)tExpr).args;
						if ((object)((list<TExpr>.Cons)((TExpr.Array)tExpr).dimensions).tl == list<TExpr>.Nil._N_constant_object)
						{
							Function<TExpr, object> f = new _N__N_lambda__82952__83014(_N_compile_expr_cp_82988);
							object[] field = list.MapToArray(f);
							FixedType field2 = tExpr.Type.Fix();
							result = new Nemerle.Builtins.Tuple<object, FixedType>(field, field2);
							break;
						}
					}
					Message.Error(tExpr.Location, "only single-dimensional arrays allowed in attributes");
					throw new Recovery();
				}
				if (tExpr is TExpr.TypeOf)
				{
					TypeVar target_type = ((TExpr.TypeOf)tExpr).target_type;
					result = _N_compile_type_82971(_N_compile_expr_cp_82988, tExpr.Location, target_type.Fix());
					break;
				}
				if (tExpr is TExpr.Error)
				{
					throw new Recovery();
				}
				if (tExpr is TExpr.DebugInfo)
				{
					TExpr expr = ((TExpr.DebugInfo)tExpr).expr;
					tExpr = expr;
					continue;
				}
			}
			Message.Error(tExpr.Location, "only constant expressions allowed in attributes: " + Convert.ToString(_N_compile_expr_cp_82988._N_expr_82968) + " (" + Convert.ToString(tExpr.Type) + ")");
			throw new Recovery();
		}
		return result;
	}

	private static Nemerle.Builtins.Tuple<bool, IMember> _N_problem_83118(_N_closureOf_pre_compile_83095 _N_pre_compile_cp_83117)
	{
		//Discarded unreachable code: IL_0054
		Message.Error(Location.Default, "the type " + Convert.ToString(_N_pre_compile_cp_83117._N_attr_83102.FullName) + " has no field nor property named `" + Convert.ToString(_N_pre_compile_cp_83117._N_name_83104) + "'");
		throw new Recovery();
	}
}
