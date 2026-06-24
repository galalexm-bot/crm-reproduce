using Nemerle.Internal;

namespace Nemerle.Core;

[ExtensionPatternEncoding("VNone", "", "ValueOption where HasValue = false")]
[ExtensionPatternEncoding("VSome", "value", "ValueOption where (HasValue = true, Value = value)")]
public struct ValueOption<T>
{
	private readonly T _value;

	public readonly bool HasValue;

	public T Value
	{
		get
		{
			if (HasValue)
			{
				return _value;
			}
			throw new AssertionException("lib\\option.n", 225, "", "try use Value when it not set");
		}
	}

	public bool IsSome => HasValue;

	public bool IsNone => !HasValue;

	public T GetValueOrDefault()
	{
		return _value;
	}

	public ValueOption(T value)
	{
		_value = value;
		HasValue = true;
	}

	public static ValueOption<T> None()
	{
		return default(ValueOption<T>);
	}

	public static ValueOption<T> Some(T value)
	{
		return new ValueOption<T>(value);
	}
}
