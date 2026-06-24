using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.BPMApps;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.BPMApps;

public class SecurityBAChapter : BPMAppManifestChapter
{
	internal static SecurityBAChapter lKrS6RpkuXdDBSPryJsQ;

	[DefaultValue(false)]
	[XmlElement("ExportFullOrgstructure")]
	public bool ExportFullOrgstructure
	{
		[CompilerGenerated]
		get
		{
			return _003CExportFullOrgstructure_003Ek__BackingField;
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
					_003CExportFullOrgstructure_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
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

	[DefaultValue(null)]
	[XmlArray("UserGroups")]
	public List<UserGroupBAItem> UserGroups { get; set; }

	public SecurityBAChapter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MGXo9VpkLIJZ1W33GvxN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SCphQ6pkm5SvqFOHlEhO()
	{
		return lKrS6RpkuXdDBSPryJsQ == null;
	}

	internal static SecurityBAChapter fW9jy2pkeyeXbkBiXyqN()
	{
		return lKrS6RpkuXdDBSPryJsQ;
	}

	internal static void MGXo9VpkLIJZ1W33GvxN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
