using System;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Managers;

public class ResponsibilityMatrixItemManager : EntityManager<IResponsibilityMatrixItem, long>
{
	internal static ResponsibilityMatrixItemManager VbYtaSOGw88Fr5xe38lA;

	public new static ResponsibilityMatrixItemManager Instance => Locator.GetServiceNotNull<ResponsibilityMatrixItemManager>();

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = InterfaceActivator.TypeOf<IResponsibilityMatrixItem>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			uMlnT0O7KwkJoip280HT(exportRule, type);
			XYpjmeO7ZyODCy99pnej(exportRule, vUMLLiO7OpMON7T9yUrw(-667465279 ^ -667478049));
			gYAVTfO7vtPBD5LoAMW5(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			uMlnT0O7KwkJoip280HT(exportRule2, type);
			exportRule2.PropertyName = (string)vUMLLiO7OpMON7T9yUrw(-17847711 ^ -17972063);
			exportRule2.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule2);
			ExportRule exportRule3 = new ExportRule();
			uMlnT0O7KwkJoip280HT(exportRule3, type);
			exportRule3.PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11821062);
			gYAVTfO7vtPBD5LoAMW5(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			XYpjmeO7ZyODCy99pnej(obj, vUMLLiO7OpMON7T9yUrw(0x13F63440 ^ 0x13F45A9E));
			gYAVTfO7vtPBD5LoAMW5(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type
			};
			XYpjmeO7ZyODCy99pnej(obj2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x7381B7F1));
			obj2.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(obj2);
			ExportRule exportRule4 = new ExportRule();
			uMlnT0O7KwkJoip280HT(exportRule4, type);
			XYpjmeO7ZyODCy99pnej(exportRule4, vUMLLiO7OpMON7T9yUrw(0x5DB28AD2 ^ 0x5DB2D5D4));
			gYAVTfO7vtPBD5LoAMW5(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule exportRule5 = new ExportRule();
			uMlnT0O7KwkJoip280HT(exportRule5, type);
			XYpjmeO7ZyODCy99pnej(exportRule5, vUMLLiO7OpMON7T9yUrw(0x6A69C5CD ^ 0x6A6BAB39));
			gYAVTfO7vtPBD5LoAMW5(exportRule5, ExportRuleType.Export);
			exportRuleList.Add(exportRule5);
			ExportRule obj3 = new ExportRule
			{
				ParentType = type,
				PropertyName = (string)vUMLLiO7OpMON7T9yUrw(0x75872B6 ^ 0x75834CA)
			};
			gYAVTfO7vtPBD5LoAMW5(obj3, ExportRuleType.Export);
			exportRuleList.Add(obj3);
			ExportRule obj4 = new ExportRule
			{
				ParentType = type,
				PropertyName = (string)vUMLLiO7OpMON7T9yUrw(-1574607501 ^ -1574618133)
			};
			gYAVTfO7vtPBD5LoAMW5(obj4, ExportRuleType.Export);
			exportRuleList.Add(obj4);
			ExportRule exportRule6 = new ExportRule();
			uMlnT0O7KwkJoip280HT(exportRule6, type);
			XYpjmeO7ZyODCy99pnej(exportRule6, vUMLLiO7OpMON7T9yUrw(-1001967776 ^ -1001950772));
			gYAVTfO7vtPBD5LoAMW5(exportRule6, ExportRuleType.Export);
			exportRuleList.Add(exportRule6);
			return exportRuleList;
		}
	}

	public ResponsibilityMatrixItemManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rZcbF0O7YdHkuctgBhUn();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void uMlnT0O7KwkJoip280HT(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static object vUMLLiO7OpMON7T9yUrw(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void XYpjmeO7ZyODCy99pnej(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void gYAVTfO7vtPBD5LoAMW5(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static bool yqNdhlOG4dRiK73MhfCY()
	{
		return VbYtaSOGw88Fr5xe38lA == null;
	}

	internal static ResponsibilityMatrixItemManager cDQph0OGzayeSZngj57o()
	{
		return VbYtaSOGw88Fr5xe38lA;
	}

	internal static void rZcbF0O7YdHkuctgBhUn()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
