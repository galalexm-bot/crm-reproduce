using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract(Name = "PackageSyncChangesData")]
public class PackageChangesSyncData
{
	private static PackageChangesSyncData J3WmdFfNrckrrQV9V9lo;

	[DataMember]
	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public long[] List
	{
		[CompilerGenerated]
		get
		{
			return _003CList_003Ek__BackingField;
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
					_003CList_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
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

	public PackageChangesSyncData()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uZ15C9fNjmOPKXObaS1S();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool mBE21XfNgF1BFnb6BTgd()
	{
		return J3WmdFfNrckrrQV9V9lo == null;
	}

	internal static PackageChangesSyncData Y0DgSofN5aFmgSv8IsMW()
	{
		return J3WmdFfNrckrrQV9V9lo;
	}

	internal static void uZ15C9fNjmOPKXObaS1S()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
