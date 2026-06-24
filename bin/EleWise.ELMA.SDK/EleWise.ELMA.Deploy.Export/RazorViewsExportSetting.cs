using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export;

[Serializable]
public class RazorViewsExportSetting
{
	internal static RazorViewsExportSetting WDb71iEjdfknGcgpeeQj;

	public bool ExportViews
	{
		[CompilerGenerated]
		get
		{
			return _003CExportViews_003Ek__BackingField;
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
					_003CExportViews_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
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

	public List<string> ViewVirtualPaths { get; set; }

	public RazorViewsExportSetting()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		VD074AEjgNAfCgLUNTuj();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				ViewVirtualPaths = new List<string>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 2:
				ExportViews = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void VD074AEjgNAfCgLUNTuj()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Q2VaypEjlXXu0IAXjYut()
	{
		return WDb71iEjdfknGcgpeeQj == null;
	}

	internal static RazorViewsExportSetting KIxLFeEjrVmyTary5TGx()
	{
		return WDb71iEjdfknGcgpeeQj;
	}
}
