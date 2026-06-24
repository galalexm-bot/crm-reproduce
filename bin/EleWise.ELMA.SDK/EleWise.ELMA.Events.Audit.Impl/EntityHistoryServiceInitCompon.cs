using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events.Audit.Impl;

[Component]
internal class EntityHistoryServiceInitComponent : IInitHandler
{
	internal static EntityHistoryServiceInitComponent Dy7hyAGc92dEOhUN6o9a;

	public IEntityActionHistoryEventService Service
	{
		[CompilerGenerated]
		get
		{
			return _003CService_003Ek__BackingField;
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
					_003CService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
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

	public void Init()
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
				Un194fGcrmaEmViPKd9M(Service);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void InitComplete()
	{
	}

	public EntityHistoryServiceInitComponent()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ONX0bTGcghI21Kox4H0m();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool WrVcWHGcdm5KYC63Am9w()
	{
		return Dy7hyAGc92dEOhUN6o9a == null;
	}

	internal static EntityHistoryServiceInitComponent FIPVqjGclApXewEtyKou()
	{
		return Dy7hyAGc92dEOhUN6o9a;
	}

	internal static void Un194fGcrmaEmViPKd9M(object P_0)
	{
		((IEntityActionHistoryEventService)P_0).Initialize();
	}

	internal static void ONX0bTGcghI21Kox4H0m()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
