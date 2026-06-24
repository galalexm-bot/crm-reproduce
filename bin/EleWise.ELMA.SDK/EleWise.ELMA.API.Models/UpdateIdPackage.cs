using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract(Name = "UpdateIdPackage")]
public class UpdateIdPackage : PackageBase
{
	internal static UpdateIdPackage zEDe1Sf3Cohn3gD9NiL4;

	[DataMember]
	public long Updated
	{
		[CompilerGenerated]
		get
		{
			return _003CUpdated_003Ek__BackingField;
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
					_003CUpdated_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
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

	[Obsolete("Этот конструктор предназначен только для десериализации.", true)]
	public UpdateIdPackage()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jZw4a1f3ZocA4NxgeL0m();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public UpdateIdPackage(Guid serviceUid, Guid typeUid)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		jZw4a1f3ZocA4NxgeL0m();
		base._002Ector(serviceUid, typeUid);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public UpdateIdPackage(Guid serviceUid, Guid typeUid, long updated)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		jZw4a1f3ZocA4NxgeL0m();
		this._002Ector(serviceUid, typeUid);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
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
			Updated = updated;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
			{
				num = 1;
			}
		}
	}

	internal static void jZw4a1f3ZocA4NxgeL0m()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool zWyS4Tf3vxaABd05hbyn()
	{
		return zEDe1Sf3Cohn3gD9NiL4 == null;
	}

	internal static UpdateIdPackage wafNK5f386qIxZydhD8W()
	{
		return zEDe1Sf3Cohn3gD9NiL4;
	}
}
