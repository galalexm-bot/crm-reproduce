using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Packaging;

public class CompositePreparedOperation : IPreparedOperation
{
	private IEnumerable<IPreparedOperation> _operations;

	public CompositePreparedOperation(IEnumerable<IPreparedOperation> operations)
	{
		if (operations == null)
		{
			throw new ArgumentNullException("operations");
		}
		_operations = operations;
	}

	public void Execute()
	{
		foreach (IPreparedOperation operation in _operations)
		{
			operation.Execute();
		}
	}
}
