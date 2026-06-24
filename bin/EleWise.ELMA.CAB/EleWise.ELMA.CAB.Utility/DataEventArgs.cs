using System;
using System.Diagnostics.Contracts;

namespace EleWise.ELMA.CAB.Utility;

public class DataEventArgs<TData> : EventArgs
{
	private readonly TData data;

	public TData Data => data;

	public DataEventArgs(TData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		this.data = data;
	}

	public override string ToString()
	{
		TData val = data;
		string text = val.ToString();
		string text2 = text;
		__ContractsRuntime.Ensures(text2 != null, null, "Contract.Result<string>() != null");
		return text2;
	}
}
