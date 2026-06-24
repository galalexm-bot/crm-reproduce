using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Nemerle.Compiler;

public static class LocationStack
{
	[ThreadStatic]
	private static List<Location> _stack;

	private static List<Location> Stack
	{
		get
		{
			List<Location> stack;
			if (_stack != null)
			{
				stack = _stack;
			}
			else
			{
				_stack = new List<Location>();
				stack = _stack;
			}
			return stack;
		}
	}

	[DebuggerNonUserCode]
	public static void Push(Location loc)
	{
		Stack.Add(loc);
	}

	[DebuggerNonUserCode]
	public static void RemoveTop()
	{
		Stack.RemoveAt(checked(Stack.Count - 1));
	}

	public static Location Pop()
	{
		Location result = Top();
		RemoveTop();
		return result;
	}

	public static Location Top()
	{
		List<Location> stack = Stack;
		return (stack.Count != 0) ? stack[checked(stack.Count - 1)].AsGenerated() : Location.Default;
	}
}
