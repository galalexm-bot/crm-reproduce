using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scripts.Types;

[Component(Order = 1030)]
public class ConnectorScriptType : OnPropertyChangedScriptType
{
	public new const string UID_S = "{8867BCC7-9F9A-4E9D-BD81-B6F23AAB6E95}";

	public new static readonly Guid UID;

	internal static ConnectorScriptType Sn5HQqmqxHUHMvZ6y33;

	public override Guid Uid => UID;

	public override string Name => (string)aMaIPxmphJ1G5aY192Q(NIXc6rmQtb7D7ysvSEw(-801808857 ^ -801808209));

	public override ScriptMethodDeclaration GenerateMethod(string name, IDictionary<string, object> generationParams = null)
	{
		ScriptMethodDeclaration obj = new ScriptMethodDeclaration
		{
			Name = name
		};
		string entityTypeName = GetEntityTypeName(generationParams);
		obj.Parameters.Add(new ScriptMethodParameter(GetEntityParameterName(generationParams), entityTypeName));
		obj.Parameters.Add(new ScriptMethodParameter(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F85E6D), string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F56AC), entityTypeName)));
		obj.ReturnType = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC07F45);
		return obj;
	}

	protected override string GetEntityTypeName(IDictionary<string, object> generationParams)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x36163867);
	}

	protected override string GetEntityParameterName(IDictionary<string, object> generationParams)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x157D5AF4 ^ 0x157D65C4);
	}

	public ConnectorScriptType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wmcwHVmCPEhuBGBxbbC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ConnectorScriptType()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)NIXc6rmQtb7D7ysvSEw(--1756698829 ^ 0x68B5278F));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				wmcwHVmCPEhuBGBxbbC();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object NIXc6rmQtb7D7ysvSEw(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aMaIPxmphJ1G5aY192Q(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool foyxMcm3fV0YXKFCxr3()
	{
		return Sn5HQqmqxHUHMvZ6y33 == null;
	}

	internal static ConnectorScriptType I43DQYmTw8120R5svGm()
	{
		return Sn5HQqmqxHUHMvZ6y33;
	}

	internal static void wmcwHVmCPEhuBGBxbbC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
