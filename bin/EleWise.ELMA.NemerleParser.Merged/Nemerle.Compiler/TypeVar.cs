using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class TypeVar : TypedBase, IComparable<TypeVar>, IEquatable<TypeVar>
{
	[Flags]
	public enum Flags
	{
		None = 0,
		IsFromNull = 1,
		IsMonoType = 2,
		IsAliased = 4,
		IsFresh = 8,
		Visit = 0x10,
		AlwaysUnify = 0x20,
		HasReferenceTypeConstraint = 0x40,
		HasValueTypeConstraint = 0x80
	}

	private sealed class _N_static_proxy_97260 : Function<TypeVar, TypeVar, bool>
	{
		[SpecialName]
		public static readonly _N_static_proxy_97260 single_instance = new _N_static_proxy_97260();

		[SpecialName]
		public sealed override bool apply(TypeVar _N_sp_parm_97267, TypeVar _N_sp_parm_97268)
		{
			return StructuralEquals(_N_sp_parm_97267, _N_sp_parm_97268);
		}

		private _N_static_proxy_97260()
		{
		}
	}

	private sealed class _N_static_proxy_98002 : Function<TypeVar, TypeVar>
	{
		[SpecialName]
		public static readonly _N_static_proxy_98002 single_instance = new _N_static_proxy_98002();

		[SpecialName]
		public sealed override TypeVar apply(TypeVar _N_sp_parm_98009)
		{
			return DoDeepFix(_N_sp_parm_98009);
		}

		private _N_static_proxy_98002()
		{
		}
	}

	private sealed class _N_static_proxy_98012 : Function<FixedType, FixedType>
	{
		[SpecialName]
		public static readonly _N_static_proxy_98012 single_instance = new _N_static_proxy_98012();

		[SpecialName]
		public sealed override FixedType apply(FixedType _N_sp_parm_98019)
		{
			return DoDeepFixM(_N_sp_parm_98019);
		}

		private _N_static_proxy_98012()
		{
		}
	}

	private sealed class _N_closureOf_AddRelation_98421
	{
		internal TypeVar _N__N_closurised_this_ptr_98426;

		internal _N_closureOf_AddRelation_98421()
		{
		}
	}

	private static int level;

	private TypeVar alias_to;

	private TypeVar next;

	protected int serial;

	private int id;

	protected FixedType lower_bound;

	protected FixedType upper_bound;

	private TypeVar[] lower_tyvars;

	private TypeVar[] upper_tyvars;

	protected Flags flags;

	private static int stop_serial;

	private static readonly TypeVar[] empty_set;

	public readonly ManagerClass Manager;

	public option<FixedType> LowerBound
	{
		get
		{
			FixedType fixedType = Self.lower_bound;
			return (fixedType != null) ? ((option<FixedType>)new option<FixedType>.Some(fixedType)) : ((option<FixedType>)option<FixedType>.None._N_constant_object);
		}
	}

	public option<FixedType> UpperBound
	{
		get
		{
			FixedType fixedType = Self.upper_bound;
			return (fixedType != null) ? ((option<FixedType>)new option<FixedType>.Some(fixedType)) : ((option<FixedType>)option<FixedType>.None._N_constant_object);
		}
	}

	public option<FixedType> Hint
	{
		get
		{
			TypeVar self = Self;
			FixedType fixedType = self.upper_bound;
			FixedType fixedType2 = self.lower_bound;
			return (fixedType != null) ? new option<FixedType>.Some(fixedType) : ((fixedType2 != null && !fixedType2.Equals(InternalType.Object)) ? ((option<FixedType>)new option<FixedType>.Some(fixedType2)) : ((option<FixedType>)option<FixedType>.None._N_constant_object));
		}
	}

	public FixedType HintFast
	{
		get
		{
			TypeVar self = Self;
			FixedType fixedType = self.upper_bound;
			FixedType fixedType2 = self.lower_bound;
			return (fixedType != null) ? fixedType : ((fixedType2 != null && !fixedType2.Equals(InternalType.Object)) ? fixedType2 : null);
		}
	}

	public option<FixedType> AnyHint
	{
		get
		{
			TypeVar self = Self;
			FixedType fixedType = self.upper_bound;
			FixedType fixedType2 = self.lower_bound;
			return (fixedType != null) ? new option<FixedType>.Some(fixedType) : ((fixedType2 != null) ? ((option<FixedType>)new option<FixedType>.Some(fixedType2)) : ((option<FixedType>)option<FixedType>.None._N_constant_object));
		}
	}

	public override FixedType FixedValue
	{
		get
		{
			TypeVar self = Self;
			if ((self.flags & Flags.IsMonoType) == 0)
			{
				throw new AssertionException("ncc\\typing\\TypeVar.n", 418, "s.flags %&& Flags.IsMonoType", "");
			}
			if (self.lower_bound == null)
			{
				throw new AssertionException("ncc\\typing\\TypeVar.n", 419, "s.lower_bound != null", "");
			}
			return self.lower_bound;
		}
	}

	public override bool IsPointer
	{
		get
		{
			bool result = false;
			TypeInfo typeInfo = TypeInfo;
			if (typeInfo != null)
			{
				result = typeInfo.IsPointer;
			}
			return result;
		}
	}

	public bool IsFixed => (Self.flags & Flags.IsMonoType) != 0;

	public bool IsFree => (Self.flags & Flags.IsMonoType) == 0;

	public bool IsFresh => (Self.flags & Flags.IsFresh) != 0;

	public bool IsEnum
	{
		get
		{
			bool result = false;
			TypeInfo typeInfo = TypeInfo;
			if (typeInfo != null)
			{
				result = typeInfo.IsEnum;
			}
			return result;
		}
	}

	public TypeInfo TypeInfo
	{
		get
		{
			TypeInfo result = null;
			FixedType hintFast = HintFast;
			if (hintFast != null)
			{
				result = hintFast.TypeInfo;
			}
			return result;
		}
	}

	public bool AlwaysUnify
	{
		get
		{
			return (Self.flags & Flags.AlwaysUnify) != 0;
		}
		set
		{
			if (value)
			{
				TypeVar self = Self;
				self.flags |= Flags.AlwaysUnify;
			}
			else
			{
				TypeVar self = Self;
				self.flags &= ~Flags.AlwaysUnify;
			}
		}
	}

	public bool IsConstrained
	{
		get
		{
			flags |= Flags.Visit;
			try
			{
				TypeVar self = Self;
				int result;
				bool flag;
				if (((uint)self.flags & (2u | (true ? 1u : 0u) | 0x20u)) != 0)
				{
					result = 1;
				}
				else
				{
					FixedType fixedType = self.upper_bound;
					FixedType fixedType2 = self.lower_bound;
					checked
					{
						if (fixedType == null)
						{
							if (fixedType2 == null)
							{
								flag = false;
								if (self.upper_tyvars != null)
								{
									TypeVar[] array = self.upper_tyvars;
									int num = 0;
									while (num < array.Length)
									{
										TypeVar typeVar = array[num];
										TypeVar typeVar2 = typeVar;
										if (typeVar2 == null || (typeVar2.flags & Flags.Visit) != 0 || !typeVar2.IsConstrained)
										{
											num++;
											continue;
										}
										goto IL_00bb;
									}
								}
								if (self.lower_tyvars != null)
								{
									TypeVar[] array2 = self.lower_tyvars;
									int num2 = 0;
									while (num2 < array2.Length)
									{
										TypeVar typeVar3 = array2[num2];
										TypeVar typeVar4 = typeVar3;
										if (typeVar4 == null || (typeVar4.flags & Flags.Visit) != 0 || !typeVar4.IsConstrained)
										{
											num2++;
											continue;
										}
										goto IL_013e;
									}
								}
								flag = false;
								goto IL_0159;
							}
							result = 1;
						}
						else
						{
							result = 1;
						}
					}
				}
				goto IL_0166;
				IL_00bb:
				flag = true;
				goto IL_0159;
				IL_0166:
				return (byte)result != 0;
				IL_0159:
				result = (flag ? 1 : 0);
				goto IL_0166;
				IL_013e:
				flag = true;
				goto IL_0159;
			}
			finally
			{
				flags &= ~Flags.Visit;
			}
		}
	}

	public bool HasReferenceTypeConstraint
	{
		get
		{
			return (Self.flags & Flags.HasReferenceTypeConstraint) != 0;
		}
		set
		{
			int num = 0;
			if (!IsFree)
			{
				throw new AssertionException("ncc\\typing\\TypeVar.n", 534, "IsFree", "");
			}
			if (!value)
			{
				throw new AssertionException("ncc\\typing\\TypeVar.n", 535, "value", "");
			}
			if (HasReferenceTypeConstraint)
			{
				return;
			}
			WillWrite();
			TypeVar self = Self;
			self.flags |= Flags.HasReferenceTypeConstraint;
			if (IsValueType)
			{
				if (Manager.Solver.CurrentMessenger.NeedMessage)
				{
					Manager.Solver.CurrentMessenger.SaveError("the 'class' constraint is not compatibile with a value type (" + Convert.ToString(Hint.UnSome()) + ")");
				}
				else
				{
					Manager.Solver.CurrentMessenger.MarkError();
				}
			}
			checked
			{
				TypeVar[] array;
				if (self.lower_tyvars != null)
				{
					array = self.lower_tyvars;
					for (num = 0; num < array.Length; num++)
					{
						TypeVar typeVar = array[num];
						typeVar = typeVar;
						if (typeVar != null && typeVar.IsFree)
						{
							typeVar.HasReferenceTypeConstraint = true;
						}
					}
				}
				if (self.upper_tyvars == null)
				{
					return;
				}
				array = self.upper_tyvars;
				for (num = 0; num < array.Length; num++)
				{
					self = array[num];
					self = self;
					if (self != null && self.IsFree)
					{
						self.HasReferenceTypeConstraint = true;
					}
				}
			}
		}
	}

	public bool IsFromNull
	{
		get
		{
			return (Self.flags & Flags.IsFromNull) != 0;
		}
		set
		{
			int num = 0;
			if (!IsFree)
			{
				throw new AssertionException("ncc\\typing\\TypeVar.n", 559, "IsFree", "");
			}
			if (!value)
			{
				throw new AssertionException("ncc\\typing\\TypeVar.n", 560, "value", "");
			}
			if (IsFromNull)
			{
				return;
			}
			WillWrite();
			TypeVar self = Self;
			self.flags |= Flags.IsFromNull;
			if (!CanBeNull)
			{
				if (Manager.Solver.CurrentMessenger.NeedMessage)
				{
					Manager.Solver.CurrentMessenger.SaveError("the `null' literal is not a valid value of type " + Convert.ToString(Hint.UnSome()));
				}
				else
				{
					Manager.Solver.CurrentMessenger.MarkError();
				}
			}
			checked
			{
				TypeVar[] array;
				if (self.lower_tyvars != null)
				{
					array = self.lower_tyvars;
					for (num = 0; num < array.Length; num++)
					{
						TypeVar typeVar = array[num];
						typeVar = typeVar;
						if (typeVar != null && typeVar.IsFree)
						{
							typeVar.IsFromNull = true;
						}
					}
				}
				if (self.upper_tyvars == null)
				{
					return;
				}
				array = self.upper_tyvars;
				for (num = 0; num < array.Length; num++)
				{
					self = array[num];
					self = self;
					if (self != null && self.IsFree)
					{
						self.IsFromNull = true;
					}
				}
			}
		}
	}

	public Solver CurrentSolver => Manager.Solver;

	public override bool IsValueType => IsValueTypeImpl(HintFast);

	public override bool IsNullable
	{
		get
		{
			FixedType hintFast = HintFast;
			int result;
			if (hintFast is FixedType.Class && ((FixedType.Class)hintFast).args is list<TypeVar>.Cons)
			{
				TypeInfo tycon = ((FixedType.Class)hintFast).tycon;
				if ((object)((list<TypeVar>.Cons)((FixedType.Class)hintFast).args).tl == list<TypeVar>.Nil._N_constant_object && tycon.Equals(InternalType.Generic_Nullable_tc))
				{
					result = 1;
					goto IL_0084;
				}
			}
			result = 0;
			goto IL_0084;
			IL_0084:
			return (byte)result != 0;
		}
	}

	public override bool CanBeNull
	{
		get
		{
			TypeVar self = Self;
			return (self.lower_bound == null || self.lower_bound.CanBeNull) && (self.upper_bound == null || self.upper_bound.CanBeNull);
		}
	}

	internal override bool NeedNoSubst
	{
		get
		{
			TypeVar self = Self;
			return ((self.flags & Flags.IsMonoType) != 0) ? self.NeedNoSubst : ((self.flags & Flags.IsFresh) != 0 || ((self.lower_bound == null || self.lower_bound.NeedNoSubst) && (self.upper_bound == null || self.upper_bound.NeedNoSubst)));
		}
	}

	protected TypeVar Self
	{
		get
		{
			WillRead();
			return ((flags & Flags.IsAliased) == 0) ? this : alias_to.Self;
		}
	}

	private bool LocalError => Manager.Solver.CurrentMessenger.LocalError;

	private int LocalErrorCount => Manager.Solver.CurrentMessenger.LocalErrorCount;

	public TypeVar ImplicitCastHint { get; set; }

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	static TypeVar()
	{
		stop_serial = -1;
		empty_set = new TypeVar[0];
	}

	public static bool StructuralEquals(TypeVar t1, TypeVar t2)
	{
		TypeVar typeVar = null;
		TypeVar typeVar2 = null;
		bool flag = false;
		int result;
		while (true)
		{
			typeVar2 = t1.Self;
			typeVar = t2.Self;
			if (typeVar2 == typeVar)
			{
				result = 1;
				break;
			}
			list<TypeVar> list;
			TypeVar to;
			TypeVar hd;
			TypeInfo tycon;
			TypeInfo tycon2;
			list<TypeVar> lst;
			if (typeVar2 is FixedType.Class)
			{
				if ((object)((FixedType.Class)typeVar2).args == list<TypeVar>.Nil._N_constant_object)
				{
					tycon = ((FixedType.Class)typeVar2).tycon;
					if (typeVar is FixedType.Class)
					{
						if ((object)((FixedType.Class)typeVar).args == list<TypeVar>.Nil._N_constant_object)
						{
							tycon2 = ((FixedType.Class)typeVar).tycon;
							result = (tycon.Equals(tycon2) ? 1 : 0);
							break;
						}
						goto IL_0087;
					}
				}
				else if (((FixedType.Class)typeVar2).args is list<TypeVar>.Cons)
				{
					tycon = ((FixedType.Class)typeVar2).tycon;
					if ((object)((list<TypeVar>.Cons)((FixedType.Class)typeVar2).args).tl == list<TypeVar>.Nil._N_constant_object)
					{
						hd = ((list<TypeVar>.Cons)((FixedType.Class)typeVar2).args).hd;
						if (typeVar is FixedType.Class)
						{
							if (((FixedType.Class)typeVar).args is list<TypeVar>.Cons)
							{
								tycon2 = ((FixedType.Class)typeVar).tycon;
								if ((object)((list<TypeVar>.Cons)((FixedType.Class)typeVar).args).tl == list<TypeVar>.Nil._N_constant_object)
								{
									typeVar = ((list<TypeVar>.Cons)((FixedType.Class)typeVar).args).hd;
									if (tycon.Equals(tycon2))
									{
										TypeVar typeVar3 = hd;
										t2 = typeVar;
										t1 = typeVar3;
										continue;
									}
									result = 0;
									break;
								}
							}
							goto IL_0087;
						}
					}
					else if (typeVar is FixedType.Class)
					{
						tycon = ((FixedType.Class)typeVar2).tycon;
						list = ((FixedType.Class)typeVar2).args;
						goto IL_00a5;
					}
				}
				else if (typeVar is FixedType.Class)
				{
					tycon = ((FixedType.Class)typeVar2).tycon;
					list = ((FixedType.Class)typeVar2).args;
					goto IL_00a5;
				}
			}
			else if (typeVar2 is FixedType.StaticTypeVarRef)
			{
				if (typeVar is FixedType.StaticTypeVarRef)
				{
					StaticTypeVar tyvar = ((FixedType.StaticTypeVarRef)typeVar2).tyvar;
					StaticTypeVar tyvar2 = ((FixedType.StaticTypeVarRef)typeVar).tyvar;
					result = (tyvar.StructuralEquals(tyvar2) ? 1 : 0);
					break;
				}
			}
			else if (typeVar2 is FixedType.Fun)
			{
				if (typeVar is FixedType.Fun)
				{
					hd = ((FixedType.Fun)typeVar2).from;
					to = ((FixedType.Fun)typeVar2).to;
					typeVar2 = ((FixedType.Fun)typeVar).from;
					typeVar = ((FixedType.Fun)typeVar).to;
					if (StructuralEquals(hd, typeVar2))
					{
						TypeVar typeVar4 = to;
						t2 = typeVar;
						t1 = typeVar4;
						continue;
					}
					result = 0;
					break;
				}
			}
			else if (typeVar2 is FixedType.Tuple)
			{
				if (typeVar is FixedType.Tuple)
				{
					list = ((FixedType.Tuple)typeVar2).args;
					lst = ((FixedType.Tuple)typeVar).args;
					result = (list.ForAll2(lst, _N_static_proxy_97260.single_instance) ? 1 : 0);
					break;
				}
			}
			else
			{
				if (!(typeVar2 is FixedType.Array))
				{
					if (typeVar2 is FixedType.Ref)
					{
						if (typeVar is FixedType.Out)
						{
							to = ((FixedType.Ref)typeVar2).t;
							hd = ((FixedType.Out)typeVar).t;
						}
						else
						{
							if (!(typeVar is FixedType.Ref))
							{
								goto IL_0628;
							}
							to = ((FixedType.Ref)typeVar2).t;
							hd = ((FixedType.Ref)typeVar).t;
						}
					}
					else
					{
						if (!(typeVar2 is FixedType.Out))
						{
							if (typeVar2 is FixedType.Void)
							{
								if (typeVar is FixedType.Void)
								{
									result = 1;
									break;
								}
							}
							else if (typeVar2 is FixedType.Intersection && typeVar is FixedType.Intersection)
							{
								list<FixedType> list2 = ((FixedType.Intersection)typeVar2).types;
								list<FixedType> list3 = ((FixedType.Intersection)typeVar).types;
								if (list2.Length == list3.Length)
								{
									Hashtable<TypeInfo, FixedType.Class> hashtable = new Hashtable<TypeInfo, FixedType.Class>();
									list2 = list2;
									while (list2 is list<FixedType>.Cons)
									{
										FixedType hd2 = ((list<FixedType>.Cons)list2).hd;
										list2 = ((list<FixedType>.Cons)list2).tl;
										if (hd2 is FixedType.Class)
										{
											tycon = ((FixedType.Class)hd2).tycon;
											hashtable[tycon] = (FixedType.Class)hd2;
										}
										list2 = list2;
									}
									flag = true;
									list2 = list3;
									while (list2 is list<FixedType>.Cons)
									{
										FixedType hd2 = ((list<FixedType>.Cons)list2).hd;
										list2 = ((list<FixedType>.Cons)list2).tl;
										if (hd2 is FixedType.Class)
										{
											tycon = ((FixedType.Class)hd2).tycon;
											flag = hashtable.Contains(tycon) && flag && StructuralEquals(hashtable[tycon], (FixedType.Class)hd2);
										}
										list2 = list2;
									}
									result = (flag ? 1 : 0);
								}
								else
								{
									result = 0;
								}
								break;
							}
							goto IL_0628;
						}
						if (typeVar is FixedType.Ref)
						{
							to = ((FixedType.Out)typeVar2).t;
							hd = ((FixedType.Ref)typeVar).t;
						}
						else
						{
							if (!(typeVar is FixedType.Out))
							{
								goto IL_0628;
							}
							to = ((FixedType.Out)typeVar2).t;
							hd = ((FixedType.Out)typeVar).t;
						}
					}
					goto IL_0460;
				}
				if (typeVar is FixedType.Array)
				{
					to = ((FixedType.Array)typeVar2).t;
					int rank = ((FixedType.Array)typeVar2).rank;
					hd = ((FixedType.Array)typeVar).t;
					int rank2 = ((FixedType.Array)typeVar).rank;
					if (rank == rank2)
					{
						goto IL_0460;
					}
				}
			}
			goto IL_0628;
			IL_064e:
			if (!(typeVar is FixedType) && 0 == 0)
			{
				result = (typeVar2.TryUnify(typeVar) ? 1 : 0);
				break;
			}
			goto IL_0665;
			IL_0087:
			tycon = ((FixedType.Class)typeVar2).tycon;
			list = ((FixedType.Class)typeVar2).args;
			goto IL_00a5;
			IL_0460:
			TypeVar typeVar5 = to;
			t2 = hd;
			t1 = typeVar5;
			continue;
			IL_00a5:
			tycon2 = ((FixedType.Class)typeVar).tycon;
			lst = ((FixedType.Class)typeVar).args;
			result = ((tycon.Equals(tycon2) && list.ForAll2(lst, _N_static_proxy_97260.single_instance)) ? 1 : 0);
			break;
			IL_0628:
			typeVar2 = typeVar2;
			typeVar = typeVar;
			if (typeVar2 is FixedType)
			{
				if (1 == 0)
				{
					goto IL_064e;
				}
			}
			else if (0 == 0)
			{
				goto IL_064e;
			}
			goto IL_0665;
			IL_0665:
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	public override bool Require(TypeVar t)
	{
		return t.IsFixed ? Require(t.FixedValue) : ((!IsFixed) ? AddRelation(t, this) : t.Provide(FixedValue));
	}

	public bool TryRequire(TypeVar t)
	{
		Manager.Solver.PushState();
		try
		{
			return Require(t);
		}
		finally
		{
			Manager.Solver.PopState();
		}
	}

	public void ForceRequire(TypeVar t)
	{
		bool flag;
		if (LocalError)
		{
			flag = Require(t);
			return;
		}
		flag = Require(t);
		if (flag)
		{
			return;
		}
		if (!Message.SeenError)
		{
			Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
		}
		throw new AssertionException("ncc\\typing\\TypeVar.n", 160, flag.ToString(), "failed to require " + Convert.ToString(t) + " from " + Convert.ToString(this));
	}

	public override bool Require(FixedType t)
	{
		return (!IsFixed) ? AddRelation(t, this, rev: false) : Self.Require(t);
	}

	public override bool Provide(TypeVar t)
	{
		return t.IsFixed ? Provide(t.FixedValue) : ((!IsFixed) ? AddRelation(this, t) : t.Require(FixedValue));
	}

	public bool TryProvide(TypeVar t)
	{
		Manager.Solver.PushState();
		try
		{
			return Provide(t);
		}
		finally
		{
			Manager.Solver.PopState();
		}
	}

	public void ForceProvide(TypeVar t)
	{
		bool flag;
		if (LocalError)
		{
			flag = Provide(t);
			return;
		}
		flag = Provide(t);
		if (flag)
		{
			return;
		}
		if (!Message.SeenError)
		{
			Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
		}
		throw new AssertionException("ncc\\typing\\TypeVar.n", 208, flag.ToString(), "failed to provide " + Convert.ToString(t) + " to " + Convert.ToString(this));
	}

	public override bool Provide(FixedType t)
	{
		return (!IsFixed) ? AddRelation(t, this, rev: true) : Self.Provide(t);
	}

	public bool Unify(TypeVar t)
	{
		return Self._N__FT_Unify_3996(t);
	}

	public bool TryUnify(TypeVar t)
	{
		Manager.Solver.PushState();
		try
		{
			return Unify(t);
		}
		finally
		{
			Manager.Solver.PopState();
		}
	}

	public override bool Unify(FixedType t)
	{
		return Self._N__FT_Unify_3997(t);
	}

	public void ForceUnify(TypeVar t)
	{
		bool flag;
		if (LocalError)
		{
			flag = Unify(t);
			return;
		}
		flag = Unify(t);
		if (flag)
		{
			return;
		}
		if (!Message.SeenError)
		{
			Message.Debug("Internal compiler error, please report a bug to bugs.nemerle.org. You can try modifying program near this location.");
		}
		throw new AssertionException("ncc\\typing\\TypeVar.n", 302, flag.ToString(), "failed to unify " + Convert.ToString(t) + " and " + Convert.ToString(this));
	}

	public bool EqualsUpperBound(TypeVar other)
	{
		bool flag = false;
		int num = 0;
		int result;
		if (upper_bound != null && upper_bound.Equals(other))
		{
			result = 1;
		}
		else if (upper_tyvars == null)
		{
			result = 0;
		}
		else
		{
			TypeVar[] array = upper_tyvars;
			num = 0;
			while (true)
			{
				if (num < array.Length)
				{
					TypeVar typeVar = array[num];
					typeVar = typeVar;
					if (typeVar != null)
					{
						if (typeVar.IsFixed)
						{
							if (typeVar.FixedValue.Equals(other))
							{
								flag = true;
								break;
							}
						}
						else
						{
							option<FixedType> hint = typeVar.Hint;
							if (hint is option<FixedType>.Some)
							{
								FixedType val = ((option<FixedType>.Some)hint).val;
								if (val.Equals(other))
								{
									flag = true;
									break;
								}
							}
						}
					}
					num = checked(num + 1);
					continue;
				}
				flag = false;
				break;
			}
			flag = flag;
			result = (flag ? 1 : 0);
		}
		return (byte)result != 0;
	}

	public bool Equals(TypeVar t)
	{
		return t.Self == Self || (IsFixed && t.IsFixed && FixedValue.Equals(t.FixedValue));
	}

	public override FixedType Fix()
	{
		Fixate();
		return FixedValue;
	}

	public override bool IsAccessibleFrom(TypeInfo _N_wildcard_3443)
	{
		//Discarded unreachable code: IL_000b
		throw new NotSupportedException("it is supposed to be called on fixed type");
	}

	public void Fixate()
	{
		Self._N__FT_Fixate_3998();
	}

	public override string ToString()
	{
		string text = null;
		FixedType fixedType = null;
		int num = 0;
		FixedType fixedType2 = null;
		checked
		{
			string result;
			if (IsFree)
			{
				level++;
				object obj;
				if (level > 4)
				{
					obj = "...";
				}
				else
				{
					fixedType2 = Self.lower_bound;
					fixedType = Self.upper_bound;
					if ((object)fixedType2 == null)
					{
						if ((object)fixedType == null)
						{
							text = "";
							if (Self.upper_tyvars != null)
							{
								TypeVar[] array = Self.upper_tyvars;
								for (num = 0; num < array.Length; num++)
								{
									TypeVar typeVar = array[num];
									typeVar = typeVar;
									if (typeVar != null)
									{
										option<FixedType> hint = typeVar.Hint;
										if (hint is option<FixedType>.Some)
										{
											fixedType = ((option<FixedType>.Some)hint).val;
											text = ((!(text == "")) ? string.Concat(text, ", " + Convert.ToString(fixedType) + "++") : (Convert.ToString(fixedType) + "++"));
										}
										else if (hint != option<FixedType>.None._N_constant_object)
										{
											throw new MatchFailureException();
										}
									}
								}
							}
							if (Self.lower_tyvars != null)
							{
								TypeVar[] array = Self.lower_tyvars;
								for (num = 0; num < array.Length; num++)
								{
									TypeVar typeVar = array[num];
									typeVar = typeVar;
									if (typeVar != null)
									{
										option<FixedType> hint = typeVar.Hint;
										if (hint is option<FixedType>.Some)
										{
											fixedType = ((option<FixedType>.Some)hint).val;
											text = ((!(text == "")) ? string.Concat(text, ", " + Convert.ToString(fixedType) + "--") : (Convert.ToString(fixedType) + "--"));
										}
										else if (hint != option<FixedType>.None._N_constant_object)
										{
											throw new MatchFailureException();
										}
									}
								}
							}
							obj = ((!(text == "")) ? text : (Self.HasReferenceTypeConstraint ? "'reference type'" : (Self.IsFromNull ? "'reference or nullable type'" : ((!Self.IsValueType) ? "?" : "'value type'"))));
						}
						else
						{
							obj = Convert.ToString(fixedType) + "-";
						}
					}
					else if ((object)fixedType == null)
					{
						obj = Convert.ToString(fixedType2) + "+";
					}
					else
					{
						fixedType2 = fixedType2;
						fixedType = fixedType;
						obj = ((!fixedType2.Equals(InternalType.Object)) ? ("(" + Convert.ToString(fixedType2) + " TILL " + Convert.ToString(fixedType) + ")") : (Convert.ToString(fixedType) + "-"));
					}
				}
				text = (string)obj;
				level--;
				result = text;
			}
			else
			{
				level++;
				text = ((level <= 4) ? FixedValue.ToString() : "...");
				level--;
				result = text;
			}
			return result;
		}
	}

	public int CompareTo(TypeVar other)
	{
		return checked(id - other.id);
	}

	public override int GetHashCode()
	{
		return id;
	}

	public override Type GetSystemType()
	{
		return Fix().GetSystemType();
	}

	public override Type GetNonVoidSystemType()
	{
		return Fix().GetNonVoidSystemType();
	}

	private static TypeVar DoDeepFix(TypeVar x)
	{
		return x.DeepFix();
	}

	private static FixedType DoDeepFixM(FixedType x)
	{
		return x.DeepFix();
	}

	public FixedType DeepFix()
	{
		object result;
		if (Manager.Solver.CanEnterPossiblyLooping())
		{
			FixedType fixedType2;
			try
			{
				FixedType fixedType = Fix();
				object obj;
				if (fixedType is FixedType.Class)
				{
					TypeInfo tycon = ((FixedType.Class)fixedType).tycon;
					list<TypeVar> list = ((FixedType.Class)fixedType).args;
					obj = new FixedType.Class(tycon, list.Map(_N_static_proxy_98002.single_instance));
				}
				else
				{
					if (fixedType is FixedType.StaticTypeVarRef)
					{
						goto IL_017c;
					}
					if (fixedType is FixedType.Fun)
					{
						TypeVar from = ((FixedType.Fun)fixedType).from;
						int argsCount = ((FixedType.Fun)fixedType).argsCount;
						TypeVar to = ((FixedType.Fun)fixedType).to;
						obj = new FixedType.Fun(from.DeepFix(), argsCount, to.DeepFix());
					}
					else if (fixedType is FixedType.Tuple)
					{
						list<TypeVar> list2 = ((FixedType.Tuple)fixedType).args;
						obj = new FixedType.Tuple(list2.Map(_N_static_proxy_98002.single_instance));
					}
					else if (fixedType is FixedType.Array)
					{
						TypeVar t = ((FixedType.Array)fixedType).t;
						int rank = ((FixedType.Array)fixedType).rank;
						obj = new FixedType.Array(t.DeepFix(), rank);
					}
					else if (fixedType is FixedType.Ref)
					{
						TypeVar t2 = ((FixedType.Ref)fixedType).t;
						obj = new FixedType.Ref(t2.DeepFix());
					}
					else if (fixedType is FixedType.Out)
					{
						TypeVar t3 = ((FixedType.Out)fixedType).t;
						obj = new FixedType.Out(t3.DeepFix());
					}
					else
					{
						if (fixedType is FixedType.Void)
						{
							goto IL_017c;
						}
						if (!(fixedType is FixedType.Intersection))
						{
							throw new MatchFailureException();
						}
						list<FixedType> list3 = ((FixedType.Intersection)fixedType).types;
						obj = new FixedType.Intersection(list3.Map(_N_static_proxy_98012.single_instance));
					}
				}
				goto IL_01bb;
				IL_01bb:
				fixedType2 = (FixedType)obj;
				goto end_IL_0015;
				IL_017c:
				obj = fixedType;
				goto IL_01bb;
				end_IL_0015:;
			}
			finally
			{
				Manager.Solver.LeavePossiblyLooping();
			}
			result = fixedType2;
		}
		else
		{
			if (Manager.Solver.CurrentMessenger.NeedMessage)
			{
				Manager.Solver.CurrentMessenger.Error("deep fixation failed");
			}
			else
			{
				Manager.Solver.CurrentMessenger.MarkError();
			}
			if (Manager.Solver.CurrentMessenger.NeedMessage)
			{
				Message.MaybeBailout();
			}
			result = InternalType.Void;
		}
		return (FixedType)result;
	}

	public static TypeVar FromList(list<TypeVar> types)
	{
		object result;
		if (types is list<TypeVar>.Cons)
		{
			if ((object)((list<TypeVar>.Cons)types).tl != list<TypeVar>.Nil._N_constant_object)
			{
				goto IL_0032;
			}
			TypeVar hd = ((list<TypeVar>.Cons)types).hd;
			result = hd;
		}
		else
		{
			if ((object)types != list<TypeVar>.Nil._N_constant_object)
			{
				goto IL_0032;
			}
			result = new FixedType.Void();
		}
		goto IL_0054;
		IL_0054:
		return (TypeVar)result;
		IL_0032:
		result = new FixedType.Tuple(types);
		goto IL_0054;
	}

	public list<TypeVar> ToList(IMethod method)
	{
		int length = method.GetParameters().Length;
		object result;
		switch (length)
		{
		case 0:
			result = list<TypeVar>.Nil._N_constant_object;
			break;
		case 1:
			result = new list<TypeVar>.Cons(this, list<TypeVar>.Nil._N_constant_object);
			break;
		default:
		{
			FixedType fixedType = Fix();
			if (fixedType is FixedType.Tuple)
			{
				list<TypeVar> list = ((FixedType.Tuple)fixedType).args;
				if (length != list.Length)
				{
				}
				result = list;
				break;
			}
			fixedType = fixedType;
			if (!Message.SeenError)
			{
				string text = ("Type not match method signature (" + Convert.ToString(fixedType) + " <- " + Convert.ToString(this) + ")").ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\typing\\TypeVar.n", 825, "", ("Type not match method signature (" + Convert.ToString(fixedType) + " <- " + Convert.ToString(this) + ")").ToString());
		}
		}
		return (list<TypeVar>)result;
	}

	public list<TypeVar> FunParamsTypes(IMethod meth)
	{
		option<FixedType> hint = Hint;
		if (hint is option<FixedType>.Some && ((option<FixedType>.Some)hint).val is FixedType.Fun)
		{
			TypeVar from = ((FixedType.Fun)((option<FixedType>.Some)hint).val).from;
			return from.ToList(meth);
		}
		if (!Message.SeenError)
		{
			string text = "(see backtrace)".ToString();
			Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
		}
		throw new AssertionException("ncc\\typing\\TypeVar.n", 835, "", "(see backtrace)");
	}

	private bool AddRelation(TypeVar low, TypeVar high)
	{
		int num = 0;
		TypeVar self = low.Self;
		TypeVar self2 = high.Self;
		if (!self.IsFree)
		{
			throw new AssertionException("ncc\\typing\\TypeVar.n", 860, "low.IsFree", "");
		}
		if (!self2.IsFree)
		{
			throw new AssertionException("ncc\\typing\\TypeVar.n", 861, "high.IsFree", "");
		}
		int result;
		checked
		{
			if (self == self2 || self2.IsIn(self.upper_tyvars))
			{
				result = 1;
			}
			else
			{
				int localErrorCount = LocalErrorCount;
				self.WillWrite();
				self2.WillWrite();
				if (self.HasReferenceTypeConstraint)
				{
					self2.HasReferenceTypeConstraint = true;
				}
				else if (self2.HasReferenceTypeConstraint)
				{
					self.HasReferenceTypeConstraint = true;
				}
				if (self.IsFromNull)
				{
					self2.IsFromNull = true;
				}
				else if (self2.IsFromNull)
				{
					self.IsFromNull = true;
				}
				self2.flags &= ~Flags.IsFresh;
				self.flags &= ~Flags.IsFresh;
				AddEdge(self, self2);
				if (self.IsIn(self.upper_tyvars))
				{
					TypeVar[] array = IntersectSets(self.upper_tyvars, self2.lower_tyvars);
					if (!self2.IsIn(array))
					{
						throw new AssertionException("ncc\\typing\\TypeVar.n", 925, "high.IsIn(cycle)", "");
					}
					if (!self.IsIn(array))
					{
						throw new AssertionException("ncc\\typing\\TypeVar.n", 926, "low.IsIn(cycle)", "");
					}
					for (num = 0; num < array.Length; num++)
					{
						self2 = array[num];
						self2 = self2;
						if (self2 != null && self2 != self)
						{
							bool flag = self2.Alias(self);
						}
					}
					self.FixArrays();
					for (num = 0; num < array.Length; num++)
					{
						self2 = array[num];
						self2 = self2;
						if (self2 != null)
						{
							if (self2.upper_bound != null)
							{
								bool flag = self.Provide(self2.upper_bound);
							}
							if (self2.lower_bound != null)
							{
								bool flag = self.Require(self2.lower_bound);
							}
						}
					}
					for (num = 0; num < array.Length; num++)
					{
						self2 = array[num];
						self2 = self2;
						if (self2 != null)
						{
							if (self2.upper_bound != null)
							{
								self.SetUpperBound(self2.upper_bound);
							}
							if (self2.lower_bound != null)
							{
								self.SetLowerBound(self2.lower_bound);
							}
						}
					}
				}
				else
				{
					self = self.Self;
					if (self.lower_bound != null)
					{
						bool flag = self2.Require(self.lower_bound);
					}
					self2 = self2.Self;
					if (self2.upper_bound != null)
					{
						bool flag = self.Provide(self2.upper_bound);
					}
				}
				result = ((localErrorCount == LocalErrorCount) ? 1 : 0);
			}
		}
		return (byte)result != 0;
	}

	private bool Alias(TypeVar tv)
	{
		WillWrite();
		if (Self != this)
		{
			throw new AssertionException("ncc\\typing\\TypeVar.n", 972, "(Self : object) == this", "");
		}
		int result;
		if (tv.Self != this)
		{
			if (tv.IsFree && HasReferenceTypeConstraint && !tv.HasReferenceTypeConstraint)
			{
				tv.HasReferenceTypeConstraint = true;
			}
			if (IsFromNull && !tv.CanBeNull)
			{
				if (Manager.Solver.CurrentMessenger.NeedMessage)
				{
					Manager.Solver.CurrentMessenger.SaveError("the `null' literal is not a valid value of type " + Convert.ToString(tv));
				}
				else
				{
					Manager.Solver.CurrentMessenger.MarkError();
				}
				result = 0;
			}
			else
			{
				if (tv.IsFree && IsFromNull && !tv.IsFromNull)
				{
					tv.IsFromNull = true;
				}
				flags |= Flags.IsAliased;
				alias_to = tv;
				result = 1;
			}
		}
		else
		{
			result = 1;
		}
		return (byte)result != 0;
	}

	protected static bool IsValueTypeImpl(FixedType type)
	{
		int result;
		if (!(type is FixedType.Class))
		{
			result = ((type is FixedType.Tuple && ((FixedType.Tuple)type).args is list<TypeVar>.Cons && ((list<TypeVar>.Cons)((FixedType.Tuple)type).args).tl is list<TypeVar>.Cons && ((object)((list<TypeVar>.Cons)((list<TypeVar>.Cons)((FixedType.Tuple)type).args).tl).tl == list<TypeVar>.Nil._N_constant_object || (((list<TypeVar>.Cons)((list<TypeVar>.Cons)((FixedType.Tuple)type).args).tl).tl is list<TypeVar>.Cons && (object)((list<TypeVar>.Cons)((list<TypeVar>.Cons)((list<TypeVar>.Cons)((FixedType.Tuple)type).args).tl).tl).tl == list<TypeVar>.Nil._N_constant_object))) ? 1 : 0);
		}
		else
		{
			TypeInfo tycon = ((FixedType.Class)type).tycon;
			result = (tycon.IsValueType ? 1 : 0);
		}
		return (byte)result != 0;
	}

	private void SetLowerBound(TypeVar lb)
	{
		int num = 0;
		if (lb == null || upper_tyvars == null)
		{
			return;
		}
		TypeVar[] array = upper_tyvars;
		for (num = 0; num < array.Length; num = checked(num + 1))
		{
			TypeVar typeVar = array[num];
			typeVar = typeVar;
			if (typeVar != null)
			{
				bool flag = typeVar.Require(lb);
			}
		}
	}

	private void SetUpperBound(TypeVar ub)
	{
		int num = 0;
		if (ub == null || lower_tyvars == null)
		{
			return;
		}
		TypeVar[] array = lower_tyvars;
		for (num = 0; num < array.Length; num = checked(num + 1))
		{
			TypeVar typeVar = array[num];
			typeVar = typeVar;
			if (typeVar != null)
			{
				bool flag = typeVar.Provide(ub);
			}
		}
	}

	private static void FixArray(TypeVar[] s, TypeVar eject)
	{
		int num = 0;
		for (num = 0; num < s.Length; num = checked(num + 1))
		{
			if (s[num] != null)
			{
				TypeVar self = s[num].Self;
				if ((self.flags & Flags.IsMonoType) != 0 || self == eject)
				{
					s[num] = null;
				}
				else
				{
					s[num] = self;
				}
			}
		}
	}

	private void FixArrays()
	{
		FixArray(lower_tyvars, this);
		FixArray(upper_tyvars, this);
	}

	private bool AddRelation(FixedType low, TypeVar high, bool rev)
	{
		_N_closureOf_AddRelation_98421 n_closureOf_AddRelation_ = new _N_closureOf_AddRelation_98421();
		n_closureOf_AddRelation_._N__N_closurised_this_ptr_98426 = this;
		int result;
		if (Manager.Solver.CanEnterPossiblyLooping())
		{
			bool flag;
			try
			{
				if (low == null)
				{
					throw new AssertionException("ncc\\typing\\TypeVar.n", 1098, "low != null", "");
				}
				if (high == null)
				{
					throw new AssertionException("ncc\\typing\\TypeVar.n", 1099, "high != null", "");
				}
				high.WillWrite();
				TypeVar self = high.Self;
				self.flags &= ~Flags.IsFresh;
				int num;
				int localErrorCount;
				FixedType fixedType;
				TypeVar self2;
				int num3;
				FixedType fixedType2;
				TypeVar self3;
				int num5;
				checked
				{
					if (low.IsSeparated && self.IsFree)
					{
						if (!(low is FixedType.Void))
						{
							throw new AssertionException("ncc\\typing\\TypeVar.n", 1149, "", "");
						}
						num = (self.Unify(low) ? 1 : 0);
					}
					else if (rev && low.Equals(InternalType.Object))
					{
						num = (self.Unify(low) ? 1 : 0);
					}
					else if (!self.IsFree)
					{
						num = (((!rev) ? self.FixedValue.Require(low) : low.Require(self.FixedValue)) ? 1 : 0);
					}
					else
					{
						if (!self.IsFree || !self.IsFromNull || low.CanBeNull)
						{
							localErrorCount = LocalErrorCount;
							if (rev)
							{
								fixedType = Manager.Solver.Sum(self.upper_bound, low);
								self2 = self.Self;
								if (self2.IsFixed)
								{
									self2.Provide(fixedType);
								}
								else
								{
									self2.WillWrite();
									if (self2.upper_bound == null || !fixedType.Equals(self2.upper_bound))
									{
										if (fixedType is FixedType.Tuple)
										{
											list<TypeVar> list = ((FixedType.Tuple)fixedType).args;
											int num2 = self2.id;
											list<TypeVar> list2 = list;
											num3 = 0;
											while (list2 is list<TypeVar>.Cons)
											{
												TypeVar hd = ((list<TypeVar>.Cons)list2).hd;
												list<TypeVar> list3 = ((list<TypeVar>.Cons)list2).tl;
												TypeVar typeVar = hd;
												if (typeVar.id != num2)
												{
													list<TypeVar> obj = list3;
													num3++;
													list2 = obj;
													continue;
												}
												goto IL_02b3;
											}
										}
										self2.upper_bound = fixedType;
										goto IL_02e0;
									}
								}
							}
							else
							{
								fixedType2 = Manager.Solver.Intersect(self.lower_bound, low);
								self3 = self.Self;
								if (self3.IsFixed)
								{
									self3.Require(fixedType2);
								}
								else
								{
									self3.WillWrite();
									if (self3.lower_bound == null || !fixedType2.Equals(self3.lower_bound))
									{
										if (fixedType2 is FixedType.Tuple)
										{
											list<TypeVar> list4 = ((FixedType.Tuple)fixedType2).args;
											int num4 = self3.id;
											list<TypeVar> list5 = list4;
											num5 = 0;
											while (list5 is list<TypeVar>.Cons)
											{
												TypeVar hd2 = ((list<TypeVar>.Cons)list5).hd;
												list<TypeVar> list6 = ((list<TypeVar>.Cons)list5).tl;
												TypeVar typeVar2 = hd2;
												if (typeVar2.id != num4)
												{
													list<TypeVar> obj2 = list6;
													num5++;
													list5 = obj2;
													continue;
												}
												goto IL_03cc;
											}
										}
										self3.lower_bound = fixedType2;
										goto IL_03fb;
									}
								}
							}
							goto IL_0408;
						}
						if (Manager.Solver.CurrentMessenger.NeedMessage)
						{
							Manager.Solver.CurrentMessenger.SaveError("the `null' literal is not a valid value of type " + Convert.ToString(low));
						}
						else
						{
							Manager.Solver.CurrentMessenger.MarkError();
						}
						num = 0;
					}
					goto IL_04df;
				}
				IL_04df:
				flag = (byte)num != 0;
				goto end_IL_0022;
				IL_02e0:
				self2.SetUpperBound(low);
				goto IL_0408;
				IL_02b3:
				_N_error_98471(n_closureOf_AddRelation_, num3, fixedType);
				goto IL_02e0;
				IL_03cc:
				_N_error_98471(n_closureOf_AddRelation_, num5, fixedType2);
				goto IL_03fb;
				IL_0408:
				if (!self.IsFixed)
				{
					TypeVar self4 = self.Self;
					if (self4.upper_bound != null && self4.lower_bound != null)
					{
						self4.upper_bound.Require(self4.lower_bound);
					}
					TypeVar self5 = self4.Self;
					if (self5.IsFree && self5.upper_bound != null && self5.lower_bound != null && self5.upper_bound.TryEnforcingEquality(self5.lower_bound))
					{
						self5.Unify(self5.lower_bound);
					}
				}
				num = ((localErrorCount == LocalErrorCount) ? 1 : 0);
				goto IL_04df;
				IL_03fb:
				self3.SetLowerBound(low);
				goto IL_0408;
				end_IL_0022:;
			}
			finally
			{
				Manager.Solver.LeavePossiblyLooping();
			}
			result = (flag ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	private void print_info()
	{
		int num = serial;
		serial = 1;
		Message.Debug(string.Concat(string.Concat("oops, our_serial=" + Convert.ToString(num) + ", stack[0]=" + Convert.ToString(Manager.Solver.serial_stack[0]) + ", ", "stack[1]=" + Convert.ToString(Manager.Solver.serial_stack[1]) + ", top=" + Convert.ToString(Manager.Solver.serial_stack_top) + ", "), "id=" + Convert.ToString(id) + ", this=" + Convert.ToString(this)));
		serial = num;
	}

	private void WillRead()
	{
		if (Manager.Solver.top_serial == serial)
		{
			return;
		}
		int num = Manager.Solver.serial_stack_top;
		while (true)
		{
			if (num < 0 || Manager.Solver.serial_stack[num] < serial)
			{
				if (next == null)
				{
					print_info();
					throw new AssertionException("ncc\\typing\\TypeVar.n", 1273, "", "");
				}
				TypeVar typeVar = next;
				CopyFrom(next);
				typeVar.next = Manager.TyVar_reuse_queue;
				Manager.TyVar_reuse_queue = typeVar;
				num = Manager.Solver.serial_stack_top;
			}
			else
			{
				if (Manager.Solver.serial_stack[num] == serial)
				{
					break;
				}
				num = checked(num - 1);
			}
		}
	}

	private void CopyArrays()
	{
		if (upper_tyvars != null)
		{
			upper_tyvars = (TypeVar[])upper_tyvars.Clone();
		}
		if (lower_tyvars != null)
		{
			lower_tyvars = (TypeVar[])lower_tyvars.Clone();
		}
	}

	private static TypeVar CopyTyVar(TypeVar tv)
	{
		TypeVar result;
		if (tv.Manager.TyVar_reuse_queue == null)
		{
			result = new TypeVar(tv);
		}
		else
		{
			TypeVar tyVar_reuse_queue = tv.Manager.TyVar_reuse_queue;
			tv.Manager.TyVar_reuse_queue = tv.Manager.TyVar_reuse_queue.next;
			tyVar_reuse_queue.flags = Flags.None;
			tyVar_reuse_queue.CopyFrom(tv);
			result = tyVar_reuse_queue;
		}
		return result;
	}

	private void WillWrite()
	{
		WillRead();
		if (Manager.Solver.top_serial != serial)
		{
			TypeVar typeVar = (next = CopyTyVar(this));
			CopyArrays();
			serial = Manager.Solver.top_serial;
		}
	}

	private void CopyFrom(TypeVar other)
	{
		if ((other.flags & Flags.IsMonoType) != 0)
		{
			throw new AssertionException("ncc\\typing\\TypeVar.n", 1346, "!other.flags %&& Flags.IsMonoType", "");
		}
		if ((flags & Flags.IsMonoType) != 0)
		{
			throw new AssertionException("ncc\\typing\\TypeVar.n", 1347, "!flags %&& Flags.IsMonoType", "");
		}
		alias_to = other.alias_to;
		next = other.next;
		serial = other.serial;
		id = other.id;
		lower_bound = other.lower_bound;
		upper_bound = other.upper_bound;
		flags = other.flags;
		lower_tyvars = other.lower_tyvars;
		upper_tyvars = other.upper_tyvars;
		Location = other.Location;
	}

	internal void ResetSerial()
	{
		if (!IsFresh)
		{
		}
		serial = 1;
	}

	[DebuggerNonUserCode]
	internal TypeVar(ManagerClass man)
	{
		Manager = man;
		id = Manager.TyVar_Id;
		ManagerClass manager = Manager;
		checked
		{
			manager.TyVar_Id++;
			serial = Manager.Solver.top_serial;
			flags = Flags.IsFresh;
			if (stop_serial != serial || this is FixedType)
			{
			}
		}
	}

	private TypeVar(TypeVar other)
	{
		Manager = other.Manager;
		CopyFrom(other);
	}

	private void NullToEmpty()
	{
		WillWrite();
		if (upper_tyvars == null)
		{
			upper_tyvars = empty_set;
		}
		if (lower_tyvars == null)
		{
			lower_tyvars = empty_set;
		}
	}

	private static void AddEdge(TypeVar low, TypeVar high)
	{
		int num = 0;
		low.NullToEmpty();
		high.NullToEmpty();
		low.upper_tyvars = SumSets(low.upper_tyvars, high.upper_tyvars);
		high.InsertSelfInto(low.upper_tyvars);
		TypeVar[] array = low.lower_tyvars;
		checked
		{
			for (num = 0; num < array.Length; num++)
			{
				TypeVar typeVar = array[num];
				typeVar = typeVar;
				if (typeVar != null)
				{
					typeVar = typeVar.Self;
					if ((typeVar.flags & Flags.IsMonoType) == 0)
					{
						typeVar.WillWrite();
						typeVar.upper_tyvars = SumSets(typeVar.upper_tyvars, low.upper_tyvars);
					}
				}
			}
			high.lower_tyvars = SumSets(low.lower_tyvars, high.lower_tyvars);
			low.InsertSelfInto(high.lower_tyvars);
			array = high.upper_tyvars;
			for (num = 0; num < array.Length; num++)
			{
				TypeVar typeVar = array[num];
				typeVar = typeVar;
				if (typeVar != null)
				{
					typeVar = typeVar.Self;
					if ((typeVar.flags & Flags.IsMonoType) == 0)
					{
						typeVar.WillWrite();
						typeVar.lower_tyvars = SumSets(typeVar.lower_tyvars, high.lower_tyvars);
					}
				}
			}
		}
	}

	private bool IsIn(TypeVar[] s)
	{
		int result;
		if (s == null)
		{
			result = 0;
		}
		else
		{
			int num = 0;
			while (true)
			{
				if (num >= s.Length)
				{
					result = 0;
					break;
				}
				if (s[num] != null && s[num].Self == this)
				{
					result = 1;
					break;
				}
				num = checked(num + 1);
			}
		}
		return (byte)result != 0;
	}

	private static int NormalizeAndCount(TypeVar[] s)
	{
		int num = 0;
		int num2 = 0;
		num2 = 0;
		checked
		{
			for (num = 0; num < s.Length; num++)
			{
				if (s[num] != null)
				{
					TypeVar self = s[num].Self;
					if ((self.flags & Flags.IsMonoType) != 0)
					{
						s[num] = null;
						continue;
					}
					s[num] = self;
					num2++;
				}
			}
			return num2;
		}
	}

	private void InsertSelfInto(TypeVar[] s)
	{
		int i;
		for (i = 0; s[i] != null; i = checked(i + 1))
		{
		}
		s[i] = this;
	}

	private bool ContainedIn(TypeVar[] s, int max)
	{
		int num = 0;
		int result;
		while (true)
		{
			if (num >= max)
			{
				result = 0;
				break;
			}
			if (s[num] == this)
			{
				result = 1;
				break;
			}
			num = checked(num + 1);
		}
		return (byte)result != 0;
	}

	private static TypeVar[] SumSets(TypeVar[] s1, TypeVar[] s2)
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			object result;
			if (s1 == null)
			{
				result = ((s2 != null) ? s2 : new TypeVar[0]);
			}
			else if (s2 == null)
			{
				result = s1;
			}
			else
			{
				num = NormalizeAndCount(s1) + NormalizeAndCount(s2);
				TypeVar[] array = new TypeVar[num + 1];
				num2 = 0;
				if (num > 42)
				{
					HashSet<int> hashSet = new HashSet<int>();
					for (num = 0; num < s1.Length; num++)
					{
						TypeVar typeVar = s1[num];
						typeVar = typeVar;
						if (typeVar != null && hashSet.Add(typeVar.id))
						{
							array[num2] = typeVar;
							num2++;
						}
					}
					for (num = 0; num < s2.Length; num++)
					{
						TypeVar typeVar = s2[num];
						typeVar = typeVar;
						if (typeVar != null && hashSet.Add(typeVar.id))
						{
							array[num2] = typeVar;
							num2++;
						}
					}
				}
				else
				{
					for (num = 0; num < s1.Length; num++)
					{
						TypeVar typeVar = s1[num];
						typeVar = typeVar;
						if (typeVar != null && !typeVar.ContainedIn(array, num2))
						{
							array[num2] = typeVar;
							num2++;
						}
					}
					for (num = 0; num < s2.Length; num++)
					{
						TypeVar typeVar = s2[num];
						typeVar = typeVar;
						if (typeVar != null && !typeVar.ContainedIn(array, num2))
						{
							array[num2] = typeVar;
							num2++;
						}
					}
				}
				result = array;
			}
			return (TypeVar[])result;
		}
	}

	private static TypeVar[] IntersectSets(TypeVar[] s1, TypeVar[] s2)
	{
		int num = 0;
		int num2 = 0;
		num = NormalizeAndCount(s1);
		int num3 = NormalizeAndCount(s2);
		TypeVar[] array = new TypeVar[(num >= num3) ? num3 : num];
		num2 = 0;
		checked
		{
			if (num + num3 > 42)
			{
				HashSet<int> hashSet = new HashSet<int>();
				for (num = 0; num < s1.Length; num++)
				{
					TypeVar typeVar = s1[num];
					typeVar = typeVar;
					if (typeVar != null)
					{
						bool flag = hashSet.Add(typeVar.id);
					}
				}
				for (num = 0; num < s2.Length; num++)
				{
					TypeVar typeVar = s2[num];
					typeVar = typeVar;
					if (typeVar != null && hashSet.Remove(typeVar.id))
					{
						array[num2] = typeVar;
						num2++;
					}
				}
			}
			else
			{
				for (num = 0; num < s1.Length; num++)
				{
					TypeVar typeVar = s1[num];
					typeVar = typeVar;
					if (typeVar != null && typeVar.ContainedIn(s2, s2.Length) && !typeVar.ContainedIn(array, num2))
					{
						array[num2] = typeVar;
						num2++;
					}
				}
			}
			return array;
		}
	}

	private void __fake()
	{
		__fake();
		SystemTypeClass systemTypeCache = SystemTypeCache;
		InternalTypeClass internalType = InternalType;
	}

	private bool _N__FT_Unify_3996(TypeVar t)
	{
		int result;
		if (Manager.Solver.CanEnterPossiblyLooping())
		{
			bool flag;
			try
			{
				TypeVar self = t.Self;
				int num;
				if (IsFixed)
				{
					num = (self.Unify(FixedValue) ? 1 : 0);
				}
				else if (self.IsFixed)
				{
					num = (Unify(self.FixedValue) ? 1 : 0);
				}
				else if (IsFresh)
				{
					num = (Alias(self) ? 1 : 0);
				}
				else if (self.IsFresh)
				{
					num = (self.Alias(this) ? 1 : 0);
				}
				else
				{
					if (!IsFree)
					{
						throw new AssertionException("ncc\\typing\\TypeVar.n", 244, "IsFree", "");
					}
					if (!self.IsFree)
					{
						throw new AssertionException("ncc\\typing\\TypeVar.n", 245, "t.IsFree", "");
					}
					num = ((Provide(self) && Require(self)) ? 1 : 0);
				}
				flag = (byte)num != 0;
			}
			finally
			{
				Manager.Solver.LeavePossiblyLooping();
			}
			result = (flag ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	private bool _N__FT_Unify_3997(FixedType t)
	{
		int result;
		if (IsFixed)
		{
			result = (FixedValue.Unify(t) ? 1 : 0);
		}
		else if (IsFresh)
		{
			result = (((!HasReferenceTypeConstraint || !t.IsValueType) && Alias(t)) ? 1 : 0);
		}
		else
		{
			int localErrorCount = LocalErrorCount;
			if (!IsFree)
			{
				throw new AssertionException("ncc\\typing\\TypeVar.n", 277, "IsFree", "");
			}
			if (Alias(t))
			{
				if (lower_bound != null)
				{
					bool flag = t.Require(lower_bound);
				}
				if (upper_bound != null)
				{
					bool flag = t.Provide(upper_bound);
				}
				SetLowerBound(t);
				SetUpperBound(t);
			}
			result = ((localErrorCount == LocalErrorCount) ? 1 : 0);
		}
		return (byte)result != 0;
	}

	public override bool Equals(object other)
	{
		return other == this || (other is TypeVar && Equals((TypeVar)other));
	}

	private void _N__FT_Fixate_3998()
	{
		if (IsFixed)
		{
			return;
		}
		option<FixedType> hint = Hint;
		object obj;
		FixedType val;
		if (hint is option<FixedType>.Some)
		{
			val = ((option<FixedType>.Some)hint).val;
			obj = val;
		}
		else
		{
			if (hint != option<FixedType>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			obj = InternalType.Object;
		}
		val = (FixedType)obj;
		bool localError = LocalError;
		int cyclicTypeCount = Manager.Solver.CyclicTypeCount;
		bool flag = Unify(val);
		if (!localError)
		{
			if (!flag)
			{
				Manager.Solver.CurrentMessenger.DumpSavedError();
			}
			if (cyclicTypeCount != Manager.Solver.CyclicTypeCount)
			{
				Message.Error(Location.Default, "cyclic type found: " + Convert.ToString(this));
				throw new Recovery();
			}
		}
	}

	private void _N_error_98471(_N_closureOf_AddRelation_98421 _N_AddRelation_cp_98470, int index, FixedType tuple)
	{
		if (Manager.Solver.CurrentMessenger.NeedMessage)
		{
			Manager.Solver.CurrentMessenger.SaveError("the element with index " + Convert.ToString(index) + " in tuple '" + Convert.ToString(tuple) + "' is recursive. This bug can be caused by the parametr to tuple transformation.");
		}
		else
		{
			Manager.Solver.CurrentMessenger.MarkError();
		}
	}
}
