using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export;

[Serializable]
public class BpmAppsExportSetting
{
	private static BpmAppsExportSetting XvcSZWEjaX7WdAA3D4R5;

	public string TempId
	{
		[CompilerGenerated]
		get
		{
			return _003CTempId_003Ek__BackingField;
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
					_003CTempId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
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

	public Dictionary<string, ElmaStoreComponentManifest> Files { get; set; }

	public Dictionary<string, BPMAppDTO> Components { get; set; }

	public BpmAppsExportSetting()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CQJq6EEjwfTHglArTfMD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Files = new Dictionary<string, ElmaStoreComponentManifest>();
				num = 2;
				continue;
			case 2:
				return;
			}
			Components = new Dictionary<string, BPMAppDTO>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
			{
				num = 0;
			}
		}
	}

	internal static void CQJq6EEjwfTHglArTfMD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool j9f9tEEjDWv3mLrexZVS()
	{
		return XvcSZWEjaX7WdAA3D4R5 == null;
	}

	internal static BpmAppsExportSetting P6idIJEjtqoHNYv2W4hs()
	{
		return XvcSZWEjaX7WdAA3D4R5;
	}
}
