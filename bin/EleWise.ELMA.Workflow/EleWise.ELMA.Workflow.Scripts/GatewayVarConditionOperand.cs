using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scripts;

[Component]
public class GatewayVarConditionOperand : IConditionOperandEvaluator
{
	public static readonly Guid UID;

	public const string ParameterName = "GatewayVar";

	private static GatewayVarConditionOperand GL1yvxmYBnZWS8XBGpC;

	public Guid Uid => UID;

	public ConditionTableEvaluator.OperandValue Evaluate(ConditionTable.Operand operand, object obj, Dictionary<string, object> additionalParams)
	{
		additionalParams.TryGetValue(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA730D38), out var value);
		if (value == null)
		{
			return null;
		}
		return new ConditionTableEvaluator.OperandValue
		{
			Value = value
		};
	}

	public GatewayVarConditionOperand()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FaiMORmJiSrRfbOkf7t();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static GatewayVarConditionOperand()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)mvtJbVmlfa02GqN6xhA(0x4943E3E4 ^ 0x4943D70A));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void FaiMORmJiSrRfbOkf7t()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool TQTXQkm8bFHCuchZ9Ja()
	{
		return GL1yvxmYBnZWS8XBGpC == null;
	}

	internal static GatewayVarConditionOperand Htknhbms4umHTZRRvi3()
	{
		return GL1yvxmYBnZWS8XBGpC;
	}

	internal static object mvtJbVmlfa02GqN6xhA(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
