using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using NuGet;

namespace EleWise.ELMA.Packaging;

public abstract class StoreComponentInfoBase : IStoreComponentInfo
{
	private readonly bool isDeprecated;

	internal static StoreComponentInfoBase WkttDyBnAbR4gFRlDXud;

	public abstract string Id { get; }

	public abstract string Title { get; }

	public virtual string ImagePath => null;

	public abstract string Description { get; }

	public abstract string Author { get; }

	public abstract string Site { get; }

	public abstract ManifestComponentType Type { get; }

	public virtual ModuleStatus Status
	{
		get
		{
			//Discarded unreachable code: IL_00bf, IL_010d, IL_011c, IL_0170, IL_017f, IL_01db, IL_01ea
			int num = 15;
			int num2 = num;
			ILicenseInfo licenseInfo = default(ILicenseInfo);
			ILicensedUnit licensedUnit = default(ILicensedUnit);
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (licenseInfo == null)
					{
						num2 = 9;
						break;
					}
					goto case 10;
				case 10:
					if (GEQkmpBnMOeQlSBohSAW(licenseInfo) == LicenseStatus.NeedRestart)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 9;
				case 11:
					licensedUnit = LicensedUnit;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 7;
					}
					break;
				default:
					return ModuleStatus.RestartRequired;
				case 2:
				case 5:
				case 8:
					return ModuleStatus.Enabled;
				case 1:
					if (!AllModules.Any())
					{
						num2 = 8;
						break;
					}
					goto case 11;
				case 15:
					if (!isDeprecated)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num2 = 12;
						}
						break;
					}
					goto case 6;
				case 7:
					if (licensedUnit != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num2 = 12;
						}
						break;
					}
					goto case 9;
				case 12:
					licenseInfo = (ILicenseInfo)tGtwrABnyJSR3J4RQadf(licensedUnit);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 4;
					}
					break;
				case 14:
					if (!yH5me7BnmOU4dbO9w6wi(this))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
						{
							num2 = 6;
						}
						break;
					}
					if (AllModules == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 1;
				case 6:
					return ModuleStatus.Disabled;
				case 3:
					return ModuleStatus.RestartRequired;
				case 9:
					if (AllModules.Any((IModule m) => m.Status == ModuleStatus.Disabled))
					{
						num2 = 13;
						break;
					}
					if (!AllModules.Any((IModule m) => m.Status == ModuleStatus.RestartRequired))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto default;
				case 13:
					return ModuleStatus.Disabled;
				}
			}
		}
	}

	public virtual ModuleDisabledReason DisabledReason
	{
		get
		{
			//Discarded unreachable code: IL_0061, IL_0070, IL_0080, IL_0093, IL_00a2, IL_0115, IL_0124, IL_0134
			int num = 11;
			IModule module = default(IModule);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (module.Status == ModuleStatus.Enabled)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 14;
					case 11:
						if (!isDeprecated)
						{
							num2 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
							{
								num2 = 10;
							}
							continue;
						}
						goto case 2;
					case 9:
						return ModuleDisabledReason.PackageNotInstalled;
					case 3:
						if (AllModules != null)
						{
							num2 = 15;
							continue;
						}
						goto case 12;
					case 7:
						if (module == null)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto default;
					case 14:
						if (module != null)
						{
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 5;
					case 5:
						return ModuleDisabledReason.Unknown;
					case 8:
						return module.DisabledReason;
					case 13:
						if (module == null)
						{
							num = 6;
							break;
						}
						goto case 14;
					case 12:
						return ModuleDisabledReason.Unknown;
					case 15:
						module = AllModules.FirstOrDefault((IModule m) => ((string)C6GF3EBnr9T157IE7dfD(m)).Equals(Id, StringComparison.CurrentCultureIgnoreCase));
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
						{
							num2 = 4;
						}
						continue;
					case 2:
						return ModuleDisabledReason.Deprecated;
					case 10:
						if (yH5me7BnmOU4dbO9w6wi(this))
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 9;
					case 1:
					case 4:
						module = AllModules.FirstOrDefault((IModule m) => _003C_003Ec.edmC8yQVe6WdD45rLTbi(m) == ModuleStatus.Disabled);
						num = 13;
						break;
					case 6:
						module = AllModules.FirstOrDefault((IModule m) => _003C_003Ec.edmC8yQVe6WdD45rLTbi(m) == ModuleStatus.RestartRequired);
						num2 = 14;
						continue;
					}
					break;
				}
			}
		}
	}

	public abstract IEnumerable<PackageDescription> AllPackages { get; }

	public abstract IEnumerable<IModule> AllModules { get; }

	public virtual ILicensedUnit LicensedUnit
	{
		get
		{
			//Discarded unreachable code: IL_0064, IL_0073, IL_00ce, IL_00d8, IL_00e7
			int num = 1;
			int num2 = num;
			ILicensedUnit licensedUnit = default(ILicensedUnit);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					return null;
				default:
					if (AllModules != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 2;
				case 1:
					if (AllModules != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 6:
					if (licensedUnit != null)
					{
						num2 = 5;
						continue;
					}
					return AllModules.OfType<ILicensedUnit>().FirstOrDefault();
				case 5:
					return licensedUnit;
				case 2:
					obj = null;
					break;
				case 3:
					obj = AllModules.FirstOrDefault(delegate(IModule m)
					{
						//Discarded unreachable code: IL_0067, IL_0076
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return Hix1nBBn5ITINl29sa6S(MScDnsBngnKJyQ9ADOeb(this), m.Id, StringComparison.CurrentCultureIgnoreCase);
							case 1:
								return false;
							case 2:
								if (C6GF3EBnr9T157IE7dfD(m) == null)
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num4 = 1;
									}
									break;
								}
								goto default;
							}
						}
					}) as ILicensedUnit;
					break;
				}
				licensedUnit = (ILicensedUnit)obj;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 6;
				}
			}
		}
	}

	public abstract bool IsInstalled { get; }

	public abstract SemanticVersion InstalledVersion { get; }

	public virtual bool IsLatestVersionInstalled
	{
		get
		{
			//Discarded unreachable code: IL_0050, IL_005f, IL_0083
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (vPE3xOBn95XpAVLc9Sac(HomueXBndqrqhwFN941g(this), null))
					{
						num2 = 4;
						break;
					}
					goto case 3;
				case 3:
					return QQ7VOJBnlVT0VdonAuSS(v8glXoBnJkLG9OgOp7Vi(this), HomueXBndqrqhwFN941g(this));
				case 1:
				case 4:
					return true;
				case 2:
					if (vPE3xOBn95XpAVLc9Sac(v8glXoBnJkLG9OgOp7Vi(this), null))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
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

	public abstract SemanticVersion LastVersion { get; }

	public virtual bool DoesInstallOrUpdateRequireRestart => true;

	protected StoreComponentInfoBase(bool isDeprecated = false)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MSeaFOBn0RU0ueDaOPJL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.isDeprecated = isDeprecated;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return Id;
	}

	internal static void MSeaFOBn0RU0ueDaOPJL()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool tvVAKMBn7qJymDcO4ikD()
	{
		return WkttDyBnAbR4gFRlDXud == null;
	}

	internal static StoreComponentInfoBase GE9pHuBnxyywEGiYZSO0()
	{
		return WkttDyBnAbR4gFRlDXud;
	}

	internal static bool yH5me7BnmOU4dbO9w6wi(object P_0)
	{
		return ((StoreComponentInfoBase)P_0).IsInstalled;
	}

	internal static object tGtwrABnyJSR3J4RQadf(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static LicenseStatus GEQkmpBnMOeQlSBohSAW(object P_0)
	{
		return ((ILicenseInfo)P_0).Status;
	}

	internal static object v8glXoBnJkLG9OgOp7Vi(object P_0)
	{
		return ((StoreComponentInfoBase)P_0).LastVersion;
	}

	internal static bool vPE3xOBn95XpAVLc9Sac(object P_0, object P_1)
	{
		return (SemanticVersion)P_0 == (SemanticVersion)P_1;
	}

	internal static object HomueXBndqrqhwFN941g(object P_0)
	{
		return ((StoreComponentInfoBase)P_0).InstalledVersion;
	}

	internal static bool QQ7VOJBnlVT0VdonAuSS(object P_0, object P_1)
	{
		return ((SemanticVersion)P_0).Equals((SemanticVersion)P_1);
	}

	internal static object C6GF3EBnr9T157IE7dfD(object P_0)
	{
		return ((IApplicationUnit)P_0).Id;
	}

	internal static object MScDnsBngnKJyQ9ADOeb(object P_0)
	{
		return ((StoreComponentInfoBase)P_0).Id;
	}

	internal static bool Hix1nBBn5ITINl29sa6S(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}
}
