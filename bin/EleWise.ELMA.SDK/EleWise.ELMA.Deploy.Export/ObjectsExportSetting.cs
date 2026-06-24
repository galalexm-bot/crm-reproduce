using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export;

[Serializable]
public class ObjectsExportSetting
{
	private static ObjectsExportSetting q7QYEuEYRb5h5GYAo24V;

	public bool ExportCatalogs
	{
		[CompilerGenerated]
		get
		{
			return _003CExportCatalogs_003Ek__BackingField;
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
					_003CExportCatalogs_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SerializableDictionary<Guid, bool> Catalogs { get; set; }

	public List<Guid> SysCatalogs { get; set; }

	public bool ExportEnums
	{
		[CompilerGenerated]
		get
		{
			return _003CExportEnums_003Ek__BackingField;
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
					_003CExportEnums_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
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

	public List<Guid> Enums { get; set; }

	public List<Guid> DataClasses { get; set; }

	public ObjectsExportSetting()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		WKmeyUEYX8ywCqXsnL4M();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 6:
				SysCatalogs = new List<Guid>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num = 0;
				}
				break;
			case 1:
				Enums = new List<Guid>();
				num = 2;
				break;
			case 2:
				DataClasses = new List<Guid>();
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num = 4;
				}
				break;
			default:
				ExportEnums = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 1;
				}
				break;
			case 5:
				Catalogs = new SerializableDictionary<Guid, bool>();
				num = 6;
				break;
			case 3:
				ExportCatalogs = true;
				num = 5;
				break;
			}
		}
	}

	internal static void WKmeyUEYX8ywCqXsnL4M()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fTh8UpEYqqOhQJ4RH1ko()
	{
		return q7QYEuEYRb5h5GYAo24V == null;
	}

	internal static ObjectsExportSetting hWBcQVEYKW0EfQdxcYdV()
	{
		return q7QYEuEYRb5h5GYAo24V;
	}
}
