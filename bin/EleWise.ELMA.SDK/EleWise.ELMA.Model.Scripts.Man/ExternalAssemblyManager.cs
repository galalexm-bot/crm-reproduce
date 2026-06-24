using System;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Manager;

public class ExternalAssemblyManager : EntityManager<IExternalAssembly, long>
{
	internal static ExternalAssemblyManager RPVDijbnOKX2KBSQlQmH;

	public new static ExternalAssemblyManager Instance => Locator.GetServiceNotNull<ExternalAssemblyManager>();

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
				type = InterfaceActivator.TypeOf<IExternalAssembly>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			OYyLLqbnPXQUCd3Zm0lX(exportRule, type);
			exportRule.PropertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE12465D);
			xP1V9Gbn1cB9NnC69TFV(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			OYyLLqbnPXQUCd3Zm0lX(exportRule2, type);
			Qbl8PBbn3p7fOPqor2SB(exportRule2, DtVXPMbnN6A8g6PFLHiS(-1146510045 ^ -1146497309));
			xP1V9Gbn1cB9NnC69TFV(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			Qbl8PBbn3p7fOPqor2SB(obj, DtVXPMbnN6A8g6PFLHiS(0xD3DEF7E ^ 0xD3F5258));
			xP1V9Gbn1cB9NnC69TFV(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule3 = new ExportRule();
			OYyLLqbnPXQUCd3Zm0lX(exportRule3, type);
			Qbl8PBbn3p7fOPqor2SB(exportRule3, DtVXPMbnN6A8g6PFLHiS(-812025778 ^ -811874956));
			xP1V9Gbn1cB9NnC69TFV(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			return exportRuleList;
		}
	}

	public ExternalAssemblyManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void OYyLLqbnPXQUCd3Zm0lX(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static void xP1V9Gbn1cB9NnC69TFV(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}

	internal static object DtVXPMbnN6A8g6PFLHiS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Qbl8PBbn3p7fOPqor2SB(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static bool zglsLwbn2x3hmmivKaRw()
	{
		return RPVDijbnOKX2KBSQlQmH == null;
	}

	internal static ExternalAssemblyManager bTeZuvbneSkjaXHOvM7x()
	{
		return RPVDijbnOKX2KBSQlQmH;
	}
}
