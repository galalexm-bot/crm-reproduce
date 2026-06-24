using System;
using EleWise.ELMA.Core.Diagnostics;

namespace EleWise.ELMA.Model;

internal class TransactionWrapper : ITransaction, System.IDisposable
{
	private readonly Transaction transaction;

	public TransactionWrapper(Transaction transaction)
	{
		Contract.ArgumentNotNull(transaction, "transaction");
		this.transaction = transaction;
	}

	public void Execute(IOperation operation)
	{
		transaction.Execute(operation);
	}

	public void Dispose()
	{
	}
}
