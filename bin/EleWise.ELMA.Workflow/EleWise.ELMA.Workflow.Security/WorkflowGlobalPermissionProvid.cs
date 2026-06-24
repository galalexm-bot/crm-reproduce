using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class WorkflowGlobalPermissionProvider : IPermissionProvider, IModuleAccessPermissionProvider
{
	public const string Module = "EleWise.ELMA.Workflow";

	public static string ModuleName;

	public const string WorkflowAccessPermissionId = "0B0F7BD9-70C9-4AE6-8077-182ABF3DD8A6";

	public const string AccessManagmentPermissionId = "6F77877D-8DD0-42EF-ACC2-778C3103C169";

	public const string WorkflowExportPermissionId = "6302CC09-6975-4177-9355-D1D6FA9B5982";

	public static readonly Permission WorkflowAccessPermission;

	public static readonly Permission AccessManagmentPermission;

	public static readonly Permission WorkflowExportPermission;

	private static WorkflowGlobalPermissionProvider KO0m27y1div7oEvVjwy;

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[3] { WorkflowAccessPermission, AccessManagmentPermission, WorkflowExportPermission };
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return new PermissionStereotype[2]
		{
			new PermissionStereotype(GetPermissions(), SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new Permission[1] { WorkflowAccessPermission }, SecurityConstants.AllUsersGroupDescriptor)
		};
	}

	public Dictionary<string, Permission> GetModuleAccessPermissions()
	{
		return new Dictionary<string, Permission> { 
		{
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768801301),
			WorkflowAccessPermission
		} };
	}

	public WorkflowGlobalPermissionProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dtOngsywHxHH2QRiD3C();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowGlobalPermissionProvider()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				ModuleName = (string)smSeCMyzCQjrjF3yRFL(H53ddYy428B64JeAKV9(-790221436 ^ -790223034));
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				dtOngsywHxHH2QRiD3C();
				num2 = 3;
				break;
			case 1:
				return;
			default:
				AccessManagmentPermission = new Permission((string)H53ddYy428B64JeAKV9(-1214182792 ^ -1214170672), (string)smSeCMyzCQjrjF3yRFL(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002068449)), "", ModuleName, null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22349492));
				num2 = 2;
				break;
			case 2:
				WorkflowExportPermission = new Permission((string)H53ddYy428B64JeAKV9(-452127399 ^ -452124355), (string)smSeCMyzCQjrjF3yRFL(H53ddYy428B64JeAKV9(0xD305CC2 ^ 0xD306872)), "", ModuleName, null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197779332));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				WorkflowAccessPermission = new Permission((string)H53ddYy428B64JeAKV9(0x6F6D7B44 ^ 0x6F6D4860), (string)smSeCMyzCQjrjF3yRFL(H53ddYy428B64JeAKV9(-1712492721 ^ -1712497601)), "", ModuleName, null, (string)H53ddYy428B64JeAKV9(0x5F800F5B ^ 0x5F800DE7));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void dtOngsywHxHH2QRiD3C()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool yTskBlyh2fD26OZMPvi()
	{
		return KO0m27y1div7oEvVjwy == null;
	}

	internal static WorkflowGlobalPermissionProvider pVm6CFyEIn6usKJTIX5()
	{
		return KO0m27y1div7oEvVjwy;
	}

	internal static object H53ddYy428B64JeAKV9(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object smSeCMyzCQjrjF3yRFL(object P_0)
	{
		return SR.M((string)P_0);
	}
}
