using System;

namespace Nemerle.Core;

[Serializable]
public class NullMatchException : MatchFailureException
{
	public static bool raise_self()
	{
		//Discarded unreachable code: IL_0006
		throw new NullMatchException();
	}
}
