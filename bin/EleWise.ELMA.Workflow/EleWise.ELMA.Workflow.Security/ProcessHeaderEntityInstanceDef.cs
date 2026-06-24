using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Security;

[Component]
public class ProcessHeaderEntityInstanceDefaultPermissions : IEntityInstanceDefaultPermission
{
	private class PermissionHelper
	{
		private object header;

		private static object zHhZxLZWKe5BTXbdLSBS;

		public PermissionHelper(IProcessHeader header)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				this.header = header;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
				{
					num = 0;
				}
			}
		}

		public void AddPermission(string permissionId, PermissionRoleType role)
		{
			int num = 2;
			int num2 = num;
			IProcessHeaderAccess @new = default(IProcessHeaderAccess);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					((IProcessHeader)header).AccessSettings.Add(@new);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
				{
					InstanceOf<IProcessHeaderAccess> instanceOf = new InstanceOf<IProcessHeaderAccess>();
					instanceOf.New.PermissionRole = kG72FHZWvNdmlPuxCtOo(role);
					KlBeNnZWY9KZT5C71Tqj(instanceOf.New, header);
					JVL5wGZW8cXgsNZRQHtm(instanceOf.New, new Guid(permissionId));
					@new = instanceOf.New;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 1;
					}
					break;
				}
				}
			}
		}

		internal static bool e9A9t5ZWOUgYyPrnTZkY()
		{
			return zHhZxLZWKe5BTXbdLSBS == null;
		}

		internal static PermissionHelper lrlmXaZWZA88skS2tIus()
		{
			return (PermissionHelper)zHhZxLZWKe5BTXbdLSBS;
		}

		internal static Guid kG72FHZWvNdmlPuxCtOo(object P_0)
		{
			return ((PermissionRoleType)P_0).UID;
		}

		internal static void KlBeNnZWY9KZT5C71Tqj(object P_0, object P_1)
		{
			((IProcessHeaderAccess)P_0).ProcessHeader = (IProcessHeader)P_1;
		}

		internal static void JVL5wGZW8cXgsNZRQHtm(object P_0, Guid value)
		{
			((IProcessHeaderAccess)P_0).PermissionId = value;
		}
	}

	private static ProcessHeaderEntityInstanceDefaultPermissions AxwAp4lhcYSSSISCM9j;

	public Type EntityType => InterfaceActivator.TypeOf<IProcessHeader>();

	public bool Disable
	{
		[CompilerGenerated]
		get
		{
			return _003CDisable_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CDisable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public void CreatePermissions(IEntity entity)
	{
		//Discarded unreachable code: IL_0311
		int num = 1;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (!Disable)
				{
					processHeader = entity as IProcessHeader;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 5:
				return;
			case 4:
				return;
			case 3:
			{
				PermissionHelper permissionHelper = new PermissionHelper(processHeader);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(-1214182792 ^ -1214175070), WorkflowRoleTypes.CurrentExecutor);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(-801808857 ^ -801800963), WorkflowRoleTypes.Initiator);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(-801808857 ^ -801800963), WorkflowRoleTypes.ResponsibleForInstance);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(-63028171 ^ -63019245), WorkflowRoleTypes.ProcessOwner);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(0x65B7F624 ^ 0x65B7D502), WorkflowRoleTypes.ProcessCurator);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(--1436248540 ^ 0x559B4AAA), WorkflowRoleTypes.ProcessOwner);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(0x141C968 ^ 0x141EA1E), WorkflowRoleTypes.ResponsibleForInstance);
				permissionHelper.AddPermission((string)gJYl7rl4w6fX5Pf3isT(-10408775 ^ -10416257), WorkflowRoleTypes.ProcessOwner);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(-708128192 ^ -708120186), WorkflowRoleTypes.Initiator);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(0x628167BE ^ 0x628143A8), WorkflowRoleTypes.ProcessOwner);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(0x5DB28AD2 ^ 0x5DB2AEC4), WorkflowRoleTypes.Initiator);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(-22348816 ^ -22356074), WorkflowRoleTypes.ProcessOwner);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(-949717965 ^ -949727147), WorkflowRoleTypes.ResponsibleForInstance);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -29974338), WorkflowRoleTypes.CurrentExecutor);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(--601115071 ^ 0x23D46DD9), WorkflowRoleTypes.DirectorsOfCurrentExecutor);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(-1600060848 ^ -1600051658), WorkflowRoleTypes.Initiator);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(0x1134D2C0 ^ 0x1134F676), WorkflowRoleTypes.ProcessOwner);
				permissionHelper.AddPermission((string)gJYl7rl4w6fX5Pf3isT(0x1C7F6FED ^ 0x1C7F4B5B), WorkflowRoleTypes.ResponsibleForInstance);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, gJYl7rl4w6fX5Pf3isT(0x2ACCDD87 ^ 0x2ACCF881), WorkflowRoleTypes.ProcessOwner);
				Y7lyT8lz2InxrdlTK3i(permissionHelper, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657575133), WorkflowRoleTypes.ResponsibleForInstance);
				permissionHelper.AddPermission((string)gJYl7rl4w6fX5Pf3isT(0x5F534A5C ^ 0x5F536F5A), WorkflowRoleTypes.DirectorsOfCurrentExecutor);
				num2 = 5;
				break;
			}
			case 2:
				if (processHeader == null)
				{
					return;
				}
				num2 = 3;
				break;
			}
		}
	}

	public ProcessHeaderEntityInstanceDefaultPermissions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jsxyRe0KtVTYUErS9YL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool LbLoqglE79K33MPx7in()
	{
		return AxwAp4lhcYSSSISCM9j == null;
	}

	internal static ProcessHeaderEntityInstanceDefaultPermissions XShri1lwjVsFWZVDGxw()
	{
		return AxwAp4lhcYSSSISCM9j;
	}

	internal static object gJYl7rl4w6fX5Pf3isT(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Y7lyT8lz2InxrdlTK3i(object P_0, object P_1, object P_2)
	{
		((PermissionHelper)P_0).AddPermission((string)P_1, (PermissionRoleType)P_2);
	}

	internal static void jsxyRe0KtVTYUErS9YL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
