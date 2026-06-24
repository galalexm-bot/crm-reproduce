using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.API.Models;

[Serializable]
[DataContract(Name = "PackageSyncChanges")]
public class PackageChangesSyncRequest
{
	internal static PackageChangesSyncRequest HFJZ4KfNJn9OZJopapa9;

	[DataMember]
	public DateTime Now
	{
		[CompilerGenerated]
		get
		{
			return _003CNow_003Ek__BackingField;
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
					_003CNow_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public PackageChangesSyncData[] Data
	{
		[CompilerGenerated]
		get
		{
			return _003CData_003Ek__BackingField;
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
					_003CData_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
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

	public PackageChangesSyncRequest()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		XlWrI5fNlI4NvhSF9Tka();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DxXaQ1fN9OQ6eeKIg7TA()
	{
		return HFJZ4KfNJn9OZJopapa9 == null;
	}

	internal static PackageChangesSyncRequest wJJJBDfNdiBA8F4P6If5()
	{
		return HFJZ4KfNJn9OZJopapa9;
	}

	internal static void XlWrI5fNlI4NvhSF9Tka()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
