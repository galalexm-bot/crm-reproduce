using System;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Utility;

[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
[Extension]
public static class NString
{
	[Extension]
	public static bool EndsWith(this string str, char value)
	{
		int length = str.Length;
		return length != 0 && str[checked(length - 1)] == value;
	}

	[Extension]
	public static bool EndsWith(this string str, char beforeEnd, char end)
	{
		int length = str.Length;
		return checked(length > 1 && str[length - 2] == beforeEnd && str[length - 1] == end);
	}

	[Extension]
	public static bool StartsWith(this string str, char first, char second)
	{
		return str.Length > 1 && str[0] == first && str[1] == second;
	}

	[Extension]
	public static bool EndsWith(this string str, params string[] values)
	{
		return str.EndsWith(StringComparison.InvariantCulture, values);
	}

	[Extension]
	public static bool EndsWith(this string str, StringComparison comparisonType, params string[] values)
	{
		int num = 0;
		bool flag = false;
		foreach (string value in values)
		{
			if (str.EndsWith(value, comparisonType))
			{
				return true;
			}
		}
		return false;
	}

	[Extension]
	public static bool StartsWith(this string str, params string[] values)
	{
		return str.StartsWith(StringComparison.InvariantCulture, values);
	}

	[Extension]
	public static bool StartsWith(this string str, StringComparison comparisonType, params string[] values)
	{
		int num = 0;
		bool flag = false;
		foreach (string value in values)
		{
			if (str.StartsWith(value, comparisonType))
			{
				return true;
			}
		}
		return false;
	}

	[Extension]
	public static list<string> SplitToList(this string str, params char[] seperators)
	{
		return Split(str, seperators);
	}

	public static list<string> Split(string str, params char[] seperators)
	{
		int num = 0;
		int num2 = 0;
		list<string> list = null;
		checked
		{
			int num3 = seperators.Length - 1;
			num2 = str.Length - 1;
			list = list<string>.Nil._N_constant_object;
			for (num = str.Length - 1; num >= 0; num--)
			{
				int num4 = 0;
				while (true)
				{
					if (seperators[num4] == str[num])
					{
						if (num2 - num > 0)
						{
							list = new list<string>.Cons(str.Substring(num + 1, num2 - num), list);
						}
						num2 = num - 1;
						break;
					}
					if (num4 >= num3)
					{
						break;
					}
					num4++;
				}
			}
			return (num2 + 1 <= 0) ? list : new list<string>.Cons(str.Substring(0, num2 + 1), list);
		}
	}

	public static list<string> Split(string str, list<char> sep)
	{
		int num = 0;
		int num2 = 0;
		list<string> list = null;
		checked
		{
			num2 = str.Length - 1;
			list = list<string>.Nil._N_constant_object;
			for (num = str.Length - 1; num >= 0; num--)
			{
				list<char> list2 = sep;
				while (true)
				{
					if (list2 is list<char>.Cons)
					{
						char hd = ((list<char>.Cons)list2).hd;
						list2 = ((list<char>.Cons)list2).tl;
						if (str[num] == hd)
						{
							if (num2 - num > 0)
							{
								list = new list<string>.Cons(str.Substring(num + 1, num2 - num), list);
							}
							num2 = num - 1;
							break;
						}
						list2 = list2;
						continue;
					}
					if ((object)list2 == list<char>.Nil._N_constant_object)
					{
						break;
					}
					throw new MatchFailureException();
				}
			}
			return (num2 + 1 <= 0) ? list : new list<string>.Cons(str.Substring(0, num2 + 1), list);
		}
	}

	public static string Concat(string sep, list<string> l)
	{
		list<string> list = l;
		StringBuilder stringBuilder = new StringBuilder("");
		StringBuilder stringBuilder2;
		while (true)
		{
			if (list is list<string>.Cons)
			{
				string hd;
				if ((object)((list<string>.Cons)list).tl == list<string>.Nil._N_constant_object)
				{
					hd = ((list<string>.Cons)list).hd;
					stringBuilder2 = stringBuilder.Append(hd);
					break;
				}
				hd = ((list<string>.Cons)list).hd;
				list = ((list<string>.Cons)list).tl;
				list<string> obj = list;
				stringBuilder = stringBuilder.Append(hd).Append(sep);
				list = obj;
				continue;
			}
			if ((object)list == list<string>.Nil._N_constant_object)
			{
				stringBuilder2 = stringBuilder;
				break;
			}
			throw new MatchFailureException();
		}
		return stringBuilder2.ToString();
	}

	public static void SeparatedCalls<_0027a>(string sep, list<_0027a> l, FunctionVoid<_0027a> f, StringBuilder acc)
	{
		_0027a val = default(_0027a);
		list<_0027a> list = l;
		while (list is list<_0027a>.Cons)
		{
			if ((object)((list<_0027a>.Cons)list).tl == list<_0027a>.Nil._N_constant_object)
			{
				val = ((list<_0027a>.Cons)list).hd;
				f.apply_void(val);
				return;
			}
			val = ((list<_0027a>.Cons)list).hd;
			list = ((list<_0027a>.Cons)list).tl;
			f.apply_void(val);
			StringBuilder stringBuilder = acc.Append(sep);
			list = list;
		}
		if ((object)list == list<_0027a>.Nil._N_constant_object)
		{
			return;
		}
		throw new MatchFailureException();
	}

	[Extension]
	public static string Map(this string s, Function<char, char> f)
	{
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder(s.Length);
		for (num = 0; num < s.Length; num = checked(num + 1))
		{
			StringBuilder stringBuilder2 = stringBuilder.Append(f.apply(s[num]));
		}
		return stringBuilder.ToString();
	}

	[Extension]
	public static string MapCS(this string s, Function<char, string> f)
	{
		int num = 0;
		StringBuilder stringBuilder = new StringBuilder(s.Length);
		for (num = 0; num < s.Length; num = checked(num + 1))
		{
			StringBuilder stringBuilder2 = stringBuilder.Append(f.apply(s[num]));
		}
		return stringBuilder.ToString();
	}

	[Extension]
	public static void Iter(this string s, FunctionVoid<char> f)
	{
		int num = 0;
		for (num = 0; num < s.Length; num = checked(num + 1))
		{
			f.apply_void(s[num]);
		}
	}

	[Extension]
	public static void IterI(this string s, FunctionVoid<char, int> f)
	{
		int num = 0;
		for (num = 0; num < s.Length; num = checked(num + 1))
		{
			f.apply_void(new Nemerle.Builtins.Tuple<char, int>(s[num], num));
		}
	}

	[Extension]
	public static _0027a Fold<_0027a>(this string s, _0027a ini, Function<char, _0027a, _0027a> f)
	{
		_0027a val = default(_0027a);
		val = ini;
		int num = 0;
		while (num < s.Length)
		{
			_0027a val2 = f.apply(s[num], val);
			num = checked(num + 1);
			val = val2;
		}
		return val;
	}

	public static _0027a Fold2<_0027a>(string s1, string s2, _0027a ini, Function<char, char, _0027a, _0027a> f)
	{
		_0027a val = default(_0027a);
		if (s1.Length != s2.Length)
		{
			throw new ArgumentException("NString.Fold2");
		}
		val = ini;
		int num = 0;
		while (num < s1.Length)
		{
			_0027a val2 = f.apply(s1[num], s2[num], val);
			num = checked(num + 1);
			val = val2;
		}
		return val;
	}

	[Extension]
	public static bool ForAll(this string s, Function<char, bool> f)
	{
		int num = 0;
		int result;
		while (true)
		{
			if (num >= s.Length)
			{
				result = 1;
				break;
			}
			if (f.apply(s[num]))
			{
				num = checked(num + 1);
				continue;
			}
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	[Extension]
	public static bool Exists(this string s, Function<char, bool> f)
	{
		int num = 0;
		int result;
		while (true)
		{
			if (num >= s.Length)
			{
				result = 0;
				break;
			}
			if (f.apply(s[num]))
			{
				result = 1;
				break;
			}
			num = checked(num + 1);
		}
		return (byte)result != 0;
	}

	[Extension]
	public static list<char> Explode(this string s)
	{
		checked
		{
			int num = s.Length - 1;
			list<char> list = list<char>.Nil._N_constant_object;
			while (num >= 0)
			{
				int num2 = num - 1;
				list = new list<char>.Cons(s[num], list);
				num = num2;
			}
			return list;
		}
	}

	[Extension]
	public static string Implode(this list<char> s)
	{
		StringBuilder stringBuilder = new StringBuilder();
		list<char> list = s;
		while (list is list<char>.Cons)
		{
			char hd = ((list<char>.Cons)list).hd;
			list = ((list<char>.Cons)list).tl;
			StringBuilder stringBuilder2 = stringBuilder.Append(hd);
			list = list;
		}
		return stringBuilder.ToString();
	}
}
