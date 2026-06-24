using System;
using System.Diagnostics;
using System.Reflection;

namespace Nemerle.Diagnostics;

public static class NDebug
{
	private static int StackTraceDepth;

	static NDebug()
	{
		StackTraceDepth = 15;
	}

	public static string ToStringWitoutNs(object str)
	{
		try
		{
			return str.ToString().Replace("System.Linq.Expressions.", "").Replace("System.Linq.", "")
				.Replace("System.Collections.Generic.", "")
				.Replace("System.Collections.", "")
				.Replace("System.", "")
				.Replace("Nemerle.Collections.", "")
				.Replace("Nemerle.Core.", "")
				.Replace("Nemerle.Compiler.", "")
				.Replace("Nemerle.", "")
				.Replace("`1", "")
				.Replace("`2", "")
				.Replace("`3", "");
		}
		catch (Exception ex)
		{
			return "ToString() throw exceptoin " + Convert.ToString(ex.GetType()) + ": " + Convert.ToString(ex.Message);
		}
	}

	public static void PrintStackTrace()
	{
		int num = 0;
		StackTrace stackTrace = new StackTrace(fNeedFileInfo: true);
		StackFrame[] frames = stackTrace.GetFrames();
		for (num = 0; num < frames.Length; num = checked(num + 1))
		{
			StackFrame stackFrame = frames[num];
			stackFrame = stackFrame;
			if (num < StackTraceDepth && num != 0)
			{
				MethodBase method = stackFrame.GetMethod();
				string name = method.Name;
				int length = method.GetParameters().Length;
				string fileName = stackFrame.GetFileName();
				int fileLineNumber = stackFrame.GetFileLineNumber();
				int fileColumnNumber = stackFrame.GetFileColumnNumber();
			}
		}
	}
}
