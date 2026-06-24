using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Packaging;

public class PackageStoreComponentInfo : StoreComponentInfoBase
{
	private static PackageStoreComponentInfo urdhC9BnzQHTXG6GVXgZ;

	public PackageDescription Package
	{
		[CompilerGenerated]
		get
		{
			return _003CPackage_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CPackage_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
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

	public List<IModule> Modules { get; private set; }

	public override string Id => (string)EEjuxyBOoG8SRthc6xJ7(Package);

	public override string Title
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!string.IsNullOrEmpty((string)LEqEppBObVeYQCQSFn2n(Package)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return Package.Id;
				default:
					return Package.Title;
				}
			}
		}
	}

	public override string Description => (string)g21eIhBOh9sGqRISVx8l(Package);

	public override string Author => string.Join((string)aKdLYJBOGtiePaJkwfhR(0x92F12D5 ^ 0x92F1ED7), Package.Authors);

	public override string Site => null;

	public override ManifestComponentType Type => ManifestComponentType.Module;

	public override IEnumerable<PackageDescription> AllPackages => new PackageDescription[1] { Package };

	public override IEnumerable<IModule> AllModules => Modules;

	public override bool IsInstalled => quNYshBOE7nuCjhY9feh(Package);

	public override SemanticVersion InstalledVersion => (SemanticVersion)qaajPKBOfC87TYKy3DWr(Package);

	public override SemanticVersion LastVersion => (SemanticVersion)m9NMsIBOQkghEh9esM2G(Package);

	public PackageStoreComponentInfo(PackageDescription package, bool isDeprecated = false)
	{
		//Discarded unreachable code: IL_001b, IL_0020
		vAGlP8BOWg508P3XQ4Cb();
		base._002Ector(isDeprecated);
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 2:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210656621));
			default:
				Modules = new List<IModule>();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num = 1;
				}
				break;
			case 3:
				if (package != null)
				{
					Package = package;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num = 0;
					}
				}
				else
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num = 2;
					}
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static void vAGlP8BOWg508P3XQ4Cb()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool ADOk0QBOFSg2USVgemNM()
	{
		return urdhC9BnzQHTXG6GVXgZ == null;
	}

	internal static PackageStoreComponentInfo fQH4FwBOBw2s1RXvqwdw()
	{
		return urdhC9BnzQHTXG6GVXgZ;
	}

	internal static object EEjuxyBOoG8SRthc6xJ7(object P_0)
	{
		return ((PackageDescription)P_0).Id;
	}

	internal static object LEqEppBObVeYQCQSFn2n(object P_0)
	{
		return ((PackageDescription)P_0).Title;
	}

	internal static object g21eIhBOh9sGqRISVx8l(object P_0)
	{
		return ((PackageDescription)P_0).Description;
	}

	internal static object aKdLYJBOGtiePaJkwfhR(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool quNYshBOE7nuCjhY9feh(object P_0)
	{
		return ((PackageDescription)P_0).IsInstalled;
	}

	internal static object qaajPKBOfC87TYKy3DWr(object P_0)
	{
		return ((PackageDescription)P_0).InstalledVersion;
	}

	internal static object m9NMsIBOQkghEh9esM2G(object P_0)
	{
		return ((PackageDescription)P_0).LastVersion;
	}
}
