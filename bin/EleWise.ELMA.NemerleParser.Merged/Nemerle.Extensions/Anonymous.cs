using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Internal;

namespace Nemerle.Extensions;

public static class Anonymous
{
	[IgnoreField]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Hashtable<Nemerle.Builtins.Tuple<ReadOnlyCollection<string>, ReadOnlyCollection<string>>, bool> _N_cache_6960;

	private static bool FieldsAreEqual(ReadOnlyCollection<string> a, ReadOnlyCollection<string> b)
	{
		bool flag = false;
		if (_N_cache_6960 == null)
		{
			_N_cache_6960 = new Hashtable<Nemerle.Builtins.Tuple<ReadOnlyCollection<string>, ReadOnlyCollection<string>>, bool>();
		}
		Nemerle.Builtins.Tuple<bool, bool> tuple = _N_cache_6960.TryGetValue(new Nemerle.Builtins.Tuple<ReadOnlyCollection<string>, ReadOnlyCollection<string>>(a, b));
		bool result;
		if (tuple.Field1)
		{
			flag = tuple.Field0;
			result = flag;
		}
		else
		{
			if (object.ReferenceEquals(a, b))
			{
				flag = true;
			}
			else
			{
				IEnumerator<string> enumerator = a.GetEnumerator();
				IEnumerator<string> enumerator2 = b.GetEnumerator();
				while (true)
				{
					if (enumerator.MoveNext() && enumerator2.MoveNext())
					{
						if (!(enumerator.Current == enumerator2.Current))
						{
							flag = false;
							break;
						}
						continue;
					}
					flag = !enumerator.MoveNext() && !enumerator2.MoveNext();
					break;
				}
			}
			flag = flag;
			_N_cache_6960[new Nemerle.Builtins.Tuple<ReadOnlyCollection<string>, ReadOnlyCollection<string>>(a, b)] = flag;
			result = flag;
		}
		return result;
	}

	public static bool Equals([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] IAnonymous a, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] IAnonymous b)
	{
		if (b == null)
		{
			throw new ArgumentNullException("b", "The ``NotNull'' contract of parameter ``b'' has been violated. See lib\\IAnonymous.n:80:59:80:60: .");
		}
		if (a == null)
		{
			throw new ArgumentNullException("a", "The ``NotNull'' contract of parameter ``a'' has been violated. See lib\\IAnonymous.n:80:33:80:34: .");
		}
		return FieldsAreEqual(a.GetFields(), b.GetFields()) && EqualityComparer<object>.Default.Equals(a.GetContent(), b.GetContent());
	}
}
