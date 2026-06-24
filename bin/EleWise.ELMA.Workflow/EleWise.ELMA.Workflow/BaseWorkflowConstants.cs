using System;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow;

public static class BaseWorkflowConstants
{
	public static readonly string ExportIsNeedToPublishProcessesPrefix;

	public static readonly string ExportProcessToPublishPrefix;

	public static readonly Guid FullMonitorGroupId;

	public static readonly GroupDescriptor FullMonitorGroupDescriptor;

	public static readonly Guid RecalcTaskOfInstanceCountGuid;

	public static readonly Guid ScriptErrorNotificationSendPermissionGroupId;

	public static readonly GroupDescriptor ScriptErrorNotificationSendPermissionGroupDescriptor;

	public static Guid RecipientExecutorChiefUid;

	public static Guid RecipientPropertyUid;

	internal static BaseWorkflowConstants LOMBtFOtTqoy0x5NV2l;

	static BaseWorkflowConstants()
	{
		int num = 8;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					ScriptErrorNotificationSendPermissionGroupDescriptor = new GroupDescriptor(ScriptErrorNotificationSendPermissionGroupId, SR.T((string)yqlY7gOBJVwAmTjCtJN(-2122743969 ^ -2122745241)), SR.T((string)yqlY7gOBJVwAmTjCtJN(-1716458555 ^ -1716457875)));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					RecalcTaskOfInstanceCountGuid = new Guid((string)yqlY7gOBJVwAmTjCtJN(-980570076 ^ -980568900));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					FullMonitorGroupDescriptor = new GroupDescriptor(FullMonitorGroupId, (string)n0bHYpOcXI0lpWvFw5f(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25710524)), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057730907)));
					num2 = 2;
					continue;
				default:
					ExportProcessToPublishPrefix = (string)yqlY7gOBJVwAmTjCtJN(0x361628FF ^ 0x36162BD3);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 10;
					}
					continue;
				case 3:
					RecipientExecutorChiefUid = new Guid((string)yqlY7gOBJVwAmTjCtJN(-1965291699 ^ -1965293259));
					num2 = 4;
					continue;
				case 8:
					basa45OgBaOB0JDLcqe();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 7;
					}
					continue;
				case 4:
					RecipientPropertyUid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B51E09));
					num2 = 6;
					continue;
				case 1:
					ScriptErrorNotificationSendPermissionGroupId = new Guid((string)yqlY7gOBJVwAmTjCtJN(--727842433 ^ 0x2B61FA69));
					num2 = 9;
					continue;
				case 6:
					return;
				case 10:
					break;
				case 7:
					ExportIsNeedToPublishProcessesPrefix = (string)yqlY7gOBJVwAmTjCtJN(0x13F63440 ^ 0x13F636AA);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			FullMonitorGroupId = new Guid((string)yqlY7gOBJVwAmTjCtJN(--1436248540 ^ 0x559B6A82));
			num = 5;
		}
	}

	internal static void basa45OgBaOB0JDLcqe()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object yqlY7gOBJVwAmTjCtJN(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object n0bHYpOcXI0lpWvFw5f(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool kLLg6HObQP3wW3Z8EFe()
	{
		return LOMBtFOtTqoy0x5NV2l == null;
	}

	internal static BaseWorkflowConstants wJSCGKO552IeyYvB9Oo()
	{
		return LOMBtFOtTqoy0x5NV2l;
	}
}
