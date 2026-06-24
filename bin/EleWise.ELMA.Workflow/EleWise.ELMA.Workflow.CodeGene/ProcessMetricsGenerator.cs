using System;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.CodeGeneration;

public class ProcessMetricsGenerator : ProcessContextGenerator
{
	private static ProcessMetricsGenerator MhuwY1OYzlrIjVYsccID;

	protected override bool IsWorkflowInstanceContext => false;

	protected override ISyntaxNode GetBaseClass()
	{
		//Discarded unreachable code: IL_0039, IL_004c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (!DsjN7IO8YMOdg2hsu3hu(base.generationParams))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 5:
				return (ISyntaxNode)I79IoDO8sBQfcZqglnaK(KEvvxSO88ZYNQu5f718N(typeof(WorkflowTablePartEntity).TypeHandle));
			case 3:
				return (ISyntaxNode)I79IoDO8sBQfcZqglnaK(KEvvxSO88ZYNQu5f718N(typeof(WorkflowProcessMetricValues).TypeHandle));
			case 4:
				return base.GetBaseClass();
			case 2:
				if (metadata is IProcessContext)
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 1:
				slnEwYO8vAI945byvSob(metadata, FIX23XO8ZBvC2ZKOYHPq(-772614310 ^ -772586802));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ProcessMetricsGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YoNXp3O8JTeIdhrlLFyC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object FIX23XO8ZBvC2ZKOYHPq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void slnEwYO8vAI945byvSob(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static bool DsjN7IO8YMOdg2hsu3hu(object P_0)
	{
		return ((ProcessContextGenerationParams)P_0).IsFullContext;
	}

	internal static Type KEvvxSO88ZYNQu5f718N(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object I79IoDO8sBQfcZqglnaK(Type P_0)
	{
		return P_0.CreateTypeSyntax();
	}

	internal static bool MEIG4vO8KK19WT2lw5BE()
	{
		return MhuwY1OYzlrIjVYsccID == null;
	}

	internal static ProcessMetricsGenerator X0dPb5O8OJP6YUDI3HQT()
	{
		return MhuwY1OYzlrIjVYsccID;
	}

	internal static void YoNXp3O8JTeIdhrlLFyC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
