using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Collections;

[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[DebuggerNonUserCode]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
public static class NCollectionsExtensions
{
	private class _N_Enumerable_22105<TEnu, TOut> : IEnumerator, IDisposable, IEnumerator<TOut>, IEnumerable, IEnumerable<TOut> where TEnu : IEnumerable<TOut>
	{
		private bool _N_finally_needed_22144;

		private bool _N_finally_needed_22142;

		internal TOut _N_elem2_22140;

		internal TEnu _N_elem1_22138;

		internal IEnumerator<TOut> _N_enumerator_22136;

		internal IEnumerator<TEnu> _N_enumerator_22134;

		internal IEnumerable<TEnu> _N_source_22132;

		internal TOut _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_22128;

		internal Function<bool> _N__N_wildcard_3438_22126;

		private int _N_this_used;

		public TOut Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_22144)
			{
				((IDisposable)_N_enumerator_22134).Dispose();
			}
			if (_N_finally_needed_22142)
			{
				((IDisposable)_N_enumerator_22136).Dispose();
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
				if (_N_state == 1)
				{
					goto IL_00a6;
				}
				if (_N_state != 0)
				{
					return false;
				}
				if (_N_source_22132 == null)
				{
					throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\Nemerle.Collections.n:74:45:74:51: .");
				}
				_N_enumerator_22134 = _N_source_22132.GetEnumerator();
				_N_finally_needed_22144 = true;
				goto IL_0061;
				IL_0061:
				if (!_N_enumerator_22134.MoveNext())
				{
					_N_finally_needed_22144 = false;
					((IDisposable)_N_enumerator_22134).Dispose();
					return false;
				}
				TEnu val = (_N_elem1_22138 = _N_enumerator_22134.Current);
				_N_enumerator_22136 = ((IEnumerable<TOut>)_N_elem1_22138).GetEnumerator();
				_N_finally_needed_22142 = true;
				goto IL_00a6;
				IL_00a6:
				if (_N_enumerator_22136.MoveNext())
				{
					TOut val2 = (_N_elem2_22140 = _N_enumerator_22136.Current);
					_N_current = _N_elem2_22140;
					_N_state = 1;
					return true;
				}
				_N_finally_needed_22142 = false;
				((IDisposable)_N_enumerator_22136).Dispose();
				goto IL_0061;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<TOut> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_22105<TEnu, TOut> n_Enumerable_ = new _N_Enumerable_22105<TEnu, TOut>();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<TOut>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<TOut>)this;
			}
			return (IEnumerator<TOut>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_22105<TEnu, TOut> n_Enumerable_ = new _N_Enumerable_22105<TEnu, TOut>();
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

		private void CopyFrom(_N_Enumerable_22105<TEnu, TOut> other)
		{
			_N_this_used = 1;
			_N_source_22132 = other._N_source_22132;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private sealed class _N__N_lambda__22176__22190<TFirst, TSecond> : Function<TFirst, TSecond, Nemerle.Builtins.Tuple<TFirst, TSecond>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__22176__22190<TFirst, TSecond> Instance = new _N__N_lambda__22176__22190<TFirst, TSecond>();

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<TFirst, TSecond> apply(TFirst _N__22188, TSecond _N__22189)
		{
			return new Nemerle.Builtins.Tuple<TFirst, TSecond>(_N__22188, _N__22189);
		}
	}

	private class _N_Enumerable_22239<TFirst, TSecond, TResult> : IEnumerator, IDisposable, IEnumerator<TResult>, IEnumerable, IEnumerable<TResult>
	{
		private bool _N_finally_needed_22288;

		private bool _N_finally_needed_22286;

		internal IEnumerator<TFirst> _N_e1_22284;

		internal IEnumerator<TSecond> _N_e2_22282;

		internal string _N_arg_22280;

		internal IEnumerator<TSecond> _N_e2_22278;

		internal IEnumerator<TFirst> _N_e1_22276;

		internal IDisposable _N_disp_22274;

		internal IDisposable _N_disp_22272;

		internal IEnumerable<TFirst> _N_first_22270;

		internal IEnumerable<TSecond> _N_second_22268;

		internal Function<TFirst, TSecond, TResult> _N_func_22266;

		internal TResult _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_22262;

		internal Function<bool> _N__N_wildcard_3438_22260;

		private int _N_this_used;

		public TResult Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_22288)
			{
				_N_disp_22274 = _N_e1_22276;
				if (_N_disp_22274 != null)
				{
					_N_disp_22274.Dispose();
				}
			}
			if (_N_finally_needed_22286)
			{
				_N_disp_22272 = _N_e2_22278;
				if (_N_disp_22272 != null)
				{
					_N_disp_22272.Dispose();
				}
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
				IEnumerator<TFirst> n_e1_;
				IEnumerator<TSecond> n_e2_;
				if (_N_state != 1)
				{
					if (_N_state != 0)
					{
						return false;
					}
					if (_N_func_22266 == null)
					{
						throw new ArgumentNullException("func", "The ``NotNull'' contract of parameter ``func'' has been violated. See lib\\Nemerle.Collections.n:93:24:93:28: .");
					}
					if (_N_second_22268 == null)
					{
						throw new ArgumentNullException("second", "The ``NotNull'' contract of parameter ``second'' has been violated. See lib\\Nemerle.Collections.n:92:24:92:30: .");
					}
					if (_N_first_22270 == null)
					{
						throw new ArgumentNullException("first", "The ``NotNull'' contract of parameter ``first'' has been violated. See lib\\Nemerle.Collections.n:91:24:91:29: .");
					}
					_N_e2_22278 = _N_second_22268.GetEnumerator();
					_N_finally_needed_22286 = true;
					_N_e1_22276 = _N_first_22270.GetEnumerator();
					_N_finally_needed_22288 = true;
					n_e1_ = _N_e1_22276;
					n_e2_ = _N_e2_22278;
				}
				else
				{
					IEnumerator<TFirst> obj = _N_e1_22284;
					n_e2_ = _N_e2_22282;
					n_e1_ = obj;
				}
				_N_e1_22284 = n_e1_;
				_N_e2_22282 = n_e2_;
				Nemerle.Builtins.Tuple<bool, bool> tuple = new Nemerle.Builtins.Tuple<bool, bool>(_N_e1_22284.MoveNext(), _N_e2_22282.MoveNext());
				if (tuple.Field0)
				{
					if (tuple.Field1)
					{
						_N_current = _N_func_22266.apply(_N_e1_22284.Current, _N_e2_22282.Current);
						_N_state = 1;
						return true;
					}
					_N_arg_22280 = "second";
				}
				else
				{
					if (!tuple.Field1)
					{
						_N_finally_needed_22288 = false;
						_N_disp_22274 = _N_e1_22276;
						if (_N_disp_22274 != null)
						{
							_N_disp_22274.Dispose();
						}
						_N_finally_needed_22286 = false;
						_N_disp_22272 = _N_e2_22278;
						if (_N_disp_22272 != null)
						{
							_N_disp_22272.Dispose();
						}
						return false;
					}
					_N_arg_22280 = "first";
				}
				throw new ArgumentException("The first & second mast be same length.", _N_arg_22280);
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<TResult> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_22239<TFirst, TSecond, TResult> n_Enumerable_ = new _N_Enumerable_22239<TFirst, TSecond, TResult>();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<TResult>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<TResult>)this;
			}
			return (IEnumerator<TResult>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_22239<TFirst, TSecond, TResult> n_Enumerable_ = new _N_Enumerable_22239<TFirst, TSecond, TResult>();
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

		private void CopyFrom(_N_Enumerable_22239<TFirst, TSecond, TResult> other)
		{
			_N_this_used = 1;
			_N_e1_22284 = other._N_e1_22284;
			_N_e2_22282 = other._N_e2_22282;
			_N_first_22270 = other._N_first_22270;
			_N_second_22268 = other._N_second_22268;
			_N_func_22266 = other._N_func_22266;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private sealed class _N_closureOf_Map2ToArray_22354<First, Second, Result>
	{
		internal Function<First, Second, Result> _N_func_22359;

		internal _N_closureOf_Map2ToArray_22354()
		{
		}
	}

	private sealed class _N_foldFunc__22396<First, Second, Result> : Function<First, Second, Nemerle.Builtins.Tuple<Result[], int>, Nemerle.Builtins.Tuple<Result[], int>>
	{
		[SpecialName]
		private _N_closureOf_Map2ToArray_22354<First, Second, Result> _N_Map2ToArray_closure_22400;

		public _N_foldFunc__22396(_N_closureOf_Map2ToArray_22354<First, Second, Result> _N_Map2ToArray_closure_22400)
		{
			this._N_Map2ToArray_closure_22400 = _N_Map2ToArray_closure_22400;
		}

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<Result[], int> apply(First _N__22393, Second _N__22394, Nemerle.Builtins.Tuple<Result[], int> _N__22395)
		{
			Result[] array = _N__22395.Field0;
			int field = _N__22395.Field1;
			array[field] = _N_Map2ToArray_closure_22400._N_func_22359.apply(_N__22393, _N__22394);
			return new Nemerle.Builtins.Tuple<Result[], int>(array, checked(field + 1));
		}
	}

	private sealed class _N__N_lambda__22451__22465<First, Second> : Function<First, Second, Nemerle.Builtins.Tuple<First, Second>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__22451__22465<First, Second> Instance = new _N__N_lambda__22451__22465<First, Second>();

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<First, Second> apply(First _N__22463, Second _N__22464)
		{
			return new Nemerle.Builtins.Tuple<First, Second>(_N__22463, _N__22464);
		}
	}

	private sealed class _N__N_lambda__22480__22494<First, Second> : Function<First, Second, Nemerle.Builtins.Tuple<First, Second>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__22480__22494<First, Second> Instance = new _N__N_lambda__22480__22494<First, Second>();

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<First, Second> apply(First _N__22492, Second _N__22493)
		{
			return new Nemerle.Builtins.Tuple<First, Second>(_N__22492, _N__22493);
		}
	}

	private sealed class _N__N_lambda__22509__22523<First, Second> : Function<First, Second, Nemerle.Builtins.Tuple<First, Second>>
	{
		[SpecialName]
		public static readonly _N__N_lambda__22509__22523<First, Second> Instance = new _N__N_lambda__22509__22523<First, Second>();

		[SpecialName]
		public sealed override Nemerle.Builtins.Tuple<First, Second> apply(First _N__22521, Second _N__22522)
		{
			return new Nemerle.Builtins.Tuple<First, Second>(_N__22521, _N__22522);
		}
	}

	private class _N_Enumerable_22861<From, To> : IEnumerator, IDisposable, IEnumerator<To>, IEnumerable, IEnumerable<To>
	{
		private bool _N_finally_needed_22896;

		internal From _N_elem_22894;

		internal IEnumerator<From> _N_enumerator_22892;

		internal IEnumerable<From> _N_source_22890;

		internal Function<From, To> _N_convert_22888;

		internal To _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_22884;

		internal Function<bool> _N__N_wildcard_3438_22882;

		private int _N_this_used;

		public To Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_22896)
			{
				((IDisposable)_N_enumerator_22892).Dispose();
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
				if (_N_state != 1)
				{
					if (_N_state != 0)
					{
						return false;
					}
					_N_enumerator_22892 = _N_source_22890.GetEnumerator();
					_N_finally_needed_22896 = true;
				}
				if (_N_enumerator_22892.MoveNext())
				{
					From val = (_N_elem_22894 = _N_enumerator_22892.Current);
					_N_current = _N_convert_22888.apply(_N_elem_22894);
					_N_state = 1;
					return true;
				}
				_N_finally_needed_22896 = false;
				((IDisposable)_N_enumerator_22892).Dispose();
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<To> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_22861<From, To> n_Enumerable_ = new _N_Enumerable_22861<From, To>();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<To>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<To>)this;
			}
			return (IEnumerator<To>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_22861<From, To> n_Enumerable_ = new _N_Enumerable_22861<From, To>();
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

		private void CopyFrom(_N_Enumerable_22861<From, To> other)
		{
			_N_this_used = 1;
			_N_source_22890 = other._N_source_22890;
			_N_convert_22888 = other._N_convert_22888;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private class _N_Enumerable_22946<From, To> : IEnumerator, IDisposable, IEnumerator<To>, IEnumerable, IEnumerable<To>
	{
		private bool _N_finally_needed_22983;

		internal From _N_elem_22981;

		internal IEnumerator<From> _N_enumerator_22979;

		internal IEnumerable<From> _N_source_22977;

		internal Function<From, bool> _N_isMatch_22975;

		internal Function<From, To> _N_convert_22973;

		internal To _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_22969;

		internal Function<bool> _N__N_wildcard_3438_22967;

		private int _N_this_used;

		public To Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_22983)
			{
				((IDisposable)_N_enumerator_22979).Dispose();
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
				if (_N_state != 1)
				{
					if (_N_state != 0)
					{
						return false;
					}
					_N_enumerator_22979 = _N_source_22977.GetEnumerator();
					_N_finally_needed_22983 = true;
				}
				while (_N_enumerator_22979.MoveNext())
				{
					From val = (_N_elem_22981 = _N_enumerator_22979.Current);
					if (_N_isMatch_22975.apply(_N_elem_22981))
					{
						_N_current = _N_convert_22973.apply(_N_elem_22981);
						_N_state = 1;
						return true;
					}
				}
				_N_finally_needed_22983 = false;
				((IDisposable)_N_enumerator_22979).Dispose();
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<To> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_22946<From, To> n_Enumerable_ = new _N_Enumerable_22946<From, To>();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<To>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<To>)this;
			}
			return (IEnumerator<To>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_22946<From, To> n_Enumerable_ = new _N_Enumerable_22946<From, To>();
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

		private void CopyFrom(_N_Enumerable_22946<From, To> other)
		{
			_N_this_used = 1;
			_N_source_22977 = other._N_source_22977;
			_N_isMatch_22975 = other._N_isMatch_22975;
			_N_convert_22973 = other._N_convert_22973;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private class _N_Enumerable_23036<From, To> : IEnumerator, IDisposable, IEnumerator<To>, IEnumerable, IEnumerable<To>
	{
		private bool _N_finally_needed_23075;

		internal From _N_elem_23073;

		internal bool _N_isMatch_23071;

		internal To _N_convertedValue_23069;

		internal IEnumerator<From> _N_enumerator_23067;

		internal IEnumerable<From> _N_source_23065;

		internal Function<From, Nemerle.Builtins.Tuple<bool, To>> _N_matchAndConvert_23063;

		internal To _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_23059;

		internal Function<bool> _N__N_wildcard_3438_23057;

		private int _N_this_used;

		public To Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_23075)
			{
				((IDisposable)_N_enumerator_23067).Dispose();
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
				if (_N_state != 1)
				{
					if (_N_state != 0)
					{
						return false;
					}
					_N_enumerator_23067 = _N_source_23065.GetEnumerator();
					_N_finally_needed_23075 = true;
				}
				while (_N_enumerator_23067.MoveNext())
				{
					From val = (_N_elem_23073 = _N_enumerator_23067.Current);
					Nemerle.Builtins.Tuple<bool, To> tuple = _N_matchAndConvert_23063.apply(_N_elem_23073);
					_N_isMatch_23071 = tuple.Field0;
					_N_convertedValue_23069 = tuple.Field1;
					if (_N_isMatch_23071)
					{
						_N_current = _N_convertedValue_23069;
						_N_state = 1;
						return true;
					}
				}
				_N_finally_needed_23075 = false;
				((IDisposable)_N_enumerator_23067).Dispose();
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<To> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_23036<From, To> n_Enumerable_ = new _N_Enumerable_23036<From, To>();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<To>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<To>)this;
			}
			return (IEnumerator<To>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_23036<From, To> n_Enumerable_ = new _N_Enumerable_23036<From, To>();
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

		private void CopyFrom(_N_Enumerable_23036<From, To> other)
		{
			_N_this_used = 1;
			_N_source_23065 = other._N_source_23065;
			_N_matchAndConvert_23063 = other._N_matchAndConvert_23063;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private class _N_Enumerable_23130<T> : IEnumerator, IDisposable, IEnumerator<T>, IEnumerable, IEnumerable<T>
	{
		private bool _N_finally_needed_23165;

		internal T _N_elem_23163;

		internal IEnumerator<T> _N_enumerator_23161;

		internal IEnumerable<T> _N_source_23159;

		internal Function<T, bool> _N_predicate_23157;

		internal T _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_23153;

		internal Function<bool> _N__N_wildcard_3438_23151;

		private int _N_this_used;

		public T Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_23165)
			{
				((IDisposable)_N_enumerator_23161).Dispose();
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
				if (_N_state != 1)
				{
					if (_N_state != 0)
					{
						return false;
					}
					_N_enumerator_23161 = _N_source_23159.GetEnumerator();
					_N_finally_needed_23165 = true;
				}
				while (_N_enumerator_23161.MoveNext())
				{
					T val = (_N_elem_23163 = _N_enumerator_23161.Current);
					if (_N_predicate_23157.apply(_N_elem_23163))
					{
						_N_current = _N_elem_23163;
						_N_state = 1;
						return true;
					}
				}
				_N_finally_needed_23165 = false;
				((IDisposable)_N_enumerator_23161).Dispose();
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_23130<T> n_Enumerable_ = new _N_Enumerable_23130<T>();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<T>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<T>)this;
			}
			return (IEnumerator<T>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_23130<T> n_Enumerable_ = new _N_Enumerable_23130<T>();
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

		private void CopyFrom(_N_Enumerable_23130<T> other)
		{
			_N_this_used = 1;
			_N_source_23159 = other._N_source_23159;
			_N_predicate_23157 = other._N_predicate_23157;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private class _N_Enumerable_23228<T> : IEnumerator, IDisposable, IEnumerator<T>, IEnumerable, IEnumerable<T>
	{
		private bool _N_finally_needed_23269;

		internal T _N_elem_23267;

		internal T _N_elem_23265;

		internal Hashtable<T, byte> _N_ht_23263;

		internal IEnumerator<T> _N_enumerator_23261;

		internal IEnumerator<T> _N_enumerator_23259;

		internal IEnumerable<T> _N_source_23257;

		internal IEnumerable<T> _N_exclude_23255;

		internal T _N_current;

		internal int _N_state;

		internal Function<bool> _N__N_yielding_function_23251;

		internal Function<bool> _N__N_wildcard_3438_23249;

		private int _N_this_used;

		public T Current => _N_current;

		public void Dispose()
		{
			_N_state = -1;
			if (_N_finally_needed_23269)
			{
				((IDisposable)_N_enumerator_23259).Dispose();
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
				if (_N_state != 1)
				{
					if (_N_state != 0)
					{
						return false;
					}
					if (_N_exclude_23255 == null)
					{
						throw new ArgumentNullException("exclude", "The ``NotNull'' contract of parameter ``exclude'' has been violated. See lib\\Nemerle.Collections.n:423:22:423:29: .");
					}
					if (_N_source_23257 == null)
					{
						throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\Nemerle.Collections.n:422:22:422:28: .");
					}
					_N_ht_23263 = new Hashtable<T, byte>();
					_N_enumerator_23261 = _N_exclude_23255.GetEnumerator();
					try
					{
						while (_N_enumerator_23261.MoveNext())
						{
							T val = (_N_elem_23265 = _N_enumerator_23261.Current);
							_N_ht_23263[_N_elem_23265] = (byte)0;
						}
					}
					finally
					{
						((IDisposable)_N_enumerator_23261).Dispose();
					}
					_N_enumerator_23259 = _N_source_23257.GetEnumerator();
					_N_finally_needed_23269 = true;
				}
				while (_N_enumerator_23259.MoveNext())
				{
					T val2 = (_N_elem_23267 = _N_enumerator_23259.Current);
					if (!_N_ht_23263.Contains(_N_elem_23267))
					{
						_N_current = _N_elem_23267;
						_N_state = 1;
						return true;
					}
				}
				_N_finally_needed_23269 = false;
				((IDisposable)_N_enumerator_23259).Dispose();
				return false;
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
		}

		public IEnumerator<T> GetEnumerator()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_23228<T> n_Enumerable_ = new _N_Enumerable_23228<T>();
				n_Enumerable_.CopyFrom(this);
				result = (IEnumerator<T>)n_Enumerable_;
			}
			else
			{
				result = (IEnumerator<T>)this;
			}
			return (IEnumerator<T>)result;
		}

		private IEnumerator NonGenericGetEnum()
		{
			object result;
			if (Interlocked.CompareExchange(ref _N_this_used, 1, 0) != 0)
			{
				_N_Enumerable_23228<T> n_Enumerable_ = new _N_Enumerable_23228<T>();
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

		private void CopyFrom(_N_Enumerable_23228<T> other)
		{
			_N_this_used = 1;
			_N_source_23257 = other._N_source_23257;
			_N_exclude_23255 = other._N_exclude_23255;
		}

		[SpecialName]
		object IEnumerator.get_Current()
		{
			return Current;
		}
	}

	private sealed class _N__N_lambda__23533__23547<From, To> : Function<From, To> where From : class where To : class, From
	{
		[SpecialName]
		public static readonly _N__N_lambda__23533__23547<From, To> Instance = new _N__N_lambda__23533__23547<From, To>();

		[SpecialName]
		public sealed override To apply(From _N__23532)
		{
			return (To)_N__23532;
		}
	}

	private sealed class _N_closureOf_Map2_24490<TFirst, TSecond, TResult>
	{
		internal TSecond[] _N_b_24497;

		internal Function<TFirst, TSecond, TResult> _N_f_24495;

		internal _N_closureOf_Map2_24490()
		{
		}
	}

	private sealed class _N_closureOf_Map2_24521<TFirst, TSecond, TResult>
	{
		internal TFirst[] _N_a_24528;

		internal Function<TFirst, TSecond, TResult> _N_f_24526;

		internal _N_closureOf_Map2_24521()
		{
		}
	}

	private sealed class _N_closureOf_FoldRight2_24624<TFirst, TSecond, TResult>
	{
		internal TSecond[] _N_b_24631;

		internal Function<TFirst, TSecond, TResult, TResult> _N_f_24629;

		internal _N_closureOf_FoldRight2_24624()
		{
		}
	}

	private sealed class _N_closureOf_FoldRight2_24657<TFirst, TSecond, TResult>
	{
		internal TFirst[] _N_a_24664;

		internal Function<TFirst, TSecond, TResult, TResult> _N_f_24662;

		internal _N_closureOf_FoldRight2_24657()
		{
		}
	}

	private sealed class _N_closureOf_Sort_24811<T, Val> where Val : IComparable<Val>
	{
		internal Function<T, Val> _N_getComparableValue_24816;

		internal _N_closureOf_Sort_24811()
		{
		}
	}

	private sealed class _N_Cmp__24818<T, Val> : Function<T, T, int> where Val : IComparable<Val>
	{
		[SpecialName]
		private _N_closureOf_Sort_24811<T, Val> _N_Sort_closure_24822;

		public _N_Cmp__24818(_N_closureOf_Sort_24811<T, Val> _N_Sort_closure_24822)
		{
			this._N_Sort_closure_24822 = _N_Sort_closure_24822;
		}

		[SpecialName]
		public sealed override int apply(T x, T y)
		{
			return _N_Sort_closure_24822._N_getComparableValue_24816.apply(x).CompareTo(_N_Sort_closure_24822._N_getComparableValue_24816.apply(y));
		}
	}

	private sealed class _N__N_lambda__24835__24841<T> : Function<T, string>
	{
		[SpecialName]
		public static readonly _N__N_lambda__24835__24841<T> Instance = new _N__N_lambda__24835__24841<T>();

		[SpecialName]
		public sealed override string apply(T value)
		{
			return value.ToString();
		}
	}

	[Nemerle.Internal.Extension]
	public static Hashtable<TKey, List<TValue>> Grouping<TSource, TKey, TValue>(this IEnumerable<TSource> source, Function<TSource, Nemerle.Builtins.Tuple<TKey, TValue>> selector)
	{
		Hashtable<TKey, List<TValue>> hashtable = new Hashtable<TKey, List<TValue>>();
		IEnumerator<TSource> enumerator = source.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				TSource val = default(TSource);
				TSource current = enumerator.Current;
				val = current;
				TValue val2 = default(TValue);
				TKey val3 = default(TKey);
				Nemerle.Builtins.Tuple<TKey, TValue> tuple = selector.apply(val);
				val3 = tuple.Field0;
				val2 = tuple.Field1;
				List<TValue> value = null;
				if (hashtable.TryGetValue(val3, out value))
				{
					value.Add(val2);
					continue;
				}
				value = new List<TValue>();
				value.Add(val2);
				hashtable.Add(val3, value);
			}
			return hashtable;
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	[Nemerle.Internal.Extension]
	public static IEnumerable<TOut> Flatten<TEnu, TOut>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<TEnu> source) where TEnu : IEnumerable<TOut>
	{
		_N_Enumerable_22105<TEnu, TOut> n_Enumerable_ = new _N_Enumerable_22105<TEnu, TOut>();
		n_Enumerable_._N_source_22132 = source;
		return n_Enumerable_;
	}

	[Nemerle.Internal.Extension]
	public static IEnumerable<Nemerle.Builtins.Tuple<TFirst, TSecond>> ZipLazy<TFirst, TSecond>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<TFirst> first, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] IEnumerable<TSecond> second)
	{
		if (second == null)
		{
			throw new ArgumentNullException("second", "The ``NotNull'' contract of parameter ``second'' has been violated. See lib\\Nemerle.Collections.n:84:19:84:25: .");
		}
		if (first == null)
		{
			throw new ArgumentNullException("first", "The ``NotNull'' contract of parameter ``first'' has been violated. See lib\\Nemerle.Collections.n:83:24:83:29: .");
		}
		Function<TFirst, TSecond, Nemerle.Builtins.Tuple<TFirst, TSecond>> instance = _N__N_lambda__22176__22190<TFirst, TSecond>.Instance;
		return first.Map2Lazy(second, instance);
	}

	[Nemerle.Internal.Extension]
	public static IEnumerable<TResult> Map2Lazy<TFirst, TSecond, TResult>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<TFirst> first, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] IEnumerable<TSecond> second, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Function<TFirst, TSecond, TResult> func)
	{
		_N_Enumerable_22239<TFirst, TSecond, TResult> n_Enumerable_ = new _N_Enumerable_22239<TFirst, TSecond, TResult>();
		n_Enumerable_._N_first_22270 = first;
		n_Enumerable_._N_second_22268 = second;
		n_Enumerable_._N_func_22266 = func;
		return n_Enumerable_;
	}

	[Nemerle.Internal.Extension]
	public static Result[] Map2ToArray<First, Second, Result>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<First> first, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] IEnumerable<Second> second, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Function<First, Second, Result> func)
	{
		_N_closureOf_Map2ToArray_22354<First, Second, Result> n_closureOf_Map2ToArray_ = new _N_closureOf_Map2ToArray_22354<First, Second, Result>();
		n_closureOf_Map2ToArray_._N_func_22359 = func;
		if (n_closureOf_Map2ToArray_._N_func_22359 == null)
		{
			throw new ArgumentNullException("func", "The ``NotNull'' contract of parameter ``func'' has been violated. See lib\\Nemerle.Collections.n:117:22:117:26: .");
		}
		if (second == null)
		{
			throw new ArgumentNullException("second", "The ``NotNull'' contract of parameter ``second'' has been violated. See lib\\Nemerle.Collections.n:116:22:116:28: .");
		}
		if (first == null)
		{
			throw new ArgumentNullException("first", "The ``NotNull'' contract of parameter ``first'' has been violated. See lib\\Nemerle.Collections.n:115:22:115:27: .");
		}
		Nemerle.Builtins.Tuple<IEnumerable<First>, IEnumerable<Second>> tuple = new Nemerle.Builtins.Tuple<IEnumerable<First>, IEnumerable<Second>>(first, second);
		Result[] result;
		System.Collections.Generic.ICollection<First> source;
		System.Collections.Generic.ICollection<Second> source2;
		if (tuple.Field0 is First[])
		{
			First[] first2 = (First[])tuple.Field0;
			if (tuple.Field1 is Second[])
			{
				Second[] second2 = (Second[])tuple.Field1;
				result = first2.Map2ToArray(second2, n_closureOf_Map2ToArray_._N_func_22359);
				goto IL_02c0;
			}
			if (tuple.Field1 is System.Collections.Generic.ICollection<Second>)
			{
				source = (System.Collections.Generic.ICollection<First>)tuple.Field0;
				source2 = (System.Collections.Generic.ICollection<Second>)tuple.Field1;
				goto IL_00d9;
			}
		}
		else if (tuple.Field0 is System.Collections.Generic.ICollection<First>)
		{
			source = (System.Collections.Generic.ICollection<First>)tuple.Field0;
			if (tuple.Field1 is System.Collections.Generic.ICollection<Second>)
			{
				source2 = (System.Collections.Generic.ICollection<Second>)tuple.Field1;
				goto IL_00d9;
			}
		}
		else if (tuple.Field0 is list<First>)
		{
			list<First> list = (list<First>)tuple.Field0;
			if (tuple.Field1 is list<Second>)
			{
				list<Second> b = (list<Second>)tuple.Field1;
				Function<First, Second, Nemerle.Builtins.Tuple<Result[], int>, Nemerle.Builtins.Tuple<Result[], int>> f = new _N_foldFunc__22396<First, Second, Result>(n_closureOf_Map2ToArray_);
				Result[] array = list.FoldLeft2(b, new Nemerle.Builtins.Tuple<Result[], int>(new Result[list.Length], 0), f).Field0;
				result = array;
				goto IL_02c0;
			}
		}
		IEnumerator<First> enumerator = first.GetEnumerator();
		Result[] array3;
		try
		{
			IEnumerator<Second> enumerator2 = second.GetEnumerator();
			Result[] array2;
			try
			{
				List<Result> list2 = new List<Result>();
				while (true)
				{
					Nemerle.Builtins.Tuple<bool, bool> tuple2 = new Nemerle.Builtins.Tuple<bool, bool>(enumerator.MoveNext(), enumerator2.MoveNext());
					if (tuple2.Field0)
					{
						if (tuple2.Field1)
						{
							list2.Add(n_closureOf_Map2ToArray_._N_func_22359.apply(enumerator.Current, enumerator2.Current));
							list2 = list2;
							continue;
						}
					}
					else if (!tuple2.Field1)
					{
						break;
					}
					throw new ArgumentException("Collections must have the same length", "first, second");
				}
				Result[] source3 = list2.NToArray();
				array2 = source3.NToArray();
			}
			finally
			{
				((IDisposable)enumerator2)?.Dispose();
			}
			array3 = array2;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		result = array3;
		goto IL_02c0;
		IL_00d9:
		result = source.NToArray().Map2ToArray(source2.NToArray(), n_closureOf_Map2ToArray_._N_func_22359);
		goto IL_02c0;
		IL_02c0:
		return result;
	}

	[Nemerle.Internal.Extension]
	public static Result[] Map2ToArray<First, Second, Result>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this First[] first, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Second[] second, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Function<First, Second, Result> func)
	{
		int num = 0;
		bool flag = false;
		int num2 = 0;
		if (func == null)
		{
			throw new ArgumentNullException("func", "The ``NotNull'' contract of parameter ``func'' has been violated. See lib\\Nemerle.Collections.n:157:17:157:21: .");
		}
		if (second == null)
		{
			throw new ArgumentNullException("second", "The ``NotNull'' contract of parameter ``second'' has been violated. See lib\\Nemerle.Collections.n:156:17:156:23: .");
		}
		if (first == null)
		{
			throw new ArgumentNullException("first", "The ``NotNull'' contract of parameter ``first'' has been violated. See lib\\Nemerle.Collections.n:155:22:155:27: .");
		}
		if (first.Length != second.Length)
		{
			throw new ArgumentException("Collections must have the same length", "first, second");
		}
		Result[] array = new Result[first.Length];
		num = 0;
		int num3 = checked(first.Length - 1);
		flag = num <= num3;
		num2 = num3 - 1;
		bool flag2 = num2 > num3;
		while (flag)
		{
			num3 = num;
			flag = ((!flag2) ? (num <= num2) : (num >= num2));
			num++;
			array[num3] = func.apply(first[num3], second[num3]);
		}
		return array;
	}

	[Nemerle.Internal.Extension]
	public static Nemerle.Builtins.Tuple<First, Second>[] ZipToArray<First, Second>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<First> first, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] IEnumerable<Second> second)
	{
		if (second == null)
		{
			throw new ArgumentNullException("second", "The ``NotNull'' contract of parameter ``second'' has been violated. See lib\\Nemerle.Collections.n:172:83:172:89: .");
		}
		if (first == null)
		{
			throw new ArgumentNullException("first", "The ``NotNull'' contract of parameter ``first'' has been violated. See lib\\Nemerle.Collections.n:172:53:172:58: .");
		}
		Function<First, Second, Nemerle.Builtins.Tuple<First, Second>> instance = _N__N_lambda__22451__22465<First, Second>.Instance;
		return first.Map2ToArray(second, instance);
	}

	[Nemerle.Internal.Extension]
	public static Nemerle.Builtins.Tuple<First, Second>[] ZipToArray<First, Second>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this System.Collections.Generic.ICollection<First> first, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] System.Collections.Generic.ICollection<Second> second)
	{
		if (second == null)
		{
			throw new ArgumentNullException("second", "The ``NotNull'' contract of parameter ``second'' has been violated. See lib\\Nemerle.Collections.n:180:17:180:23: .");
		}
		if (first == null)
		{
			throw new ArgumentNullException("first", "The ``NotNull'' contract of parameter ``first'' has been violated. See lib\\Nemerle.Collections.n:179:22:179:27: .");
		}
		Function<First, Second, Nemerle.Builtins.Tuple<First, Second>> instance = _N__N_lambda__22480__22494<First, Second>.Instance;
		return first.Map2ToArray(second, instance);
	}

	[Nemerle.Internal.Extension]
	public static Nemerle.Builtins.Tuple<First, Second>[] ZipToArray<First, Second>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this First[] first, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Second[] second)
	{
		if (second == null)
		{
			throw new ArgumentNullException("second", "The ``NotNull'' contract of parameter ``second'' has been violated. See lib\\Nemerle.Collections.n:189:17:189:23: .");
		}
		if (first == null)
		{
			throw new ArgumentNullException("first", "The ``NotNull'' contract of parameter ``first'' has been violated. See lib\\Nemerle.Collections.n:188:22:188:27: .");
		}
		Function<First, Second, Nemerle.Builtins.Tuple<First, Second>> instance = _N__N_lambda__22509__22523<First, Second>.Instance;
		return first.Map2ToArray(second, instance);
	}

	[Nemerle.Internal.Extension]
	public static bool ForAll2<T1, T2>(this IEnumerable<T1> first, IEnumerable<T2> second, Function<T1, T2, bool> comparator)
	{
		Nemerle.Builtins.Tuple<IEnumerable<T1>, IEnumerable<T2>> tuple = new Nemerle.Builtins.Tuple<IEnumerable<T1>, IEnumerable<T2>>(first, second);
		bool result;
		IList<T1> first3;
		IList<T2> second3;
		if (tuple.Field0 is T1[])
		{
			T1[] first2 = (T1[])tuple.Field0;
			if (tuple.Field1 is T2[])
			{
				T2[] second2 = (T2[])tuple.Field1;
				result = first2.ForAll2(second2, comparator);
				goto IL_016a;
			}
			if (tuple.Field1 is IList<T2>)
			{
				first3 = (IList<T1>)tuple.Field0;
				second3 = (IList<T2>)tuple.Field1;
				goto IL_0076;
			}
		}
		else if (tuple.Field0 is IList<T1>)
		{
			first3 = (IList<T1>)tuple.Field0;
			if (tuple.Field1 is IList<T2>)
			{
				second3 = (IList<T2>)tuple.Field1;
				goto IL_0076;
			}
		}
		if (first == null)
		{
			result = second == null;
		}
		else if (second == null)
		{
			result = first == null;
		}
		else
		{
			IEnumerator<T1> enumerator = first.GetEnumerator();
			IEnumerator<T2> enumerator2 = second.GetEnumerator();
			bool flag3;
			try
			{
				int num;
				while (true)
				{
					bool flag = enumerator.MoveNext();
					bool flag2 = enumerator2.MoveNext();
					if (flag && flag2)
					{
						if (comparator.apply(enumerator.Current, enumerator2.Current))
						{
							continue;
						}
						num = 0;
						break;
					}
					num = ((flag == flag2) ? 1 : 0);
					break;
				}
				flag3 = (byte)num != 0;
			}
			finally
			{
				enumerator.Dispose();
				enumerator2.Dispose();
			}
			result = flag3;
		}
		goto IL_016a;
		IL_0076:
		result = first3.ForAll2(second3, comparator);
		goto IL_016a;
		IL_016a:
		return result;
	}

	[Nemerle.Internal.Extension]
	public static bool ForAll2<T1, T2>(this IList<T1> first, IList<T2> second, Function<T1, T2, bool> comparator)
	{
		int result;
		if (first is T1[] && second is T2[])
		{
			result = (((T1[])first).ForAll2((T2[])second, comparator) ? 1 : 0);
		}
		else if (first == second)
		{
			result = 1;
		}
		else if (first == null || second == null)
		{
			result = 0;
		}
		else if (first.Count != second.Count)
		{
			result = 0;
		}
		else
		{
			int i;
			for (i = 0; i < first.Count && comparator.apply(first[i], second[i]); i = checked(i + 1))
			{
			}
			result = ((i == first.Count) ? 1 : 0);
		}
		return (byte)result != 0;
	}

	[Nemerle.Internal.Extension]
	public static bool ForAll2<T1, T2>(this T1[] first, T2[] second, Function<T1, T2, bool> comparator)
	{
		int result;
		if (first == second)
		{
			result = 1;
		}
		else if (first == null || second == null)
		{
			result = 0;
		}
		else if (first.Length != second.Length)
		{
			result = 0;
		}
		else
		{
			int i;
			for (i = 0; i < first.Length && comparator.apply(first[i], second[i]); i = checked(i + 1))
			{
			}
			result = ((i == first.Length) ? 1 : 0);
		}
		return (byte)result != 0;
	}

	[Nemerle.Internal.Extension]
	public static bool IsEmpty(this ICollection seq)
	{
		return seq == null || seq.Count == 0;
	}

	[Nemerle.Internal.Extension]
	public static bool IsEmpty(this string str)
	{
		return str == null || str.Length == 0;
	}

	[Nemerle.Internal.Extension]
	public static bool IsEmpty<T>(this T[] seq)
	{
		return seq == null || seq.Length == 0;
	}

	[Nemerle.Internal.Extension]
	public static bool IsEmpty<T>(this list<T> seq)
	{
		return (object)seq == list<T>.Nil._N_constant_object || !(seq is list<T>.Cons);
	}

	[Nemerle.Internal.Extension]
	public static bool IsEmpty<T>(this IEnumerable<T> seq)
	{
		bool flag = false;
		int result;
		if (seq == list<T>.Nil._N_constant_object)
		{
			result = 1;
		}
		else if (seq is list<T>.Cons)
		{
			result = 0;
		}
		else if (seq is T[])
		{
			T[] seq2 = (T[])seq;
			result = (seq2.IsEmpty() ? 1 : 0);
		}
		else if (seq is ICollection)
		{
			ICollection seq3 = (ICollection)seq;
			result = (seq3.IsEmpty() ? 1 : 0);
		}
		else if (seq is string)
		{
			string str = (string)(object)seq;
			result = (str.IsEmpty() ? 1 : 0);
		}
		else if ((object)seq == null)
		{
			result = 1;
		}
		else
		{
			IEnumerator<T> enumerator = seq.GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					return false;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			result = 1;
		}
		return (byte)result != 0;
	}

	[Macro("Nemerle.Assertions.Requires:method:postscan", 0, "n <= source.Length@")]
	[Nemerle.Internal.Extension]
	[Macro("Nemerle.Assertions.Requires:method:postscan", 0, "n >= 0@")]
	public static T[] NLastN<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this T[] source, int n)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\Nemerle.Collections.n:300:37:300:43: .");
		}
		if (n > source.Length)
		{
			throw new AssertionException("lib\\Nemerle.Collections.n", 301, "n <= source.Length", "The ``Requires'' contract of method `NLastN' has been violated.".ToString());
		}
		if (n < 0)
		{
			throw new AssertionException("lib\\Nemerle.Collections.n", 301, "n >= 0", "The ``Requires'' contract of method `NLastN' has been violated.".ToString());
		}
		T[] array = new T[n];
		if (n > 0)
		{
			Array.Copy(source, checked(source.Length - n), array, 0, n);
		}
		return array;
	}

	[Nemerle.Internal.Extension]
	public static int NCount<T>(this IEnumerable<T> seq)
	{
		int result;
		if (seq is T[])
		{
			T[] array = (T[])seq;
			result = array.Length;
		}
		else if (seq is list<T>)
		{
			list<T> list = (list<T>)seq;
			result = list.Length;
		}
		else if (seq is List<T>)
		{
			List<T> list2 = (List<T>)seq;
			result = list2.Count;
		}
		else if (seq is IList<T>)
		{
			IList<T> list3 = (IList<T>)seq;
			result = list3.Count;
		}
		else if (seq is string)
		{
			string text = (string)(object)seq;
			result = text.Length;
		}
		else if ((object)seq == null)
		{
			result = 0;
		}
		else
		{
			int num = 0;
			IEnumerator<T> enumerator = seq.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					T val = default(T);
					T current = enumerator.Current;
					val = current;
					num = checked(num + 1);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			result = num;
		}
		return result;
	}

	[Nemerle.Internal.Extension]
	public static T NLast<T>(this IList<T> source)
	{
		return source[checked(source.Count - 1)];
	}

	[Nemerle.Internal.Extension]
	public static T NLast<T>(this T[] source)
	{
		return source[checked(source.Length - 1)];
	}

	[Nemerle.Internal.Extension]
	public static T NLast<T>(this IEnumerable<T> source)
	{
		bool flag = false;
		T result = default(T);
		IEnumerator<T> enumerator = source.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				flag = true;
				result = val;
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		if (flag)
		{
			return result;
		}
		throw new IndexOutOfRangeException();
	}

	[Nemerle.Internal.Extension]
	public static T NFirst<T>(this IList<T> source)
	{
		return source[0];
	}

	[Nemerle.Internal.Extension]
	public static T NFirst<T>(this T[] source)
	{
		return source[0];
	}

	[Nemerle.Internal.Extension]
	public static T NFirst<T>(this IEnumerable<T> source)
	{
		T val = default(T);
		IEnumerator<T> enumerator = source.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				T val2 = default(T);
				return enumerator.Current;
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		throw new IndexOutOfRangeException();
	}

	[Nemerle.Internal.Extension]
	public static IEnumerable<To> MapLazy<From, To>(this IEnumerable<From> source, Function<From, To> convert)
	{
		_N_Enumerable_22861<From, To> n_Enumerable_ = new _N_Enumerable_22861<From, To>();
		n_Enumerable_._N_source_22890 = source;
		n_Enumerable_._N_convert_22888 = convert;
		return n_Enumerable_;
	}

	[Nemerle.Internal.Extension]
	public static IEnumerable<To> MapLazyFiltered<From, To>(this IEnumerable<From> source, Function<From, bool> isMatch, Function<From, To> convert)
	{
		_N_Enumerable_22946<From, To> n_Enumerable_ = new _N_Enumerable_22946<From, To>();
		n_Enumerable_._N_source_22977 = source;
		n_Enumerable_._N_isMatch_22975 = isMatch;
		n_Enumerable_._N_convert_22973 = convert;
		return n_Enumerable_;
	}

	[Nemerle.Internal.Extension]
	public static IEnumerable<To> MapLazyFiltered<From, To>(this IEnumerable<From> source, Function<From, Nemerle.Builtins.Tuple<bool, To>> matchAndConvert)
	{
		_N_Enumerable_23036<From, To> n_Enumerable_ = new _N_Enumerable_23036<From, To>();
		n_Enumerable_._N_source_23065 = source;
		n_Enumerable_._N_matchAndConvert_23063 = matchAndConvert;
		return n_Enumerable_;
	}

	[Nemerle.Internal.Extension]
	public static IEnumerable<T> FilterLazy<T>(this IEnumerable<T> source, Function<T, bool> predicate)
	{
		_N_Enumerable_23130<T> n_Enumerable_ = new _N_Enumerable_23130<T>();
		n_Enumerable_._N_source_23159 = source;
		n_Enumerable_._N_predicate_23157 = predicate;
		return n_Enumerable_;
	}

	[Nemerle.Internal.Extension]
	public static IEnumerable<T> ExcludeLazy<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<T> source, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] IEnumerable<T> exclude)
	{
		_N_Enumerable_23228<T> n_Enumerable_ = new _N_Enumerable_23228<T>();
		n_Enumerable_._N_source_23257 = source;
		n_Enumerable_._N_exclude_23255 = exclude;
		return n_Enumerable_;
	}

	[Nemerle.Internal.Extension]
	public static void Iter<T>(this IEnumerable<T> source, FunctionVoid<T> action)
	{
		IEnumerator<T> enumerator = source.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				action.apply_void(val);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	[Nemerle.Internal.Extension]
	public static int FindIndex<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this T[] source, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Function<T, bool> isMatch)
	{
		int num = 0;
		if (isMatch == null)
		{
			throw new ArgumentNullException("isMatch", "The ``NotNull'' contract of parameter ``isMatch'' has been violated. See lib\\Nemerle.Collections.n:445:69:445:76: .");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\Nemerle.Collections.n:445:40:445:46: .");
		}
		for (num = 0; num < source.Length; num = checked(num + 1))
		{
			if (isMatch.apply(source[num]))
			{
				return num;
			}
		}
		return -1;
	}

	[Nemerle.Internal.Extension]
	public static int FindIndex<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IList<T> source, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Function<T, bool> isMatch)
	{
		int num = 0;
		if (isMatch == null)
		{
			throw new ArgumentNullException("isMatch", "The ``NotNull'' contract of parameter ``isMatch'' has been violated. See lib\\Nemerle.Collections.n:454:73:454:80: .");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\Nemerle.Collections.n:454:40:454:46: .");
		}
		for (num = 0; num < source.Count; num = checked(num + 1))
		{
			if (isMatch.apply(source[num]))
			{
				return num;
			}
		}
		return -1;
	}

	[Nemerle.Internal.Extension]
	public static int FindIndex<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this List<T> source, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Function<T, bool> isMatch)
	{
		int num = 0;
		if (isMatch == null)
		{
			throw new ArgumentNullException("isMatch", "The ``NotNull'' contract of parameter ``isMatch'' has been violated. See lib\\Nemerle.Collections.n:463:72:463:79: .");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\Nemerle.Collections.n:463:40:463:46: .");
		}
		for (num = 0; num < source.Count; num = checked(num + 1))
		{
			if (isMatch.apply(source[num]))
			{
				return num;
			}
		}
		return -1;
	}

	[Nemerle.Internal.Extension]
	public static TAccumulator FoldLeft<TAccumulator, T>(this IEnumerable<T> source, TAccumulator ini, Function<T, TAccumulator, TAccumulator> convert)
	{
		IEnumerator<T> enumerator = source.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				ini = convert.apply(val, ini);
			}
			return ini;
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	[Nemerle.Internal.Extension]
	public static TAccumulator FoldRight<TAccumulator, T>(this IEnumerable<T> source, TAccumulator ini, Function<T, TAccumulator, TAccumulator> convert)
	{
		int num = 0;
		T[] array = source.NToArray();
		checked
		{
			for (num = array.Length - 1; num >= 0; num--)
			{
				ini = convert.apply(array[num], ini);
			}
			return ini;
		}
	}

	[Nemerle.Internal.Extension]
	public static TAccumulator Fold<TAccumulator, T>(this IEnumerable<T> source, TAccumulator ini, Function<T, TAccumulator, TAccumulator> convert)
	{
		return source.FoldLeft(ini, convert);
	}

	[Nemerle.Internal.Extension]
	public static int BinarySearch<TElem>(this TElem[] collection, int lo, int hi, Function<TElem, int> comparer)
	{
		checked
		{
			int result;
			while (true)
			{
				if (lo <= hi)
				{
					int num = lo + hi >> 1;
					int num2 = comparer.apply(collection[num]);
					if (num2 == 0)
					{
						result = num;
						break;
					}
					if (num2 < 0)
					{
						TElem[] obj = collection;
						int num3 = num + 1;
						int num4 = hi;
						comparer = comparer;
						hi = num4;
						lo = num3;
						collection = obj;
					}
					else
					{
						TElem[] obj2 = collection;
						int num5 = lo;
						int num6 = num - 1;
						comparer = comparer;
						hi = num6;
						lo = num5;
						collection = obj2;
					}
					continue;
				}
				result = ~lo;
				break;
			}
			return result;
		}
	}

	[Nemerle.Internal.Extension]
	public static int BinarySearch<TElem>(this TElem[] collection, Function<TElem, int> comparer)
	{
		return BinarySearch(collection, 0, checked(collection.Length - 1), comparer);
	}

	[Nemerle.Internal.Extension]
	public static int BinarySearch<TElem>(this IList<TElem> collection, int lo, int hi, Function<TElem, int> comparer)
	{
		checked
		{
			int result;
			while (true)
			{
				if (lo <= hi)
				{
					int num = lo + hi >> 1;
					int num2 = comparer.apply(collection[num]);
					if (num2 == 0)
					{
						result = num;
						break;
					}
					if (num2 < 0)
					{
						IList<TElem> obj = collection;
						int num3 = num + 1;
						int num4 = hi;
						comparer = comparer;
						hi = num4;
						lo = num3;
						collection = obj;
					}
					else
					{
						IList<TElem> obj2 = collection;
						int num5 = lo;
						int num6 = num - 1;
						comparer = comparer;
						hi = num6;
						lo = num5;
						collection = obj2;
					}
					continue;
				}
				result = ~lo;
				break;
			}
			return result;
		}
	}

	[Nemerle.Internal.Extension]
	public static int BinarySearch<TElem>(this IList<TElem> collection, Function<TElem, int> comparer)
	{
		return collection.BinarySearch(0, checked(collection.Count - 1), comparer);
	}

	[Nemerle.Internal.Extension]
	public static list<T> NToList<T>(this T[] source)
	{
		return source.ToNList();
	}

	[Nemerle.Internal.Extension]
	public static list<T> ToNList<T>(this List<T> source)
	{
		return source.NToList();
	}

	[Nemerle.Internal.Extension]
	public static list<T> NToList<T>(this List<T> source)
	{
		checked
		{
			int num = source.Count - 1;
			list<T> list = list<T>.Nil._N_constant_object;
			while (num >= 0)
			{
				int num2 = num - 1;
				list = new list<T>.Cons(source[num], list);
				num = num2;
			}
			return list;
		}
	}

	[Nemerle.Internal.Extension]
	public static list<T> NToList<T>(this IEnumerable<T> source)
	{
		return new List<T>(source).NToList();
	}

	[Nemerle.Internal.Extension]
	public static T[] NToArray<T>(this System.Collections.Generic.ICollection<T> source)
	{
		T[] result;
		if (source == null)
		{
			result = new T[0];
		}
		else
		{
			T[] array = new T[source.Count];
			source.CopyTo(array, 0);
			result = array;
		}
		return result;
	}

	[Nemerle.Internal.Extension]
	public static T[] NToArray<T>(this IEnumerable<T> source)
	{
		T[] result;
		if (source is System.Collections.Generic.ICollection<T>)
		{
			System.Collections.Generic.ICollection<T> source2 = (System.Collections.Generic.ICollection<T>)source;
			result = source2.NToArray();
		}
		else if ((object)source == null)
		{
			result = new T[0];
		}
		else
		{
			List<T> list = new List<T>();
			IEnumerator<T> enumerator = source.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					T val = default(T);
					T current = enumerator.Current;
					val = current;
					list.Add(val);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			result = list.NToArray();
		}
		return result;
	}

	[Nemerle.Internal.Extension]
	public static To[] UpCastToArray<From, To>(this System.Collections.Generic.ICollection<From> source) where From : class where To : class, From
	{
		To[] result;
		if ((object)source == null)
		{
			result = new To[0];
		}
		else if (source is From[])
		{
			From[] from = (From[])source;
			Function<From, To> instance = _N__N_lambda__23533__23547<From, To>.Instance;
			result = from.Map(instance);
		}
		else if (source.Count == 0)
		{
			result = new To[0];
		}
		else
		{
			To[] array = new To[source.Count];
			source.CopyTo(array.ToBase<To, From>(), 0);
			result = array;
		}
		return result;
	}

	[Nemerle.Internal.Extension]
	public static To[] MapToArray<From, To>(this IEnumerable<From> source, Function<From, To> convert)
	{
		To[] result;
		if ((object)source == null)
		{
			result = new To[0];
		}
		else if (source is From[])
		{
			From[] from = (From[])source;
			result = from.Map(convert);
		}
		else if (source is System.Collections.Generic.ICollection<From>)
		{
			System.Collections.Generic.ICollection<From> collection = (System.Collections.Generic.ICollection<From>)source;
			From[] array = new From[collection.Count];
			collection.CopyTo(array, 0);
			result = array.Map(convert);
		}
		else
		{
			List<To> list = new List<To>();
			IEnumerator<From> enumerator = source.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					From val = default(From);
					From current = enumerator.Current;
					val = current;
					list.Add(convert.apply(val));
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			result = list.NToArray();
		}
		return result;
	}

	[Nemerle.Internal.Extension]
	public static To[] ConvertToArray<From, To>(this IEnumerable<From> source, Function<From, To> convert)
	{
		return source.MapToArray(convert);
	}

	[Nemerle.Internal.Extension]
	public static T[] ToArrayFiltered<T>(this IEnumerable<T> source, Function<T, bool> isMatch)
	{
		return source.NToArrayFiltered(isMatch);
	}

	[Nemerle.Internal.Extension]
	public static T[] NToArrayFiltered<T>(this IEnumerable<T> source, Function<T, bool> isMatch)
	{
		T[] result;
		if ((object)source == null)
		{
			result = new T[0];
		}
		else
		{
			List<T> list = new List<T>();
			IEnumerator<T> enumerator = source.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					T val = default(T);
					T current = enumerator.Current;
					val = current;
					if (isMatch.apply(val))
					{
						list.Add(val);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			result = list.NToArray();
		}
		return result;
	}

	private static To[] InternalMapToArrayFiltered<From, To>(From[] source, Function<From, bool> isMatch, Function<From, To> convert)
	{
		int num = 0;
		From val = default(From);
		List<To> list = new List<To>(source.Length);
		for (num = 0; num < source.Length; num = checked(num + 1))
		{
			val = source[num];
			val = val;
			if (isMatch.apply(val))
			{
				list.Add(convert.apply(val));
			}
		}
		return list.NToArray();
	}

	[Nemerle.Internal.Extension]
	public static To[] MapToArrayFiltered<From, To>(this From[] source, Function<From, bool> isMatch, Function<From, To> convert)
	{
		From val = default(From);
		object result;
		if (source == null || source.Length == 0)
		{
			result = new To[0];
		}
		else if (source.Length == 1)
		{
			val = source[0];
			result = ((!isMatch.apply(val)) ? new To[0] : new To[1] { convert.apply(val) });
		}
		else
		{
			result = InternalMapToArrayFiltered(source, isMatch, convert);
		}
		return (To[])result;
	}

	[Nemerle.Internal.Extension]
	public static To[] MapToArrayFiltered<From, To>(this IEnumerable<From> source, Function<From, bool> isMatch, Function<From, To> convert)
	{
		To[] result;
		if ((object)source == null)
		{
			result = new To[0];
		}
		else if (source is From[])
		{
			From[] source2 = (From[])source;
			result = InternalMapToArrayFiltered(source2, isMatch, convert);
		}
		else
		{
			List<To> list = new List<To>();
			IEnumerator<From> enumerator = source.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					From val = default(From);
					From current = enumerator.Current;
					val = current;
					if (isMatch.apply(val))
					{
						list.Add(convert.apply(val));
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			result = list.NToArray();
		}
		return result;
	}

	[Nemerle.Internal.Extension]
	public static To[] ConvertToArrayFiltered<From, To>(this IEnumerable<From> source, Function<From, bool> isMatch, Function<From, To> convert)
	{
		return source.MapToArrayFiltered(isMatch, convert);
	}

	[Nemerle.Internal.Extension]
	public static list<To> MapToList<From, To>(this From[] source, Function<From, To> convert)
	{
		int num = 0;
		list<To> list = null;
		checked
		{
			object result;
			if ((object)source == null)
			{
				result = list<To>.Nil._N_constant_object;
			}
			else
			{
				list = list<To>.Nil._N_constant_object;
				for (num = source.Length - 1; num >= 0; num--)
				{
					list = new list<To>.Cons(convert.apply(source[num]), list);
				}
				result = list;
			}
			return (list<To>)result;
		}
	}

	[Nemerle.Internal.Extension]
	public static list<To> MapToList<From, To>(this IList<From> source, Function<From, To> convert)
	{
		int num = 0;
		list<To> list = null;
		checked
		{
			object result;
			if ((object)source == null)
			{
				result = list<To>.Nil._N_constant_object;
			}
			else if (source is From[])
			{
				result = ((From[])source).MapToList(convert);
			}
			else
			{
				list = list<To>.Nil._N_constant_object;
				for (num = source.Count - 1; num >= 0; num--)
				{
					list = new list<To>.Cons(convert.apply(source[num]), list);
				}
				result = list;
			}
			return (list<To>)result;
		}
	}

	[Nemerle.Internal.Extension]
	public static list<To> MapToList<From, To>(this IEnumerable<From> source, Function<From, To> convert)
	{
		object result;
		if ((object)source == null)
		{
			result = list<To>.Nil._N_constant_object;
		}
		else if (source is From[])
		{
			From[] source2 = (From[])source;
			result = source2.MapToList(convert);
		}
		else if (source is IList<From>)
		{
			IList<From> source3 = (IList<From>)source;
			result = source3.MapToList(convert);
		}
		else
		{
			List<To> list = new List<To>();
			IEnumerator<From> enumerator = source.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					From val = default(From);
					From current = enumerator.Current;
					val = current;
					list.Add(convert.apply(val));
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			result = list.NToList();
		}
		return (list<To>)result;
	}

	[Nemerle.Internal.Extension]
	public static list<To> Map<From, To>(this IEnumerable<From> source, Function<From, To> convert)
	{
		return source.MapToList(convert);
	}

	[Nemerle.Internal.Extension]
	public static list<T> Filter<T>(this IEnumerable<T> seq, Function<T, bool> predicate)
	{
		list<T>.Cons cons = null;
		list<T>.Cons cons2 = null;
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (predicate.apply(val))
				{
					list<T>.Cons cons3 = new list<T>.Cons(val, list<T>.Nil._N_constant_object);
					if (cons == null)
					{
						cons = cons3;
						cons2 = cons3;
					}
					else
					{
						cons2.tl = cons3;
						cons2 = cons3;
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return (!(cons == null)) ? ((list<T>)cons) : ((list<T>)list<T>.Nil._N_constant_object);
	}

	[Nemerle.Internal.Extension]
	public static T[] FilterToArray<T>(this T[] source, Function<T, bool> isMatch)
	{
		T val = default(T);
		object result;
		if (source == null || source.Length == 0)
		{
			result = new T[0];
		}
		else if (source.Length == 1)
		{
			val = source[0];
			result = ((!isMatch.apply(val)) ? new T[0] : new T[1] { val });
		}
		else
		{
			result = InternalFilterToArray(source, isMatch);
		}
		return (T[])result;
	}

	[Nemerle.Internal.Extension]
	public static T[] FilterToArray<T>(this IEnumerable<T> source, Function<T, bool> isMatch)
	{
		T[] result;
		if ((object)source == null)
		{
			result = new T[0];
		}
		else if (source is T[])
		{
			T[] source2 = (T[])source;
			result = InternalFilterToArray(source2, isMatch);
		}
		else
		{
			List<T> list = new List<T>();
			IEnumerator<T> enumerator = source.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					T val = default(T);
					T current = enumerator.Current;
					val = current;
					if (isMatch.apply(val))
					{
						list.Add(val);
					}
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			result = list.NToArray();
		}
		return result;
	}

	private static T[] InternalFilterToArray<T>(T[] source, Function<T, bool> isMatch)
	{
		int num = 0;
		T val = default(T);
		List<T> list = new List<T>(source.Length);
		for (num = 0; num < source.Length; num = checked(num + 1))
		{
			val = source[num];
			val = val;
			if (isMatch.apply(val))
			{
				list.Add(val);
			}
		}
		return list.NToArray();
	}

	[Nemerle.Internal.Extension]
	public static string ToString<T>(this IEnumerable<T> source, string separator)
	{
		string text = null;
		if (source == null)
		{
			return "";
		}
		bool flag = true;
		StringBuilder stringBuilder = new StringBuilder();
		IEnumerator<T> enumerator = source.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(separator);
				}
				stringBuilder.Append(val);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return stringBuilder.ToString();
	}

	[Nemerle.Internal.Extension]
	public static T RightHand<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IList<T> source, int index) where T : new()
	{
		T val = default(T);
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\Nemerle.Collections.n:902:40:902:46: .");
		}
		int num = checked(index + 1);
		return (num < source.Count) ? source[num] : ((val != null) ? val : new T());
	}

	[Nemerle.Internal.Extension]
	public static T LeftHand<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IList<T> source, int index) where T : new()
	{
		T val = default(T);
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\Nemerle.Collections.n:910:39:910:45: .");
		}
		int num = checked(index - 1);
		return (num >= 0) ? source[num] : ((val != null) ? val : new T());
	}

	[Nemerle.Internal.Extension]
	public static List<T> NReverse<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<T> seq)
	{
		if (seq == null)
		{
			throw new ArgumentNullException("seq", "The ``NotNull'' contract of parameter ``seq'' has been violated. See lib\\Nemerle.Collections.n:917:39:917:42: .");
		}
		List<T> list = new List<T>(seq);
		list.Reverse();
		return list;
	}

	[Nemerle.Internal.Extension]
	public static option<T> Find<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<T> seq, Function<T, bool> predicate)
	{
		option<T> option = null;
		if (seq == null)
		{
			throw new ArgumentNullException("seq", "The ``NotNull'' contract of parameter ``seq'' has been violated. See lib\\Nemerle.Collections.n:924:35:924:38: .");
		}
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (predicate.apply(val))
				{
					return new option<T>.Some(val);
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return option<T>.None._N_constant_object;
	}

	[Nemerle.Internal.Extension]
	public static T FindObject<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<T> seq, Function<T, bool> predicate) where T : class
	{
		T val = null;
		if (seq == null)
		{
			throw new ArgumentNullException("seq", "The ``NotNull'' contract of parameter ``seq'' has been violated. See lib\\Nemerle.Collections.n:934:41:934:44: .");
		}
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val2 = null;
				T current = enumerator.Current;
				val2 = current;
				if (predicate.apply(val2))
				{
					return val2;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return null;
	}

	[Nemerle.Internal.Extension]
	public static T? FindValue<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<T> seq, Function<T, bool> predicate) where T : struct
	{
		T? val = null;
		if (seq == null)
		{
			throw new ArgumentNullException("seq", "The ``NotNull'' contract of parameter ``seq'' has been violated. See lib\\Nemerle.Collections.n:944:40:944:43: .");
		}
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val2 = default(T);
				T current = enumerator.Current;
				val2 = current;
				if (predicate.apply(val2))
				{
					return val2;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return null;
	}

	[Nemerle.Internal.Extension]
	public static T[] Append<T>(this T[] source, T value)
	{
		int length = source.Length;
		Array.Resize(ref source, checked(length + 1));
		source[length] = value;
		return source;
	}

	[Nemerle.Internal.Extension]
	public static T[] Append<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this T[] source, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] T[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value", "The ``NotNull'' contract of parameter ``value'' has been violated. See lib\\Nemerle.Collections.n:962:74:962:79: .");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source", "The ``NotNull'' contract of parameter ``source'' has been violated. See lib\\Nemerle.Collections.n:962:45:962:51: .");
		}
		int newSize = checked(source.Length + value.Length);
		int length = source.Length;
		Array.Resize(ref source, newSize);
		value.CopyTo(source, length);
		return source;
	}

	[Nemerle.Internal.Extension]
	public static void Iter<T>(this T[] arr, FunctionVoid<T> f)
	{
		for (int i = 0; i < arr.Length; i = checked(i + 1))
		{
			f.apply_void(arr[i]);
		}
	}

	[Nemerle.Internal.Extension]
	public static T[] ChopFirstN<T>(this T[] arr, int n)
	{
		if (arr.Length < n)
		{
			throw new ArgumentException("ChopFirstN called for too short array");
		}
		T[] array = new T[checked(arr.Length - n)];
		Array.Copy(arr, n, array, 0, array.Length);
		return array;
	}

	[Nemerle.Internal.Extension]
	public static T[] ChopLastN<T>(this T[] arr, int n)
	{
		if (arr.Length < n)
		{
			throw new ArgumentException("LastFirstN called for too short array");
		}
		T[] array = new T[checked(arr.Length - n)];
		Array.Copy(arr, 0, array, 0, array.Length);
		return array;
	}

	[Nemerle.Internal.Extension]
	public static void IterI<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<T> seq, FunctionVoid<int, T> f)
	{
		if (seq == null)
		{
			throw new ArgumentNullException("seq", "The ``NotNull'' contract of parameter ``seq'' has been violated. See lib\\Nemerle.Collections.n:1015:36:1015:39: .");
		}
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			int num = 0;
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				f.apply_void(new Nemerle.Builtins.Tuple<int, T>(num, val));
				num = checked(num + 1);
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	}

	[Nemerle.Internal.Extension]
	public static void IterI<T>(this T[] arr, FunctionVoid<int, T> f)
	{
		for (int i = 0; i < arr.Length; i = checked(i + 1))
		{
			f.apply_void(new Nemerle.Builtins.Tuple<int, T>(i, arr[i]));
		}
	}

	[Nemerle.Internal.Extension]
	public static To[] Map<From, To>(this From[] from, Function<From, To> f)
	{
		int num = 0;
		To[] result;
		if (from == null)
		{
			result = new To[0];
		}
		else
		{
			To[] array = new To[from.Length];
			for (num = 0; num < from.Length; num = checked(num + 1))
			{
				array[num] = f.apply(from[num]);
			}
			result = array;
		}
		return result;
	}

	[Nemerle.Internal.Extension]
	public static To[] ConvertAll<From, To>(this From[] source, Function<From, To> f)
	{
		return source.Map(f);
	}

	public static To[] Map<From, To>(Type res_type, From[] ar, Function<From, To> f)
	{
		if (!typeof(To).Equals(res_type))
		{
			throw new AssertionException("lib\\Nemerle.Collections.n", 1059, "typeof (To).Equals(res_type)", "");
		}
		return ar.Map(f);
	}

	[Nemerle.Internal.Extension]
	public static TAccumulator Fold<TAccumulator, T>(this T[] arr, TAccumulator ini, Function<T, TAccumulator, TAccumulator> f)
	{
		TAccumulator val = default(TAccumulator);
		val = ini;
		int num = 0;
		while (num < arr.Length)
		{
			TAccumulator val2 = f.apply(arr[num], val);
			num = checked(num + 1);
			val = val2;
		}
		return val;
	}

	[Nemerle.Internal.Extension]
	public static TAccumulator FoldI<TAccumulator, T>(this T[] arr, TAccumulator ini, Function<int, T, TAccumulator, TAccumulator> f)
	{
		TAccumulator val = default(TAccumulator);
		val = ini;
		int num = 0;
		while (num < arr.Length)
		{
			TAccumulator val2 = f.apply(num, arr[num], val);
			num = checked(num + 1);
			val = val2;
		}
		return val;
	}

	[Nemerle.Internal.Extension]
	public static bool Exists<T>([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] this IEnumerable<T> seq, Function<T, bool> predicate)
	{
		bool flag = false;
		if (seq == null)
		{
			throw new ArgumentNullException("seq", "The ``NotNull'' contract of parameter ``seq'' has been violated. See lib\\Nemerle.Collections.n:1090:37:1090:40: .");
		}
		IEnumerator<T> enumerator = seq.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				T val = default(T);
				T current = enumerator.Current;
				val = current;
				if (predicate.apply(val))
				{
					return true;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return false;
	}

	[Nemerle.Internal.Extension]
	public static bool Exists<T>(this T[] a, Function<T, bool> f)
	{
		int num = 0;
		int result;
		while (true)
		{
			if (num < a.Length)
			{
				if (f.apply(a[num]))
				{
					result = 1;
					break;
				}
				num = checked(num + 1);
				continue;
			}
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	[Nemerle.Internal.Extension]
	public static bool ForAll<T>(this T[] a, Function<T, bool> f)
	{
		int num = 0;
		int result;
		while (true)
		{
			if (num >= a.Length)
			{
				result = 1;
				break;
			}
			if (f.apply(a[num]))
			{
				num = checked(num + 1);
				continue;
			}
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	public static T[] FromList<T>(Type t, list<T> x)
	{
		if (!t.Equals(typeof(T)))
		{
			throw new AssertionException("lib\\Nemerle.Collections.n", 1139, "t.Equals(typeof (T))", "");
		}
		return x.NToArray();
	}

	[Nemerle.Internal.Extension]
	public static list<T> ToNList<T>(this T[] arr)
	{
		return NList.FromArray(arr);
	}

	[Nemerle.Internal.Extension]
	public static void Iter2<TFirst, TSecond>(this list<TFirst> a, TSecond[] b, FunctionVoid<TFirst, TSecond> f)
	{
		TFirst val = default(TFirst);
		list<TFirst> list = a;
		int num = 0;
		while (true)
		{
			if ((object)list == list<TFirst>.Nil._N_constant_object)
			{
				return;
			}
			if (!(list is list<TFirst>.Cons))
			{
				break;
			}
			val = ((list<TFirst>.Cons)list).hd;
			list = ((list<TFirst>.Cons)list).tl;
			f.apply_void(new Nemerle.Builtins.Tuple<TFirst, TSecond>(val, b[num]));
			list<TFirst> obj = list;
			num = checked(num + 1);
			list = obj;
		}
		throw new MatchFailureException();
	}

	[Nemerle.Internal.Extension]
	public static void Iter2<TFirst, TSecond>(this TFirst[] a, list<TSecond> b, FunctionVoid<TFirst, TSecond> f)
	{
		TSecond val = default(TSecond);
		list<TSecond> list = b;
		int num = 0;
		while (true)
		{
			if ((object)list == list<TSecond>.Nil._N_constant_object)
			{
				return;
			}
			if (!(list is list<TSecond>.Cons))
			{
				break;
			}
			val = ((list<TSecond>.Cons)list).hd;
			list = ((list<TSecond>.Cons)list).tl;
			f.apply_void(new Nemerle.Builtins.Tuple<TFirst, TSecond>(a[num], val));
			list<TSecond> obj = list;
			num = checked(num + 1);
			list = obj;
		}
		throw new MatchFailureException();
	}

	[Nemerle.Internal.Extension]
	public static void Iter2<TFirst, TSecond>(this IEnumerable<TFirst> a, IEnumerable<TSecond> b, FunctionVoid<TFirst, TSecond> f)
	{
		IEnumerator<TFirst> enumerator = a.GetEnumerator();
		IEnumerator<TSecond> enumerator2 = b.GetEnumerator();
		try
		{
			IEnumerator<TFirst> enumerator3 = enumerator;
			IEnumerator<TSecond> enumerator4 = enumerator2;
			bool flag;
			bool flag2;
			while (true)
			{
				flag = enumerator3.MoveNext();
				flag2 = enumerator4.MoveNext();
				if (!flag || !flag2)
				{
					break;
				}
				f.apply_void(new Nemerle.Builtins.Tuple<TFirst, TSecond>(enumerator3.Current, enumerator4.Current));
				IEnumerator<TFirst> obj = enumerator3;
				enumerator4 = enumerator4;
				enumerator3 = obj;
			}
			if (flag != flag2)
			{
				throw new ArgumentException("Arguments has different length");
			}
		}
		finally
		{
			enumerator.Dispose();
			enumerator2.Dispose();
		}
	}

	public static void IterX<T>(FunctionVoid<T[]> f, params IEnumerable<T>[] sources)
	{
		IEnumerator<T>[] array = new IEnumerator<T>[sources.Length];
		checked
		{
			for (int i = 0; i < sources.Length; i++)
			{
				IEnumerable<T> enumerable = sources[i];
				IEnumerable<T> enumerable2 = enumerable;
				array[i] = enumerable2.GetEnumerator();
			}
			try
			{
				IEnumerator<T>[] array2 = array;
				while (true)
				{
					bool flag = false;
					IEnumerator<T>[] array3 = array2;
					for (int j = 0; j < array3.Length; j++)
					{
						IEnumerator<T> enumerator = array3[j];
						IEnumerator<T> enumerator2 = enumerator;
						if (j == 0)
						{
							flag = enumerator2.MoveNext();
						}
						else if (flag != enumerator2.MoveNext())
						{
							throw new ArgumentException("Arguments has different length", "sources");
						}
					}
					if (flag)
					{
						T[] array4 = new T[array2.Length];
						IEnumerator<T>[] array5 = array2;
						for (int k = 0; k < array5.Length; k++)
						{
							IEnumerator<T> enumerator3 = array5[k];
							IEnumerator<T> enumerator4 = enumerator3;
							array4[k] = enumerator4.Current;
						}
						f.apply_void(array4);
						array2 = array2;
						continue;
					}
					break;
				}
			}
			finally
			{
				IEnumerator<T>[] array6 = array;
				foreach (IEnumerator<T> enumerator5 in array6)
				{
					IEnumerator<T> enumerator6 = enumerator5;
					enumerator6.Dispose();
				}
			}
		}
	}

	[Nemerle.Internal.Extension]
	public static list<TResult> Map2<TFirst, TSecond, TResult>(this list<TFirst> a, TSecond[] b, Function<TFirst, TSecond, TResult> f)
	{
		_N_closureOf_Map2_24490<TFirst, TSecond, TResult> n_closureOf_Map2_ = new _N_closureOf_Map2_24490<TFirst, TSecond, TResult>();
		n_closureOf_Map2_._N_b_24497 = b;
		n_closureOf_Map2_._N_f_24495 = f;
		return _N_loop_24500(n_closureOf_Map2_, a, 0);
	}

	[Nemerle.Internal.Extension]
	public static list<TResult> Map2<TFirst, TSecond, TResult>(this TFirst[] a, list<TSecond> b, Function<TFirst, TSecond, TResult> f)
	{
		_N_closureOf_Map2_24521<TFirst, TSecond, TResult> n_closureOf_Map2_ = new _N_closureOf_Map2_24521<TFirst, TSecond, TResult>();
		n_closureOf_Map2_._N_a_24528 = a;
		n_closureOf_Map2_._N_f_24526 = f;
		return _N_loop_24531(n_closureOf_Map2_, b, 0);
	}

	[Nemerle.Internal.Extension]
	public static list<TResult> RevMap2<TFirst, TSecond, TResult>(this list<TFirst> a, TSecond[] b, Function<TFirst, TSecond, TResult> f)
	{
		TFirst val = default(TFirst);
		list<TFirst> list = a;
		int num = 0;
		list<TResult> list2 = list<TResult>.Nil._N_constant_object;
		while (true)
		{
			if ((object)list == list<TFirst>.Nil._N_constant_object)
			{
				return list2;
			}
			if (!(list is list<TFirst>.Cons))
			{
				break;
			}
			val = ((list<TFirst>.Cons)list).hd;
			list = ((list<TFirst>.Cons)list).tl;
			list<TFirst> obj = list;
			int num2 = checked(num + 1);
			list2 = new list<TResult>.Cons(f.apply(val, b[num]), list2);
			num = num2;
			list = obj;
		}
		throw new MatchFailureException();
	}

	[Nemerle.Internal.Extension]
	public static list<TResult> RevMap2<TFirst, TSecond, TResult>(this TFirst[] a, list<TSecond> b, Function<TFirst, TSecond, TResult> f)
	{
		TSecond val = default(TSecond);
		list<TSecond> list = b;
		int num = 0;
		list<TResult> list2 = list<TResult>.Nil._N_constant_object;
		while (true)
		{
			if ((object)list == list<TSecond>.Nil._N_constant_object)
			{
				return list2;
			}
			if (!(list is list<TSecond>.Cons))
			{
				break;
			}
			val = ((list<TSecond>.Cons)list).hd;
			list = ((list<TSecond>.Cons)list).tl;
			list<TSecond> obj = list;
			int num2 = checked(num + 1);
			list2 = new list<TResult>.Cons(f.apply(a[num], val), list2);
			num = num2;
			list = obj;
		}
		throw new MatchFailureException();
	}

	[Nemerle.Internal.Extension]
	public static TResult FoldLeft2<TFirst, TSecond, TResult>(this list<TFirst> a, TSecond[] b, TResult acc, Function<TFirst, TSecond, TResult, TResult> f)
	{
		TResult val = default(TResult);
		TFirst val2 = default(TFirst);
		list<TFirst> list = a;
		int num = 0;
		val = acc;
		while (true)
		{
			if ((object)list == list<TFirst>.Nil._N_constant_object)
			{
				return val;
			}
			if (!(list is list<TFirst>.Cons))
			{
				break;
			}
			val2 = ((list<TFirst>.Cons)list).hd;
			list = ((list<TFirst>.Cons)list).tl;
			list<TFirst> obj = list;
			int num2 = checked(num + 1);
			val = f.apply(val2, b[num], val);
			num = num2;
			list = obj;
		}
		throw new MatchFailureException();
	}

	[Nemerle.Internal.Extension]
	public static TResult FoldLeft2<TFirst, TSecond, TResult>(this TFirst[] a, list<TSecond> b, TResult acc, Function<TFirst, TSecond, TResult, TResult> f)
	{
		TResult val = default(TResult);
		TSecond val2 = default(TSecond);
		list<TSecond> list = b;
		int num = 0;
		val = acc;
		while (true)
		{
			if ((object)list == list<TSecond>.Nil._N_constant_object)
			{
				return val;
			}
			if (!(list is list<TSecond>.Cons))
			{
				break;
			}
			val2 = ((list<TSecond>.Cons)list).hd;
			list = ((list<TSecond>.Cons)list).tl;
			list<TSecond> obj = list;
			int num2 = checked(num + 1);
			val = f.apply(a[num], val2, val);
			num = num2;
			list = obj;
		}
		throw new MatchFailureException();
	}

	[Nemerle.Internal.Extension]
	public static TResult FoldRight2<TFirst, TSecond, TResult>(this list<TFirst> a, TSecond[] b, TResult c, Function<TFirst, TSecond, TResult, TResult> f)
	{
		_N_closureOf_FoldRight2_24624<TFirst, TSecond, TResult> n_closureOf_FoldRight2_ = new _N_closureOf_FoldRight2_24624<TFirst, TSecond, TResult>();
		n_closureOf_FoldRight2_._N_b_24631 = b;
		n_closureOf_FoldRight2_._N_f_24629 = f;
		return _N_loop_24634(n_closureOf_FoldRight2_, a, 0, c);
	}

	[Nemerle.Internal.Extension]
	public static TResult FoldRight2<TFirst, TSecond, TResult>(this TFirst[] a, list<TSecond> b, TResult c, Function<TFirst, TSecond, TResult, TResult> f)
	{
		_N_closureOf_FoldRight2_24657<TFirst, TSecond, TResult> n_closureOf_FoldRight2_ = new _N_closureOf_FoldRight2_24657<TFirst, TSecond, TResult>();
		n_closureOf_FoldRight2_._N_a_24664 = a;
		n_closureOf_FoldRight2_._N_f_24662 = f;
		return _N_loop_24667(n_closureOf_FoldRight2_, b, 0, c);
	}

	[Nemerle.Internal.Extension]
	public static bool ForAll2<TFirst, TSecond>(this list<TFirst> a, TSecond[] b, Function<TFirst, TSecond, bool> f)
	{
		TFirst val = default(TFirst);
		list<TFirst> list = a;
		int num = 0;
		int result;
		while (true)
		{
			if ((object)list == list<TFirst>.Nil._N_constant_object)
			{
				result = 1;
				break;
			}
			if (list is list<TFirst>.Cons)
			{
				val = ((list<TFirst>.Cons)list).hd;
				list = ((list<TFirst>.Cons)list).tl;
				if (f.apply(val, b[num]))
				{
					list<TFirst> obj = list;
					num = checked(num + 1);
					list = obj;
					continue;
				}
				result = 0;
				break;
			}
			throw new MatchFailureException();
		}
		return (byte)result != 0;
	}

	[Nemerle.Internal.Extension]
	public static bool ForAll2<TFirst, TSecond>(this TFirst[] a, list<TSecond> b, Function<TFirst, TSecond, bool> f)
	{
		TSecond val = default(TSecond);
		list<TSecond> list = b;
		int num = 0;
		int result;
		while (true)
		{
			if ((object)list == list<TSecond>.Nil._N_constant_object)
			{
				result = 1;
				break;
			}
			if (list is list<TSecond>.Cons)
			{
				val = ((list<TSecond>.Cons)list).hd;
				list = ((list<TSecond>.Cons)list).tl;
				if (f.apply(a[num], val))
				{
					list<TSecond> obj = list;
					num = checked(num + 1);
					list = obj;
					continue;
				}
				result = 0;
				break;
			}
			throw new MatchFailureException();
		}
		return (byte)result != 0;
	}

	[Nemerle.Internal.Extension]
	public static bool Exists2<TFirst, TSecond>(this TFirst[] a, list<TSecond> b, Function<TFirst, TSecond, bool> f)
	{
		TSecond val = default(TSecond);
		list<TSecond> list = b;
		int num = 0;
		int result;
		while (true)
		{
			if ((object)list == list<TSecond>.Nil._N_constant_object)
			{
				result = 0;
				break;
			}
			if (list is list<TSecond>.Cons)
			{
				val = ((list<TSecond>.Cons)list).hd;
				list = ((list<TSecond>.Cons)list).tl;
				if (f.apply(a[num], val))
				{
					result = 1;
					break;
				}
				list<TSecond> obj = list;
				num = checked(num + 1);
				list = obj;
				continue;
			}
			throw new MatchFailureException();
		}
		return (byte)result != 0;
	}

	[Nemerle.Internal.Extension]
	public static bool Exists2<TFirst, TSecond>(this list<TFirst> a, TSecond[] b, Function<TFirst, TSecond, bool> f)
	{
		TFirst val = default(TFirst);
		list<TFirst> list = a;
		int num = 0;
		int result;
		while (true)
		{
			if ((object)list == list<TFirst>.Nil._N_constant_object)
			{
				result = 0;
				break;
			}
			if (list is list<TFirst>.Cons)
			{
				val = ((list<TFirst>.Cons)list).hd;
				list = ((list<TFirst>.Cons)list).tl;
				if (f.apply(val, b[num]))
				{
					result = 1;
					break;
				}
				list<TFirst> obj = list;
				num = checked(num + 1);
				list = obj;
				continue;
			}
			throw new MatchFailureException();
		}
		return (byte)result != 0;
	}

	[Nemerle.Internal.Extension]
	public static list<T> Filter<T>(this T[] ary, Function<T, bool> predicate)
	{
		int num = 0;
		list<T>.Cons cons = null;
		T val = default(T);
		list<T>.Cons cons2 = null;
		cons = null;
		cons2 = null;
		for (num = 0; num < ary.Length; num = checked(num + 1))
		{
			val = ary[num];
			val = val;
			if (predicate.apply(val))
			{
				list<T>.Cons cons3 = new list<T>.Cons(val, list<T>.Nil._N_constant_object);
				if (cons == null)
				{
					cons = cons3;
					cons2 = cons3;
				}
				else
				{
					cons2.tl = cons3;
					cons2 = cons3;
				}
			}
		}
		return (!(cons == null)) ? ((list<T>)cons) : ((list<T>)list<T>.Nil._N_constant_object);
	}

	[Nemerle.Internal.Extension]
	public static Base[] ToBase<Derive, Base>(this Derive[] source) where Derive : class, Base where Base : class
	{
		return source;
	}

	[Nemerle.Internal.Extension]
	public static T[] SortInplace<T>(this T[] source, Comparison<T> comparison)
	{
		Array.Sort(source, comparison);
		return source;
	}

	[Nemerle.Internal.Extension]
	public static T[] Sort<T, Val>(this T[] source, Function<T, Val> getComparableValue) where Val : IComparable<Val>
	{
		_N_closureOf_Sort_24811<T, Val> n_closureOf_Sort_ = new _N_closureOf_Sort_24811<T, Val>();
		n_closureOf_Sort_._N_getComparableValue_24816 = getComparableValue;
		Function<T, T, int> function = new _N_Cmp__24818<T, Val>(n_closureOf_Sort_);
		Array.Sort(source, function.apply);
		return source;
	}

	[Nemerle.Internal.Extension]
	public static T Clone<T>(this T source) where T : ICloneable
	{
		return (T)source.Clone();
	}

	[Nemerle.Internal.Extension]
	public static string ToString<T>(this T[] source, string separator)
	{
		Function<T, string> instance = _N__N_lambda__24835__24841<T>.Instance;
		return string.Join(separator, source.Map(instance));
	}

	private static list<TResult> _N_loop_24500<TFirst, TSecond, TResult>(_N_closureOf_Map2_24490<TFirst, TSecond, TResult> _N_Map2_cp_24499, list<TFirst> l, int acc)
	{
		TFirst val = default(TFirst);
		object result;
		if ((object)l == list<TFirst>.Nil._N_constant_object)
		{
			result = list<TResult>.Nil._N_constant_object;
		}
		else
		{
			if (!(l is list<TFirst>.Cons))
			{
				throw new MatchFailureException();
			}
			val = ((list<TFirst>.Cons)l).hd;
			list<TFirst> l2 = ((list<TFirst>.Cons)l).tl;
			result = new list<TResult>.Cons(_N_Map2_cp_24499._N_f_24495.apply(val, _N_Map2_cp_24499._N_b_24497[acc]), _N_loop_24500(_N_Map2_cp_24499, l2, checked(acc + 1)));
		}
		return (list<TResult>)result;
	}

	private static list<TResult> _N_loop_24531<TFirst, TSecond, TResult>(_N_closureOf_Map2_24521<TFirst, TSecond, TResult> _N_Map2_cp_24530, list<TSecond> l, int acc)
	{
		TSecond val = default(TSecond);
		object result;
		if ((object)l == list<TSecond>.Nil._N_constant_object)
		{
			result = list<TResult>.Nil._N_constant_object;
		}
		else
		{
			if (!(l is list<TSecond>.Cons))
			{
				throw new MatchFailureException();
			}
			val = ((list<TSecond>.Cons)l).hd;
			list<TSecond> l2 = ((list<TSecond>.Cons)l).tl;
			result = new list<TResult>.Cons(_N_Map2_cp_24530._N_f_24526.apply(_N_Map2_cp_24530._N_a_24528[acc], val), _N_loop_24531(_N_Map2_cp_24530, l2, checked(acc + 1)));
		}
		return (list<TResult>)result;
	}

	private static TResult _N_loop_24634<TFirst, TSecond, TResult>(_N_closureOf_FoldRight2_24624<TFirst, TSecond, TResult> _N_FoldRight2_cp_24633, list<TFirst> x, int i, TResult acc)
	{
		TFirst val = default(TFirst);
		TResult result;
		if ((object)x == list<TFirst>.Nil._N_constant_object)
		{
			result = acc;
		}
		else
		{
			if (!(x is list<TFirst>.Cons))
			{
				throw new MatchFailureException();
			}
			val = ((list<TFirst>.Cons)x).hd;
			list<TFirst> x2 = ((list<TFirst>.Cons)x).tl;
			result = _N_FoldRight2_cp_24633._N_f_24629.apply(val, _N_FoldRight2_cp_24633._N_b_24631[i], _N_loop_24634(_N_FoldRight2_cp_24633, x2, checked(i + 1), acc));
		}
		return result;
	}

	private static TResult _N_loop_24667<TFirst, TSecond, TResult>(_N_closureOf_FoldRight2_24657<TFirst, TSecond, TResult> _N_FoldRight2_cp_24666, list<TSecond> x, int i, TResult acc)
	{
		TSecond val = default(TSecond);
		TResult result;
		if ((object)x == list<TSecond>.Nil._N_constant_object)
		{
			result = acc;
		}
		else
		{
			if (!(x is list<TSecond>.Cons))
			{
				throw new MatchFailureException();
			}
			val = ((list<TSecond>.Cons)x).hd;
			list<TSecond> x2 = ((list<TSecond>.Cons)x).tl;
			result = _N_FoldRight2_cp_24666._N_f_24662.apply(_N_FoldRight2_cp_24666._N_a_24664[i], val, _N_loop_24667(_N_FoldRight2_cp_24666, x2, checked(i + 1), acc));
		}
		return result;
	}
}
