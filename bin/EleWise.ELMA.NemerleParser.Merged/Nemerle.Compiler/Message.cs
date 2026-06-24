using System;
using System.IO;

namespace Nemerle.Compiler;

public static class Message
{
	internal static bool ListenDebug;

	public static bool SeenError => Manager.Message_ErrorCount != 0;

	public static int ErrorCount => Manager.Message_ErrorCount;

	public static ManagerClass Manager => ManagerClass.Instance;

	public static InternalTypeClass InternalType => Manager.InternalType;

	public static SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	static Message()
	{
		ListenDebug = false;
	}

	public static void Error(Location loc, string m)
	{
		Location location = ((!(loc == Location.Default)) ? loc : LocationStack.Top());
		Manager.RunErrorOccured(location, m);
		ManagerClass manager = Manager;
		checked
		{
			manager.Message_ErrorCount++;
			if (Manager.Options.ColorMessages)
			{
				report(location, "\u001b[01;31merror\u001b[0m: " + m);
			}
			else
			{
				report(location, "error: " + m);
			}
			if (Manager.Options.ThrowOnError)
			{
				throw new BailOutException();
			}
		}
	}

	public static void Error(string m)
	{
		Error(Location.Default, m);
	}

	public static void Warning(Location loc, string m)
	{
		Warning(-1, loc, m);
	}

	public static void Warning(string m)
	{
		Warning(-1, Location.Default, m);
	}

	public static void Warning(int code, Location loc, string m)
	{
		Location location = findLoc(loc);
		checked
		{
			if (code == -1 || Manager.Options.Warnings.IsEnabledAt(location, code))
			{
				Manager.RunWarningOccured(location, m);
				ManagerClass manager = Manager;
				manager.Message_WarningCount++;
				string text = ((code != -1) ? ("N" + Convert.ToString(code) + ": " + Convert.ToString(m)) : m);
				if (Manager.Options.Warnings.TreatWarningsAsErrors)
				{
					Error(location, "warning: " + text);
				}
				else if (Manager.Options.ColorMessages)
				{
					report(location, "\u001b[01;33mwarning\u001b[0m: " + text);
				}
				else
				{
					report(location, "warning: " + text);
				}
			}
		}
	}

	public static void Warning(int code, string m)
	{
		Warning(code, Location.Default, m);
	}

	private static Location findLoc(Location loc)
	{
		return (!(loc == Location.Default)) ? loc : LocationStack.Top();
	}

	public static void Hint(Location loc, string m)
	{
		if (Manager.Options.ColorMessages)
		{
			report(loc, "\u001b[01;32mhint\u001b[0m: " + m);
		}
		else
		{
			report(loc, "hint: " + m);
		}
	}

	public static void Hint(string m)
	{
		Hint(Location.Default, m);
	}

	public static void HintOnce(Location loc, string m)
	{
		if (Manager.IsIntelliSenseMode)
		{
			Hint(loc, m);
		}
		else if (!Manager.Message_emitted_hints.Contains(m))
		{
			if (Manager.Options.ColorMessages)
			{
				report(loc, "\u001b[01;32mhint\u001b[0m: " + m);
			}
			else
			{
				report(loc, "hint: " + m);
			}
			Manager.Message_emitted_hints.Add(m, 0);
		}
	}

	public static void HintOnce(int code, Location loc, string m)
	{
		Location loc2 = findLoc(loc);
		if (Manager.Options.Warnings.IsEnabledAt(loc2, code))
		{
			HintOnce(loc2, m);
		}
	}

	public static void HintOnce(int code, string m)
	{
		HintOnce(code, Location.Default, m);
	}

	public static void HintOnce(string m)
	{
		HintOnce(Location.Default, m);
	}

	public static void Debug(Location loc, string m)
	{
		string m2 = "debug: " + m;
		report(loc, m2);
		if (!ListenDebug)
		{
		}
	}

	public static void Debug(string m)
	{
		Debug(Location.Default, m);
	}

	public static void FatalError2(Location loc, string m)
	{
		Error(loc, m);
		if (!Manager.IsIntelliSenseMode)
		{
			throw new Recovery();
		}
	}

	public static void MaybeBailout(bool fscked_up)
	{
		if ((!Manager.Options.IgnoreConfusion || !fscked_up) && SeenError)
		{
			if (fscked_up)
			{
				Console.Write("confused by earlier errors bailing out\n");
			}
			if (Manager.Options.IgnoreConfusion)
			{
				throw new Recovery();
			}
			Environment.Exit(1);
		}
	}

	public static void MaybeBailout()
	{
		MaybeBailout(fscked_up: false);
	}

	internal static void report(Location l, string m)
	{
		Location loc = ((!(l == Location.Default)) ? l : LocationStack.Top());
		Manager.KillProgressBar();
		string text = loc.ToString() + m;
		Manager.RunMessageOccured(loc, text);
		if (Manager.Message_output == null)
		{
			Manager.Message_output = Console.Out;
		}
		TextWriter message_output = Manager.Message_output;
		message_output.Write(text);
		message_output.Write("\n");
	}

	private static void __fake()
	{
		__fake();
		SystemTypeClass systemTypeCache = SystemTypeCache;
		InternalTypeClass internalType = InternalType;
	}
}
