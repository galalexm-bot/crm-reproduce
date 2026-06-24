using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Packaging;

public class ManifestStoreComponentInfo : StoreComponentInfoBase
{
	private ElmaStoreComponentManifest _manifest;

	private string _imagePath;

	private static ManifestStoreComponentInfo XQdm0FBnnm8wVjsLyn43;

	public override string ImagePath => _imagePath;

	public ElmaStoreComponentManifest InstalledManifest
	{
		[CompilerGenerated]
		get
		{
			return _003CInstalledManifest_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CInstalledManifest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ElmaStoreComponentFile InstalledFile
	{
		[CompilerGenerated]
		get
		{
			return _003CInstalledFile_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CInstalledFile_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ElmaStoreComponentManifest LastManifest
	{
		[CompilerGenerated]
		get
		{
			return _003CLastManifest_003Ek__BackingField;
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
					_003CLastManifest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
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

	public ElmaStoreComponentFile LastFile
	{
		[CompilerGenerated]
		get
		{
			return _003CLastFile_003Ek__BackingField;
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
					_003CLastFile_003Ek__BackingField = value;
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

	public List<PackageDescription> ElmaPackages { get; private set; }

	public List<PackageDescription> Packages { get; private set; }

	public List<IModule> Modules { get; private set; }

	public override string Id => (string)CAyL5gBn1OgEW5mq2yoc(_manifest);

	public override string Title
	{
		get
		{
			//Discarded unreachable code: IL_0074, IL_0083
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!uItG3ZBn30C43aqQIa7D(En03bMBnN9f5ksAZHhkX(_manifest)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return (string)CAyL5gBn1OgEW5mq2yoc(_manifest);
				default:
					return (string)En03bMBnN9f5ksAZHhkX(_manifest);
				}
			}
		}
	}

	public override string Description => (string)EKM6JRBnp3QG68afe3fc(_manifest);

	public override string Author => _manifest.Author;

	public override string Site => (string)ul4SgWBna0SuXx6JTRBh(_manifest);

	public override ManifestComponentType Type => QwofqYBnD3CLfLReYA7C(_manifest);

	public override IEnumerable<PackageDescription> AllPackages => Packages;

	public override IEnumerable<IModule> AllModules => Modules;

	public override bool IsInstalled
	{
		get
		{
			//Discarded unreachable code: IL_0082
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (InstalledManifest != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 3:
					return false;
				case 2:
					return ElmaPackages.All((PackageDescription p) => _003C_003Ec.psGCOCQVuSSC1nStVhlQ(p));
				}
				if (ElmaPackages.Any())
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 2;
					}
					continue;
				}
				return true;
			}
		}
	}

	public override SemanticVersion InstalledVersion
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return null;
				case 1:
					return (SemanticVersion)cRKe6tBntNPI70eiZC0w(InstalledManifest);
				case 2:
					if (InstalledManifest != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	public override SemanticVersion LastVersion
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (LastManifest != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return null;
				case 1:
					return (SemanticVersion)cRKe6tBntNPI70eiZC0w(LastManifest);
				}
			}
		}
	}

	public override bool DoesInstallOrUpdateRequireRestart
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					ElmaStoreComponentManifest lastManifest = LastManifest;
					if (lastManifest == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 0;
						}
						break;
					}
					return lastManifest.Packages.Count > 0;
				}
				default:
					return false;
				}
			}
		}
	}

	public ManifestStoreComponentInfo(ElmaStoreComponentManifest installedManifest, ElmaStoreComponentManifest lastManifest, ElmaStoreComponentFile installedFile, ElmaStoreComponentFile lastFile, bool isDeprecated = false)
	{
		//Discarded unreachable code: IL_002c, IL_0099
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(isDeprecated);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			case 2:
				LastManifest = lastManifest;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				if (lastManifest == null)
				{
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num = 8;
					}
					break;
				}
				goto case 10;
			case 7:
				LastFile = lastFile;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num = 11;
				}
				break;
			case 9:
				Modules = new List<IModule>();
				num2 = 12;
				goto IL_0031;
			default:
				InstalledFile = installedFile;
				num = 7;
				break;
			case 1:
				if (installedManifest != null)
				{
					num = 10;
					break;
				}
				goto case 3;
			case 12:
				InstalledManifest = installedManifest;
				num = 2;
				break;
			case 5:
				ElmaPackages = new List<PackageDescription>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num = 9;
				}
				break;
			case 6:
				return;
			case 8:
				throw new ArgumentNullException((string)HbVZdNBnesf89mYQoQKK(--1333735954 ^ 0x4F7E02FA));
			case 10:
				Packages = new List<PackageDescription>();
				num2 = 5;
				goto IL_0031;
			case 11:
				_manifest = installedManifest ?? lastManifest;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 4;
				}
				break;
			case 4:
				{
					_imagePath = (string)((installedFile != null) ? hKD5NWBnP3qgeQVr3HKe(installedFile) : lastFile?.IconPath);
					num = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num = 5;
					}
					break;
				}
				IL_0031:
				num = num2;
				break;
			}
		}
	}

	internal static object HbVZdNBnesf89mYQoQKK(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hKD5NWBnP3qgeQVr3HKe(object P_0)
	{
		return ((ElmaStoreComponentFile)P_0).IconPath;
	}

	internal static bool X4sasEBnO0Ca5X4dfEaZ()
	{
		return XQdm0FBnnm8wVjsLyn43 == null;
	}

	internal static ManifestStoreComponentInfo AfQYyqBn2N4LhnulM4Er()
	{
		return XQdm0FBnnm8wVjsLyn43;
	}

	internal static object CAyL5gBn1OgEW5mq2yoc(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Id;
	}

	internal static object En03bMBnN9f5ksAZHhkX(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Title;
	}

	internal static bool uItG3ZBn30C43aqQIa7D(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object EKM6JRBnp3QG68afe3fc(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Description;
	}

	internal static object ul4SgWBna0SuXx6JTRBh(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Site;
	}

	internal static ManifestComponentType QwofqYBnD3CLfLReYA7C(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).ProductType;
	}

	internal static object cRKe6tBntNPI70eiZC0w(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).SemanticVersion;
	}
}
