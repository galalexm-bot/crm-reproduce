using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Collections;

[Variant("Nemerle.Collections.RList.Nil,Nemerle.Collections.RList.Zero,Nemerle.Collections.RList.One")]
public abstract class RList<_0027a> : IEnumerable, IEnumerable<_0027a>, IEquatable<RList<_0027a>>
{
	[ConstantVariantOption]
	public class Nil : RList<_0027a>
	{
		public static readonly Nil _N_constant_object;

		[SpecialName]
		public static Nil _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static Nil()
		{
			_N_constant_object = new Nil();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		private Nil()
		{
		}
	}

	[VariantOption]
	public class Zero : RList<_0027a>
	{
		public readonly RList<Pair<_0027a>> arg;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Zero([MappedMember("arg")] RList<Pair<_0027a>> arg)
		{
			this.arg = arg;
		}
	}

	[VariantOption]
	public class One : RList<_0027a>
	{
		public readonly _0027a arg1;

		public readonly RList<Pair<_0027a>> arg2;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public One([MappedMember("arg1")] _0027a arg1, [MappedMember("arg2")] RList<Pair<_0027a>> arg2)
		{
			this.arg1 = arg1;
			this.arg2 = arg2;
		}
	}

	private sealed class _N_closureOf_Exists_26385
	{
		internal Function<_0027a, bool> _N_f_26390;

		internal _N_closureOf_Exists_26385()
		{
		}
	}

	private sealed class _N_f___26392 : Function<Pair<_0027a>, bool>
	{
		[SpecialName]
		private _N_closureOf_Exists_26385 _N_Exists_closure_26396;

		public _N_f___26392(_N_closureOf_Exists_26385 _N_Exists_closure_26396)
		{
			this._N_Exists_closure_26396 = _N_Exists_closure_26396;
		}

		[SpecialName]
		public sealed override bool apply(Pair<_0027a> x)
		{
			return _N_Exists_closure_26396._N_f_26390.apply(x.fst) || _N_Exists_closure_26396._N_f_26390.apply(x.snd);
		}
	}

	private sealed class _N_closureOf_Member_26426
	{
		internal _0027a _N_elem_26431;

		internal _N_closureOf_Member_26426()
		{
		}
	}

	private sealed class _N__N_lambda__26420__26433 : Function<_0027a, bool>
	{
		[SpecialName]
		private _N_closureOf_Member_26426 _N_Member_closure_26437;

		public _N__N_lambda__26420__26433(_N_closureOf_Member_26426 _N_Member_closure_26437)
		{
			this._N_Member_closure_26437 = _N_Member_closure_26437;
		}

		[SpecialName]
		public sealed override bool apply(_0027a x)
		{
			return x.Equals(_N_Member_closure_26437._N_elem_26431);
		}
	}

	private sealed class _N_closureOf__Update_26504
	{
		internal Function<_0027a, _0027a> _N_f_26511;

		internal int _N_i_26509;

		internal _N_closureOf__Update_26504()
		{
		}
	}

	private sealed class _N_f___26519 : Function<Pair<_0027a>, Pair<_0027a>>
	{
		[SpecialName]
		private _N_closureOf__Update_26504 _N__Update_closure_26523;

		public _N_f___26519(_N_closureOf__Update_26504 _N__Update_closure_26523)
		{
			this._N__Update_closure_26523 = _N__Update_closure_26523;
		}

		[SpecialName]
		public sealed override Pair<_0027a> apply(Pair<_0027a> p)
		{
			return (_N__Update_closure_26523._N_i_26509 % 2 != 0) ? new Pair<_0027a>(p.fst, _N__Update_closure_26523._N_f_26511.apply(p.snd)) : new Pair<_0027a>(_N__Update_closure_26523._N_f_26511.apply(p.fst), p.snd);
		}
	}

	private sealed class _N_closureOf_Update_26545
	{
		internal _0027a _N_y_26550;

		internal _N_closureOf_Update_26545()
		{
		}
	}

	private sealed class _N__N_lambda__26539__26552 : Function<_0027a, _0027a>
	{
		[SpecialName]
		private _N_closureOf_Update_26545 _N_Update_closure_26556;

		public _N__N_lambda__26539__26552(_N_closureOf_Update_26545 _N_Update_closure_26556)
		{
			this._N_Update_closure_26556 = _N_Update_closure_26556;
		}

		[SpecialName]
		public sealed override _0027a apply(_0027a _N_wildcard_26538)
		{
			return _N_Update_closure_26556._N_y_26550;
		}
	}

	private sealed class _N_closureOf_FoldLeft_26586<_0027b>
	{
		internal Function<_0027a, _0027b, _0027b> _N_f_26591;

		internal _N_closureOf_FoldLeft_26586()
		{
		}
	}

	private sealed class _N__N_lambda__26571__26599<_0027b> : Function<Pair<_0027a>, _0027b, _0027b>
	{
		[SpecialName]
		private _N_closureOf_FoldLeft_26586<_0027b> _N_FoldLeft_closure_26603;

		public _N__N_lambda__26571__26599(_N_closureOf_FoldLeft_26586<_0027b> _N_FoldLeft_closure_26603)
		{
			this._N_FoldLeft_closure_26603 = _N_FoldLeft_closure_26603;
		}

		[SpecialName]
		public sealed override _0027b apply(Pair<_0027a> a, _0027b b)
		{
			return _N_FoldLeft_closure_26603._N_f_26591.apply(a.snd, _N_FoldLeft_closure_26603._N_f_26591.apply(a.fst, b));
		}
	}

	private sealed class _N__N_lambda__26579__26608<_0027b> : Function<Pair<_0027a>, _0027b, _0027b>
	{
		[SpecialName]
		private _N_closureOf_FoldLeft_26586<_0027b> _N_FoldLeft_closure_26612;

		public _N__N_lambda__26579__26608(_N_closureOf_FoldLeft_26586<_0027b> _N_FoldLeft_closure_26612)
		{
			this._N_FoldLeft_closure_26612 = _N_FoldLeft_closure_26612;
		}

		[SpecialName]
		public sealed override _0027b apply(Pair<_0027a> a, _0027b b)
		{
			return _N_FoldLeft_closure_26612._N_f_26591.apply(a.snd, _N_FoldLeft_closure_26612._N_f_26591.apply(a.fst, b));
		}
	}

	private sealed class _N_closureOf_FoldRight_26642<_0027b>
	{
		internal Function<_0027a, _0027b, _0027b> _N_f_26647;

		internal _N_closureOf_FoldRight_26642()
		{
		}
	}

	private sealed class _N__N_lambda__26627__26655<_0027b> : Function<Pair<_0027a>, _0027b, _0027b>
	{
		[SpecialName]
		private _N_closureOf_FoldRight_26642<_0027b> _N_FoldRight_closure_26659;

		public _N__N_lambda__26627__26655(_N_closureOf_FoldRight_26642<_0027b> _N_FoldRight_closure_26659)
		{
			this._N_FoldRight_closure_26659 = _N_FoldRight_closure_26659;
		}

		[SpecialName]
		public sealed override _0027b apply(Pair<_0027a> a, _0027b b)
		{
			return _N_FoldRight_closure_26659._N_f_26647.apply(a.fst, _N_FoldRight_closure_26659._N_f_26647.apply(a.snd, b));
		}
	}

	private sealed class _N__N_lambda__26635__26664<_0027b> : Function<Pair<_0027a>, _0027b, _0027b>
	{
		[SpecialName]
		private _N_closureOf_FoldRight_26642<_0027b> _N_FoldRight_closure_26668;

		public _N__N_lambda__26635__26664(_N_closureOf_FoldRight_26642<_0027b> _N_FoldRight_closure_26668)
		{
			this._N_FoldRight_closure_26668 = _N_FoldRight_closure_26668;
		}

		[SpecialName]
		public sealed override _0027b apply(Pair<_0027a> a, _0027b b)
		{
			return _N_FoldRight_closure_26668._N_f_26647.apply(a.fst, _N_FoldRight_closure_26668._N_f_26647.apply(a.snd, b));
		}
	}

	private sealed class _N_closureOf_Map_26689<_0027b>
	{
		internal Function<_0027a, _0027b> _N_f_26694;

		internal _N_closureOf_Map_26689()
		{
		}
	}

	private sealed class _N_f___26696<_0027b> : Function<Pair<_0027a>, Pair<_0027b>>
	{
		[SpecialName]
		private _N_closureOf_Map_26689<_0027b> _N_Map_closure_26700;

		public _N_f___26696(_N_closureOf_Map_26689<_0027b> _N_Map_closure_26700)
		{
			this._N_Map_closure_26700 = _N_Map_closure_26700;
		}

		[SpecialName]
		public sealed override Pair<_0027b> apply(Pair<_0027a> x)
		{
			return new Pair<_0027b>(_N_Map_closure_26700._N_f_26694.apply(x.fst), _N_Map_closure_26700._N_f_26694.apply(x.snd));
		}
	}

	private sealed class _N_closureOf_Iter_26726
	{
		internal FunctionVoid<_0027a> _N_f_26731;

		internal _N_closureOf_Iter_26726()
		{
		}
	}

	private sealed class _N_f___26733 : FunctionVoid<Pair<_0027a>>
	{
		[SpecialName]
		private _N_closureOf_Iter_26726 _N_Iter_closure_26737;

		public _N_f___26733(_N_closureOf_Iter_26726 _N_Iter_closure_26737)
		{
			this._N_Iter_closure_26737 = _N_Iter_closure_26737;
		}

		[SpecialName]
		public sealed override void apply_void(Pair<_0027a> x)
		{
			_N_Iter_closure_26737._N_f_26731.apply_void(x.fst);
			_N_Iter_closure_26737._N_f_26731.apply_void(x.snd);
		}
	}

	private sealed class _N_static_proxy_26755 : Function<_0027a, RList<_0027a>, RList<_0027a>>
	{
		[SpecialName]
		public static readonly _N_static_proxy_26755 single_instance = new _N_static_proxy_26755();

		[SpecialName]
		public sealed override RList<_0027a> apply(_0027a _N_sp_parm_26762, RList<_0027a> _N_sp_parm_26763)
		{
			return RList<_0027a>.Cons(_N_sp_parm_26762, _N_sp_parm_26763);
		}

		private _N_static_proxy_26755()
		{
		}
	}

	private sealed class _N_static_proxy_26773 : Function<_0027a, RList<_0027a>, RList<_0027a>>
	{
		[SpecialName]
		public static readonly _N_static_proxy_26773 single_instance = new _N_static_proxy_26773();

		[SpecialName]
		public sealed override RList<_0027a> apply(_0027a _N_sp_parm_26780, RList<_0027a> _N_sp_parm_26781)
		{
			return RList<_0027a>.Cons(_N_sp_parm_26780, _N_sp_parm_26781);
		}

		private _N_static_proxy_26773()
		{
		}
	}

	private sealed class _N__N_lambda__26798__26806 : Function<list<_0027a>, Nemerle.Builtins.Tuple<_0027a, list<_0027a>>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__26798__26806 Instance = new _N__N_lambda__26798__26806();

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<_0027a, list<_0027a>> apply(list<_0027a> l)
		{
			_0027a val = default(_0027a);
			if (l is list<_0027a>.Cons)
			{
				val = ((list<_0027a>.Cons)l).hd;
				list<_0027a> field = ((list<_0027a>.Cons)l).tl;
				return new Nemerle.Builtins.Tuple<_0027a, list<_0027a>>(val, field);
			}
			if ((object)l == list<_0027a>.Nil._N_constant_object)
			{
				throw new Exception("Empty");
			}
			throw new MatchFailureException();
		}
	}

	private sealed class _N_closureOf__FromList_26834<_0027b>
	{
		internal Function<list<_0027b>, Nemerle.Builtins.Tuple<_0027a, list<_0027b>>> _N_f_26839;

		internal _N_closureOf__FromList_26834()
		{
		}
	}

	private sealed class _N_f___26841<_0027b> : Function<list<_0027b>, Nemerle.Builtins.Tuple<Pair<_0027a>, list<_0027b>>>
	{
		[SpecialName]
		private _N_closureOf__FromList_26834<_0027b> _N__FromList_closure_26845;

		public _N_f___26841(_N_closureOf__FromList_26834<_0027b> _N__FromList_closure_26845)
		{
			this._N__FromList_closure_26845 = _N__FromList_closure_26845;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<Pair<_0027a>, list<_0027b>> apply(list<_0027b> l)
		{
			_0027a val = default(_0027a);
			_0027a val2 = default(_0027a);
			Nemerle.Builtins.Tuple<_0027a, list<_0027b>> tuple = _N__FromList_closure_26845._N_f_26839.apply(l);
			val = tuple.Field0;
			list<_0027b> n_wildcard_ = tuple.Field1;
			tuple = _N__FromList_closure_26845._N_f_26839.apply(n_wildcard_);
			val2 = tuple.Field0;
			n_wildcard_ = tuple.Field1;
			return new Nemerle.Builtins.Tuple<Pair<_0027a>, list<_0027b>>(new Pair<_0027a>(val, val2), n_wildcard_);
		}
	}

	private sealed class _N__N_lambda__26873__26880 : Function<_0027a, list<_0027a>, list<_0027a>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__26873__26880 Instance = new _N__N_lambda__26873__26880();

		[SpecialName]
		public sealed override list<_0027a> apply(_0027a _N__26871, list<_0027a> _N__26872)
		{
			return new list<_0027a>.Cons(_N__26871, _N__26872);
		}
	}

	private class _N_Enumerator_26949 : IEnumerator, IDisposable, IEnumerator<_0027a>
	{
		private bool _N_finally_needed_26987;

		private bool _N_finally_needed_26985;

		internal Pair<_0027a> _N_elem_26983;

		internal Pair<_0027a> _N_elem_26981;

		internal RList<Pair<_0027a>> _N_ps_26979;

		internal IEnumerator<Pair<_0027a>> _N_enumerator_26977;

		internal _0027a _N_x_26975;

		internal RList<Pair<_0027a>> _N_ps_26973;

		internal IEnumerator<Pair<_0027a>> _N_enumerator_26971;

		internal _0027a _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_26967;

		internal RList<_0027a> _N__N_closurised_this_ptr_26965;

		internal Function<bool> _N__N_wildcard_3438_26963;

		public _0027a Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_26987)
			{
				((IDisposable)_N_enumerator_26971).Dispose();
			}
			if (_N_finally_needed_26985)
			{
				((IDisposable)_N_enumerator_26977).Dispose();
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
				switch (_N_state)
				{
				default:
					return false;
				case 0:
					if (_N__N_closurised_this_ptr_26965 == Nil._N_constant_object)
					{
						break;
					}
					if (_N__N_closurised_this_ptr_26965 is Zero)
					{
						_N_ps_26979 = ((Zero)_N__N_closurised_this_ptr_26965).arg;
						_N_enumerator_26977 = _N_ps_26979.GetEnumerator();
						_N_finally_needed_26985 = true;
						goto case 2;
					}
					if (_N__N_closurised_this_ptr_26965 is One)
					{
						_N_x_26975 = ((One)_N__N_closurised_this_ptr_26965).arg1;
						_N_ps_26973 = ((One)_N__N_closurised_this_ptr_26965).arg2;
						_N_current = _N_x_26975;
						_N_state = 3;
						return true;
					}
					throw new MatchFailureException();
				case 2:
					if (_N_enumerator_26977.MoveNext())
					{
						Pair<_0027a> current2 = _N_enumerator_26977.Current;
						_N_elem_26981 = current2;
						_N_current = _N_elem_26981.fst;
						_N_state = 1;
						return true;
					}
					_N_finally_needed_26985 = false;
					((IDisposable)_N_enumerator_26977).Dispose();
					break;
				case 1:
					_N_current = _N_elem_26981.snd;
					_N_state = 2;
					return true;
				case 3:
					_N_enumerator_26971 = _N_ps_26973.GetEnumerator();
					_N_finally_needed_26987 = true;
					goto case 5;
				case 5:
					if (_N_enumerator_26971.MoveNext())
					{
						Pair<_0027a> current = _N_enumerator_26971.Current;
						_N_elem_26983 = current;
						_N_current = _N_elem_26983.fst;
						_N_state = 4;
						return true;
					}
					_N_finally_needed_26987 = false;
					((IDisposable)_N_enumerator_26971).Dispose();
					break;
				case 4:
					_N_current = _N_elem_26983.snd;
					_N_state = 5;
					return true;
				}
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	public static readonly RList<_0027a> Empty;

	public int Length => _Length(this);

	public _0027a this[int index] => Nth(this, index);

	static RList()
	{
		Empty = Nil._N_constant_object;
	}

	public static bool IsEmpty(RList<_0027a> xs)
	{
		return (xs == Nil._N_constant_object) ? true : false;
	}

	public bool IsEmpty()
	{
		return IsEmpty(this);
	}

	public static bool Equals(RList<_0027a> xs, RList<_0027a> ys)
	{
		_0027a val = default(_0027a);
		_0027a val2 = default(_0027a);
		int result;
		RList<Pair<_0027a>> xs2;
		RList<Pair<_0027a>> ys2;
		if (xs == Nil._N_constant_object)
		{
			if (ys == Nil._N_constant_object)
			{
				result = 1;
				goto IL_010b;
			}
		}
		else if (xs is Zero)
		{
			if (ys is Zero)
			{
				xs2 = ((Zero)xs).arg;
				ys2 = ((Zero)ys).arg;
				goto IL_00e8;
			}
		}
		else if (xs is One && ys is One)
		{
			val2 = ((One)xs).arg1;
			xs2 = ((One)xs).arg2;
			val = ((One)ys).arg1;
			ys2 = ((One)ys).arg2;
			if (val2.Equals(val))
			{
				goto IL_00e8;
			}
		}
		result = 0;
		goto IL_010b;
		IL_00e8:
		result = (RList<Pair<_0027a>>.Equals(xs2, ys2) ? 1 : 0);
		goto IL_010b;
		IL_010b:
		return (byte)result != 0;
	}

	public bool Equals(RList<_0027a> ys)
	{
		return Equals(this, ys);
	}

	public static RList<_0027a> Cons(_0027a x, RList<_0027a> xs)
	{
		_0027a val = default(_0027a);
		object result;
		if (xs == Nil._N_constant_object)
		{
			result = new One(x, RList<Pair<_0027a>>.Nil._N_constant_object);
		}
		else if (xs is Zero)
		{
			RList<Pair<_0027a>> arg = ((Zero)xs).arg;
			result = new One(x, arg);
		}
		else
		{
			if (!(xs is One))
			{
				throw new MatchFailureException();
			}
			val = ((One)xs).arg1;
			RList<Pair<_0027a>> arg = ((One)xs).arg2;
			result = new Zero(RList<Pair<_0027a>>.Cons(new Pair<_0027a>(x, val), arg));
		}
		return (RList<_0027a>)result;
	}

	public RList<_0027a> Cons(_0027a x)
	{
		return Cons(x, this);
	}

	public static Nemerle.Builtins.Tuple<_0027a, RList<_0027a>> UnCons(RList<_0027a> xs)
	{
		_0027a val = default(_0027a);
		_0027a val2 = default(_0027a);
		if (xs == Nil._N_constant_object)
		{
			throw new Exception("Empty");
		}
		Nemerle.Builtins.Tuple<_0027a, RList<_0027a>> result;
		if (xs is Zero)
		{
			RList<Pair<_0027a>> xs2 = ((Zero)xs).arg;
			Nemerle.Builtins.Tuple<Pair<_0027a>, RList<Pair<_0027a>>> tuple = RList<Pair<_0027a>>.UnCons(xs2);
			val2 = tuple.Field0.fst;
			val = tuple.Field0.snd;
			xs2 = tuple.Field1;
			result = new Nemerle.Builtins.Tuple<_0027a, RList<_0027a>>(val2, new One(val, xs2));
		}
		else
		{
			if (!(xs is One))
			{
				throw new MatchFailureException();
			}
			if (((One)xs).arg2 == RList<Pair<_0027a>>.Nil._N_constant_object)
			{
				val = ((One)xs).arg1;
				result = new Nemerle.Builtins.Tuple<_0027a, RList<_0027a>>(val, Nil._N_constant_object);
			}
			else
			{
				val = ((One)xs).arg1;
				RList<Pair<_0027a>> xs2 = ((One)xs).arg2;
				result = new Nemerle.Builtins.Tuple<_0027a, RList<_0027a>>(val, new Zero(xs2));
			}
		}
		return result;
	}

	public Nemerle.Builtins.Tuple<_0027a, RList<_0027a>> UnCons()
	{
		return UnCons(this);
	}

	public static _0027a Head(RList<_0027a> xs)
	{
		_0027a val = default(_0027a);
		if (xs == Nil._N_constant_object)
		{
			throw new Exception("Empty");
		}
		_0027a result;
		if (xs is Zero)
		{
			RList<Pair<_0027a>> xs2 = ((Zero)xs).arg;
			Pair<_0027a> pair = RList<Pair<_0027a>>.Head(xs2);
			val = pair.fst;
			result = val;
		}
		else
		{
			if (!(xs is One))
			{
				throw new MatchFailureException();
			}
			val = ((One)xs).arg1;
			result = val;
		}
		return result;
	}

	public _0027a Head()
	{
		return Head(this);
	}

	public static _0027a Hd(RList<_0027a> xs)
	{
		return Head(xs);
	}

	public _0027a Hd()
	{
		return Head(this);
	}

	public static RList<_0027a> Tail(RList<_0027a> xs)
	{
		return UnCons(xs).Field1;
	}

	public RList<_0027a> Tail()
	{
		return Tail(this);
	}

	public static RList<_0027a> Tl(RList<_0027a> xs)
	{
		return Tail(xs);
	}

	public RList<_0027a> Tl()
	{
		return Tail(this);
	}

	public static _0027a Last(RList<_0027a> xs)
	{
		_0027a val = default(_0027a);
		if (xs == Nil._N_constant_object)
		{
			throw new ArgumentException("RList.Last called for empty RList");
		}
		_0027a result;
		if (xs is Zero)
		{
			RList<Pair<_0027a>> xs2 = ((Zero)xs).arg;
			result = RList<Pair<_0027a>>.Last(xs2).snd;
		}
		else
		{
			if (!(xs is One))
			{
				throw new MatchFailureException();
			}
			if (((One)xs).arg2 == RList<Pair<_0027a>>.Nil._N_constant_object)
			{
				val = ((One)xs).arg1;
				result = val;
			}
			else
			{
				RList<Pair<_0027a>> xs2 = ((One)xs).arg2;
				result = RList<Pair<_0027a>>.Last(xs2).snd;
			}
		}
		return result;
	}

	public _0027a Last()
	{
		return Last(this);
	}

	private static int _Length(RList<_0027a> xs, int tmp = 1, int count = 0)
	{
		checked
		{
			int result;
			if (xs == Nil._N_constant_object)
			{
				result = count;
			}
			else if (xs is Zero)
			{
				RList<Pair<_0027a>> xs2 = ((Zero)xs).arg;
				result = RList<Pair<_0027a>>._Length(xs2, tmp * 2, count);
			}
			else
			{
				if (!(xs is One))
				{
					throw new MatchFailureException();
				}
				RList<Pair<_0027a>> xs2 = ((One)xs).arg2;
				result = RList<Pair<_0027a>>._Length(xs2, tmp * 2, count + tmp);
			}
			return result;
		}
	}

	public static bool Exists(RList<_0027a> xs, Function<_0027a, bool> f)
	{
		_0027a val = default(_0027a);
		_N_closureOf_Exists_26385 n_closureOf_Exists_ = new _N_closureOf_Exists_26385();
		n_closureOf_Exists_._N_f_26390 = f;
		Function<Pair<_0027a>, bool> f2 = new _N_f___26392(n_closureOf_Exists_);
		int result;
		if (xs == Nil._N_constant_object)
		{
			result = 0;
		}
		else if (xs is Zero)
		{
			RList<Pair<_0027a>> xs2 = ((Zero)xs).arg;
			result = (RList<Pair<_0027a>>.Exists(xs2, f2) ? 1 : 0);
		}
		else
		{
			if (!(xs is One))
			{
				throw new MatchFailureException();
			}
			val = ((One)xs).arg1;
			RList<Pair<_0027a>> xs2 = ((One)xs).arg2;
			result = ((n_closureOf_Exists_._N_f_26390.apply(val) || RList<Pair<_0027a>>.Exists(xs2, f2)) ? 1 : 0);
		}
		return (byte)result != 0;
	}

	public bool Exists(Function<_0027a, bool> f)
	{
		return Exists(this, f);
	}

	public static bool Member(RList<_0027a> xs, _0027a elem)
	{
		_N_closureOf_Member_26426 n_closureOf_Member_ = new _N_closureOf_Member_26426();
		n_closureOf_Member_._N_elem_26431 = elem;
		Function<_0027a, bool> f = new _N__N_lambda__26420__26433(n_closureOf_Member_);
		return Exists(xs, f);
	}

	public bool Member(_0027a elem)
	{
		return Member(this, elem);
	}

	public static bool Contains(RList<_0027a> xs, _0027a elem)
	{
		return Member(xs, elem);
	}

	public bool Contains(_0027a elem)
	{
		return Member(this, elem);
	}

	public static _0027a Nth(RList<_0027a> xs, int i)
	{
		_0027a val = default(_0027a);
		_0027a val2 = default(_0027a);
		if (xs == Nil._N_constant_object)
		{
			throw new Exception("Subscript");
		}
		object result;
		if (xs is Zero)
		{
			RList<Pair<_0027a>> xs2 = ((Zero)xs).arg;
			Pair<_0027a> pair = RList<Pair<_0027a>>.Nth(xs2, i / 2);
			val = pair.fst;
			val2 = pair.snd;
			result = ((i % 2 != 0) ? val2 : val);
		}
		else
		{
			if (!(xs is One))
			{
				throw new MatchFailureException();
			}
			val = ((One)xs).arg1;
			RList<Pair<_0027a>> xs2 = ((One)xs).arg2;
			if (i == 0)
			{
				result = val;
			}
			else
			{
				Pair<_0027a> pair = RList<Pair<_0027a>>.Nth(xs2, checked(i - 1) / 2);
				val2 = pair.fst;
				val = pair.snd;
				result = ((i % 2 == 0) ? val : val2);
			}
		}
		return (_0027a)result;
	}

	public _0027a Nth(int i)
	{
		return Nth(this, i);
	}

	private static RList<_0027a> _Update(Function<_0027a, _0027a> f, int i, RList<_0027a> xs)
	{
		_0027a val = default(_0027a);
		_N_closureOf__Update_26504 n_closureOf__Update_ = new _N_closureOf__Update_26504();
		n_closureOf__Update_._N_f_26511 = f;
		n_closureOf__Update_._N_i_26509 = i;
		if (xs == Nil._N_constant_object)
		{
			throw new Exception("Subscript");
		}
		object result;
		if (xs is Zero)
		{
			RList<Pair<_0027a>> xs2 = ((Zero)xs).arg;
			Function<Pair<_0027a>, Pair<_0027a>> f2 = new _N_f___26519(n_closureOf__Update_);
			result = new Zero(RList<Pair<_0027a>>._Update(f2, n_closureOf__Update_._N_i_26509 / 2, xs2));
		}
		else
		{
			if (!(xs is One))
			{
				throw new MatchFailureException();
			}
			val = ((One)xs).arg1;
			RList<Pair<_0027a>> xs2 = ((One)xs).arg2;
			result = ((n_closureOf__Update_._N_i_26509 != 0) ? Cons(val, _Update(n_closureOf__Update_._N_f_26511, checked(n_closureOf__Update_._N_i_26509 - 1), new Zero(xs2))) : new One(n_closureOf__Update_._N_f_26511.apply(val), xs2));
		}
		return (RList<_0027a>)result;
	}

	public static RList<_0027a> Update(int i, _0027a y, RList<_0027a> xs)
	{
		_N_closureOf_Update_26545 n_closureOf_Update_ = new _N_closureOf_Update_26545();
		n_closureOf_Update_._N_y_26550 = y;
		Function<_0027a, _0027a> f = new _N__N_lambda__26539__26552(n_closureOf_Update_);
		return _Update(f, i, xs);
	}

	public RList<_0027a> Update(int i, _0027a y)
	{
		return Update(i, y, this);
	}

	public static _0027b FoldLeft<_0027b>(RList<_0027a> xs, _0027b acc, Function<_0027a, _0027b, _0027b> f)
	{
		_0027a val = default(_0027a);
		_N_closureOf_FoldLeft_26586<_0027b> n_closureOf_FoldLeft_ = new _N_closureOf_FoldLeft_26586<_0027b>();
		n_closureOf_FoldLeft_._N_f_26591 = f;
		_0027b result;
		if (xs == Nil._N_constant_object)
		{
			result = acc;
		}
		else if (xs is Zero)
		{
			RList<Pair<_0027a>> rList = ((Zero)xs).arg;
			RList<Pair<_0027a>> xs2 = rList;
			Function<Pair<_0027a>, _0027b, _0027b> f2 = new _N__N_lambda__26571__26599<_0027b>(n_closureOf_FoldLeft_);
			result = RList<Pair<_0027a>>.FoldLeft(xs2, acc, f2);
		}
		else
		{
			if (!(xs is One))
			{
				throw new MatchFailureException();
			}
			val = ((One)xs).arg1;
			RList<Pair<_0027a>> rList = ((One)xs).arg2;
			RList<Pair<_0027a>> xs3 = rList;
			_0027b acc2 = n_closureOf_FoldLeft_._N_f_26591.apply(val, acc);
			Function<Pair<_0027a>, _0027b, _0027b> f2 = new _N__N_lambda__26579__26608<_0027b>(n_closureOf_FoldLeft_);
			result = RList<Pair<_0027a>>.FoldLeft(xs3, acc2, f2);
		}
		return result;
	}

	public _0027b FoldLeft<_0027b>(_0027b acc, Function<_0027a, _0027b, _0027b> f)
	{
		return FoldLeft(this, acc, f);
	}

	public static _0027b FoldRight<_0027b>(RList<_0027a> xs, _0027b acc, Function<_0027a, _0027b, _0027b> f)
	{
		_0027a val = default(_0027a);
		_N_closureOf_FoldRight_26642<_0027b> n_closureOf_FoldRight_ = new _N_closureOf_FoldRight_26642<_0027b>();
		n_closureOf_FoldRight_._N_f_26647 = f;
		_0027b result;
		if (xs == Nil._N_constant_object)
		{
			result = acc;
		}
		else if (xs is Zero)
		{
			RList<Pair<_0027a>> rList = ((Zero)xs).arg;
			RList<Pair<_0027a>> xs2 = rList;
			Function<Pair<_0027a>, _0027b, _0027b> f2 = new _N__N_lambda__26627__26655<_0027b>(n_closureOf_FoldRight_);
			result = RList<Pair<_0027a>>.FoldRight(xs2, acc, f2);
		}
		else
		{
			if (!(xs is One))
			{
				throw new MatchFailureException();
			}
			val = ((One)xs).arg1;
			RList<Pair<_0027a>> rList = ((One)xs).arg2;
			Function<_0027a, _0027b, _0027b> n_f_ = n_closureOf_FoldRight_._N_f_26647;
			_0027a n_wildcard_ = val;
			RList<Pair<_0027a>> xs3 = rList;
			Function<Pair<_0027a>, _0027b, _0027b> f2 = new _N__N_lambda__26635__26664<_0027b>(n_closureOf_FoldRight_);
			result = n_f_.apply(n_wildcard_, RList<Pair<_0027a>>.FoldRight(xs3, acc, f2));
		}
		return result;
	}

	public _0027b FoldRight<_0027b>(_0027b acc, Function<_0027a, _0027b, _0027b> f)
	{
		return FoldRight(this, acc, f);
	}

	public static RList<_0027b> Map<_0027b>(RList<_0027a> xs, Function<_0027a, _0027b> f)
	{
		_0027a val = default(_0027a);
		_N_closureOf_Map_26689<_0027b> n_closureOf_Map_ = new _N_closureOf_Map_26689<_0027b>();
		n_closureOf_Map_._N_f_26694 = f;
		Function<Pair<_0027a>, Pair<_0027b>> f2 = new _N_f___26696<_0027b>(n_closureOf_Map_);
		object result;
		if (xs == Nil._N_constant_object)
		{
			result = RList<_0027b>.Nil._N_constant_object;
		}
		else if (xs is Zero)
		{
			RList<Pair<_0027a>> xs2 = ((Zero)xs).arg;
			result = new RList<_0027b>.Zero(RList<Pair<_0027a>>.Map(xs2, f2));
		}
		else
		{
			if (!(xs is One))
			{
				throw new MatchFailureException();
			}
			val = ((One)xs).arg1;
			RList<Pair<_0027a>> xs2 = ((One)xs).arg2;
			result = new RList<_0027b>.One(n_closureOf_Map_._N_f_26694.apply(val), RList<Pair<_0027a>>.Map(xs2, f2));
		}
		return (RList<_0027b>)result;
	}

	public RList<_0027b> Map<_0027b>(Function<_0027a, _0027b> f)
	{
		return Map(this, f);
	}

	public static void Iter(RList<_0027a> xs, FunctionVoid<_0027a> f)
	{
		_0027a val = default(_0027a);
		_N_closureOf_Iter_26726 n_closureOf_Iter_ = new _N_closureOf_Iter_26726();
		n_closureOf_Iter_._N_f_26731 = f;
		FunctionVoid<Pair<_0027a>> f2 = new _N_f___26733(n_closureOf_Iter_);
		if (xs == Nil._N_constant_object)
		{
			return;
		}
		if (xs is Zero)
		{
			RList<Pair<_0027a>> xs2 = ((Zero)xs).arg;
			RList<Pair<_0027a>>.Iter(xs2, f2);
			return;
		}
		if (xs is One)
		{
			val = ((One)xs).arg1;
			RList<Pair<_0027a>> xs2 = ((One)xs).arg2;
			n_closureOf_Iter_._N_f_26731.apply_void(val);
			RList<Pair<_0027a>>.Iter(xs2, f2);
			return;
		}
		throw new MatchFailureException();
	}

	public void Iter(FunctionVoid<_0027a> f)
	{
		Iter(this, f);
	}

	public static RList<_0027a> Rev(RList<_0027a> xs)
	{
		return FoldLeft(xs, Nil._N_constant_object, _N_static_proxy_26755.single_instance);
	}

	public RList<_0027a> Rev()
	{
		return Rev(this);
	}

	public static RList<_0027a> Append(RList<_0027a> xs, RList<_0027a> ys)
	{
		return FoldRight(xs, ys, _N_static_proxy_26773.single_instance);
	}

	public RList<_0027a> Append(RList<_0027a> ys)
	{
		return Append(this, ys);
	}

	public static RList<_0027a>operator +(RList<_0027a> xs, RList<_0027a> ys)
	{
		return Append(xs, ys);
	}

	public static RList<_0027a> FromList(list<_0027a> xs)
	{
		return FromList(xs, xs.Length);
	}

	public static RList<_0027a> FromList(list<_0027a> xs, int i)
	{
		Function<list<_0027a>, Nemerle.Builtins.Tuple<_0027a, list<_0027a>>> instance = _N__N_lambda__26798__26806.Instance;
		return _FromList(xs, i, instance);
	}

	private static RList<_0027a> _FromList<_0027b>(list<_0027b> xs, int i, Function<list<_0027b>, Nemerle.Builtins.Tuple<_0027a, list<_0027b>>> f)
	{
		_0027a val = default(_0027a);
		_N_closureOf__FromList_26834<_0027b> n_closureOf__FromList_ = new _N_closureOf__FromList_26834<_0027b>();
		n_closureOf__FromList_._N_f_26839 = f;
		Function<list<_0027b>, Nemerle.Builtins.Tuple<Pair<_0027a>, list<_0027b>>> f2 = new _N_f___26841<_0027b>(n_closureOf__FromList_);
		object result;
		if (i % 2 != 1)
		{
			result = ((i != 0) ? ((RList<_0027a>)new Zero(RList<Pair<_0027a>>._FromList(xs, i / 2, f2))) : ((RList<_0027a>)Nil._N_constant_object));
		}
		else
		{
			Nemerle.Builtins.Tuple<_0027a, list<_0027b>> tuple = n_closureOf__FromList_._N_f_26839.apply(xs);
			val = tuple.Field0;
			list<_0027b> xs2 = tuple.Field1;
			result = new One(val, RList<Pair<_0027a>>._FromList(xs2, i / 2, f2));
		}
		return (RList<_0027a>)result;
	}

	public static list<_0027a> ToList(RList<_0027a> xs)
	{
		list<_0027a>.Nil n_constant_object = list<_0027a>.Nil._N_constant_object;
		Function<_0027a, list<_0027a>, list<_0027a>> instance = _N__N_lambda__26873__26880.Instance;
		return FoldRight(xs, n_constant_object, instance);
	}

	public list<_0027a> ToList()
	{
		return ToList(this);
	}

	public static string ToString(RList<_0027a> xs)
	{
		return xs.ToString();
	}

	public override string ToString()
	{
		_0027a val = default(_0027a);
		object result;
		if (this == Nil._N_constant_object)
		{
			result = "Nil";
		}
		else if (this is Zero)
		{
			RList<Pair<_0027a>> rList = ((Zero)this).arg;
			result = "Zero (" + Convert.ToString(rList) + ")";
		}
		else
		{
			if (!(this is One))
			{
				throw new MatchFailureException();
			}
			val = ((One)this).arg1;
			RList<Pair<_0027a>> rList = ((One)this).arg2;
			result = "One (" + Convert.ToString(val) + ", " + Convert.ToString(rList) + ")";
		}
		return (string)result;
	}

	public IEnumerator<_0027a> GetEnumerator()
	{
		_N_Enumerator_26949 n_Enumerator_ = new _N_Enumerator_26949();
		n_Enumerator_._N__N_closurised_this_ptr_26965 = this;
		return n_Enumerator_;
	}

	public override bool Equals(object other)
	{
		return other == this || (other is RList<_0027a> && Equals((RList<_0027a>)other));
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(RList<_0027a> x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is RList<_0027a>)) ? (-1) : ((RList<_0027a>)x)._N_GetVariantCode();
	}

	[SpecialName]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
