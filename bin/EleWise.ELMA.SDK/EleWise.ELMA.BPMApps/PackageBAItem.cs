using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.BPMApps;

public class PackageBAItem : BPMAppManifestItem
{
	private static PackageBAItem VCFQubfkgsUqiPCr6cEp;

	[DefaultValue("")]
	[XmlElement("PackageId")]
	public string PackageId
	{
		[CompilerGenerated]
		get
		{
			return _003CPackageId_003Ek__BackingField;
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
					_003CPackageId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue("")]
	[XmlElement("PackageTitle")]
	public string PackageTitle
	{
		[CompilerGenerated]
		get
		{
			return _003CPackageTitle_003Ek__BackingField;
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
					_003CPackageTitle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PackageBAItem()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		PvG8LXfkYGCIwiLa4rkl();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				PackageTitle = "";
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				PackageId = "";
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void PvG8LXfkYGCIwiLa4rkl()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool BjyboAfk5y66C3gBDRKh()
	{
		return VCFQubfkgsUqiPCr6cEp == null;
	}

	internal static PackageBAItem JhqNZyfkjiqQPuOnrynp()
	{
		return VCFQubfkgsUqiPCr6cEp;
	}
}
