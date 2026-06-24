using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.BPMApps;

[Component]
public abstract class BPMAppManifestChapter : IXsiType
{
	internal static BPMAppManifestChapter hOqhB7fkomCtJMaQEPWA;

	[XmlElement("Uid")]
	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
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

	protected BPMAppManifestChapter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		P95NhKfkGicNNmlwYxl2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool EooIFSfkb8Qid7cWYZij()
	{
		return hOqhB7fkomCtJMaQEPWA == null;
	}

	internal static BPMAppManifestChapter AhvycvfkhWGMRJv5VFt1()
	{
		return hOqhB7fkomCtJMaQEPWA;
	}

	internal static void P95NhKfkGicNNmlwYxl2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
