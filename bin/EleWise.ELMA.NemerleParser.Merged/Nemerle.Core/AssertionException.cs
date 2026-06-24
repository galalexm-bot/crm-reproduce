using System;

namespace Nemerle.Core;

[Serializable]
public class AssertionException : Exception
{
	public AssertionException()
	{
	}

	public AssertionException(string file, int line, string cond, string msg)
	{
		string text = string.Concat(string.Concat(string.Concat(string.Concat("assertion" + ((!(cond != "")) ? "" : string.Concat(" ``" + cond, "''")), " failed in file "), file), ", line "), line.ToString());
		base._002Ector((!(msg != "")) ? text : string.Concat(text + ": ", msg));
	}
}
