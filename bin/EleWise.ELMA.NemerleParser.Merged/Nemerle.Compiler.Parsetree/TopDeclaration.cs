using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

[Variant("Nemerle.Compiler.Parsetree.TopDeclaration.Class,Nemerle.Compiler.Parsetree.TopDeclaration.Alias,Nemerle.Compiler.Parsetree.TopDeclaration.Interface,Nemerle.Compiler.Parsetree.TopDeclaration.Variant,Nemerle.Compiler.Parsetree.TopDeclaration.VariantOption,Nemerle.Compiler.Parsetree.TopDeclaration.Macro,Nemerle.Compiler.Parsetree.TopDeclaration.Delegate,Nemerle.Compiler.Parsetree.TopDeclaration.Enum")]
public abstract class TopDeclaration : MemberBase
{
	[VariantOption]
	public class Class : TopDeclaration
	{
		public list<PExpr> t_extends;

		public readonly list<ClassMember> decls;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Class(Location loc, Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(loc, name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Class(Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Class(Name name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Class(Typarms tp, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(tp)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Class([MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
		{
			this.t_extends = t_extends;
			this.decls = decls;
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
			list<ClassMember> list = decls;
			if (list != null)
			{
				list = list;
				while (list is list<ClassMember>.Cons)
				{
					ClassMember hd = ((list<ClassMember>.Cons)list).hd;
					list = ((list<ClassMember>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			list<PExpr> list2 = t_extends;
			if (list2 != null)
			{
				list2 = list2;
				while (list2 is list<PExpr>.Cons)
				{
					PExpr hd2 = ((list<PExpr>.Cons)list2).hd;
					list2 = ((list<PExpr>.Cons)list2).tl;
					((ISupportRelocation)hd2).RelocateImpl(_info);
					list2 = list2;
				}
			}
		}
	}

	[VariantOption]
	public class Alias : TopDeclaration
	{
		public readonly PExpr ty;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Alias(Location loc, Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("ty")] PExpr ty)
			: base(loc, name, modifiers, typarms)
		{
			this.ty = ty;
		}

		[RecordCtor]
		public Alias(Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("ty")] PExpr ty)
			: base(name, modifiers, typarms)
		{
			this.ty = ty;
		}

		[RecordCtor]
		public Alias(Name name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("ty")] PExpr ty)
			: base(name, modifiers, typarms)
		{
			this.ty = ty;
		}

		[RecordCtor]
		public Alias(Typarms tp, [MappedMember("ty")] PExpr ty)
			: base(tp)
		{
			this.ty = ty;
		}

		[RecordCtor]
		public Alias([MappedMember("ty")] PExpr ty)
		{
			this.ty = ty;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				ty?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Interface : TopDeclaration
	{
		public list<PExpr> t_extends;

		public readonly list<ClassMember> methods;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public Interface(Location loc, Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("methods")] list<ClassMember> methods)
			: base(loc, name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.methods = methods;
		}

		[RecordCtor]
		public Interface(Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("methods")] list<ClassMember> methods)
			: base(name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.methods = methods;
		}

		[RecordCtor]
		public Interface(Name name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("methods")] list<ClassMember> methods)
			: base(name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.methods = methods;
		}

		[RecordCtor]
		public Interface(Typarms tp, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("methods")] list<ClassMember> methods)
			: base(tp)
		{
			this.t_extends = t_extends;
			this.methods = methods;
		}

		[RecordCtor]
		public Interface([MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("methods")] list<ClassMember> methods)
		{
			this.t_extends = t_extends;
			this.methods = methods;
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
			list<ClassMember> list = methods;
			if (list != null)
			{
				list = list;
				while (list is list<ClassMember>.Cons)
				{
					ClassMember hd = ((list<ClassMember>.Cons)list).hd;
					list = ((list<ClassMember>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			list<PExpr> list2 = t_extends;
			if (list2 != null)
			{
				list2 = list2;
				while (list2 is list<PExpr>.Cons)
				{
					PExpr hd2 = ((list<PExpr>.Cons)list2).hd;
					list2 = ((list<PExpr>.Cons)list2).tl;
					((ISupportRelocation)hd2).RelocateImpl(_info);
					list2 = list2;
				}
			}
		}
	}

	[VariantOption]
	public class Variant : TopDeclaration
	{
		public list<PExpr> t_extends;

		public list<ClassMember> decls;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		public Variant(Location loc, Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(loc, name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Variant(Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Variant(Name name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Variant(Typarms tp, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(tp)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Variant([MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
		{
			this.t_extends = t_extends;
			this.decls = decls;
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
			list<ClassMember> list = decls;
			if (list != null)
			{
				list = list;
				while (list is list<ClassMember>.Cons)
				{
					ClassMember hd = ((list<ClassMember>.Cons)list).hd;
					list = ((list<ClassMember>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			list<PExpr> list2 = t_extends;
			if (list2 != null)
			{
				list2 = list2;
				while (list2 is list<PExpr>.Cons)
				{
					PExpr hd2 = ((list<PExpr>.Cons)list2).hd;
					list2 = ((list<PExpr>.Cons)list2).tl;
					((ISupportRelocation)hd2).RelocateImpl(_info);
					list2 = list2;
				}
			}
		}
	}

	[VariantOption]
	public class VariantOption : TopDeclaration
	{
		public readonly list<ClassMember> decls;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		public VariantOption(Location loc, Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("decls")] list<ClassMember> decls)
			: base(loc, name, modifiers, typarms)
		{
			this.decls = decls;
		}

		[RecordCtor]
		public VariantOption(Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("decls")] list<ClassMember> decls)
			: base(name, modifiers, typarms)
		{
			this.decls = decls;
		}

		[RecordCtor]
		public VariantOption(Name name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("decls")] list<ClassMember> decls)
			: base(name, modifiers, typarms)
		{
			this.decls = decls;
		}

		[RecordCtor]
		public VariantOption(Typarms tp, [MappedMember("decls")] list<ClassMember> decls)
			: base(tp)
		{
			this.decls = decls;
		}

		[RecordCtor]
		public VariantOption([MappedMember("decls")] list<ClassMember> decls)
		{
			this.decls = decls;
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
			list<ClassMember> list = decls;
			if (list != null)
			{
				list = list;
				while (list is list<ClassMember>.Cons)
				{
					ClassMember hd = ((list<ClassMember>.Cons)list).hd;
					list = ((list<ClassMember>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
		}
	}

	[VariantOption]
	public class Macro : TopDeclaration
	{
		public readonly PFunHeader header;

		public readonly list<PExpr> synt;

		public readonly PExpr expr;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
		}

		[RecordCtor]
		public Macro(Location loc, Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("header")] PFunHeader header, [MappedMember("synt")] list<PExpr> synt, [MappedMember("expr")] PExpr expr)
			: base(loc, name, modifiers, typarms)
		{
			this.header = header;
			this.synt = synt;
			this.expr = expr;
		}

		[RecordCtor]
		public Macro(Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("header")] PFunHeader header, [MappedMember("synt")] list<PExpr> synt, [MappedMember("expr")] PExpr expr)
			: base(name, modifiers, typarms)
		{
			this.header = header;
			this.synt = synt;
			this.expr = expr;
		}

		[RecordCtor]
		public Macro(Name name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("header")] PFunHeader header, [MappedMember("synt")] list<PExpr> synt, [MappedMember("expr")] PExpr expr)
			: base(name, modifiers, typarms)
		{
			this.header = header;
			this.synt = synt;
			this.expr = expr;
		}

		[RecordCtor]
		public Macro(Typarms tp, [MappedMember("header")] PFunHeader header, [MappedMember("synt")] list<PExpr> synt, [MappedMember("expr")] PExpr expr)
			: base(tp)
		{
			this.header = header;
			this.synt = synt;
			this.expr = expr;
		}

		[RecordCtor]
		public Macro([MappedMember("header")] PFunHeader header, [MappedMember("synt")] list<PExpr> synt, [MappedMember("expr")] PExpr expr)
		{
			this.header = header;
			this.synt = synt;
			this.expr = expr;
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
			expr?.RelocateImplInternal(_info);
			list<PExpr> list = synt;
			if (list != null)
			{
				list = list;
				while (list is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)list).hd;
					list = ((list<PExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			header?.RelocateImplInternal(_info);
		}
	}

	[VariantOption]
	public class Delegate : TopDeclaration
	{
		public readonly PFunHeader header;

		[IgnoreField]
		[field: IgnoreField]
		public AttributesAndModifiers ReturnValueModifiers { get; set; }

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 6;
		}

		[RecordCtor]
		public Delegate(Location loc, Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("header")] PFunHeader header)
			: base(loc, name, modifiers, typarms)
		{
			this.header = header;
		}

		[RecordCtor]
		public Delegate(Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("header")] PFunHeader header)
			: base(name, modifiers, typarms)
		{
			this.header = header;
		}

		[RecordCtor]
		public Delegate(Name name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("header")] PFunHeader header)
			: base(name, modifiers, typarms)
		{
			this.header = header;
		}

		[RecordCtor]
		public Delegate(Typarms tp, [MappedMember("header")] PFunHeader header)
			: base(tp)
		{
			this.header = header;
		}

		[RecordCtor]
		public Delegate([MappedMember("header")] PFunHeader header)
		{
			this.header = header;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				header?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Enum : TopDeclaration
	{
		public readonly list<PExpr> t_extends;

		public readonly list<ClassMember> decls;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 7;
		}

		[RecordCtor]
		public Enum(Location loc, Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(loc, name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Enum(Splicable name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Enum(Name name, AttributesAndModifiers modifiers, Typarms typarms, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(name, modifiers, typarms)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Enum(Typarms tp, [MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
			: base(tp)
		{
			this.t_extends = t_extends;
			this.decls = decls;
		}

		[RecordCtor]
		public Enum([MappedMember("t_extends")] list<PExpr> t_extends, [MappedMember("decls")] list<ClassMember> decls)
		{
			this.t_extends = t_extends;
			this.decls = decls;
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
			list<ClassMember> list = decls;
			if (list != null)
			{
				list = list;
				while (list is list<ClassMember>.Cons)
				{
					ClassMember hd = ((list<ClassMember>.Cons)list).hd;
					list = ((list<ClassMember>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			list<PExpr> list2 = t_extends;
			if (list2 != null)
			{
				list2 = list2;
				while (list2 is list<PExpr>.Cons)
				{
					PExpr hd2 = ((list<PExpr>.Cons)list2).hd;
					list2 = ((list<PExpr>.Cons)list2).tl;
					((ISupportRelocation)hd2).RelocateImpl(_info);
					list2 = list2;
				}
			}
		}
	}

	private class _N_Enumerable_39829 : IEnumerator, IDisposable, IEnumerator<PExpr>, IEnumerable, IEnumerable<PExpr>
	{
		private bool _N_finally_needed_39868;

		private bool _N_finally_needed_39866;

		internal PExpr _N_x_39864;

		internal PExpr _N_x_39862;

		internal IEnumerator<PExpr> _N_enumerator_39860;

		internal IEnumerator<PExpr> _N_enumerator_39858;

		internal PExpr _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_39854;

		internal TopDeclaration _N__N_closurised_this_ptr_39852;

		internal Function<bool> _N__N_wildcard_3438_39850;

		private int _N_this_used;

		public PExpr Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_39868)
			{
				((IDisposable)_N_enumerator_39858).Dispose();
			}
			if (_N_finally_needed_39866)
			{
				((IDisposable)_N_enumerator_39860).Dispose();
			}
		}

		public void Reset()
		{
			//Discarded unreachable code: IL_0006
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			try
			{
				bool flag = false;
				if (_N_state != 0)
				{
					if (_N_state != 1)
					{
						if (_N_state == 2)
						{
							goto IL_00cc;
						}
						return false;
					}
				}
				else
				{
					_N_enumerator_39860 = _N__N_closurised_this_ptr_39852.GetSubtypesReferences().GetEnumerator();
					_N_finally_needed_39866 = true;
				}
				if (_N_enumerator_39860.MoveNext())
				{
					PExpr pExpr = (_N_x_39862 = _N_enumerator_39860.Current);
					_N_current = _N_x_39862;
					_N_state = 1;
					return true;
				}
				_N_finally_needed_39866 = false;
				((IDisposable)_N_enumerator_39860).Dispose();
				_N_enumerator_39858 = _N__N_closurised_this_ptr_39852.GetMembersTypeReferences().GetEnumerator();
				_N_finally_needed_39868 = true;
				goto IL_00cc;
				IL_00cc:
				if (_N_enumerator_39858.MoveNext())
				{
					PExpr pExpr2 = (_N_x_39864 = _N_enumerator_39858.Current);
					_N_current = _N_x_39864;
					_N_state = 2;
					return true;
				}
				_N_finally_needed_39868 = false;
				((IDisposable)_N_enumerator_39858).Dispose();
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<PExpr> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_39829 n_Enumerable_ = new _N_Enumerable_39829();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<PExpr>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<PExpr>)this;
			}
			return (IEnumerator<PExpr>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_39829 n_Enumerable_ = new _N_Enumerable_39829();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator)this;
			}
			return (IEnumerator)result;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in NonGenericGetEnum
			return this.NonGenericGetEnum();
		}

		private void CopyFrom(_N_Enumerable_39829 other)
		{
			_N_this_used = 1;
			_N__N_closurised_this_ptr_39852 = other._N__N_closurised_this_ptr_39852;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private class _N_Enumerable_39980 : IEnumerator, IDisposable, IEnumerator<PExpr>, IEnumerable, IEnumerable<PExpr>
	{
		private bool _N_finally_needed_40055;

		private bool _N_finally_needed_40053;

		internal PExpr _N_x_40051;

		internal list<PExpr> _N__N_wildcard_4026_40049;

		internal PExpr _N_x_40047;

		internal list<PExpr> _N_xs_40045;

		internal PExpr _N_x_40043;

		internal PExpr _N_x_40041;

		internal list<PParameter> _N__N_wildcard_4026_40039;

		internal PParameter _N_x_40037;

		internal list<PParameter> _N_xs_40035;

		internal PParameter _N_parameter_40033;

		internal IEnumerator<PExpr> _N_enumerator_40031;

		internal list<ClassMember> _N__N_wildcard_4026_40029;

		internal ClassMember _N_x_40027;

		internal list<ClassMember> _N_xs_40025;

		internal ClassMember _N_member_40023;

		internal PExpr _N_ty_40021;

		internal ClassMember.Property _N_prop_40019;

		internal ClassMember.Function _N_fn_40017;

		internal IEnumerator<PExpr> _N_enumerator_40015;

		internal ClassMember.Event _N_e_40013;

		internal option<PExpr> _N_value_40011;

		internal PExpr _N_x_40009;

		internal PExpr _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_40005;

		internal TopDeclaration _N__N_closurised_this_ptr_40003;

		internal Function<bool> _N__N_wildcard_3438_40001;

		private int _N_this_used;

		public PExpr Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_40055)
			{
				((IDisposable)_N_enumerator_40015).Dispose();
			}
			if (_N_finally_needed_40053)
			{
				((IDisposable)_N_enumerator_40031).Dispose();
			}
		}

		public void Reset()
		{
			//Discarded unreachable code: IL_0006
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			try
			{
				bool flag = false;
				list<ClassMember> n__N_wildcard_4026_2;
				list<PExpr> n__N_wildcard_4026_;
				list<PParameter> n__N_wildcard_4026_3;
				switch (_N_state)
				{
				default:
					return false;
				case 0:
					n__N_wildcard_4026_2 = _N__N_closurised_this_ptr_40003.GetMembers();
					goto IL_0068;
				case 4:
					n__N_wildcard_4026_ = _N_xs_40045;
					goto IL_0143;
				case 5:
					if (_N_enumerator_40015.MoveNext())
					{
						PExpr pExpr2 = (_N_x_40051 = _N_enumerator_40015.Current);
						_N_current = _N_x_40051;
						_N_state = 5;
						return true;
					}
					_N_finally_needed_40055 = false;
					((IDisposable)_N_enumerator_40015).Dispose();
					goto case 1;
				case 2:
					if (_N_enumerator_40031.MoveNext())
					{
						PExpr pExpr = (_N_x_40041 = _N_enumerator_40031.Current);
						_N_current = _N_x_40041;
						_N_state = 2;
						return true;
					}
					_N_finally_needed_40053 = false;
					((IDisposable)_N_enumerator_40031).Dispose();
					n__N_wildcard_4026_3 = _N_xs_40035;
					goto IL_026a;
				case 1:
				case 3:
				case 6:
				case 7:
					{
						n__N_wildcard_4026_2 = _N_xs_40025;
						goto IL_0068;
					}
					IL_0068:
					_N__N_wildcard_4026_40029 = n__N_wildcard_4026_2;
					if (_N__N_wildcard_4026_40029 is list<ClassMember>.Cons)
					{
						_N_x_40027 = ((list<ClassMember>.Cons)_N__N_wildcard_4026_40029).hd;
						_N_xs_40025 = ((list<ClassMember>.Cons)_N__N_wildcard_4026_40029).tl;
						_N_member_40023 = _N_x_40027;
						if (!(_N_member_40023 is ClassMember.TypeDeclaration))
						{
							if (_N_member_40023 is ClassMember.Field)
							{
								_N_ty_40021 = ((ClassMember.Field)_N_member_40023).ty;
								_N_current = _N_ty_40021;
								_N_state = 1;
								return true;
							}
							if (_N_member_40023 is ClassMember.Function)
							{
								_N_fn_40017 = (ClassMember.Function)_N_member_40023;
								n__N_wildcard_4026_ = _N_fn_40017.implemented;
								goto IL_0143;
							}
							if (_N_member_40023 is ClassMember.Property)
							{
								_N_prop_40019 = (ClassMember.Property)_N_member_40023;
								n__N_wildcard_4026_3 = _N_prop_40019.parameters;
								goto IL_026a;
							}
							if (_N_member_40023 is ClassMember.Event)
							{
								_N_e_40013 = (ClassMember.Event)_N_member_40023;
								_N_current = _N_e_40013.ty;
								_N_state = 6;
								return true;
							}
							if (!(_N_member_40023 is ClassMember.EnumOption))
							{
								throw new MatchFailureException();
							}
							_N_value_40011 = ((ClassMember.EnumOption)_N_member_40023).value;
							if (_N_value_40011 is option<PExpr>.Some)
							{
								_N_x_40009 = ((option<PExpr>.Some)_N_value_40011).val;
								_N_current = _N_x_40009;
								_N_state = 7;
								return true;
							}
						}
						goto case 1;
					}
					return false;
					IL_026a:
					_N__N_wildcard_4026_40039 = n__N_wildcard_4026_3;
					if (_N__N_wildcard_4026_40039 is list<PParameter>.Cons)
					{
						_N_x_40037 = ((list<PParameter>.Cons)_N__N_wildcard_4026_40039).hd;
						_N_xs_40035 = ((list<PParameter>.Cons)_N__N_wildcard_4026_40039).tl;
						_N_parameter_40033 = _N_x_40037;
						_N_enumerator_40031 = _N_parameter_40033.GetTypeReferences().GetEnumerator();
						_N_finally_needed_40053 = true;
						goto case 2;
					}
					_N_current = _N_prop_40019.returnType;
					_N_state = 3;
					return true;
					IL_0143:
					_N__N_wildcard_4026_40049 = n__N_wildcard_4026_;
					if (_N__N_wildcard_4026_40049 is list<PExpr>.Cons)
					{
						_N_x_40047 = ((list<PExpr>.Cons)_N__N_wildcard_4026_40049).hd;
						_N_xs_40045 = ((list<PExpr>.Cons)_N__N_wildcard_4026_40049).tl;
						_N_x_40043 = _N_x_40047;
						_N_current = _N_x_40043;
						_N_state = 4;
						return true;
					}
					_N_enumerator_40015 = _N_fn_40017.header.GetTypeReferences().GetEnumerator();
					_N_finally_needed_40055 = true;
					goto case 5;
				}
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<PExpr> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_39980 n_Enumerable_ = new _N_Enumerable_39980();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<PExpr>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<PExpr>)this;
			}
			return (IEnumerator<PExpr>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_39980 n_Enumerable_ = new _N_Enumerable_39980();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator)this;
			}
			return (IEnumerator)result;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in NonGenericGetEnum
			return this.NonGenericGetEnum();
		}

		private void CopyFrom(_N_Enumerable_39980 other)
		{
			_N_this_used = 1;
			_N__N_wildcard_4026_40049 = other._N__N_wildcard_4026_40049;
			_N__N_wildcard_4026_40039 = other._N__N_wildcard_4026_40039;
			_N__N_wildcard_4026_40029 = other._N__N_wildcard_4026_40029;
			_N__N_closurised_this_ptr_40003 = other._N__N_closurised_this_ptr_40003;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private sealed class _N_closureOf_get_FullQualifiedName_40168
	{
		internal _N_closureOf_get_FullQualifiedName_40168()
		{
		}
	}

	private sealed class _N_closureOf_get_FullName_40201
	{
		internal _N_closureOf_get_FullName_40201()
		{
		}
	}

	private sealed class _N_closureOf_GetAllInnerTypes_40253
	{
		internal list<TopDeclaration> _N_res_40258;

		internal _N_closureOf_GetAllInnerTypes_40253()
		{
		}
	}

	[IgnoreField]
	public readonly Typarms DeclaredTypeParameters;

	public Typarms typarms;

	[IgnoreField]
	internal TopDeclaration _definedIn;

	[IgnoreField]
	internal TypeBuilder _typeBuilder;

	[IgnoreField]
	internal Location _headerLocation;

	public int DeclaredTypeParametersCount => (DeclaredTypeParameters != null) ? DeclaredTypeParameters.tyvars.Length : 0;

	public Typarms TypeParameters
	{
		get
		{
			return typarms;
		}
		set
		{
			typarms = value;
		}
	}

	public int TypeParametersCount => (typarms != null) ? typarms.tyvars.Length : 0;

	public string FullQualifiedName
	{
		get
		{
			_N_closureOf_get_FullQualifiedName_40168 n_get_FullQualifiedName_cp_ = new _N_closureOf_get_FullQualifiedName_40168();
			option<GlobalEnv> option = TryGetEnv();
			object result;
			if (option is option<GlobalEnv>.Some)
			{
				GlobalEnv val = ((option<GlobalEnv>.Some)option).val;
				if (val != null)
				{
					string displayName = val.CurrentNamespace.GetDisplayName();
					result = ((!string.IsNullOrEmpty(displayName)) ? string.Concat(displayName + ".", _N_makeName_40174(n_get_FullQualifiedName_cp_, this)) : _N_makeName_40174(n_get_FullQualifiedName_cp_, this));
					goto IL_0078;
				}
			}
			result = _N_makeName_40174(n_get_FullQualifiedName_cp_, this);
			goto IL_0078;
			IL_0078:
			return (string)result;
		}
	}

	public string FullName
	{
		get
		{
			_N_closureOf_get_FullName_40201 n_get_FullName_cp_ = new _N_closureOf_get_FullName_40201();
			option<GlobalEnv> option = TryGetEnv();
			object result;
			if (option is option<GlobalEnv>.Some)
			{
				GlobalEnv val = ((option<GlobalEnv>.Some)option).val;
				if (val != null)
				{
					string displayName = val.CurrentNamespace.GetDisplayName();
					result = ((!string.IsNullOrEmpty(displayName)) ? string.Concat(displayName + ".", _N_makeName_40207(n_get_FullName_cp_, this)) : _N_makeName_40207(n_get_FullName_cp_, this));
					goto IL_0078;
				}
			}
			result = _N_makeName_40207(n_get_FullName_cp_, this);
			goto IL_0078;
			IL_0078:
			return (string)result;
		}
	}

	public TopDeclaration DefinedIn
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _definedIn;
		}
	}

	public TypeBuilder TypeBuilder
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _typeBuilder;
		}
	}

	public Location HeaderLocation
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _headerLocation;
		}
	}

	public IEnumerable<PExpr> GetTypeReferences()
	{
		_N_Enumerable_39829 n_Enumerable_ = new _N_Enumerable_39829();
		n_Enumerable_._N__N_closurised_this_ptr_39852 = this;
		return n_Enumerable_;
	}

	public IEnumerable<PExpr> GetSubtypesReferences()
	{
		list<PExpr> list;
		object result;
		if (this is Class)
		{
			list = ((Class)this).t_extends;
		}
		else
		{
			if (this is Alias)
			{
				PExpr ty = ((Alias)this).ty;
				result = (IEnumerable<PExpr>)new list<PExpr>.Cons(ty, list<PExpr>.Nil._N_constant_object);
				goto IL_010a;
			}
			if (this is Interface)
			{
				list = ((Interface)this).t_extends;
			}
			else
			{
				if (!(this is Variant))
				{
					if (this is VariantOption)
					{
						result = (IEnumerable<PExpr>)list<PExpr>.Nil._N_constant_object;
					}
					else if (this is Macro)
					{
						result = (IEnumerable<PExpr>)list<PExpr>.Nil._N_constant_object;
					}
					else
					{
						if (!(this is Delegate))
						{
							if (this is Enum)
							{
								list = ((Enum)this).t_extends;
								goto IL_00f9;
							}
							throw new MatchFailureException();
						}
						result = (IEnumerable<PExpr>)list<PExpr>.Nil._N_constant_object;
					}
					goto IL_010a;
				}
				list = ((Variant)this).t_extends;
			}
		}
		goto IL_00f9;
		IL_010a:
		return (IEnumerable<PExpr>)result;
		IL_00f9:
		result = (IEnumerable<PExpr>)list;
		goto IL_010a;
	}

	public IEnumerable<PExpr> GetMembersTypeReferences()
	{
		_N_Enumerable_39980 n_Enumerable_ = new _N_Enumerable_39980();
		n_Enumerable_._N__N_closurised_this_ptr_40003 = this;
		return n_Enumerable_;
	}

	public TopDeclaration(Location loc, Splicable name, AttributesAndModifiers modifiers, Typarms typarms)
		: base(loc, name, modifiers)
	{
		this.typarms = typarms;
		DeclaredTypeParameters = typarms;
	}

	public TopDeclaration(Splicable name, AttributesAndModifiers modifiers, Typarms typarms)
		: base(name, modifiers)
	{
		this.typarms = typarms;
		DeclaredTypeParameters = typarms;
	}

	public TopDeclaration(Name name, AttributesAndModifiers modifiers, Typarms typarms)
		: base(new Splicable.Name(name), modifiers)
	{
		this.typarms = typarms;
		DeclaredTypeParameters = typarms;
	}

	public TopDeclaration(Typarms tp)
		: this()
	{
		typarms = tp;
	}

	public TopDeclaration()
		: base(new Splicable.Name(new Name("")), new AttributesAndModifiers())
	{
	}

	public list<ClassMember> GetMembers()
	{
		list<ClassMember> list;
		if (this is Class)
		{
			list = ((Class)this).decls;
		}
		else
		{
			if (this is Alias)
			{
				goto IL_00af;
			}
			if (this is Interface)
			{
				list = ((Interface)this).methods;
			}
			else if (this is Variant)
			{
				list = ((Variant)this).decls;
			}
			else if (this is VariantOption)
			{
				list = ((VariantOption)this).decls;
			}
			else
			{
				if (this is Macro || this is Delegate)
				{
					goto IL_00af;
				}
				if (!(this is Enum))
				{
					throw new MatchFailureException();
				}
				list = ((Enum)this).decls;
			}
		}
		object result = list;
		goto IL_00e1;
		IL_00e1:
		return (list<ClassMember>)result;
		IL_00af:
		result = list<ClassMember>.Nil._N_constant_object;
		goto IL_00e1;
	}

	public list<TopDeclaration> GetAllInnerTypes()
	{
		_N_closureOf_GetAllInnerTypes_40253 n_closureOf_GetAllInnerTypes_ = new _N_closureOf_GetAllInnerTypes_40253();
		n_closureOf_GetAllInnerTypes_._N_res_40258 = list<TopDeclaration>.Nil._N_constant_object;
		_N_getInner_40261(n_closureOf_GetAllInnerTypes_, this);
		return n_closureOf_GetAllInnerTypes_._N_res_40258;
	}

	public override string ToString()
	{
		string text = Name;
		string result;
		if (this is Class)
		{
			result = "class " + Convert.ToString(text);
		}
		else if (this is Alias)
		{
			PExpr ty = ((Alias)this).ty;
			result = "type " + Convert.ToString(text) + " = " + Convert.ToString(ty);
		}
		else if (this is Interface)
		{
			result = "interface " + Convert.ToString(text);
		}
		else if (this is Variant)
		{
			result = "variant " + Convert.ToString(text);
		}
		else if (this is VariantOption)
		{
			result = "| " + Convert.ToString(text);
		}
		else if (this is Macro)
		{
			PFunHeader header = ((Macro)this).header;
			result = "macro " + Convert.ToString(text) + "(" + Convert.ToString(header) + ")";
		}
		else if (this is Delegate)
		{
			PFunHeader header = ((Delegate)this).header;
			result = "delegate " + Convert.ToString(text) + ": " + Convert.ToString(header);
		}
		else
		{
			if (!(this is Enum))
			{
				throw new MatchFailureException();
			}
			result = "enum " + Convert.ToString(text);
		}
		return result;
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(TopDeclaration x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is TopDeclaration)) ? (-1) : ((TopDeclaration)x)._N_GetVariantCode();
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			_headerLocation = Completion.Relocate(_headerLocation, _info);
			_typeBuilder?.RelocateImplInternal(_info);
			typarms?.RelocateImplInternal(_info);
			DeclaredTypeParameters?.RelocateImplInternal(_info);
		}
	}

	private static string _N_makeName_40174(_N_closureOf_get_FullQualifiedName_40168 _N_get_FullQualifiedName_cp_40173, TopDeclaration td)
	{
		return (td.DefinedIn == null) ? td.Name : string.Concat(_N_makeName_40174(_N_get_FullQualifiedName_cp_40173, td.DefinedIn) + ".", td.Name);
	}

	private static string _N_makeName_40207(_N_closureOf_get_FullName_40201 _N_get_FullName_cp_40206, TopDeclaration td)
	{
		string text = ((td.typarms != null) ? td.typarms.ToString() : "");
		return (td.DefinedIn == null) ? (td.Name + text) : (Convert.ToString(_N_makeName_40207(_N_get_FullName_cp_40206, td.DefinedIn)) + "." + Convert.ToString(td.Name) + Convert.ToString(text));
	}

	private static void _N_getInner_40261(_N_closureOf_GetAllInnerTypes_40253 _N_GetAllInnerTypes_cp_40260, TopDeclaration x)
	{
		list<ClassMember> list;
		if (x is Class)
		{
			list = ((Class)x).decls;
		}
		else
		{
			if (x is Alias)
			{
				return;
			}
			if (x is Interface)
			{
				list = ((Interface)x).methods;
			}
			else if (x is Variant)
			{
				list = ((Variant)x).decls;
			}
			else
			{
				if (!(x is VariantOption))
				{
					if (x is Macro || x is Delegate || x is Enum)
					{
						return;
					}
					throw new MatchFailureException();
				}
				list = ((VariantOption)x).decls;
			}
		}
		list = list;
		while (list is list<ClassMember>.Cons)
		{
			ClassMember hd = ((list<ClassMember>.Cons)list).hd;
			list = ((list<ClassMember>.Cons)list).tl;
			if (hd is ClassMember.TypeDeclaration)
			{
				TopDeclaration td = ((ClassMember.TypeDeclaration)hd).td;
				_N_GetAllInnerTypes_cp_40260._N_res_40258 = new list<TopDeclaration>.Cons(td, _N_GetAllInnerTypes_cp_40260._N_res_40258);
				_N_getInner_40261(_N_GetAllInnerTypes_cp_40260, td);
			}
			list = list;
		}
	}
}
