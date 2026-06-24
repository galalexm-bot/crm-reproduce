using System;

namespace Nemerle.Collections;

public class EmptyCollection : Exception
{
	public readonly string msg;

	public EmptyCollection(string msg)
	{
		this.msg = msg;
	}
}
