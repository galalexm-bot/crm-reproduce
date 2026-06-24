using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.DTO.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Deploy.Export;

[Component]
public class CheckCanExportWorkflow : ICheckCanExport
{
	internal static CheckCanExportWorkflow N4MeAQOOU6xCTCZ3GVnH;

	public string CanExport()
	{
		return (string)LyJwuaOOGxJmNv4unNI4(Locator.GetServiceNotNull<IProcessContextDTOManager>());
	}

	public bool AdditionalActions()
	{
		//Discarded unreachable code: IL_004f, IL_0081, IL_00b9, IL_00c8
		switch (1)
		{
		case 1:
			try
			{
				LyJwuaOOGxJmNv4unNI4(Locator.GetServiceNotNull<IProcessContextDTOManager>());
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			catch (Exception)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
				{
					num2 = 0;
				}
				bool result = default(bool);
				while (true)
				{
					switch (num2)
					{
					case 1:
						return result;
					}
					result = false;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 1;
					}
				}
			}
			break;
		}
		return true;
	}

	public CheckCanExportWorkflow()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		js7eOZOO7AgOvEA6iBGJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object LyJwuaOOGxJmNv4unNI4(object P_0)
	{
		return ((IProcessContextDTOManager)P_0).AllHaveUids();
	}

	internal static bool BliMc1OOVJ1BAoRge1u5()
	{
		return N4MeAQOOU6xCTCZ3GVnH == null;
	}

	internal static CheckCanExportWorkflow qX2gMgOOAjO79M3VvnvB()
	{
		return N4MeAQOOU6xCTCZ3GVnH;
	}

	internal static void js7eOZOO7AgOvEA6iBGJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
