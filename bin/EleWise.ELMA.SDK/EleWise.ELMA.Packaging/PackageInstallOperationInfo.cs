using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;
using NuGet;

namespace EleWise.ELMA.Packaging;

[Serializable]
[XmlRoot]
public class PackageInstallOperationInfo
{
	internal static PackageInstallOperationInfo nyaemDBOSxO7i1XE5Qj0;

	[XmlElement("Id")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
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

	[XmlElement("Type")]
	public PackageOperationType Type
	{
		[CompilerGenerated]
		get
		{
			return _003CType_003Ek__BackingField;
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
					_003CType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("Version")]
	public string Version
	{
		[CompilerGenerated]
		get
		{
			return _003CVersion_003Ek__BackingField;
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
					_003CVersion_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
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

	public static PackageInstallOperationInfo Create(PackageOperationInfo info)
	{
		PackageInstallOperationInfo packageInstallOperationInfo = new PackageInstallOperationInfo();
		lDZrcCBOK2N272OG7FER(packageInstallOperationInfo, sOGAARBOqrLnmpdj7Q8f(info.Package));
		CqUDYyBOOMZ6CrVh41vE(packageInstallOperationInfo, FtYi2kBOkitj7DhIEysN(zQCwacBOTGinuYgv0edE(FIBOEbBOXq4dmP7PE23v(info)), null) ? zQCwacBOTGinuYgv0edE(FIBOEbBOXq4dmP7PE23v(info)).ToString() : (((SemanticVersion)JHiHoCBOnC4rOPFnf30Z(info) != (SemanticVersion)null) ? JHiHoCBOnC4rOPFnf30Z(info).ToString() : null));
		packageInstallOperationInfo.Type = info.Type;
		return packageInstallOperationInfo;
	}

	public PackageInstallOperationInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Pxok5UBOiuWaOvuN1cc7()
	{
		return nyaemDBOSxO7i1XE5Qj0 == null;
	}

	internal static PackageInstallOperationInfo btp824BOR6284ZrktgjQ()
	{
		return nyaemDBOSxO7i1XE5Qj0;
	}

	internal static object sOGAARBOqrLnmpdj7Q8f(object P_0)
	{
		return ((PackageInfo)P_0).Id;
	}

	internal static void lDZrcCBOK2N272OG7FER(object P_0, object P_1)
	{
		((PackageInstallOperationInfo)P_0).Id = (string)P_1;
	}

	internal static object FIBOEbBOXq4dmP7PE23v(object P_0)
	{
		return ((PackageOperationInfo)P_0).Package;
	}

	internal static object zQCwacBOTGinuYgv0edE(object P_0)
	{
		return ((PackageInfo)P_0).Version;
	}

	internal static bool FtYi2kBOkitj7DhIEysN(object P_0, object P_1)
	{
		return (SemanticVersion)P_0 != (SemanticVersion)P_1;
	}

	internal static object JHiHoCBOnC4rOPFnf30Z(object P_0)
	{
		return ((PackageOperationInfo)P_0).InstalledVersion;
	}

	internal static void CqUDYyBOOMZ6CrVh41vE(object P_0, object P_1)
	{
		((PackageInstallOperationInfo)P_0).Version = (string)P_1;
	}
}
