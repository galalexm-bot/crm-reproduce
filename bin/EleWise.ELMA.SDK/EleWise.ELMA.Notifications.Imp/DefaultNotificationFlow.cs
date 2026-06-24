using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

[Component(Order = int.MaxValue)]
public class DefaultNotificationFlow : INotificationFlow
{
	public static readonly Guid UID;

	private static DefaultNotificationFlow IB6X78DGAuaDPNSLeW9;

	public Guid Uid => UID;

	public string Name => SR.T((string)zEJ4auDQQ9kXOGVMXjl(0x34A6D230 ^ 0x34A656F2));

	public IEnumerable<INotificationFlowObject> FlowObjects => from nfo in ComponentManager.Current.GetExtensionPoints<INotificationFlowObject>()
		where YJRsCcDv3dURotPMBdq(nfo, Uid)
		select nfo;

	public DefaultNotificationFlow()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KHtqehDC5RtGYid072y();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DefaultNotificationFlow()
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
				KHtqehDC5RtGYid072y();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)zEJ4auDQQ9kXOGVMXjl(-1088304168 ^ -1088336126));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object zEJ4auDQQ9kXOGVMXjl(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool vc6fD6DERouQa4itBEL()
	{
		return IB6X78DGAuaDPNSLeW9 == null;
	}

	internal static DefaultNotificationFlow gnmVWqDfbhJ94RDLF9X()
	{
		return IB6X78DGAuaDPNSLeW9;
	}

	internal static void KHtqehDC5RtGYid072y()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool YJRsCcDv3dURotPMBdq(object P_0, Guid flowUid)
	{
		return ((INotificationFlowObject)P_0).Can(flowUid);
	}
}
