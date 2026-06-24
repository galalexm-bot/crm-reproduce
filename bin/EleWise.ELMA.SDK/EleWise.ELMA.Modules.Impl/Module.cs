using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Modules.Impl;

internal class Module : ModuleBase, ILicensedUnit, IActivationTokenContainer
{
	private ModuleInfoMetadata info;

	private IModuleAssembly mainAssembly;

	internal static Module gayCFG3Fj3wI4OLp7lM;

	public override string Id => (string)RKIAH33GtKNoJYnPDAG(info);

	public override Guid Uid => Sq19Mx3EDurnXHI2S4C(info);

	public override string Title => (string)REfv3A3fMj84WXhoOoo(info);

	public override string Description => (string)DD6w8h3QwCHioEcoB65(info);

	public IModuleAssembly MainAssembly => mainAssembly;

	public override string Version
	{
		get
		{
			//Discarded unreachable code: IL_0064, IL_0073
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return "";
				default:
					return (string)eFyCfw3CVjNArl8E03m(mainAssembly);
				case 1:
					if (mainAssembly != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
	}

	public override string Author
	{
		get
		{
			//Discarded unreachable code: IL_0064, IL_0073
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return "";
				default:
					return (string)IUlS8T3vyFpYuHibI6r(mainAssembly);
				case 1:
					if (mainAssembly != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
			}
		}
	}

	public override string WebSite
	{
		get
		{
			//Discarded unreachable code: IL_0052, IL_0061
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (info != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return "";
				case 1:
					return (string)ftZ50o38aJuO0WlSUUB(info);
				}
			}
		}
	}

	public override string HtmlDescription
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
					if (info == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return (string)nFXWuq3Zf34JtV8hUd2(info);
				default:
					return "";
				}
			}
		}
	}

	public override bool ServerModuleRequired
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
					if (info != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return false;
				default:
					return m9WfV23u6bfKyMKNROJ(info);
				}
			}
		}
	}

	public Guid RegistrationKeyMethodUid
	{
		get
		{
			//Discarded unreachable code: IL_0052, IL_0061
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (MainLicensedAssembly != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return Guid.Empty;
				default:
					return MainLicensedAssembly.RegistrationKeyMethodUid;
				}
			}
		}
	}

	private ILicensedUnit MainLicensedAssembly
	{
		get
		{
			int num = 1;
			int num2 = num;
			ILicensedUnit licensedUnit = default(ILicensedUnit);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return licensedUnit;
				case 3:
					return licensedUnit;
				case 1:
					licensedUnit = mainAssembly as ILicensedUnit;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (licensedUnit != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					licensedUnit = base.Assemblies.OfType<ILicensedUnit>().FirstOrDefault();
					num2 = 3;
				}
			}
		}
	}

	public Module(ModuleInfoMetadata info, IModuleAssembly mainAssembly)
	{
		//Discarded unreachable code: IL_002a, IL_006e, IL_007d
		DGVSyx3ogKre39fkRYQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				if (info != null)
				{
					num = 9;
					break;
				}
				goto case 7;
			case 1:
				base.ModuleType = info.ModuleType;
				num = 2;
				break;
			case 5:
				base.Status = JW1LfR3hoME1oLgDcaP(info);
				num = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num = 4;
				}
				break;
			case 7:
				throw new ArgumentNullException((string)hceJl33bwafrSuGeWuC(-672123589 ^ -672120707));
			case 9:
				if (mainAssembly != null)
				{
					num = 8;
					break;
				}
				goto case 4;
			case 3:
				this.mainAssembly = mainAssembly;
				num = 5;
				break;
			case 4:
				throw new ArgumentNullException((string)hceJl33bwafrSuGeWuC(-1123633026 ^ -1123627732));
			case 8:
			{
				this.info = info;
				int num2 = 3;
				num = num2;
				break;
			}
			case 10:
				if (base.Status == ModuleStatus.Disabled)
				{
					num = 6;
					break;
				}
				goto case 1;
			case 6:
				base.DisabledReason = ModuleDisabledReason.DisabledManually;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public string GetRegistrationKey()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (MainLicensedAssembly != null)
				{
					return (string)TbEfsX3IqDFpN6qg8Vh(MainLicensedAssembly);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ApplyActivationKey(string key)
	{
		//Discarded unreachable code: IL_002f, IL_003e, IL_0049, IL_00c6, IL_00fe, IL_010d
		int num = 1;
		int num2 = num;
		IEnumerator<ILicensedUnit> enumerator = default(IEnumerator<ILicensedUnit>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = Units.OfType<ILicensedUnit>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!dKMMUr3Squ1BP6339W1(enumerator))
					{
						num3 = 2;
						goto IL_004d;
					}
					goto IL_0079;
					IL_004d:
					switch (num3)
					{
					case 2:
						return;
					case 1:
						break;
					default:
						goto IL_0079;
					}
					continue;
					IL_0079:
					rKBA323VFZM3n34RuKV(enumerator.Current, key);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num3 = 1;
					}
					goto IL_004d;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							JnPD5V3iIPId2lSAxRw(enumerator);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public void CompleteLicensingInitialize()
	{
		//Discarded unreachable code: IL_005b, IL_0065, IL_00f1, IL_0131, IL_013c, IL_014b
		int num = 1;
		int num2 = num;
		IEnumerator<ILicensedUnit> enumerator = default(IEnumerator<ILicensedUnit>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = Units.OfType<ILicensedUnit>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!dKMMUr3Squ1BP6339W1(enumerator))
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num3 = 0;
						}
						goto IL_0069;
					}
					goto IL_007f;
					IL_007f:
					y8bbOY3RDBNpq8gBlET(enumerator.Current);
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num3 = 0;
					}
					goto IL_0069;
					IL_0069:
					switch (num3)
					{
					case 1:
						return;
					case 2:
						break;
					default:
						continue;
					}
					goto IL_007f;
				}
			}
			finally
			{
				int num4;
				if (enumerator == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num4 = 0;
					}
					goto IL_00f5;
				}
				goto IL_010b;
				IL_010b:
				JnPD5V3iIPId2lSAxRw(enumerator);
				num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num4 = 1;
				}
				goto IL_00f5;
				IL_00f5:
				switch (num4)
				{
				default:
					goto end_IL_00d0;
				case 2:
					break;
				case 0:
					goto end_IL_00d0;
				case 1:
					goto end_IL_00d0;
				}
				goto IL_010b;
				end_IL_00d0:;
			}
		}
	}

	public ILicenseInfo GetLicenseInfo()
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (MainLicensedAssembly != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 1:
				return (ILicenseInfo)qcPowo3qQJq3TG1MrM8(MainLicensedAssembly);
			}
		}
	}

	public void UpdateLicenseInfo()
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_00d4, IL_00f3, IL_0123, IL_0132
		int num = 1;
		int num2 = num;
		IEnumerator<ILicensedUnit> enumerator = default(IEnumerator<ILicensedUnit>);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = Units.OfType<ILicensedUnit>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!dKMMUr3Squ1BP6339W1(enumerator))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
						{
							num3 = 0;
						}
						goto IL_004c;
					}
					goto IL_0088;
					IL_0088:
					cwckEI3KvrkQfuYKA98(enumerator.Current);
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num3 = 1;
					}
					goto IL_004c;
					IL_004c:
					switch (num3)
					{
					default:
						return;
					case 1:
						break;
					case 2:
						goto IL_0088;
					case 0:
						return;
					}
				}
			}
			finally
			{
				int num4;
				if (enumerator == null)
				{
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num4 = 1;
					}
					goto IL_00d8;
				}
				goto IL_0101;
				IL_0101:
				JnPD5V3iIPId2lSAxRw(enumerator);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num4 = 0;
				}
				goto IL_00d8;
				IL_00d8:
				switch (num4)
				{
				default:
					goto end_IL_00b3;
				case 1:
					goto end_IL_00b3;
				case 2:
					break;
				case 0:
					goto end_IL_00b3;
				}
				goto IL_0101;
				end_IL_00b3:;
			}
		}
	}

	public byte[] GetActivationToken()
	{
		//Discarded unreachable code: IL_0060, IL_006f
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return (byte[])vtusj83XSBLBJ1OR3qn(MainLicensedAssembly);
			case 2:
				if (MainLicensedAssembly != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	ActivationToken IActivationTokenContainer.GetActivationToken()
	{
		int num = 1;
		int num2 = num;
		IActivationTokenContainer activationTokenContainer = default(IActivationTokenContainer);
		while (true)
		{
			switch (num2)
			{
			case 1:
				activationTokenContainer = MainLicensedAssembly as IActivationTokenContainer;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return null;
			}
			if (activationTokenContainer == null)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return activationTokenContainer.GetActivationToken();
		}
	}

	internal static void DGVSyx3ogKre39fkRYQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object hceJl33bwafrSuGeWuC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static ModuleStatus JW1LfR3hoME1oLgDcaP(object P_0)
	{
		return ((ModuleInfoMetadata)P_0).DefaultStatus;
	}

	internal static bool OMgal93Be9PoqXKPLfg()
	{
		return gayCFG3Fj3wI4OLp7lM == null;
	}

	internal static Module uwinRy3Wi078HrwaLdk()
	{
		return gayCFG3Fj3wI4OLp7lM;
	}

	internal static object RKIAH33GtKNoJYnPDAG(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static Guid Sq19Mx3EDurnXHI2S4C(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object REfv3A3fMj84WXhoOoo(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object DD6w8h3QwCHioEcoB65(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static object eFyCfw3CVjNArl8E03m(object P_0)
	{
		return ((IApplicationUnit)P_0).Version;
	}

	internal static object IUlS8T3vyFpYuHibI6r(object P_0)
	{
		return ((IApplicationUnit)P_0).Author;
	}

	internal static object ftZ50o38aJuO0WlSUUB(object P_0)
	{
		return ((ModuleInfoMetadata)P_0).WebSite;
	}

	internal static object nFXWuq3Zf34JtV8hUd2(object P_0)
	{
		return ((ModuleInfoMetadata)P_0).HtmlDescription;
	}

	internal static bool m9WfV23u6bfKyMKNROJ(object P_0)
	{
		return ((ModuleInfoMetadata)P_0).ServerModuleRequired;
	}

	internal static object TbEfsX3IqDFpN6qg8Vh(object P_0)
	{
		return ((ILicensedUnit)P_0).GetRegistrationKey();
	}

	internal static void rKBA323VFZM3n34RuKV(object P_0, object P_1)
	{
		((ILicensedUnit)P_0).ApplyActivationKey((string)P_1);
	}

	internal static bool dKMMUr3Squ1BP6339W1(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void JnPD5V3iIPId2lSAxRw(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void y8bbOY3RDBNpq8gBlET(object P_0)
	{
		((ILicensedUnit)P_0).CompleteLicensingInitialize();
	}

	internal static object qcPowo3qQJq3TG1MrM8(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static void cwckEI3KvrkQfuYKA98(object P_0)
	{
		((ILicensedUnit)P_0).UpdateLicenseInfo();
	}

	internal static object vtusj83XSBLBJ1OR3qn(object P_0)
	{
		return ((ILicensedUnit)P_0).GetActivationToken();
	}
}
