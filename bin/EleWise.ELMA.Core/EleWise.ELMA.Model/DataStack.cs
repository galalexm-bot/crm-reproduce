using System;
using System.Collections;
using System.Collections.Generic;
using Bridge;

namespace EleWise.ELMA.Model;

public sealed class DataStack : HashSet<DataStackItem>, IDataStack, System.Collections.Generic.IEnumerable<DataStackItem>, System.Collections.IEnumerable, IBridgeClass, ICloneable
{
	public IDataStack Clone()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		DataStack dataStack = new DataStack();
		Enumerator<DataStackItem> enumerator = base.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataStackItem current = enumerator.get_Current();
				((HashSet<DataStackItem>)dataStack).Add(current);
			}
			return dataStack;
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	object ICloneable.Clone()
	{
		return Clone();
	}
}
