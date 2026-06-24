using System;
using Nemerle.Internal;

namespace Nemerle.Diagnostics;

public class CompileStatistic : Attribute
{
	public string Key { get; }

	[RecordCtor]
	public CompileStatistic([MappedMember("Key")] string key)
	{
		_N_Key_3474 = key;
	}
}
