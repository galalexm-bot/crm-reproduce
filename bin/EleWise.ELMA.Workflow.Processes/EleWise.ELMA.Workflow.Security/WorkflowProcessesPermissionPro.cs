using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class WorkflowProcessesPermissionProvider : IPermissionProvider
{
	public const string Module = "EleWise.ELMA.Workflow";

	public static string ModuleName;

	public const string MyProcessAdminPermissionId = "0E660DD1-F26F-4466-8E4D-D1584C2C086D";

	public const string MonitorAccessPermissionId = "61F8D4F7-C299-4B44-9B4F-A56C2F63B15B";

	public const string MonitorAdminPermissionId = "7B520A7D-6F69-4E31-AF7F-663F5ACEDB10";

	public const string DocumentationAccessPermissionId = "E33F5F85-D627-41C0-A938-358C14811367";

	public const string FullDocumentationAccessPermissionId = "168AC634-6688-427B-8D2E-B72CB6B00747";

	public const string ImprovementModulePermissionId = "38A743DC-7DDB-4ACD-94C7-323F8014E881";

	public const string CreateImprovementPermissionId = "9E944413-08E5-45D8-BB34-2BD584B4AEC2";

	[Obsolete("Устаревшее, используйте ImprovementAccessPermissionId", true)]
	public const string WorkflowAccessPermissionId = "70E84328-D900-4584-A798-5D13DD17F6D0";

	public const string ImprovementAccessPermissionId = "70E84328-D900-4584-A798-5D13DD17F6D0";

	public const string ImprovementExecutionAccessPermissionId = "6B5D2304-E728-45E7-8834-9879518AE950";

	public const string ImprovementAdminPermissionId = "2C6C2B83-515A-460C-97CE-4A492FBFA0D3";

	public const string WorkflowQueueManagementPermissionId = "{B68AE858-467E-4AFA-8D02-A8BACE0EB955}";

	public static readonly Permission ImprovementModulePermission;

	public static readonly Permission CreateImprovementPermission;

	public static readonly Permission ImprovementAccessPermission;

	public static readonly Permission ImprovementExecutionAccessPermission;

	public static readonly Permission ImprovementAdminPermission;

	public static readonly Permission MyProcessAdminPermission;

	public static readonly Permission MonitorAccessPermission;

	public static readonly Permission MonitorAdminPermission;

	public static readonly Permission DocumentationAccessPermission;

	public static readonly Permission FullDocumentationAccessPermission;

	public static readonly Permission WorkflowQueueManagementPermission;

	internal static WorkflowProcessesPermissionProvider MEyXkLCGHr2Px8oGhKe;

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[11]
		{
			MyProcessAdminPermission, MonitorAccessPermission, MonitorAdminPermission, ImprovementModulePermission, CreateImprovementPermission, ImprovementAccessPermission, ImprovementAdminPermission, ImprovementExecutionAccessPermission, DocumentationAccessPermission, FullDocumentationAccessPermission,
			WorkflowQueueManagementPermission
		};
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return new PermissionStereotype[4]
		{
			new PermissionStereotype(new List<Permission> { MyProcessAdminPermission, MonitorAdminPermission, ImprovementAdminPermission, FullDocumentationAccessPermission, WorkflowQueueManagementPermission }, SecurityConstants.AdminGroupDescriptor),
			new PermissionStereotype(new List<Permission> { MonitorAccessPermission, ImprovementModulePermission, CreateImprovementPermission, DocumentationAccessPermission }, SecurityConstants.AllUsersGroupDescriptor),
			new PermissionStereotype(new List<Permission> { ImprovementAccessPermission }, WorkflowConstants.ImprovementAllProcessesGroupDescriptor),
			new PermissionStereotype(new List<Permission> { ImprovementExecutionAccessPermission }, WorkflowConstants.ImprovementProcessesGroupDescriptor)
		};
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		return new Dictionary<Permission, string>
		{
			{
				MyProcessAdminPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20C96B1E ^ 0x20C96720)
			},
			{
				MonitorAccessPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51F798FE ^ 0x51F7948C)
			},
			{
				MonitorAdminPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-5433396 ^ -5432472)
			},
			{
				ImprovementModulePermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x27A6CAB5 ^ 0x27A6C661)
			},
			{
				CreateImprovementPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFAE81C9 ^ 0xFAE8CC7)
			},
			{
				ImprovementAccessPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x467974A9 ^ 0x467979E1)
			},
			{
				ImprovementAdminPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31D4A123 ^ 0x31D4ACA1)
			},
			{
				ImprovementExecutionAccessPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-416187968 ^ -416189318)
			},
			{
				DocumentationAccessPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633140121 ^ -1633137567)
			},
			{
				FullDocumentationAccessPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x124714F0 ^ 0x12471AB4)
			}
		};
	}

	public WorkflowProcessesPermissionProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pLDV9DCONmo3b4Z8Icm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowProcessesPermissionProvider()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 7:
				ImprovementAdminPermission = new Permission((string)KggZ0tC6XTkLC0qBwKK(-92270799 ^ -92266927), (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(-982315145 ^ -982311205)), (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(-796330436 ^ -796335056)), ModuleName, null, (string)KggZ0tC6XTkLC0qBwKK(-79921577 ^ -79923787));
				num2 = 11;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 != 0)
				{
					num2 = 7;
				}
				break;
			case 6:
				MonitorAccessPermission = new Permission((string)KggZ0tC6XTkLC0qBwKK(-351702578 ^ -351706542), SR.M((string)KggZ0tC6XTkLC0qBwKK(-2125832759 ^ -2125836767)), "", ModuleName, null, (string)KggZ0tC6XTkLC0qBwKK(0x48B7D69C ^ 0x48B7DD7E));
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				DocumentationAccessPermission = new Permission(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x29336E79 ^ 0x29337B33), (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(0x66914DC5 ^ 0x66915853)), "", ModuleName, null, (string)KggZ0tC6XTkLC0qBwKK(0x32F3F75 ^ 0x32F3497));
				num2 = 13;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead != 0)
				{
					num2 = 10;
				}
				break;
			default:
				WorkflowQueueManagementPermission = new Permission((string)KggZ0tC6XTkLC0qBwKK(0x3C126B81 ^ 0x3C127D7D), (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(-1979431200 ^ -1979428436)), (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(-444713948 ^ -444718204)), ModuleName, null, (string)KggZ0tC6XTkLC0qBwKK(--230863782 ^ 0xDC2B844));
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 != 0)
				{
					num2 = 8;
				}
				break;
			case 8:
				return;
			case 10:
				CreateImprovementPermission = new Permission((string)KggZ0tC6XTkLC0qBwKK(-711228462 ^ -711226214), (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(-949720076 ^ -949722016)), "", ModuleName, null, (string)KggZ0tC6XTkLC0qBwKK(0x48FD6D2E ^ 0x48FD66CC));
				num2 = 12;
				break;
			case 3:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				ImprovementExecutionAccessPermission = new Permission((string)KggZ0tC6XTkLC0qBwKK(-2144947971 ^ -2144952223), (string)hPKIpqCRCnaRB2FsGOO(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-588615921 ^ -588611609)), "", ModuleName, null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--47835757 ^ 0x2D9E18F), PermissionType.Global, null, null, showInGlobalSettings: true, readOnly: true);
				num2 = 7;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead != 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				MonitorAdminPermission = new Permission((string)KggZ0tC6XTkLC0qBwKK(-882646278 ^ -882641202), SR.M(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x467974A9 ^ 0x46796029)), (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(0x927D360 ^ 0x927C7AE)), ModuleName, null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x33BD2188 ^ 0x33BD2A6A));
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
				{
					num2 = 2;
				}
				break;
			case 11:
				MyProcessAdminPermission = new Permission((string)KggZ0tC6XTkLC0qBwKK(0x77CE159B ^ 0x77CE0701), (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(-254800515 ^ -254795877)), (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(-1535001335 ^ -1535005149)), ModuleName, null, (string)KggZ0tC6XTkLC0qBwKK(-474638327 ^ -474639381));
				num2 = 6;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 == 0)
				{
					num2 = 5;
				}
				break;
			case 12:
				ImprovementAccessPermission = new Permission((string)KggZ0tC6XTkLC0qBwKK(0x27A6CAB5 ^ 0x27A6C543), SR.M(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x47356CA4 ^ 0x47357CE6)), "", ModuleName, null, (string)KggZ0tC6XTkLC0qBwKK(-1941486619 ^ -1941485561), PermissionType.Global, null, null, showInGlobalSettings: true, readOnly: true);
				num2 = 9;
				break;
			case 13:
				FullDocumentationAccessPermission = new Permission((string)KggZ0tC6XTkLC0qBwKK(0x3F8E27D0 ^ 0x3F8E3230), (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(-1587393812 ^ -1587389248)), (string)hPKIpqCRCnaRB2FsGOO(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48B7D69C ^ 0x48B7C018)), ModuleName, null, (string)KggZ0tC6XTkLC0qBwKK(-97750002 ^ -97746964));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9451b1fac1ed452e82e1cbd5a96b41fd == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				ImprovementModulePermission = new Permission((string)KggZ0tC6XTkLC0qBwKK(-588615921 ^ -588619375), SR.M(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31D4A123 ^ 0x31D4AFC9)), "", ModuleName, null, (string)KggZ0tC6XTkLC0qBwKK(-1941486619 ^ -1941485561));
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 == 0)
				{
					num2 = 10;
				}
				break;
			case 2:
				ModuleName = (string)hPKIpqCRCnaRB2FsGOO(KggZ0tC6XTkLC0qBwKK(-1941486619 ^ -1941484177));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void pLDV9DCONmo3b4Z8Icm()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool VZK2giCnWU8kiy4x7EA()
	{
		return MEyXkLCGHr2Px8oGhKe == null;
	}

	internal static WorkflowProcessesPermissionProvider RQsFYoCyno4VEoB3UwP()
	{
		return MEyXkLCGHr2Px8oGhKe;
	}

	internal static object KggZ0tC6XTkLC0qBwKK(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hPKIpqCRCnaRB2FsGOO(object P_0)
	{
		return SR.M((string)P_0);
	}
}
