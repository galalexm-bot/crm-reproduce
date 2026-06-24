using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class MonitorPublishedProcessFilterProvider : PublishedProcessFilterProvider
{
	public new const string UID_S = "F0554E03-91C9-47C3-892B-270A3DF8D896";

	public new static readonly Guid UID;

	internal static MonitorPublishedProcessFilterProvider FB7f4WOJb0QFGu0gx0Oa;

	public override Guid ProviderUid => UID;

	public override void ApplyFilter(IEntityFilter filter, string data)
	{
		int num = 1;
		int num2 = num;
		IProcessHeaderFilter processHeaderFilter = default(IProcessHeaderFilter);
		while (true)
		{
			switch (num2)
			{
			default:
				processHeaderFilter = filter as IProcessHeaderFilter;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 1:
				base.ApplyFilter(filter, data);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (processHeaderFilter != null)
				{
					x5lKgyOJBaTFkAfIAFFY(processHeaderFilter, true);
					num2 = 3;
					break;
				}
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public MonitorPublishedProcessFilterProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rIYIpEOJc6Qr3ot9CMjB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MonitorPublishedProcessFilterProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				rIYIpEOJc6Qr3ot9CMjB();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				UID = new Guid((string)DNV7cwOJPxSyokXct2m1(0x350C0E8 ^ 0x3515E48));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void x5lKgyOJBaTFkAfIAFFY(object P_0, bool value)
	{
		((IProcessHeaderFilter)P_0).MonitorProcessHeaderFilter = value;
	}

	internal static bool rhRSI3OJ5Q4eWmCQTOAO()
	{
		return FB7f4WOJb0QFGu0gx0Oa == null;
	}

	internal static MonitorPublishedProcessFilterProvider FB1LC3OJgPXNRTBMvCYF()
	{
		return FB7f4WOJb0QFGu0gx0Oa;
	}

	internal static void rIYIpEOJc6Qr3ot9CMjB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object DNV7cwOJPxSyokXct2m1(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
