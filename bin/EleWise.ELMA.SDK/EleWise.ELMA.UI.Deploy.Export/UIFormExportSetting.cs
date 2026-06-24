using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Deploy.Export;

[Serializable]
public class UIFormExportSetting
{
	internal static UIFormExportSetting Esb87dd3pwKPYMyYFiP;

	public bool ExportForms
	{
		[CompilerGenerated]
		get
		{
			return _003CExportForms_003Ek__BackingField;
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
					_003CExportForms_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Guid> FormHeaderUids { get; set; }

	public UIFormExportSetting()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		CwQyAKdDCOBQns6mpnB();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				FormHeaderUids = new List<Guid>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 0;
				}
				break;
			case 2:
				ExportForms = true;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void CwQyAKdDCOBQns6mpnB()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool TdvgTAdppYmS863Ktgy()
	{
		return Esb87dd3pwKPYMyYFiP == null;
	}

	internal static UIFormExportSetting AFRLfqdaicx33il3knm()
	{
		return Esb87dd3pwKPYMyYFiP;
	}
}
