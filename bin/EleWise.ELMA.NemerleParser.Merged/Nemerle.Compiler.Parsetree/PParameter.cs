using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Nemerle.Builtins;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;

namespace Nemerle.Compiler.Parsetree;

public class PParameter : DeclarationBase
{
	private sealed class _N_closureOf__ctor_43584
	{
		internal PExpr _N_from_43589;

		internal _N_closureOf__ctor_43584()
		{
		}
	}

	private class _N_Enumerable_43647 : IEnumerator, IDisposable, IEnumerator<PExpr>, IEnumerable, IEnumerable<PExpr>
	{
		internal PExpr _N_x_43676;

		internal PExpr _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_43672;

		internal PParameter _N__N_closurised_this_ptr_43670;

		internal Function<bool> _N__N_wildcard_3438_43668;

		private int _N_this_used;

		public PExpr Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
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
						if (_N_state != 2)
						{
							return false;
						}
					}
					else
					{
						option<PExpr> defaultValue = _N__N_closurised_this_ptr_43670.DefaultValue;
						if (defaultValue is option<PExpr>.Some)
						{
							_N_x_43676 = ((option<PExpr>.Some)defaultValue).val;
							_N_current = _N_x_43676;
							_N_state = 2;
							return true;
						}
					}
					return false;
				}
				_N_current = _N__N_closurised_this_ptr_43670.Type;
				_N_state = 1;
				return true;
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
				_N_Enumerable_43647 n_Enumerable_ = new _N_Enumerable_43647();
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
				_N_Enumerable_43647 n_Enumerable_ = new _N_Enumerable_43647();
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

		private void CopyFrom(_N_Enumerable_43647 other)
		{
			_N_this_used = 1;
			_N__N_closurised_this_ptr_43670 = other._N__N_closurised_this_ptr_43670;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	public PExpr Type;

	public readonly PExpr ParsedType;

	public readonly PExpr ParsedPatternHack;

	public readonly option<PExpr> ParsedDefaultValue;

	public PExpr PatternHack { get; private set; }

	public option<PExpr> DefaultValue { get; set; }

	public new TParameter TypedObject => (TParameter)base.TypedObject;

	public PExpr ReferencingExpr
	{
		get
		{
			Splicable splicable = base.name;
			Name name;
			if (splicable is Splicable.Name)
			{
				name = ((Splicable.Name)splicable).body;
				goto IL_0057;
			}
			object result;
			if (splicable is Splicable.Expression)
			{
				PExpr expr = ((Splicable.Expression)splicable).expr;
				result = expr;
			}
			else
			{
				if (splicable is Splicable.HalfId)
				{
					name = ((Splicable.HalfId)splicable).prefix;
					goto IL_0057;
				}
				result = new PExpr.Error();
			}
			goto IL_007a;
			IL_007a:
			return (PExpr)result;
			IL_0057:
			result = new PExpr.Ref(base.name.Location.AsGenerated(), name);
			goto IL_007a;
		}
	}

	public void ResetPatternHack()
	{
		PatternHack = null;
	}

	public PParameter(Name name, AttributesAndModifiers modifiers, PExpr Type, option<PExpr> DefaultValue)
		: this(new Splicable.Name(name), modifiers, Type, DefaultValue)
	{
	}

	public PParameter(Splicable name, AttributesAndModifiers modifiers, PExpr Type, option<PExpr> DefaultValue)
		: base(LocationStack.Top(), name, modifiers)
	{
		this.Type = Type;
		ParsedType = Type;
		this.DefaultValue = DefaultValue;
		ParsedDefaultValue = DefaultValue;
	}

	public PParameter(Splicable name, AttributesAndModifiers modifiers, PExpr Type)
		: base(LocationStack.Top(), name, modifiers)
	{
		this.Type = Type;
		ParsedType = Type;
		DefaultValue = option<PExpr>.None._N_constant_object;
		ParsedDefaultValue = option<PExpr>.None._N_constant_object;
	}

	public PParameter(Name name, AttributesAndModifiers modifiers, PExpr Type)
		: this(new Splicable.Name(name), modifiers, Type)
	{
	}

	public PParameter(Splicable name, PExpr ty, AttributesAndModifiers modifiers, option<PExpr> defval)
		: base(LocationStack.Top(), name, modifiers)
	{
		Type = ty;
		ParsedType = ty;
		DefaultValue = defval;
		ParsedDefaultValue = defval;
	}

	public PParameter(Name name, PExpr ty, AttributesAndModifiers modifiers, option<PExpr> defval)
		: this(new Splicable.Name(name), ty, modifiers, defval)
	{
	}

	public PParameter(Splicable name, PExpr ty, AttributesAndModifiers modifiers)
		: base(LocationStack.Top(), name, modifiers)
	{
		Type = ty;
		ParsedType = ty;
		DefaultValue = option<PExpr>.None._N_constant_object;
		ParsedDefaultValue = option<PExpr>.None._N_constant_object;
	}

	public PParameter(Name name, PExpr ty, AttributesAndModifiers modifiers)
		: this(new Splicable.Name(name), ty, modifiers)
	{
	}

	public PParameter(Location loc, Splicable name, PExpr ty, AttributesAndModifiers modifiers, PExpr patternHack = null)
		: base(loc, name, modifiers)
	{
		Type = ty;
		ParsedType = ty;
		PatternHack = patternHack;
		ParsedPatternHack = patternHack;
		DefaultValue = option<PExpr>.None._N_constant_object;
		ParsedDefaultValue = option<PExpr>.None._N_constant_object;
	}

	public PParameter(Location loc, Name name, PExpr ty, AttributesAndModifiers modifiers, PExpr patternHack = null)
		: this(loc, new Splicable.Name(name), ty, modifiers, patternHack)
	{
	}

	public PParameter(Location loc, Name name, PExpr ty, AttributesAndModifiers modifiers, option<PExpr> defval, PExpr patternHack = null)
		: this(loc, new Splicable.Name(name), ty, modifiers, defval, patternHack)
	{
	}

	public PParameter(Location loc, Splicable name, PExpr ty, AttributesAndModifiers modifiers, option<PExpr> defval, PExpr patternHack = null)
		: base(loc, name, modifiers)
	{
		Type = ty;
		ParsedType = ty;
		PatternHack = patternHack;
		ParsedPatternHack = patternHack;
		DefaultValue = defval;
		ParsedDefaultValue = defval;
	}

	public PParameter(PExpr from)
	{
		_N_closureOf__ctor_43584 n_closureOf__ctor_ = new _N_closureOf__ctor_43584
		{
			_N_from_43589 = from
		};
		base._002Ector(n_closureOf__ctor_._N_from_43589.Location, null, new AttributesAndModifiers(NemerleModifiers.None, list<PExpr>.Nil._N_constant_object));
		if (n_closureOf__ctor_._N_from_43589 is PExpr.Assign)
		{
			PExpr target = ((PExpr.Assign)n_closureOf__ctor_._N_from_43589).target;
			PExpr source = ((PExpr.Assign)n_closureOf__ctor_._N_from_43589).source;
			option<PExpr>.Some some = new option<PExpr>.Some(source);
			Nemerle.Builtins.Tuple<Splicable, PExpr> tuple = _N_from_expr_43592(n_closureOf__ctor_, target);
			Splicable field = tuple.Field0;
			source = tuple.Field1;
			name = field;
			Type = source;
			ParsedType = source;
			DefaultValue = some;
			ParsedDefaultValue = some;
		}
		else
		{
			PExpr source = n_closureOf__ctor_._N_from_43589;
			Nemerle.Builtins.Tuple<Splicable, PExpr> tuple = _N_from_expr_43592(n_closureOf__ctor_, source);
			Splicable field = tuple.Field0;
			source = tuple.Field1;
			name = field;
			Type = source;
			ParsedType = source;
			DefaultValue = option<PExpr>.None._N_constant_object;
			ParsedDefaultValue = option<PExpr>.None._N_constant_object;
		}
	}

	public IEnumerable<PExpr> GetTypeReferences()
	{
		_N_Enumerable_43647 n_Enumerable_ = new _N_Enumerable_43647();
		n_Enumerable_._N__N_closurised_this_ptr_43670 = this;
		return n_Enumerable_;
	}

	public override string ToString()
	{
		string text = Convert.ToString(Name) + " : " + Convert.ToString(Type);
		option<PExpr> defaultValue = DefaultValue;
		string result;
		if (defaultValue is option<PExpr>.Some)
		{
			PExpr val = ((option<PExpr>.Some)defaultValue).val;
			result = Convert.ToString(text) + " = " + Convert.ToString(val);
		}
		else
		{
			result = text;
		}
		return result;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			option<PExpr> parsedDefaultValue = ParsedDefaultValue;
			if (parsedDefaultValue is option<PExpr>.Some)
			{
				PExpr val = ((option<PExpr>.Some)parsedDefaultValue).val;
				((ISupportRelocation)val).RelocateImpl(_info);
			}
			ParsedPatternHack?.RelocateImplInternal(_info);
			ParsedType?.RelocateImplInternal(_info);
			Type?.RelocateImplInternal(_info);
		}
	}

	private static Nemerle.Builtins.Tuple<Splicable, PExpr> _N_from_expr_43592(_N_closureOf__ctor_43584 _N__ctor_cp_43591, PExpr e)
	{
		Nemerle.Builtins.Tuple<Splicable, PExpr> result;
		if (e is PExpr.Ref)
		{
			Name body = ((PExpr.Ref)e).name;
			Splicable.Name name = new Splicable.Name(body);
			PExpr.Wildcard wildcard = new PExpr.Wildcard(_N__ctor_cp_43591._N_from_43589.Location);
			result = new Nemerle.Builtins.Tuple<Splicable, PExpr>(name, wildcard);
		}
		else if (e is PExpr.TypeEnforcement)
		{
			if (((PExpr.TypeEnforcement)e).expr is PExpr.Ref)
			{
				Name body = ((PExpr.Ref)((PExpr.TypeEnforcement)e).expr).name;
				PExpr ty = ((PExpr.TypeEnforcement)e).ty;
				Splicable.Name name = new Splicable.Name(body);
				result = new Nemerle.Builtins.Tuple<Splicable, PExpr>(name, ty);
			}
			else
			{
				if (!(((PExpr.TypeEnforcement)e).expr is PExpr.Spliced))
				{
					goto IL_0143;
				}
				PExpr ty = ((PExpr.Spliced)((PExpr.TypeEnforcement)e).expr).body;
				PExpr ty2 = ((PExpr.TypeEnforcement)e).ty;
				Splicable.Expression expression = new Splicable.Expression(ty);
				result = new Nemerle.Builtins.Tuple<Splicable, PExpr>(expression, ty2);
			}
		}
		else
		{
			if (!(e is PExpr.Spliced))
			{
				goto IL_0143;
			}
			PExpr ty = ((PExpr.Spliced)e).body;
			Splicable.Expression expression = new Splicable.Expression(ty);
			PExpr.Wildcard wildcard = new PExpr.Wildcard(_N__ctor_cp_43591._N_from_43589.Location);
			result = new Nemerle.Builtins.Tuple<Splicable, PExpr>(expression, wildcard);
		}
		return result;
		IL_0143:
		throw new ArgumentException("incorrect expression supplied for parameter creation: " + Convert.ToString(_N__ctor_cp_43591._N_from_43589));
	}
}
