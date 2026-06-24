using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Diagrams.Activities.Gateways;

[DataContract]
public class GatewayExecutingInfo
{
	private static GatewayExecutingInfo QcZ8O14s1wlqCBClVPi;

	[DataMember]
	public Guid StartGatewayUid
	{
		[CompilerGenerated]
		get
		{
			return _003CStartGatewayUid_003Ek__BackingField;
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
					_003CStartGatewayUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
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

	[DataMember]
	public int StartedGatesCount
	{
		[CompilerGenerated]
		get
		{
			return _003CStartedGatesCount_003Ek__BackingField;
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
					_003CStartedGatesCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
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

	[DataMember]
	public int FinishedGatesCount
	{
		[CompilerGenerated]
		get
		{
			return _003CFinishedGatesCount_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CFinishedGatesCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public GatewayExecutingInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lM0ySY40mkjUUbZDv6W();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool P7Gjuk4JjgLqKNLqYfk()
	{
		return QcZ8O14s1wlqCBClVPi == null;
	}

	internal static GatewayExecutingInfo fEMXUW4lhV99edhIjGV()
	{
		return QcZ8O14s1wlqCBClVPi;
	}

	internal static void lM0ySY40mkjUUbZDv6W()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
