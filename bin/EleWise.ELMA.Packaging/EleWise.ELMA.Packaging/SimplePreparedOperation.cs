using System;

namespace EleWise.ELMA.Packaging;

public class SimplePreparedOperation : IPreparedOperation
{
	private Action _action;

	public SimplePreparedOperation(Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		_action = action;
	}

	public void Execute()
	{
		_action();
	}
}
