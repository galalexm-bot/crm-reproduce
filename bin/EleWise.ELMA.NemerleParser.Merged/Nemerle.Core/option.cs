using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using Nemerle.Builtins;
using Nemerle.Internal;

namespace Nemerle.Core;

[Serializable]
[DebuggerNonUserCode]
[Variant("Nemerle.Core.option.None,Nemerle.Core.option.Some")]
public abstract class option<T> : IEquatable<option<T>>
{
	[Serializable]
	[ConstantVariantOption]
	[DebuggerNonUserCode]
	public class None : option<T>, IObjectReference
	{
		public static readonly None _N_constant_object;

		[SpecialName]
		public static None _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		[SpecialName]
		[SecurityCritical]
		public object GetRealObject(StreamingContext _N_wildcard_3398)
		{
			return _N_constant_object;
		}

		static None()
		{
			_N_constant_object = new None();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		private None()
		{
		}
	}

	[Serializable]
	[VariantOption]
	[DebuggerNonUserCode]
	public class Some : option<T>
	{
		public readonly T val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Some([MappedMember("val")] T val)
		{
			this.val = val;
		}
	}

	public bool IsSome => this is Some;

	public bool IsNone => (this == None._N_constant_object) ? true : false;

	public bool HasValue => this is Some;

	public T Value
	{
		get
		{
			T val = default(T);
			if (this is Some)
			{
				return ((Some)this).val;
			}
			if (this == None._N_constant_object)
			{
				throw new ArgumentException("option.Value");
			}
			throw new MatchFailureException();
		}
	}

	public override string ToString()
	{
		T val = default(T);
		object result;
		if (this is Some)
		{
			val = ((Some)this).val;
			if (val == null)
			{
				result = "Some()";
			}
			else
			{
				val = ((Some)this).val;
				result = string.Concat("Some (" + val.ToString(), ")");
			}
		}
		else
		{
			if (this != None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = "None";
		}
		return (string)result;
	}

	public bool Equals(option<T> o)
	{
		return Option.Equals(this, o);
	}

	public override int GetHashCode()
	{
		T val = default(T);
		int result;
		if (this == None._N_constant_object)
		{
			result = 0;
		}
		else
		{
			if (!(this is Some))
			{
				throw new MatchFailureException();
			}
			val = ((Some)this).val;
			result = val.GetHashCode();
		}
		return result;
	}

	public T WithDefault(T val)
	{
		T val2 = default(T);
		T result;
		if (this is Some)
		{
			val2 = ((Some)this).val;
			result = val2;
		}
		else
		{
			if (this != None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = val;
		}
		return result;
	}

	[SpecialName]
	public static option<TFrom> op_Implicit<TFrom>(TFrom? value) where TFrom : struct
	{
		return (!value.HasValue) ? ((option<TFrom>)option<TFrom>.None._N_constant_object) : ((option<TFrom>)new option<TFrom>.Some(value.Value));
	}

	public override bool Equals(object other)
	{
		return other == this || (other is option<T> && Equals((option<T>)other));
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(option<T> x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is option<T>)) ? (-1) : ((option<T>)x)._N_GetVariantCode();
	}
}
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
[Nemerle.Internal.Extension]
public static class Option
{
	public static bool Equals<T>(option<T> x, option<T> y)
	{
		T val = default(T);
		T val2 = default(T);
		int result;
		if (x is option<T>.Some)
		{
			if (y is option<T>.Some)
			{
				val = ((option<T>.Some)x).val;
				val2 = ((option<T>.Some)y).val;
				result = (val.Equals(val2) ? 1 : 0);
				goto IL_009c;
			}
		}
		else if (x == option<T>.None._N_constant_object)
		{
			if (y == option<T>.None._N_constant_object)
			{
				result = 1;
				goto IL_009c;
			}
		}
		else if ((object)y == null)
		{
			throw new ArgumentException("option can't be null");
		}
		result = 0;
		goto IL_009c;
		IL_009c:
		return (byte)result != 0;
	}

	[Nemerle.Internal.Extension]
	public static option<TTo> Map<T, TTo>(this option<T> x, Function<T, TTo> f)
	{
		T val = default(T);
		object result;
		if (x is option<T>.Some)
		{
			val = ((option<T>.Some)x).val;
			result = new option<TTo>.Some(f.apply(val));
		}
		else
		{
			if ((object)x == null)
			{
				throw new ArgumentException("option can't be null");
			}
			result = option<TTo>.None._N_constant_object;
		}
		return (option<TTo>)result;
	}

	[Nemerle.Internal.Extension]
	public static void Iter<T>(this option<T> x, FunctionVoid<T> f)
	{
		T val = default(T);
		if (x is option<T>.Some)
		{
			val = ((option<T>.Some)x).val;
			f.apply_void(val);
		}
		else if ((object)x != null)
		{
		}
	}

	public static bool IsSome<T>(option<T> x)
	{
		return x is option<T>.Some;
	}

	public static bool IsNone<T>(option<T> x)
	{
		int result;
		if (x == option<T>.None._N_constant_object)
		{
			result = 1;
		}
		else
		{
			if ((object)x == null)
			{
				throw new ArgumentException("option can't be null");
			}
			result = 0;
		}
		return (byte)result != 0;
	}

	[Nemerle.Internal.Extension]
	public static T UnSome<T>(this option<T> x)
	{
		T val = default(T);
		if (x is option<T>.Some)
		{
			return ((option<T>.Some)x).val;
		}
		throw new ArgumentException("Option.UnSome");
	}

	[Nemerle.Internal.Extension]
	public static option<T> ToOption<T>(this T? x) where T : struct
	{
		return option<object>.op_Implicit(x);
	}
}
