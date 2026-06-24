using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class WorkflowPermissionProvider : IPermissionProvider
{
	public const string Module = "EleWise.ELMA.Workflow";

	public static string ModuleName;

	public const string MyProcessesPermissionId = "D1E8731D-2178-4925-9BB2-6284F8EE036A";

	public const string ProcessMonitorId = "{CB35EE6A-A40C-46B9-A9CD-ED7EA2925B04}";

	public const string AssignResponsibleForInstanceId = "{6827E4DF-3E53-4DCD-972F-80664508BBF2}";

	public const string StartProcessId = "{8053A5BC-AA1F-459A-B9F5-06341C6E3072}";

	public const string TerminateProcessId = "{24062AB8-8DAB-4714-B833-F5CF750EA046}";

	public const string ViewTaskListOfInstanceId = "{E9A08507-C44A-481D-A303-2C312EDB8F9A}";

	public const string EditDataProcessId = "{FD757ABA-E275-4459-A90C-90F08A648384}";

	public const string ReassignProcessTaskId = "{BDE596B6-6338-4D5E-8452-4CEA5B3D5D97}";

	public const string MembersManagementId = "{C9B3E5CE-82A5-4BA5-91E7-BF980F27F435}";

	public const string FullMonitorAccessPermissionId = "3534CCCF-2C6A-4510-849D-90B223DC1596";

	public const string ChangeProcessVersionPermissionId = "{DEFDF204-9257-42D1-9989-806D37087944}";

	public const string ScriptErrorNotificationSendPermissionId = "0E0AA6F0-DC53-4FE5-8B46-77B209E10282";

	public static readonly Permission MyProcessesPermission;

	public static readonly Permission ProcessMonitor;

	public static readonly Permission AssignResponsibleForInstance;

	public static readonly Permission TerminateProcess;

	public static readonly Permission StartProcess;

	public static readonly Permission ViewTaskListOfInstance;

	public static readonly Permission EditDataProcess;

	public static readonly Permission ReassignProcessTask;

	public static readonly Permission MembersManagement;

	public static readonly Permission FullMonitorAccessPermission;

	public static readonly Permission ChangeProcessVersionPermission;

	public static readonly Permission ScriptErrorNotificationSendPermission;

	internal static WorkflowPermissionProvider XiUbVMyLPtyo1cNKa53;

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[12]
		{
			MyProcessesPermission, ProcessMonitor, MembersManagement, AssignResponsibleForInstance, TerminateProcess, StartProcess, ViewTaskListOfInstance, EditDataProcess, ReassignProcessTask, FullMonitorAccessPermission,
			ChangeProcessVersionPermission, ScriptErrorNotificationSendPermission
		};
	}

	public static List<Guid> GetPermissionUids()
	{
		return new List<Guid>
		{
			MyProcessesPermission.Id, ProcessMonitor.Id, MembersManagement.Id, AssignResponsibleForInstance.Id, TerminateProcess.Id, StartProcess.Id, ViewTaskListOfInstance.Id, EditDataProcess.Id, ReassignProcessTask.Id, FullMonitorAccessPermission.Id,
			ChangeProcessVersionPermission.Id, ScriptErrorNotificationSendPermission.Id
		};
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return new PermissionStereotype[2]
		{
			new PermissionStereotype(new Permission[1] { FullMonitorAccessPermission }, BaseWorkflowConstants.FullMonitorGroupDescriptor),
			new PermissionStereotype(new Permission[1] { ScriptErrorNotificationSendPermission }, BaseWorkflowConstants.ScriptErrorNotificationSendPermissionGroupDescriptor)
		};
	}

	public Dictionary<Permission, string> GetPermissionNames()
	{
		return new Dictionary<Permission, string>
		{
			{
				MyProcessesPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708118762)
			},
			{
				ProcessMonitor,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B61DB05)
			},
			{
				MembersManagement,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776312486)
			},
			{
				AssignResponsibleForInstance,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -419993725)
			},
			{
				TerminateProcess,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539991275)
			},
			{
				StartProcess,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8D5763A ^ 0x8D55010)
			},
			{
				ViewTaskListOfInstance,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720464091)
			},
			{
				EditDataProcess,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B7D052)
			},
			{
				ReassignProcessTask,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965284907)
			},
			{
				FullMonitorAccessPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x141EFAA)
			},
			{
				ChangeProcessVersionPermission,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559B4F20)
			}
		};
	}

	public WorkflowPermissionProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yuuSF3yW0C6csxuBq7W();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowPermissionProvider()
	{
		int num = 10;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					ModuleName = (string)INcec1yjwWsAxKYNQfu(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F0CF60));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					TerminateProcess = new Permission((string)dRu75myRS0hJLZMLAvD(--1436248540 ^ 0x559B4DCA), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(-1214182792 ^ -1214176500)), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(-197778752 ^ -197784738)), "", null, (string)dRu75myRS0hJLZMLAvD(-1638225214 ^ -1638225794), PermissionType.Instance);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
					{
						num2 = 3;
					}
					continue;
				case 10:
					yuuSF3yW0C6csxuBq7W();
					num2 = 9;
					continue;
				case 8:
					return;
				case 3:
					StartProcess = new Permission((string)dRu75myRS0hJLZMLAvD(-862330810 ^ -862336592), (string)INcec1yjwWsAxKYNQfu(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1927F0D5)), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(-1965291699 ^ -1965282037)), "", null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865214416), PermissionType.Instance);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					ProcessMonitor = new Permission((string)dRu75myRS0hJLZMLAvD(0x595C500A ^ 0x595C732C), (string)INcec1yjwWsAxKYNQfu(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD307B7C)), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(0x7381F16B ^ 0x7381D683)), "", null, (string)dRu75myRS0hJLZMLAvD(-148495695 ^ -148496371), PermissionType.Instance);
					num2 = 4;
					continue;
				case 14:
					ReassignProcessTask = new Permission((string)dRu75myRS0hJLZMLAvD(--296112178 ^ 0x11A67534), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(-720457373 ^ -720462489)), SR.M((string)dRu75myRS0hJLZMLAvD(0x2ACCDD87 ^ 0x2ACCF1B7)), "", null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB2886E), PermissionType.Instance);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					ViewTaskListOfInstance = new Permission((string)dRu75myRS0hJLZMLAvD(0x2269BD32 ^ 0x22699954), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(-949717965 ^ -949723557)), SR.M((string)dRu75myRS0hJLZMLAvD(-495296780 ^ -495291294)), "", null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17848099), PermissionType.Instance);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					EditDataProcess = new Permission((string)dRu75myRS0hJLZMLAvD(0x12F686A ^ 0x12F4CDC), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(0xA7339EE ^ 0xA73129C)), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(0x738ABA6E ^ 0x738A91DC)), "", null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895852387), PermissionType.Instance);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 14;
					}
					continue;
				case 7:
					MembersManagement = new Permission((string)dRu75myRS0hJLZMLAvD(-1638225214 ^ -1638233676), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(-1361036319 ^ -1361045783)), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(0x1C7F6FED ^ 0x1C7F42AB)), "", null, (string)dRu75myRS0hJLZMLAvD(0x361628FF ^ 0x36162A43), PermissionType.Instance);
					num2 = 5;
					continue;
				case 5:
					FullMonitorAccessPermission = new Permission(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39178686), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(-130098986 ^ -130091268)), "", ModuleName, null, (string)dRu75myRS0hJLZMLAvD(-420003255 ^ -420003595));
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num2 = 8;
					}
					continue;
				case 11:
					ScriptErrorNotificationSendPermission = (Permission)hMkN9yyTkHjHuK1fpbQ(EciLK3y3CdYTGNCsxKe(CUdBZSyqiZPDT4ILdPC(ScipOcy6lhiZUnaUMHB(dRu75myRS0hJLZMLAvD(-935313063 ^ -935301425), SR.M((string)dRu75myRS0hJLZMLAvD(0xF400DF8 ^ 0xF4008C0)), "", SR.M((string)dRu75myRS0hJLZMLAvD(0x5F534A5C ^ 0x5F53409E))), dRu75myRS0hJLZMLAvD(0x4943E3E4 ^ 0x4943E158)), true));
					num2 = 8;
					continue;
				case 12:
					ChangeProcessVersionPermission = new Permission((string)dRu75myRS0hJLZMLAvD(-768800937 ^ -768792109), (string)INcec1yjwWsAxKYNQfu(dRu75myRS0hJLZMLAvD(0x56F860D7 ^ 0x56F84E03)), SR.M((string)dRu75myRS0hJLZMLAvD(0x56A753C9 ^ 0x56A77CC3)), "", null, (string)dRu75myRS0hJLZMLAvD(0x1EA50FCC ^ 0x1EA50D70), PermissionType.Instance);
					num2 = 11;
					continue;
				case 4:
					AssignResponsibleForInstance = new Permission((string)dRu75myRS0hJLZMLAvD(0x56A753C9 ^ 0x56A7700F), SR.M(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657576257)), SR.M((string)dRu75myRS0hJLZMLAvD(0x5F534A5C ^ 0x5F5362A0)), "", null, (string)dRu75myRS0hJLZMLAvD(-1542190822 ^ -1542190170), PermissionType.Instance);
					num2 = 6;
					continue;
				}
				break;
			}
			MyProcessesPermission = new Permission((string)dRu75myRS0hJLZMLAvD(-261315199 ^ -261322917), SR.M((string)dRu75myRS0hJLZMLAvD(-667465279 ^ -667455747)), SR.M((string)dRu75myRS0hJLZMLAvD(0x37E97159 ^ 0x37E95601)), "", null, (string)dRu75myRS0hJLZMLAvD(-452127399 ^ -452126747), PermissionType.Instance);
			num = 13;
		}
	}

	internal static void yuuSF3yW0C6csxuBq7W()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool kY9V9uyfo6f9l1lSS9M()
	{
		return XiUbVMyLPtyo1cNKa53 == null;
	}

	internal static WorkflowPermissionProvider rSQThmy9Dj9lI4Oy3a6()
	{
		return XiUbVMyLPtyo1cNKa53;
	}

	internal static object INcec1yjwWsAxKYNQfu(object P_0)
	{
		return SR.M((string)P_0);
	}

	internal static object dRu75myRS0hJLZMLAvD(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ScipOcy6lhiZUnaUMHB(object P_0, object P_1, object P_2, object P_3)
	{
		return Permission.Create((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}

	internal static object CUdBZSyqiZPDT4ILdPC(object P_0, object P_1)
	{
		return ((PermissionBuilder)P_0).ModuleUid((string)P_1);
	}

	internal static object EciLK3y3CdYTGNCsxKe(object P_0, bool P_1)
	{
		return ((PermissionBuilder)P_0).ReadOnly(P_1);
	}

	internal static object hMkN9yyTkHjHuK1fpbQ(object P_0)
	{
		return (Permission)(PermissionBuilder)P_0;
	}
}
