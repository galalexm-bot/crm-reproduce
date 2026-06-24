using System;
using System.Collections.Generic;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Services;

[Service(CreateInstancePerResolve = true)]
public class UndoRedoEngine : IUndoRedoEngine
{
	private class UndoRedoCount : Reactive
	{
		private int _003CUndoCount_003Ek__BackingField;

		private int _003CRedoCount_003Ek__BackingField;

		internal int UndoCount
		{
			get
			{
				return _003CUndoCount_003Ek__BackingField;
			}
			set
			{
				_003CUndoCount_003Ek__BackingField = value;
			}
		}

		internal int RedoCount
		{
			get
			{
				return _003CRedoCount_003Ek__BackingField;
			}
			set
			{
				_003CRedoCount_003Ek__BackingField = value;
			}
		}
	}

	private Stack<Transaction> undoStack;

	private Stack<Transaction> redoStack;

	private Transaction currentTransaction;

	private readonly UndoRedoCount undoRedoCount;

	public UndoRedoEngine(IReactiveModelFactory reactiveModelFactory)
	{
		Reset();
		undoRedoCount = reactiveModelFactory.CreateModel<UndoRedoCount>();
	}

	public void Reset()
	{
		undoStack = new Stack<Transaction>();
		redoStack = new Stack<Transaction>();
	}

	public bool CanRedo()
	{
		return undoRedoCount.RedoCount != 0;
	}

	public bool CanUndo()
	{
		return undoRedoCount.UndoCount != 0;
	}

	public void Redo()
	{
		if (CanRedo())
		{
			Transaction transaction = redoStack.Pop();
			transaction.Redo();
			undoStack.Push(transaction);
			undoRedoCount.RedoCount = redoStack.get_Count();
			undoRedoCount.UndoCount = undoStack.get_Count();
		}
	}

	public void Undo()
	{
		if (CanUndo())
		{
			Transaction transaction = undoStack.Pop();
			transaction.Undo();
			redoStack.Push(transaction);
			undoRedoCount.RedoCount = redoStack.get_Count();
			undoRedoCount.UndoCount = undoStack.get_Count();
		}
	}

	public ITransaction BeginTransaction()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		if (currentTransaction != null)
		{
			return new TransactionWrapper(currentTransaction);
		}
		currentTransaction = new Transaction((Action)delegate
		{
			currentTransaction = null;
		});
		undoStack.Push(currentTransaction);
		redoStack.Clear();
		undoRedoCount.RedoCount = redoStack.get_Count();
		undoRedoCount.UndoCount = undoStack.get_Count();
		return currentTransaction;
	}

	private void _003CBeginTransaction_003Eb__10_0()
	{
		currentTransaction = null;
	}
}
