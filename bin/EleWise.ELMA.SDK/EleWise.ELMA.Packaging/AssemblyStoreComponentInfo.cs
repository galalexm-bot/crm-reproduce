using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using NuGet;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Packaging;

public class AssemblyStoreComponentInfo : StoreComponentInfoBase
{
	internal static AssemblyStoreComponentInfo EKanfZBnIcxjuCh4s4uj;

	public IModule Module
	{
		[CompilerGenerated]
		get
		{
			return _003CModule_003Ek__BackingField;
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
					_003CModule_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override string Id => (string)xLGcInBnisnpBZTUl4Bc(Module);

	public override string Title
	{
		get
		{
			//Discarded unreachable code: IL_0045, IL_0054
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (string)xLGcInBnisnpBZTUl4Bc(Module);
				case 1:
					return Module.Title;
				case 2:
					if (!UAUYWxBnqAL5DU03VQuV(Fn6cwmBnR9D42XE93QOj(Module)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
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

	public override string Description => (string)U8C56nBnKjOYswQT5ocy(Module);

	public override string Author => (string)vIGLe1BnXavh5ebnfcHM(Module);

	public override string Site => (string)fWOkOsBnTvnDsZDfmebk(Module);

	public override ManifestComponentType Type => ManifestComponentType.Module;

	public override IEnumerable<PackageDescription> AllPackages => new PackageDescription[0];

	public override IEnumerable<IModule> AllModules => new IModule[1] { Module };

	public override bool IsInstalled => true;

	public override SemanticVersion InstalledVersion
	{
		get
		{
			int num = 1;
			int num2 = num;
			SemanticVersion result = default(SemanticVersion);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return result;
				case 1:
					if (!UAUYWxBnqAL5DU03VQuV(HKOZ8DBnkWy0l1PWS5bY(Module)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_002b;
				default:
					{
						if (SemanticVersion.TryParse(Module.Version, ref result))
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto IL_002b;
					}
					IL_002b:
					return null;
				}
			}
		}
	}

	public override SemanticVersion LastVersion => null;

	public AssemblyStoreComponentInfo(IModule module, bool isDeprecated = false)
	{
		//Discarded unreachable code: IL_002b, IL_0030, IL_0053, IL_0062
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(isDeprecated);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92E220D));
			case 3:
				Module = module;
				num = 2;
				break;
			case 2:
				return;
			case 1:
				if (module != null)
				{
					num = 3;
					break;
				}
				goto default;
			}
		}
	}

	internal static bool iXCOViBnViGcG3osoeNV()
	{
		return EKanfZBnIcxjuCh4s4uj == null;
	}

	internal static AssemblyStoreComponentInfo v1ER6lBnSumMwf8uD9ij()
	{
		return EKanfZBnIcxjuCh4s4uj;
	}

	internal static object xLGcInBnisnpBZTUl4Bc(object P_0)
	{
		return ((IApplicationUnit)P_0).Id;
	}

	internal static object Fn6cwmBnR9D42XE93QOj(object P_0)
	{
		return ((IApplicationUnit)P_0).Title;
	}

	internal static bool UAUYWxBnqAL5DU03VQuV(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object U8C56nBnKjOYswQT5ocy(object P_0)
	{
		return ((IApplicationUnit)P_0).Description;
	}

	internal static object vIGLe1BnXavh5ebnfcHM(object P_0)
	{
		return ((IApplicationUnit)P_0).Author;
	}

	internal static object fWOkOsBnTvnDsZDfmebk(object P_0)
	{
		return ((IModule)P_0).WebSite;
	}

	internal static object HKOZ8DBnkWy0l1PWS5bY(object P_0)
	{
		return ((IApplicationUnit)P_0).Version;
	}
}
