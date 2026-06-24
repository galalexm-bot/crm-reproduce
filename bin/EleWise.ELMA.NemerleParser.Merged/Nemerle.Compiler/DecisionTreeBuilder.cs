using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

internal class DecisionTreeBuilder : ISupportRelocation
{
	private class IgnoreCounterExample : Exception, ISupportRelocation
	{
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

	[Variant("Nemerle.Compiler.DecisionTreeBuilder.Con.Variant,Nemerle.Compiler.DecisionTreeBuilder.Con.Lit,Nemerle.Compiler.DecisionTreeBuilder.Con.Type,Nemerle.Compiler.DecisionTreeBuilder.Con.Guard,Nemerle.Compiler.DecisionTreeBuilder.Con.Unspecified,Nemerle.Compiler.DecisionTreeBuilder.Con.Not")]
	protected internal abstract class Con : IEquatable<Con>, ISupportRelocation
	{
		[VariantOption]
		public class Variant : Con
		{
			public readonly TypeInfo ti;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			public Variant([MappedMember("ti")] TypeInfo ti)
			{
				this.ti = ti;
			}
		}

		[VariantOption]
		public class Lit : Con
		{
			public readonly Literal lit;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (!_info.VisitedObjects.ContainsKey(this))
				{
					base.RelocateImplInternal(_info);
					_info.VisitedObjects[this] = 0;
					lit?.RelocateImplInternal(_info);
				}
			}

			[RecordCtor]
			public Lit([MappedMember("lit")] Literal lit)
			{
				this.lit = lit;
			}
		}

		[VariantOption]
		public class Type : Con
		{
			public readonly FixedType ti;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 2;
			}

			[RecordCtor]
			public Type([MappedMember("ti")] FixedType ti)
			{
				this.ti = ti;
			}
		}

		[ConstantVariantOption]
		public class Guard : Con
		{
			public static readonly Guard _N_constant_object;

			[SpecialName]
			public static Guard _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static Guard()
			{
				_N_constant_object = new Guard();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 3;
			}

			[RecordCtor]
			private Guard()
			{
			}
		}

		[ConstantVariantOption]
		public class Unspecified : Con
		{
			public static readonly Unspecified _N_constant_object;

			[SpecialName]
			public static Unspecified _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static Unspecified()
			{
				_N_constant_object = new Unspecified();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 4;
			}

			[RecordCtor]
			private Unspecified()
			{
			}
		}

		[VariantOption]
		public class Not : Con
		{
			public readonly list<Con> lst;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 5;
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
				list<Con> list = lst;
				if (list != null)
				{
					list = list;
					while (list is list<Con>.Cons)
					{
						Con hd = ((list<Con>.Cons)list).hd;
						list = ((list<Con>.Cons)list).tl;
						((ISupportRelocation)hd).RelocateImpl(_info);
						list = list;
					}
				}
			}

			[RecordCtor]
			public Not([MappedMember("lst")] list<Con> lst)
			{
				this.lst = lst;
			}
		}

		private sealed class _N_closureOf_get_cmpf_96000
		{
			internal Literal _N_val_96005;

			internal _N_closureOf_get_cmpf_96000()
			{
			}
		}

		private sealed class _N__N_lambda__95947__96010 : Function<Con, bool>
		{
			[SpecialName]
			private _N_closureOf_get_cmpf_96000 _N_get_cmpf_closure_96014;

			public _N__N_lambda__95947__96010(_N_closureOf_get_cmpf_96000 _N_get_cmpf_closure_96014)
			{
				this._N_get_cmpf_closure_96014 = _N_get_cmpf_closure_96014;
			}

			[SpecialName]
			public sealed override bool apply(Con l)
			{
				int result;
				if (l is Lit)
				{
					Literal lit = ((Lit)l).lit;
					result = (_N_get_cmpf_closure_96014._N_val_96005.Equals(lit) ? 1 : 0);
				}
				else
				{
					result = 0;
				}
				return (byte)result != 0;
			}
		}

		private sealed class _N__N_lambda__95953__96028 : Function<Con, bool>
		{
			[SpecialName]
			private _N_closureOf_get_cmpf_96000 _N_get_cmpf_closure_96032;

			public _N__N_lambda__95953__96028(_N_closureOf_get_cmpf_96000 _N_get_cmpf_closure_96032)
			{
				this._N_get_cmpf_closure_96032 = _N_get_cmpf_closure_96032;
			}

			[SpecialName]
			public sealed override bool apply(Con l)
			{
				int result;
				if (l is Lit && ((Lit)l).lit is Literal.Enum)
				{
					Literal.Integer val = ((Literal.Enum)((Lit)l).lit).val;
					result = (_N_get_cmpf_closure_96032._N_val_96005.Equals(val) ? 1 : 0);
				}
				else
				{
					result = 0;
				}
				return (byte)result != 0;
			}
		}

		private sealed class _N__N_lambda__95980__96085 : Function<Con, bool>
		{
			[SpecialName]
			public static readonly _N__N_lambda__95980__96085 Instance = new _N__N_lambda__95980__96085();

			[SpecialName]
			public sealed override bool apply(Con x)
			{
				bool flag = ((x is Lit && ((Lit)x).lit is Literal.Null) ? true : false);
				return !flag;
			}
		}

		public int Span
		{
			get
			{
				int result;
				if (this is Variant)
				{
					TypeInfo ti = ((Variant)this).ti;
					TypeDeclaration tydecl = ti.SuperClass().UnSome().GetTydecl();
					if (tydecl is TypeDeclaration.Variant)
					{
						list<TypeInfo> list = ((TypeDeclaration.Variant)tydecl).members;
						result = checked(list.Length + 1);
					}
					else
					{
						if (tydecl != TypeDeclaration.Class._N_constant_object)
						{
							throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 245, "", "");
						}
						result = -1;
					}
				}
				else
				{
					if (!(this is Lit))
					{
						if (this is Type || this == Guard._N_constant_object || this == Unspecified._N_constant_object || this is Not)
						{
							goto IL_0107;
						}
						throw new MatchFailureException();
					}
					if (((Lit)this).lit is Literal.Bool)
					{
						result = 2;
					}
					else
					{
						if (!(((Lit)this).lit is Literal.Void))
						{
							goto IL_0107;
						}
						result = 1;
					}
				}
				goto IL_0113;
				IL_0113:
				return result;
				IL_0107:
				result = -1;
				goto IL_0113;
			}
		}

		public bool Equals(Con con)
		{
			Con con2 = null;
			con2 = this;
			int result;
			if (con2 is Variant)
			{
				if (!(con is Variant))
				{
					goto IL_00fc;
				}
				TypeInfo ti = ((Variant)con2).ti;
				TypeInfo ti2 = ((Variant)con).ti;
				result = (ti.Equals(ti2) ? 1 : 0);
			}
			else if (con2 is Lit)
			{
				if (!(con is Lit))
				{
					goto IL_00fc;
				}
				Literal lit = ((Lit)con2).lit;
				Literal lit2 = ((Lit)con).lit;
				result = (lit.Equals(lit2) ? 1 : 0);
			}
			else if (con2 is Type)
			{
				if (!(con is Type))
				{
					goto IL_00fc;
				}
				FixedType ti3 = ((Type)con2).ti;
				FixedType ti4 = ((Type)con).ti;
				result = (ti3.Equals(ti4) ? 1 : 0);
			}
			else
			{
				if (con2 != Guard._N_constant_object || con != Guard._N_constant_object)
				{
					goto IL_00fc;
				}
				result = 1;
			}
			goto IL_00fd;
			IL_00fc:
			result = 0;
			goto IL_00fd;
			IL_00fd:
			return (byte)result != 0;
		}

		private static string FindValueExcept(list<Con> cons, bool throw_ignore = false)
		{
			string text = null;
			object result;
			if ((object)cons == list<Con>.Nil._N_constant_object)
			{
				result = "_";
			}
			else
			{
				if (!(cons is list<Con>.Cons))
				{
					goto IL_01de;
				}
				if (((list<Con>.Cons)cons).hd is Lit)
				{
					if (!(((Lit)((list<Con>.Cons)cons).hd).lit is Literal.Bool))
					{
						if (((Lit)((list<Con>.Cons)cons).hd).lit is Literal.Enum)
						{
							TypeInfo ty = ((Literal.Enum)((Lit)((list<Con>.Cons)cons).hd).lit).ty;
							if (!ty.HasAttribute(ty.Manager.InternalType.FlagsAttribute_tc))
							{
								text = null;
								list<IMember> list = ty.GetMembers();
								while (list is list<IMember>.Cons)
								{
									IMember hd = ((list<IMember>.Cons)list).hd;
									list = ((list<IMember>.Cons)list).tl;
									if (hd is IField)
									{
										IField field = (IField)hd;
										if (field.IsLiteral && field.DeclaringType.Equals(ty) && !((list<Con>.Cons)cons).Exists(_N_get_cmpf_95995(field.GetValue())))
										{
											text = field.Name;
										}
									}
									list = list;
								}
								if (text == null && throw_ignore)
								{
									throw new IgnoreCounterExample();
								}
								if (!(text != null))
								{
									throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 170, "res != null", "");
								}
								result = text;
								goto IL_0361;
							}
						}
						goto IL_01de;
					}
					result = ((!((Literal.Bool)((Lit)((list<Con>.Cons)cons).hd).lit).val) ? "true" : "false");
				}
				else
				{
					if (!(((list<Con>.Cons)cons).hd is Variant))
					{
						goto IL_01de;
					}
					list<Con>.Cons cons2 = (list<Con>.Cons)cons;
					TypeInfo ty = ((Variant)((list<Con>.Cons)cons).hd).ti;
					TypeDeclaration tydecl = ty.SuperClass().UnSome().GetTydecl();
					if (!(tydecl is TypeDeclaration.Variant))
					{
						throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 187, "", "");
					}
					list<TypeInfo> list2 = ((TypeDeclaration.Variant)tydecl).members;
					text = null;
					list2 = list2;
					while (list2 is list<TypeInfo>.Cons)
					{
						ty = ((list<TypeInfo>.Cons)list2).hd;
						list2 = ((list<TypeInfo>.Cons)list2).tl;
						ty = ty;
						if (!cons2.Contains(new Variant(ty)))
						{
							text = ty.Name;
						}
						list2 = list2;
					}
					if (text == null)
					{
						Function<Con, bool> instance = _N__N_lambda__95980__96085.Instance;
						if (cons2.ForAll(instance))
						{
							if (throw_ignore)
							{
								throw new IgnoreCounterExample();
							}
							text = "null";
						}
					}
					if (!(text != null))
					{
						throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 185, "res != null", "");
					}
					result = text;
				}
			}
			goto IL_0361;
			IL_0361:
			return (string)result;
			IL_01de:
			result = "(anything except " + Convert.ToString(cons) + ")";
			goto IL_0361;
		}

		public string ToString(bool throw_ignore)
		{
			object result;
			if (this is Variant)
			{
				TypeInfo ti = ((Variant)this).ti;
				result = ti.ToString();
			}
			else if (this is Lit)
			{
				Literal lit = ((Lit)this).lit;
				result = lit.ToString();
			}
			else if (this is Type)
			{
				FixedType ti2 = ((Type)this).ti;
				result = "is " + Convert.ToString(ti2);
			}
			else if (this == Guard._N_constant_object)
			{
				result = "GUARD";
			}
			else if (this == Unspecified._N_constant_object)
			{
				result = "UNSPECIFIED";
			}
			else
			{
				if (!(this is Not))
				{
					throw new MatchFailureException();
				}
				list<Con> cons = ((Not)this).lst;
				result = FindValueExcept(cons, throw_ignore);
			}
			return (string)result;
		}

		public override string ToString()
		{
			return ToString(throw_ignore: false);
		}

		public override int GetHashCode()
		{
			int result;
			if (this is Variant)
			{
				TypeInfo ti = ((Variant)this).ti;
				result = ti.GetHashCode();
			}
			else if (this is Lit)
			{
				Literal lit = ((Lit)this).lit;
				result = lit.GetHashCode();
			}
			else if (this is Type)
			{
				FixedType ti2 = ((Type)this).ti;
				result = ti2.GetHashCode();
			}
			else if (this == Guard._N_constant_object)
			{
				result = 4;
			}
			else
			{
				if (this != Unspecified._N_constant_object && !(this is Not))
				{
					throw new MatchFailureException();
				}
				result = 0;
			}
			return result;
		}

		public override bool Equals(object other)
		{
			return other == this || (other is Con && Equals((Con)other));
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(Con x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is Con)) ? (-1) : ((Con)x)._N_GetVariantCode();
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

		private static Function<Con, bool> _N_get_cmpf_95995(Literal val)
		{
			_N_closureOf_get_cmpf_96000 n_closureOf_get_cmpf_ = new _N_closureOf_get_cmpf_96000();
			n_closureOf_get_cmpf_._N_val_96005 = val;
			Function<Con, bool> result;
			if (n_closureOf_get_cmpf_._N_val_96005 is Literal.Enum)
			{
				Function<Con, bool> function = new _N__N_lambda__95947__96010(n_closureOf_get_cmpf_);
				result = function;
			}
			else
			{
				if (!(n_closureOf_get_cmpf_._N_val_96005 is Literal.Integer))
				{
					throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 155, "(val is Literal.Integer)", "");
				}
				Function<Con, bool> function = new _N__N_lambda__95953__96028(n_closureOf_get_cmpf_);
				result = function;
			}
			return result;
		}
	}

	private class Skeleton : ISupportRelocation
	{
		private sealed class _N_closureOf_Select_96366
		{
			internal IMember _N_fld_96371;

			internal _N_closureOf_Select_96366()
			{
			}
		}

		private sealed class _N__N_lambda__96357__96381 : Function<Skeleton, bool>
		{
			[SpecialName]
			private _N_closureOf_Select_96366 _N_Select_closure_96385;

			public _N__N_lambda__96357__96381(_N_closureOf_Select_96366 _N_Select_closure_96385)
			{
				this._N_Select_closure_96385 = _N_Select_closure_96385;
			}

			[SpecialName]
			public sealed override bool apply(Skeleton td)
			{
				return td.field.Equals(_N_Select_closure_96385._N_fld_96371);
			}
		}

		private readonly IMember field;

		private list<Con> is_not;

		private Con is_con;

		private list<Skeleton> args;

		public void AddPositive(Con con)
		{
			if (is_con != null)
			{
				throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 276, "is_con == null", "");
			}
			is_con = con;
			args = list<Skeleton>.Nil._N_constant_object;
			is_not = null;
		}

		public void AddNegative(Con con)
		{
			if (is_con != null)
			{
				throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 286, "is_con == null", "");
			}
			if (is_not.Contains(con))
			{
				throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 287, "!is_not.Contains(con)", "");
			}
			is_not = new list<Con>.Cons(con, is_not);
		}

		public bool IsIt(Con con)
		{
			Con con2 = null;
			int result;
			if (is_con == null)
			{
				list<Con> list = is_not;
				if (((((object)list == list<Con>.Nil._N_constant_object) ? true : false) && con.Span != 1) || is_not.Contains(con))
				{
					result = 0;
				}
				else
				{
					int num = ((!(con is Con.Lit) || !(((Con.Lit)con).lit is Literal.Null)) ? con.Span : is_not.Head.Span);
					if (checked(is_not.Length + 1) == num)
					{
						AddPositive(con);
						result = 1;
					}
					else
					{
						result = 0;
					}
				}
			}
			else
			{
				con2 = is_con;
				if (con2 is Con.Variant || con2 is Con.Lit)
				{
					result = (is_con.Equals(con) ? 1 : 0);
				}
				else if (con2 is Con.Type && con is Con.Type)
				{
					FixedType ti = ((Con.Type)con2).ti;
					FixedType ti2 = ((Con.Type)con).ti;
					result = (ti.TryRequire(ti2) ? 1 : 0);
				}
				else
				{
					result = 0;
				}
			}
			return (byte)result != 0;
		}

		public bool CanBe(Con con)
		{
			Con con2 = null;
			int result;
			if (is_con == null)
			{
				result = ((!is_not.Contains(con)) ? 1 : 0);
			}
			else
			{
				con2 = is_con;
				if (con2 is Con.Variant || con2 is Con.Lit)
				{
					result = (is_con.Equals(con) ? 1 : 0);
				}
				else if (con2 is Con.Type && con is Con.Type)
				{
					FixedType ti = ((Con.Type)con2).ti;
					FixedType ti2 = ((Con.Type)con).ti;
					result = (ti.TryRequire(ti2) ? 1 : 0);
				}
				else
				{
					result = 0;
				}
			}
			return (byte)result != 0;
		}

		public Nemerle.Builtins.Tuple<list<Con>, Con, list<Skeleton>> Save()
		{
			return new Nemerle.Builtins.Tuple<list<Con>, Con, list<Skeleton>>(is_not, is_con, args);
		}

		public void Restore(list<Con> is_not, Con is_con, list<Skeleton> args)
		{
			this.is_not = is_not;
			this.is_con = is_con;
			this.args = args;
		}

		private Skeleton(IMember f)
		{
			field = f;
			is_not = list<Con>.Nil._N_constant_object;
		}

		public static Skeleton Empty()
		{
			return new Skeleton(null);
		}

		public Skeleton Select(IMember fld)
		{
			_N_closureOf_Select_96366 n_closureOf_Select_ = new _N_closureOf_Select_96366();
			n_closureOf_Select_._N_fld_96371 = fld;
			if (is_con == null)
			{
				is_con = Con.Unspecified._N_constant_object;
				is_not = null;
				args = list<Skeleton>.Nil._N_constant_object;
			}
			list<Skeleton> list = args;
			Function<Skeleton, bool> pred = new _N__N_lambda__96357__96381(n_closureOf_Select_);
			option<Skeleton> option = list.Find(pred);
			Skeleton result;
			if (option is option<Skeleton>.Some)
			{
				Skeleton val = ((option<Skeleton>.Some)option).val;
				result = val;
			}
			else
			{
				if (option != option<Skeleton>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				Skeleton val = new Skeleton(n_closureOf_Select_._N_fld_96371);
				args = new list<Skeleton>.Cons(val, args);
				result = val;
			}
			return result;
		}

		public override string ToString()
		{
			return (is_con != null) ? ("Pos(" + Convert.ToString(is_con) + "(" + Convert.ToString(args) + "))") : ("Neg(" + Convert.ToString(is_not) + ")");
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (_info.VisitedObjects.ContainsKey(this))
			{
				return;
			}
			_info.VisitedObjects[this] = 0;
			list<Skeleton> list = args;
			if (list != null)
			{
				list = list;
				while (list is list<Skeleton>.Cons)
				{
					Skeleton hd = ((list<Skeleton>.Cons)list).hd;
					list = ((list<Skeleton>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			is_con?.RelocateImplInternal(_info);
			list<Con> list2 = is_not;
			if (list2 != null)
			{
				list2 = list2;
				while (list2 is list<Con>.Cons)
				{
					Con hd2 = ((list<Con>.Cons)list2).hd;
					list2 = ((list<Con>.Cons)list2).tl;
					((ISupportRelocation)hd2).RelocateImpl(_info);
					list2 = list2;
				}
			}
			IMember member = field;
			if (member != null)
			{
				((ISupportRelocation)member).RelocateImpl(_info);
			}
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}
	}

	[Variant("Nemerle.Compiler.DecisionTreeBuilder.Path.Here,Nemerle.Compiler.DecisionTreeBuilder.Path.Field")]
	protected internal abstract class Path : IEquatable<Path>, ISupportRelocation
	{
		[VariantOption]
		public class Here : Path
		{
			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			public Here(TypeVar ty)
				: base(ty)
			{
			}

			[RecordCtor]
			public Here()
			{
			}
		}

		[VariantOption]
		public class Field : Path
		{
			public readonly IMember field;

			public readonly Path path;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (!_info.VisitedObjects.ContainsKey(this))
				{
					base.RelocateImplInternal(_info);
					_info.VisitedObjects[this] = 0;
					path?.RelocateImplInternal(_info);
					IMember member = field;
					if (member != null)
					{
						((ISupportRelocation)member).RelocateImpl(_info);
					}
				}
			}

			[RecordCtor]
			public Field(TypeVar ty, [MappedMember("field")] IMember field, [MappedMember("path")] Path path)
				: base(ty)
			{
				this.field = field;
				this.path = path;
			}

			[RecordCtor]
			public Field([MappedMember("field")] IMember field, [MappedMember("path")] Path path)
			{
				this.field = field;
				this.path = path;
			}
		}

		[IgnoreField]
		[IgnoreField]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _N_is_cached_18577;

		[IgnoreField]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[IgnoreField]
		private int _N_cached_value_18576;

		private readonly TypeVar ty;

		private TExpr access_expr;

		public TypeVar Type => ty;

		public TExpr AccessExpr
		{
			[CompilerGenerated]
			[DebuggerStepThrough]
			get
			{
				return access_expr;
			}
			[CompilerGenerated]
			[DebuggerStepThrough]
			set
			{
				access_expr = value;
			}
		}

		public Path(TypeVar ty)
		{
			this.ty = ty;
			access_expr = null;
		}

		public Path()
		{
			ty = null;
			access_expr = null;
		}

		public override string ToString()
		{
			object result;
			if (this is Here)
			{
				result = "obj";
			}
			else
			{
				if (!(this is Field))
				{
					throw new MatchFailureException();
				}
				IMember field = ((Field)this).field;
				Path path = ((Field)this).path;
				result = "(" + Convert.ToString(path) + " : " + Convert.ToString(field.DeclaringType) + ")." + Convert.ToString(field.Name);
			}
			return (string)result;
		}

		public bool Equals(Path path)
		{
			Path path2 = null;
			path2 = this;
			int result;
			if (path2 is Here)
			{
				if (!(path is Here))
				{
					goto IL_0020;
				}
				result = 1;
			}
			else
			{
				if (!(path2 is Field) || !(path is Field))
				{
					goto IL_0020;
				}
				IMember field = ((Field)path2).field;
				path2 = ((Field)path2).path;
				IMember field2 = ((Field)path).field;
				Path path3 = ((Field)path).path;
				result = ((field.Equals(field2) && path2.Equals(path3)) ? 1 : 0);
			}
			goto IL_0093;
			IL_0020:
			result = 0;
			goto IL_0093;
			IL_0093:
			return (byte)result != 0;
		}

		public override int GetHashCode()
		{
			if (!_N_is_cached_18577)
			{
				int n_cached_value_;
				if (this is Here)
				{
					n_cached_value_ = 0;
				}
				else
				{
					if (!(this is Field))
					{
						throw new MatchFailureException();
					}
					IMember field = ((Field)this).field;
					Path path = ((Field)this).path;
					n_cached_value_ = field.GetHashCode() + path.GetHashCode();
				}
				int num = (_N_cached_value_18576 = n_cached_value_);
				_N_is_cached_18577 = true;
			}
			return _N_cached_value_18576;
		}

		public override bool Equals(object other)
		{
			return other == this || (other is Path && Equals((Path)other));
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(Path x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is Path)) ? (-1) : ((Path)x)._N_GetVariantCode();
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				_info.VisitedObjects[this] = 0;
				access_expr?.RelocateImplInternal(_info);
			}
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}
	}

	[Variant("Nemerle.Compiler.DecisionTreeBuilder.Decision.Success,Nemerle.Compiler.DecisionTreeBuilder.Decision.Failure,Nemerle.Compiler.DecisionTreeBuilder.Decision.Assign,Nemerle.Compiler.DecisionTreeBuilder.Decision.IfEq")]
	protected internal abstract class Decision : IEquatable<Decision>, ISupportRelocation
	{
		[VariantOption]
		public class Success : Decision
		{
			public readonly int res;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			public Success(Location loc, [MappedMember("res")] int res)
				: base(loc)
			{
				this.res = res;
			}
		}

		[VariantOption]
		public class Failure : Decision
		{
			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
			}

			[RecordCtor]
			public Failure(Location loc)
				: base(loc)
			{
			}
		}

		[VariantOption]
		public class Assign : Decision
		{
			public readonly Path path;

			public readonly LocalValue decl;

			public readonly Decision dtree;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 2;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (!_info.VisitedObjects.ContainsKey(this))
				{
					base.RelocateImplInternal(_info);
					_info.VisitedObjects[this] = 0;
					dtree?.RelocateImplInternal(_info);
					decl?.RelocateImplInternal(_info);
					path?.RelocateImplInternal(_info);
				}
			}

			[RecordCtor]
			public Assign(Location loc, [MappedMember("path")] Path path, [MappedMember("decl")] LocalValue decl, [MappedMember("dtree")] Decision dtree)
				: base(loc)
			{
				this.path = path;
				this.decl = decl;
				this.dtree = dtree;
			}
		}

		[VariantOption]
		public class IfEq : Decision
		{
			public readonly Path path;

			public readonly Con con;

			public readonly Decision if_true;

			public readonly Decision if_false;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 3;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (!_info.VisitedObjects.ContainsKey(this))
				{
					base.RelocateImplInternal(_info);
					_info.VisitedObjects[this] = 0;
					if_false?.RelocateImplInternal(_info);
					if_true?.RelocateImplInternal(_info);
					con?.RelocateImplInternal(_info);
					path?.RelocateImplInternal(_info);
				}
			}

			[RecordCtor]
			public IfEq(Location loc, [MappedMember("path")] Path path, [MappedMember("con")] Con con, [MappedMember("if_true")] Decision if_true, [MappedMember("if_false")] Decision if_false)
				: base(loc)
			{
				this.path = path;
				this.con = con;
				this.if_true = if_true;
				this.if_false = if_false;
			}
		}

		private int in_deg;

		private Location location;

		private bool is_debug_marked;

		private option<int> label_id;

		public bool IsShared => in_deg > 1;

		public int InDeg
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return in_deg;
			}
			[CompilerGenerated]
			[DebuggerStepThrough]
			set
			{
				in_deg = value;
			}
		}

		public Location Location
		{
			[CompilerGenerated]
			[DebuggerStepThrough]
			get
			{
				return location;
			}
		}

		public bool IsDebugMarked
		{
			[CompilerGenerated]
			[DebuggerStepThrough]
			get
			{
				return is_debug_marked;
			}
		}

		public option<int> LabelId
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return label_id;
			}
			[DebuggerStepThrough]
			[CompilerGenerated]
			set
			{
				label_id = value;
			}
		}

		private string ToString(string indent)
		{
			string result;
			if (this is Success)
			{
				int res = ((Success)this).res;
				result = Convert.ToString(indent) + "success " + Convert.ToString(res) + Environment.NewLine;
			}
			else if (this is Failure)
			{
				result = Convert.ToString(indent) + "failure" + Environment.NewLine;
			}
			else if (this is Assign)
			{
				Path path = ((Assign)this).path;
				LocalValue decl = ((Assign)this).decl;
				Decision dtree = ((Assign)this).dtree;
				string text = indent + "   ";
				result = string.Concat(Convert.ToString(indent) + "def " + Convert.ToString(decl.Name) + " = " + Convert.ToString(path) + Environment.NewLine, string.Concat(Convert.ToString(dtree.ToString(text))));
			}
			else
			{
				if (!(this is IfEq))
				{
					throw new MatchFailureException();
				}
				Path path = ((IfEq)this).path;
				Con con = ((IfEq)this).con;
				Decision dtree = ((IfEq)this).if_true;
				Decision if_false = ((IfEq)this).if_false;
				string text = indent + "   ";
				result = string.Concat(string.Concat(string.Concat(Convert.ToString(indent) + "if " + Convert.ToString(path) + " = " + Convert.ToString(con) + ":" + Environment.NewLine, string.Concat(Convert.ToString(dtree.ToString(text)))), Convert.ToString(indent) + "else:" + Environment.NewLine), string.Concat(Convert.ToString(if_false.ToString(text))));
			}
			return result;
		}

		public override string ToString()
		{
			return "\n" + ToString("");
		}

		internal void MarkDebug()
		{
			is_debug_marked = true;
		}

		public Decision(Location loc)
		{
			in_deg = 0;
			label_id = option<int>.None._N_constant_object;
			location = loc;
		}

		public bool Equals(Decision other)
		{
			Decision decision = null;
			decision = this;
			int result;
			if (decision is Success)
			{
				if (!(other is Success))
				{
					goto IL_01cc;
				}
				int res = ((Success)decision).res;
				int res2 = ((Success)other).res;
				result = ((res == res2) ? 1 : 0);
			}
			else if (decision is Failure)
			{
				if (!(other is Failure))
				{
					goto IL_01cc;
				}
				result = 1;
			}
			else if (decision is Assign)
			{
				if (!(other is Assign))
				{
					goto IL_01cc;
				}
				Path path = ((Assign)decision).path;
				LocalValue decl = ((Assign)decision).decl;
				decision = ((Assign)decision).dtree;
				Path path2 = ((Assign)other).path;
				LocalValue decl2 = ((Assign)other).decl;
				Decision dtree = ((Assign)other).dtree;
				result = ((decision == dtree && decl.Equals(decl2) && path.Equals(path2)) ? 1 : 0);
			}
			else
			{
				if (!(decision is IfEq) || !(other is IfEq))
				{
					goto IL_01cc;
				}
				Path path = ((IfEq)decision).path;
				Con con = ((IfEq)decision).con;
				Decision dtree = ((IfEq)decision).if_true;
				Decision if_false = ((IfEq)decision).if_false;
				Path path2 = ((IfEq)other).path;
				Con con2 = ((IfEq)other).con;
				decision = ((IfEq)other).if_true;
				Decision if_false2 = ((IfEq)other).if_false;
				result = ((dtree == decision && if_false == if_false2 && con.Equals(con2) && path.Equals(path2)) ? 1 : 0);
			}
			goto IL_01cd;
			IL_01cd:
			return (byte)result != 0;
			IL_01cc:
			result = 0;
			goto IL_01cd;
		}

		public override int GetHashCode()
		{
			int result;
			if (this is Success)
			{
				int res = ((Success)this).res;
				result = 1 + res;
			}
			else if (this is Failure)
			{
				result = 0;
			}
			else if (this is Assign)
			{
				Path path = ((Assign)this).path;
				LocalValue decl = ((Assign)this).decl;
				result = path.GetHashCode() + decl.GetHashCode();
			}
			else
			{
				if (!(this is IfEq))
				{
					throw new MatchFailureException();
				}
				Path path = ((IfEq)this).path;
				Con con = ((IfEq)this).con;
				result = path.GetHashCode() + con.GetHashCode();
			}
			return result;
		}

		public override bool Equals(object other)
		{
			return other == this || (other is Decision && Equals((Decision)other));
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(Decision x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is Decision)) ? (-1) : ((Decision)x)._N_GetVariantCode();
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				_info.VisitedObjects[this] = 0;
				location = Completion.Relocate(location, _info);
			}
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}
	}

	private class TopLevelPattern : ISupportRelocation
	{
		private sealed class _N_closureOf_Build_96895
		{
			internal TopLevelPattern _N__N_closurised_this_ptr_96910;

			internal Path _N_path_96908;

			internal Skeleton _N_skel_96906;

			internal Pattern _N_pat_96904;

			internal int _N_id_96902;

			internal TupleType _N_tt_96900;

			internal _N_closureOf_Build_96895()
			{
			}
		}

		private sealed class _N__N_lambda__96858__96961 : Function<Pattern, Nemerle.Builtins.Tuple<IMember, Pattern>>
		{
			[SpecialName]
			private _N_closureOf_Build_96895 _N_Build_closure_96965;

			public _N__N_lambda__96858__96961(_N_closureOf_Build_96895 _N_Build_closure_96965)
			{
				this._N_Build_closure_96965 = _N_Build_closure_96965;
			}

			[SpecialName]
			public sealed override Nemerle.Builtins.Tuple<IMember, Pattern> apply(Pattern pat)
			{
				_N_Build_closure_96965._N_id_96902 = checked(_N_Build_closure_96965._N_id_96902 + 1);
				return new Nemerle.Builtins.Tuple<IMember, Pattern>(_N_Build_closure_96965._N_tt_96900.GetField(_N_Build_closure_96965._N_id_96902), pat);
			}
		}

		private sealed class _N__N_lambda__96867__96970 : Function<IMember, Pattern, Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>
		{
			[SpecialName]
			private _N_closureOf_Build_96895 _N_Build_closure_96974;

			public _N__N_lambda__96867__96970(_N_closureOf_Build_96895 _N_Build_closure_96974)
			{
				this._N_Build_closure_96974 = _N_Build_closure_96974;
			}

			[SpecialName]
			public sealed override Nemerle.Builtins.Tuple<Path, Skeleton, Pattern> apply(IMember fld, Pattern p)
			{
				return new Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>(new Path.Field(p.Type, fld, _N_Build_closure_96974._N_path_96908), _N_Build_closure_96974._N_skel_96906.Select(fld), p);
			}
		}

		private readonly bool has_guard;

		private readonly int res_id;

		private Location res_loc;

		private readonly list<Nemerle.Builtins.Tuple<Pattern, bool, int>> continuation;

		private readonly Skeleton skel;

		private readonly Hashtable<Decision, Decision> nodes;

		private Decision BuildFailure()
		{
			list<Nemerle.Builtins.Tuple<Pattern, bool, int>> list = continuation;
			object result;
			if ((object)list == list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Nil._N_constant_object)
			{
				result = new Decision.Failure(Location.Default);
			}
			else
			{
				if (!(list is list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons))
				{
					throw new MatchFailureException();
				}
				Pattern field = ((list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)list).hd.Field0;
				bool field2 = ((list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)list).hd.Field1;
				int field3 = ((list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)list).hd.Field2;
				list = ((list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)list).tl;
				TopLevelPattern topLevelPattern = new TopLevelPattern(field2, field3, field.Location, list, skel, nodes);
				result = topLevelPattern.Build(new list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons(new Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>(new Path.Here(field.Type), skel, field), list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Nil._N_constant_object));
			}
			return (Decision)result;
		}

		private Decision BuildSuccess()
		{
			return (!has_guard) ? ((Decision)new Decision.Success(res_loc, res_id)) : ((Decision)new Decision.IfEq(Location.Default, new Path.Here(), Con.Guard._N_constant_object, new Decision.Success(res_loc, res_id), BuildFailure()));
		}

		public Decision Build(list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>> pats)
		{
			_N_closureOf_Build_96895 n_closureOf_Build_ = new _N_closureOf_Build_96895();
			n_closureOf_Build_._N__N_closurised_this_ptr_96910 = this;
			Decision result;
			if ((object)pats == list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Nil._N_constant_object)
			{
				result = BuildSuccess();
				goto IL_0678;
			}
			list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>> list;
			object obj;
			TypeInfo name;
			list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons cons;
			Decision decision;
			if (pats is list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons)
			{
				n_closureOf_Build_._N_path_96908 = ((list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons)pats).hd.Field0;
				n_closureOf_Build_._N_skel_96906 = ((list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons)pats).hd.Field1;
				n_closureOf_Build_._N_pat_96904 = ((list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons)pats).hd.Field2;
				list = ((list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons)pats).tl;
				if (n_closureOf_Build_._N_pat_96904 is Pattern.Wildcard)
				{
					goto IL_0585;
				}
				if (n_closureOf_Build_._N_pat_96904 is Pattern.As)
				{
					Pattern pat = ((Pattern.As)n_closureOf_Build_._N_pat_96904).pat;
					LocalValue decl = ((Pattern.As)n_closureOf_Build_._N_pat_96904).decl;
					decision = Build(new list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons(new Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>(n_closureOf_Build_._N_path_96908, n_closureOf_Build_._N_skel_96906, pat), list));
					Decision decision2 = decision;
					while (true)
					{
						if (decision2 is Decision.Success)
						{
							int res = ((Decision.Success)decision2).res;
							if (res != res_id)
							{
								obj = decision;
								break;
							}
						}
						else if (!(decision2 is Decision.Failure))
						{
							if (decision2 is Decision.Assign)
							{
								decision2 = ((Decision.Assign)decision2).dtree;
								decision2 = decision2;
								continue;
							}
							if (decision2 is Decision.IfEq)
							{
								decision2 = ((Decision.IfEq)decision2).if_true;
								decision2 = decision2;
								continue;
							}
							throw new MatchFailureException();
						}
						if (!(decision is Decision.Success))
						{
							if (decision is Decision.Failure)
							{
								obj = decision;
								break;
							}
							if (!(decision is Decision.Assign))
							{
								if (decision is Decision.IfEq)
								{
									if (((Decision.IfEq)decision).con == Con.Guard._N_constant_object)
									{
										obj = new Decision.Assign(decision.Location, n_closureOf_Build_._N_path_96908, decl, decision);
										break;
									}
									Path path = ((Decision.IfEq)decision).path;
									Con con = ((Decision.IfEq)decision).con;
									decision2 = ((Decision.IfEq)decision).if_true;
									Decision if_false = ((Decision.IfEq)decision).if_false;
									Decision.Assign if_true = new Decision.Assign(decision2.Location, n_closureOf_Build_._N_path_96908, decl, decision2);
									obj = new Decision.IfEq(decision.Location, path, con, if_true, if_false);
									break;
								}
								throw new MatchFailureException();
							}
						}
						obj = new Decision.Assign(decision.Location, n_closureOf_Build_._N_path_96908, decl, decision);
						break;
					}
				}
				else if (n_closureOf_Build_._N_pat_96904 is Pattern.HasType)
				{
					FixedType typ = ((Pattern.HasType)n_closureOf_Build_._N_pat_96904).typ;
					obj = _N_check_if_96916(n_closureOf_Build_, new Con.Type(typ), list);
				}
				else if (n_closureOf_Build_._N_pat_96904 is Pattern.Tuple)
				{
					list<Pattern> list2 = ((Pattern.Tuple)n_closureOf_Build_._N_pat_96904).args;
					n_closureOf_Build_._N_id_96902 = 0;
					n_closureOf_Build_._N_tt_96900 = n_closureOf_Build_._N_pat_96904.ty.Manager.InternalType.GetTupleType(list2.Length);
					Function<Pattern, Nemerle.Builtins.Tuple<IMember, Pattern>> convert = new _N__N_lambda__96858__96961(n_closureOf_Build_);
					list<Nemerle.Builtins.Tuple<IMember, Pattern>> args = list2.Map(convert);
					Pattern.Record record = new Pattern.Record(n_closureOf_Build_._N_pat_96904.Location, n_closureOf_Build_._N_pat_96904.ty, args);
					obj = Build(new list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons(new Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>(n_closureOf_Build_._N_path_96908, n_closureOf_Build_._N_skel_96906, record), list));
				}
				else if (n_closureOf_Build_._N_pat_96904 is Pattern.Record)
				{
					list<Nemerle.Builtins.Tuple<IMember, Pattern>> args = ((Pattern.Record)n_closureOf_Build_._N_pat_96904).args;
					list<Nemerle.Builtins.Tuple<IMember, Pattern>> list3 = args;
					Function<IMember, Pattern, Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>> convert2 = new _N__N_lambda__96867__96970(n_closureOf_Build_);
					list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>> list4 = list3.Map(convert2);
					obj = Build(list4 + list);
				}
				else if (n_closureOf_Build_._N_pat_96904 is Pattern.Application)
				{
					name = ((Pattern.Application)n_closureOf_Build_._N_pat_96904).name;
					Pattern pat = ((Pattern.Application)n_closureOf_Build_._N_pat_96904).arg;
					Pattern n_pat_ = n_closureOf_Build_._N_pat_96904;
					cons = new list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons(new Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>(n_closureOf_Build_._N_path_96908, n_closureOf_Build_._N_skel_96906, pat), list);
					FixedType typ = n_pat_.Type.HintFast;
					if (!(typ is FixedType.Class))
					{
						goto IL_0481;
					}
					TypeInfo tycon = ((FixedType.Class)typ).tycon;
					if (tycon.Equals(name))
					{
						obj = Build(cons);
					}
					else
					{
						TypeDeclaration tydecl = name.GetTydecl();
						if (!(tydecl is TypeDeclaration.Variant) && (tydecl != TypeDeclaration.VariantOption._N_constant_object || 1 == 0))
						{
							goto IL_0481;
						}
						obj = _N_check_if_96916(n_closureOf_Build_, new Con.Variant(name), cons);
					}
				}
				else if (n_closureOf_Build_._N_pat_96904 is Pattern.Enum)
				{
					IField fld = ((Pattern.Enum)n_closureOf_Build_._N_pat_96904).fld;
					Literal val = ((Pattern.Enum)n_closureOf_Build_._N_pat_96904).val;
					object obj2;
					if (val is Literal.Enum)
					{
						obj2 = val;
					}
					else
					{
						if (!(val is Literal.Integer))
						{
							throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 734, "", "");
						}
						obj2 = new Literal.Enum((Literal.Integer)val, fld.DeclaringType, fld);
					}
					val = (Literal)obj2;
					obj = _N_check_if_96916(n_closureOf_Build_, new Con.Lit(val), list);
				}
				else
				{
					if (!(n_closureOf_Build_._N_pat_96904 is Pattern.Literal))
					{
						if (!(n_closureOf_Build_._N_pat_96904 is Pattern.Error))
						{
							throw new MatchFailureException();
						}
						goto IL_0585;
					}
					Literal val = ((Pattern.Literal)n_closureOf_Build_._N_pat_96904).lit;
					obj = _N_check_if_96916(n_closureOf_Build_, new Con.Lit(val), list);
				}
				goto IL_0597;
			}
			throw new MatchFailureException();
			IL_0678:
			return result;
			IL_0481:
			obj = _N_check_if_96916(n_closureOf_Build_, new Con.Type(name.GetFreshType()), cons);
			goto IL_0597;
			IL_0597:
			decision = (Decision)obj;
			option<Decision> option = nodes.Get(decision);
			checked
			{
				if (option == option<Decision>.None._N_constant_object)
				{
					nodes.Add(decision, decision);
					if (decision is Decision.IfEq)
					{
						Decision decision2 = ((Decision.IfEq)decision).if_true;
						Decision if_false = ((Decision.IfEq)decision).if_false;
						decision2.InDeg++;
						if_false.InDeg++;
					}
					else if (decision is Decision.Assign)
					{
						((Decision.Assign)decision).dtree.InDeg++;
					}
					result = decision;
				}
				else
				{
					if (!(option is option<Decision>.Some))
					{
						throw new MatchFailureException();
					}
					decision = ((option<Decision>.Some)option).val;
					result = decision;
				}
				goto IL_0678;
			}
			IL_0585:
			obj = Build(list);
			goto IL_0597;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				_info.VisitedObjects[this] = 0;
				skel?.RelocateImplInternal(_info);
				res_loc = Completion.Relocate(res_loc, _info);
			}
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}

		[RecordCtor]
		public TopLevelPattern([MappedMember("has_guard")] bool has_guard, [MappedMember("res_id")] int res_id, [MappedMember("res_loc")] Location res_loc, [MappedMember("continuation")] list<Nemerle.Builtins.Tuple<Pattern, bool, int>> continuation, [MappedMember("skel")] Skeleton skel, [MappedMember("nodes")] Hashtable<Decision, Decision> nodes)
		{
			this.has_guard = has_guard;
			this.res_id = res_id;
			this.res_loc = res_loc;
			this.continuation = continuation;
			this.skel = skel;
			this.nodes = nodes;
		}

		private Decision _N_check_if_96916(_N_closureOf_Build_96895 _N_Build_cp_96915, Con con, list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>> rest)
		{
			bool flag = _N_Build_cp_96915._N_skel_96906.IsIt(con);
			bool flag2 = !_N_Build_cp_96915._N_skel_96906.CanBe(con);
			object result;
			if (flag)
			{
				result = Build(rest);
			}
			else if (flag2)
			{
				result = BuildFailure();
			}
			else
			{
				Nemerle.Builtins.Tuple<list<Con>, Con, list<Skeleton>> tuple = _N_Build_cp_96915._N_skel_96906.Save();
				_N_Build_cp_96915._N_skel_96906.AddPositive(con);
				Decision if_true = Build(rest);
				_N_Build_cp_96915._N_skel_96906.Restore(tuple.Field0, tuple.Field1, tuple.Field2);
				_N_Build_cp_96915._N_skel_96906.AddNegative(con);
				Decision if_false = BuildFailure();
				_N_Build_cp_96915._N_skel_96906.Restore(tuple.Field0, tuple.Field1, tuple.Field2);
				result = new Decision.IfEq(_N_Build_cp_96915._N_pat_96904.Location, _N_Build_cp_96915._N_path_96908, con, if_true, if_false);
			}
			return (Decision)result;
		}
	}

	[Variant("Nemerle.Compiler.DecisionTreeBuilder.CounterExample.Anything,Nemerle.Compiler.DecisionTreeBuilder.CounterExample.Exactly")]
	private abstract class CounterExample : ISupportRelocation
	{
		[ConstantVariantOption]
		public class Anything : CounterExample
		{
			public static readonly Anything _N_constant_object;

			[SpecialName]
			public static Anything _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static Anything()
			{
				_N_constant_object = new Anything();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			private Anything()
			{
			}
		}

		[VariantOption]
		public class Exactly : CounterExample
		{
			public readonly Con con;

			public readonly list<Nemerle.Builtins.Tuple<IMember, CounterExample>> args;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
			}

			[CompilerGenerated]
			internal override void RelocateImplInternal(RelocationInfo _info)
			{
				if (!_info.VisitedObjects.ContainsKey(this))
				{
					base.RelocateImplInternal(_info);
					_info.VisitedObjects[this] = 0;
					con?.RelocateImplInternal(_info);
				}
			}

			[RecordCtor]
			public Exactly([MappedMember("con")] Con con, [MappedMember("args")] list<Nemerle.Builtins.Tuple<IMember, CounterExample>> args)
			{
				this.con = con;
				this.args = args;
			}
		}

		private sealed class _N_closureOf_With_97053
		{
			internal IMember _N_fld_97060;

			internal CounterExample _N_example_97058;

			internal _N_closureOf_With_97053()
			{
			}
		}

		private sealed class _N__N_lambda__97042__97083 : Function<Nemerle.Builtins.Tuple<IMember, CounterExample>, list<Nemerle.Builtins.Tuple<IMember, CounterExample>>, list<Nemerle.Builtins.Tuple<IMember, CounterExample>>>
		{
			[SpecialName]
			private _N_closureOf_With_97053 _N_With_closure_97087;

			public _N__N_lambda__97042__97083(_N_closureOf_With_97053 _N_With_closure_97087)
			{
				this._N_With_closure_97087 = _N_With_closure_97087;
			}

			[SpecialName]
			public sealed override list<Nemerle.Builtins.Tuple<IMember, CounterExample>> apply(Nemerle.Builtins.Tuple<IMember, CounterExample> elem, list<Nemerle.Builtins.Tuple<IMember, CounterExample>> acc)
			{
				IMember field = elem.Field0;
				CounterExample field2 = elem.Field1;
				object result;
				if (field.Equals(_N_With_closure_97087._N_fld_97060))
				{
					_N_With_closure_97087._N_example_97058 = field2;
					result = acc;
				}
				else
				{
					result = new list<Nemerle.Builtins.Tuple<IMember, CounterExample>>.Cons(elem, acc);
				}
				return (list<Nemerle.Builtins.Tuple<IMember, CounterExample>>)result;
			}
		}

		private sealed class _N_static_proxy_97118 : Function<IMember, CounterExample, string>
		{
			[SpecialName]
			public static readonly _N_static_proxy_97118 single_instance = new _N_static_proxy_97118();

			[SpecialName]
			public sealed override string apply(IMember _N_sp_parm_97125, CounterExample _N_sp_parm_97126)
			{
				return FieldToString(_N_sp_parm_97125, _N_sp_parm_97126);
			}

			private _N_static_proxy_97118()
			{
			}
		}

		public CounterExample With(Con con, Path path)
		{
			_N_closureOf_With_97053 n_closureOf_With_ = new _N_closureOf_With_97053();
			Exactly result;
			if (path is Path.Here)
			{
				if (this == Anything._N_constant_object)
				{
					result = new Exactly(con, list<Nemerle.Builtins.Tuple<IMember, CounterExample>>.Nil._N_constant_object);
				}
				else
				{
					if (!(this is Exactly))
					{
						throw new MatchFailureException();
					}
					Con con2 = ((Exactly)this).con;
					list<Nemerle.Builtins.Tuple<IMember, CounterExample>> args = ((Exactly)this).args;
					object obj;
					if (con2 == null)
					{
						obj = con;
					}
					else if (con2 is Con.Not)
					{
						list<Con> list = ((Con.Not)con2).lst;
						if (con is Con.Not)
						{
							list<Con> list2 = ((Con.Not)con).lst;
							obj = new Con.Not(list2 + list);
						}
						else
						{
							con2 = con;
							if (list.Contains(con2))
							{
								throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 809, "!lst.Contains(c)", "");
							}
							obj = con2;
						}
					}
					else
					{
						obj = con2;
					}
					con2 = (Con)obj;
					result = new Exactly(con2, args);
				}
			}
			else
			{
				if (!(path is Path.Field))
				{
					throw new MatchFailureException();
				}
				n_closureOf_With_._N_fld_97060 = ((Path.Field)path).field;
				Path path2 = ((Path.Field)path).path;
				if (this == Anything._N_constant_object)
				{
					result = new Exactly(null, new list<Nemerle.Builtins.Tuple<IMember, CounterExample>>.Cons(new Nemerle.Builtins.Tuple<IMember, CounterExample>(n_closureOf_With_._N_fld_97060, Anything._N_constant_object.With(con, path2)), list<Nemerle.Builtins.Tuple<IMember, CounterExample>>.Nil._N_constant_object));
				}
				else
				{
					if (!(this is Exactly))
					{
						throw new MatchFailureException();
					}
					Con con2 = ((Exactly)this).con;
					list<Nemerle.Builtins.Tuple<IMember, CounterExample>> args = ((Exactly)this).args;
					n_closureOf_With_._N_example_97058 = Anything._N_constant_object;
					list<Nemerle.Builtins.Tuple<IMember, CounterExample>> list3 = args;
					list<Nemerle.Builtins.Tuple<IMember, CounterExample>>.Nil n_constant_object = list<Nemerle.Builtins.Tuple<IMember, CounterExample>>.Nil._N_constant_object;
					Function<Nemerle.Builtins.Tuple<IMember, CounterExample>, list<Nemerle.Builtins.Tuple<IMember, CounterExample>>, list<Nemerle.Builtins.Tuple<IMember, CounterExample>>> f = new _N__N_lambda__97042__97083(n_closureOf_With_);
					args = list3.FoldLeft(n_constant_object, f);
					result = new Exactly(con2, new list<Nemerle.Builtins.Tuple<IMember, CounterExample>>.Cons(new Nemerle.Builtins.Tuple<IMember, CounterExample>(n_closureOf_With_._N_fld_97060, n_closureOf_With_._N_example_97058.With(con, path2)), args));
				}
			}
			return result;
		}

		private static string FieldToString(IMember mem, CounterExample example)
		{
			return (!TupleType.IsTupleMember(mem)) ? (Convert.ToString(mem.Name) + " = " + Convert.ToString(example)) : string.Concat(Convert.ToString(example));
		}

		public override string ToString()
		{
			object result;
			if (this == Anything._N_constant_object)
			{
				result = "_";
			}
			else
			{
				if (!(this is Exactly))
				{
					throw new MatchFailureException();
				}
				if ((object)((Exactly)this).con == null)
				{
					if ((object)((Exactly)this).args == list<Nemerle.Builtins.Tuple<IMember, CounterExample>>.Nil._N_constant_object)
					{
						result = "_";
					}
					else
					{
						list<Nemerle.Builtins.Tuple<IMember, CounterExample>> list = ((Exactly)this).args;
						result = "(" + string.Join(", ", NCollectionsExtensions.MapToArray(list, _N_static_proxy_97118.single_instance)) + ")";
					}
				}
				else if ((object)((Exactly)this).args == list<Nemerle.Builtins.Tuple<IMember, CounterExample>>.Nil._N_constant_object)
				{
					Con con = ((Exactly)this).con;
					result = con.ToString(throw_ignore: true);
				}
				else
				{
					Con con = ((Exactly)this).con;
					list<Nemerle.Builtins.Tuple<IMember, CounterExample>> list = ((Exactly)this).args;
					result = Convert.ToString(con) + " (" + string.Join(", ", NCollectionsExtensions.MapToArray(list, _N_static_proxy_97118.single_instance)) + ")";
				}
			}
			return (string)result;
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(CounterExample x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is CounterExample)) ? (-1) : ((CounterExample)x)._N_GetVariantCode();
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

	private sealed class _N__N_lambda__95735__95745 : Function<Nemerle.Builtins.Tuple<Path, Con>, CounterExample, CounterExample>
	{
		[SpecialName]
		public static readonly _N__N_lambda__95735__95745 Instance = new _N__N_lambda__95735__95745();

		[SpecialName]
		public sealed override CounterExample apply(Nemerle.Builtins.Tuple<Path, Con> elem, CounterExample acc)
		{
			Path field = elem.Field0;
			Con field2 = elem.Field1;
			return (field2 != Con.Guard._N_constant_object && (!(field2 is Con.Not) || !(((Con.Not)field2).lst is list<Con>.Cons) || ((list<Con>.Cons)((Con.Not)field2).lst).hd != Con.Guard._N_constant_object || (object)((list<Con>.Cons)((Con.Not)field2).lst).tl != list<Con>.Nil._N_constant_object)) ? acc.With(field2, field) : acc;
		}
	}

	private sealed class _N_closureOf_CheckMatching_95835
	{
		internal Pattern[] _N_pat_arr_95842;

		internal bool _N_non_exhaustive_shown_95840;

		internal _N_closureOf_CheckMatching_95835()
		{
		}
	}

	private list<Nemerle.Builtins.Tuple<Pattern, bool, int>> patterns;

	private readonly Decision decision;

	public readonly ManagerClass Manager;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	private static Decision Build(list<Nemerle.Builtins.Tuple<Pattern, bool, int>> patterns)
	{
		if (patterns is list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)
		{
			Pattern field = ((list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)patterns).hd.Field0;
			bool field2 = ((list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)patterns).hd.Field1;
			int field3 = ((list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)patterns).hd.Field2;
			list<Nemerle.Builtins.Tuple<Pattern, bool, int>> continuation = ((list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)patterns).tl;
			Skeleton skeleton = Skeleton.Empty();
			Hashtable<Decision, Decision> nodes = new Hashtable<Decision, Decision>();
			TopLevelPattern topLevelPattern = new TopLevelPattern(field2, field3, field.Location, continuation, skeleton, nodes);
			return topLevelPattern.Build(new list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Cons(new Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>(new Path.Here(field.Type), skeleton, field), list<Nemerle.Builtins.Tuple<Path, Skeleton, Pattern>>.Nil._N_constant_object));
		}
		throw new AssertionException("ncc\\typing\\DecisionTreeBuilder.n", 780, "", "");
	}

	private static string BuildCounterExample(list<Nemerle.Builtins.Tuple<Path, Con>> path)
	{
		CounterExample.Anything n_constant_object = CounterExample.Anything._N_constant_object;
		Function<Nemerle.Builtins.Tuple<Path, Con>, CounterExample, CounterExample> instance = _N__N_lambda__95735__95745.Instance;
		CounterExample counterExample = path.FoldLeft(n_constant_object, instance);
		return counterExample.ToString();
	}

	public DecisionTreeBuilder(list<Match_case> cases)
	{
		int num = 0;
		patterns = list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Nil._N_constant_object;
		base._002Ector();
		num = 0;
		list<Match_case> list = cases;
		while (list is list<Match_case>.Cons)
		{
			Match_case hd = ((list<Match_case>.Cons)list).hd;
			list = ((list<Match_case>.Cons)list).tl;
			list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>> list2;
			Pattern field;
			int num2;
			bool flag;
			for (list2 = hd.patterns; list2 is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons; flag = (byte)num2 != 0, patterns = new list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons(new Nemerle.Builtins.Tuple<Pattern, bool, int>(field, !flag, num), patterns), num = checked(num + 1), list2 = list2)
			{
				Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>> hd2 = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)list2).hd;
				list2 = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)list2).tl;
				field = hd2.Field0;
				TExpr field2 = hd2.Field1;
				Manager = field.Type.Manager;
				if (field2 is TExpr.DebugInfo)
				{
					if (((TExpr.DebugInfo)field2).expr is TExpr.Literal && ((TExpr.Literal)((TExpr.DebugInfo)field2).expr).val is Literal.Bool && ((Literal.Bool)((TExpr.Literal)((TExpr.DebugInfo)field2).expr).val).val)
					{
						goto IL_00fa;
					}
				}
				else if (field2 is TExpr.Literal && ((TExpr.Literal)field2).val is Literal.Bool && ((Literal.Bool)((TExpr.Literal)field2).val).val)
				{
					goto IL_00fa;
				}
				num2 = 0;
				continue;
				IL_00fa:
				num2 = 1;
			}
			list = list;
		}
		patterns = patterns.Rev();
		decision = Build(patterns);
	}

	internal Decision GetDecision()
	{
		return decision;
	}

	public void CheckMatching()
	{
		int num = 0;
		_N_closureOf_CheckMatching_95835 n_closureOf_CheckMatching_ = new _N_closureOf_CheckMatching_95835();
		n_closureOf_CheckMatching_._N_pat_arr_95842 = new Pattern[patterns.Length];
		list<Nemerle.Builtins.Tuple<Pattern, bool, int>> list = patterns;
		while (list is list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)
		{
			Nemerle.Builtins.Tuple<Pattern, bool, int> hd = ((list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)list).hd;
			list = ((list<Nemerle.Builtins.Tuple<Pattern, bool, int>>.Cons)list).tl;
			Pattern field = hd.Field0;
			num = hd.Field2;
			n_closureOf_CheckMatching_._N_pat_arr_95842[num] = field;
			list = list;
		}
		n_closureOf_CheckMatching_._N_non_exhaustive_shown_95840 = false;
		_N_traverse_95851(n_closureOf_CheckMatching_, list<Nemerle.Builtins.Tuple<Path, Con>>.Nil._N_constant_object, decision);
		Pattern[] n_pat_arr_ = n_closureOf_CheckMatching_._N_pat_arr_95842;
		for (num = 0; num < n_pat_arr_.Length; num = checked(num + 1))
		{
			Pattern field = n_pat_arr_[num];
			field = field;
			if (field != null)
			{
				Message.Warning(field.Location, "this match clause is unused");
			}
		}
	}

	public static void CheckMatching(list<Match_case> cases)
	{
		DecisionTreeBuilder decisionTreeBuilder = new DecisionTreeBuilder(cases);
		decisionTreeBuilder.CheckMatching();
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
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			decision?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private static void _N_traverse_95851(_N_closureOf_CheckMatching_95835 _N_CheckMatching_cp_95850, list<Nemerle.Builtins.Tuple<Path, Con>> path, Decision n)
	{
		while (true)
		{
			if (n is Decision.Success)
			{
				int res = ((Decision.Success)n).res;
				_N_CheckMatching_cp_95850._N_pat_arr_95842[res] = null;
				return;
			}
			if (n is Decision.Failure)
			{
				if (_N_CheckMatching_cp_95850._N_non_exhaustive_shown_95840)
				{
					return;
				}
				try
				{
					string text = BuildCounterExample(path);
					_N_CheckMatching_cp_95850._N_non_exhaustive_shown_95840 = true;
					Message.Warning("matching is not exhaustive, example unmatched value: " + Convert.ToString(text));
					return;
				}
				catch (IgnoreCounterExample)
				{
					return;
				}
			}
			if (n is Decision.Assign)
			{
				Decision dtree = ((Decision.Assign)n).dtree;
				list<Nemerle.Builtins.Tuple<Path, Con>> obj = path;
				n = dtree;
				path = obj;
				continue;
			}
			if (!(n is Decision.IfEq))
			{
				break;
			}
			Path path2 = ((Decision.IfEq)n).path;
			Con con = ((Decision.IfEq)n).con;
			Decision if_true = ((Decision.IfEq)n).if_true;
			Decision if_false = ((Decision.IfEq)n).if_false;
			_N_traverse_95851(_N_CheckMatching_cp_95850, new list<Nemerle.Builtins.Tuple<Path, Con>>.Cons(new Nemerle.Builtins.Tuple<Path, Con>(path2, con), path), if_true);
			list<Nemerle.Builtins.Tuple<Path, Con>> obj2 = new list<Nemerle.Builtins.Tuple<Path, Con>>.Cons(new Nemerle.Builtins.Tuple<Path, Con>(path2, new Con.Not(new list<Con>.Cons(con, list<Con>.Nil._N_constant_object))), path);
			n = if_false;
			path = obj2;
		}
		throw new MatchFailureException();
	}
}
