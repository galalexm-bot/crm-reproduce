using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Diagnostics;

namespace EleWise.ELMA.Model;

public class Transaction : ITransaction, System.IDisposable
{
	private readonly List<IOperation> operations;

	private readonly Action onDispose;

	public Transaction(Action onDispose)
	{
		Contract.ArgumentNotNull(onDispose, "onDispose");
		this.onDispose = onDispose;
		operations = new List<IOperation>();
	}

	public void Execute(IOperation operation)
	{
		Contract.ArgumentNotNull(operation, "operation");
		operation.Do();
		operations.Add(operation);
	}

	public void Undo()
	{
		if (operations.get_Count() == 0)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<IOperation> enumerator = Enumerable.Reverse<IOperation>((System.Collections.Generic.IEnumerable<IOperation>)operations).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				enumerator.get_Current().Undo();
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public void Redo()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (operations.get_Count() == 0)
		{
			return;
		}
		Enumerator<IOperation> enumerator = operations.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				enumerator.get_Current().Do();
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public void Dispose()
	{
		onDispose.Invoke();
	}
}
