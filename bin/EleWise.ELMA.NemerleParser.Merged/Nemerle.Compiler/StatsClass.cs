using System;
using System.Runtime.CompilerServices;

namespace Nemerle.Compiler;

internal class StatsClass : ISupportRelocation
{
	public bool PrintTemps = false;

	public int AllTypeBuilders;

	public int FirstClassFunctions;

	public int FunctionClosures;

	public int TimeStarted;

	public int Temp1;

	public int Temp2;

	public int Temp3;

	public void Reset()
	{
		AllTypeBuilders = 0;
		FirstClassFunctions = 0;
		FunctionClosures = 0;
		Temp1 = 0;
		Temp2 = 0;
		Temp3 = 0;
		TimeStarted = Environment.TickCount;
	}

	public void Run(ManagerClass Manager)
	{
		if (Manager.Options.DoPrintStats)
		{
			Console.Write("------------- STATS ---------------" + Environment.NewLine);
			Console.Write("  AllTypeBuilders:     " + Convert.ToString(AllTypeBuilders) + Environment.NewLine);
			Console.Write("  FirstClassFunctions: " + Convert.ToString(FirstClassFunctions) + Environment.NewLine);
			Console.Write("  FunctionClosures:    " + Convert.ToString(FunctionClosures) + Environment.NewLine);
			Console.Write("  RealRunningTime:     " + Convert.ToString(checked(Environment.TickCount - TimeStarted)) + "ms" + Environment.NewLine);
			if (Temp1 != 0 || Temp2 != 0 || Temp3 != 0 || PrintTemps)
			{
				Console.Write(string.Concat(Environment.NewLine));
				Console.Write("  Temp1: " + Convert.ToString(Temp1) + Environment.NewLine);
				Console.Write("  Temp2: " + Convert.ToString(Temp2) + Environment.NewLine);
				Console.Write("  Temp3: " + Convert.ToString(Temp3) + Environment.NewLine);
			}
			Console.Write("------------- END STATS ---------------" + Environment.NewLine);
		}
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
