using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Packaging;

[Serializable]
[XmlRoot]
public class PackageInstallInfo
{
	public const string Prefix = "PackageInstallInfo";

	private static PackageInstallInfo jOwC9kBOCoKVwLTHDH9n;

	[XmlArray]
	public List<PackageInstallOperationInfo> Operations { get; set; }

	[XmlElement("UpdatingUid")]
	public Guid UpdatingUid
	{
		[CompilerGenerated]
		get
		{
			return _003CUpdatingUid_003Ek__BackingField;
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
					_003CUpdatingUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PackageInstallInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DKJpWpBOZ28yMDjALFto();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Operations = new List<PackageInstallOperationInfo>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static string GenerateFileName()
	{
		return (string)BbjwbNBOV0Vo8KWLOk0M(WUCJDABOuDWyU579wgRr(-16752921 ^ -16683131), vsRLySBOIdmNVibjP6TQ().ToString((string)WUCJDABOuDWyU579wgRr(-672123589 ^ -672070473)), WUCJDABOuDWyU579wgRr(-978351861 ^ -978385083));
	}

	internal static bool XnY5qVBOvUP9iDnUhcpX()
	{
		return jOwC9kBOCoKVwLTHDH9n == null;
	}

	internal static PackageInstallInfo Ebp9erBO8DN3QvX4yR84()
	{
		return jOwC9kBOCoKVwLTHDH9n;
	}

	internal static void DKJpWpBOZ28yMDjALFto()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object WUCJDABOuDWyU579wgRr(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static DateTime vsRLySBOIdmNVibjP6TQ()
	{
		return DateTime.Now;
	}

	internal static object BbjwbNBOV0Vo8KWLOk0M(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}
}
