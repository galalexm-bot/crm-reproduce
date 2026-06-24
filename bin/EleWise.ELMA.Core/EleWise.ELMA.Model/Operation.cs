using System;
using EleWise.ELMA.Core.Diagnostics;

namespace EleWise.ELMA.Model;

public class Operation : IOperation
{
	private readonly Action onDo;

	private readonly Action onUndo;

	public Operation(Action onDo, Action onUndo)
	{
		Contract.ArgumentNotNull(onDo, "onDo");
		Contract.ArgumentNotNull(onUndo, "onUndo");
		this.onDo = onDo;
		this.onUndo = onUndo;
	}

	public void Do()
	{
		onDo.Invoke();
	}

	public void Undo()
	{
		onUndo.Invoke();
	}
}
