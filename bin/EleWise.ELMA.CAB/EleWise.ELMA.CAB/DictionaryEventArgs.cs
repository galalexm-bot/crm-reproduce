using System.Collections.Generic;
using System.Diagnostics.Contracts;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB;

public class DictionaryEventArgs : DataEventArgs<Dictionary<string, object>>
{
	public DictionaryEventArgs()
		: base(new Dictionary<string, object>())
	{
	}

	public override string ToString()
	{
		string[] array = new string[base.Data.Count];
		int num = 0;
		foreach (KeyValuePair<string, object> datum in base.Data)
		{
			array[num++] = datum.Key + ": " + datum.Value;
		}
		string text = string.Join(", ", array);
		string text2 = text;
		__ContractsRuntime.Ensures(text2 != null, null, "Contract.Result<string>() != null");
		return text2;
	}
}
