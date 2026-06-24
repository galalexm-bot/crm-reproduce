using System;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class AssignedRoleStereotypeManager : EntityManager<IAssignedRoleStereotype, long>
{
	internal static AssignedRoleStereotypeManager qEaZGMEy50Qengd809X;

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
				Locator.GetServiceNotNull<IMetadataRuntimeService>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				type = InterfaceActivator.TypeOf<IAssignedRoleStereotype>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			{
				ExportRuleList exportRuleList = new ExportRuleList();
				ExportRule exportRule = new ExportRule();
				x917l8E9jt3ZYaWZqod(exportRule, type);
				ld9JdAE16eBCOeiQMvj(exportRule, oybvxGEfArS0N0tcYus(0x6AA79E0 ^ 0x6AAFA00));
				uLnVnaEzw0hioBjeGm6(exportRule, ExportRuleType.Export);
				exportRuleList.Add(exportRule);
				ExportRule exportRule2 = new ExportRule();
				x917l8E9jt3ZYaWZqod(exportRule2, type);
				ld9JdAE16eBCOeiQMvj(exportRule2, oybvxGEfArS0N0tcYus(-230994601 ^ -230962827));
				uLnVnaEzw0hioBjeGm6(exportRule2, ExportRuleType.Export);
				exportRuleList.Add(exportRule2);
				ExportRule exportRule3 = new ExportRule();
				x917l8E9jt3ZYaWZqod(exportRule3, type);
				exportRule3.PropertyName = (string)oybvxGEfArS0N0tcYus(0x71BC7C31 ^ 0x71BC73AF);
				exportRule3.ExportRuleType = ExportRuleType.Export;
				exportRuleList.Add(exportRule3);
				return exportRuleList;
			}
			}
		}
	}

	public AssignedRoleStereotypeManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LpVXVNDkyXXCoyBtxst();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void x917l8E9jt3ZYaWZqod(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static object oybvxGEfArS0N0tcYus(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void ld9JdAE16eBCOeiQMvj(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void uLnVnaEzw0hioBjeGm6(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static bool DVRpyPEbSO7EX8bRQEA()
	{
		return qEaZGMEy50Qengd809X == null;
	}

	internal static AssignedRoleStereotypeManager wvck1QESEpUjIFPx8I7()
	{
		return qEaZGMEy50Qengd809X;
	}

	internal static void LpVXVNDkyXXCoyBtxst()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
