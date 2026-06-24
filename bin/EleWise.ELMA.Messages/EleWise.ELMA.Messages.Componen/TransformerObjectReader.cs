using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Messages.Components;

internal class TransformerObjectReader
{
	private readonly object[] tuple;

	private readonly List<string> aliases;

	public TransformerObjectReader(object[] tuple, IEnumerable<string> aliases)
	{
		this.tuple = tuple;
		this.aliases = aliases.ToList();
	}

	public T Value<T>(string name, T defaultValue, Func<object, T> converter = null)
	{
		int num = aliases.ToList().FindIndex((string a) => a.Equals(name, StringComparison.OrdinalIgnoreCase));
		object obj = ((num == -1) ? null : tuple[num]);
		if (obj == null)
		{
			return defaultValue;
		}
		if (converter == null)
		{
			return (T)obj;
		}
		return converter(obj);
	}
}
