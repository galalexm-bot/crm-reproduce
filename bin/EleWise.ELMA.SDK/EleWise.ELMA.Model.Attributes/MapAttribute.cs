using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Attributes;

public class MapAttribute : Attribute
{
	private readonly Guid propertyUid;

	private readonly Guid _classUid;

	private static MapAttribute w3EgLSouKv6PjifnYXRb;

	public Guid PropertyUid => propertyUid;

	public Guid ClassTypeUid => _classUid;

	public MapAttribute(string uid, string entityTypeUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GNH9Oqouk8nymdKWDlTR();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				_classUid = new Guid(entityTypeUid);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num = 1;
				}
				break;
			default:
				propertyUid = new Guid(uid);
				num = 2;
				break;
			case 3:
				a1quGUounL3gR9Wq08i3(uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE0B8A3));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void GNH9Oqouk8nymdKWDlTR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void a1quGUounL3gR9Wq08i3(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool DNdSpoouXi4Q5j5Hok1B()
	{
		return w3EgLSouKv6PjifnYXRb == null;
	}

	internal static MapAttribute ANssFeouTZU0idOhvhNt()
	{
		return w3EgLSouKv6PjifnYXRb;
	}
}
