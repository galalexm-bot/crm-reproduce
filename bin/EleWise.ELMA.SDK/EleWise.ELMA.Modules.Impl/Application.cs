using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Licensing;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Modules.Impl;

internal class Application : ModuleBase, IApplication, IModule, ICompositeApplicationUnit, IApplicationUnit, ILicensedUnit, IActivationTokenContainer
{
	private ApplicationDescriptor descriptor;

	private IModule mainModule;

	private ILicensedUnit mainLicensedUnit;

	private List<IModule> systemModules;

	private static Application iiD7lQ1rlTYeHMTPOje;

	public override IEnumerable<IApplicationUnit> Units => base.Units.Union(SystemModules);

	public override string Id => descriptor.Id;

	public override Guid Uid => n5R4dU1LnsFjprRUInm(descriptor);

	public override string Title => descriptor.Title;

	public override string Description => (string)aaHeDc1UJbITjNhJ7Ej(descriptor);

	public override string Version
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
					if (mainModule != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return "";
				case 1:
					return (string)tSm1CO1so56JrMh6vaM(mainModule);
				}
			}
		}
	}

	public override string Author
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
					if (mainModule != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return "";
				case 1:
					return (string)q9In0t1cOtDKGsDUTx7(mainModule);
				}
			}
		}
	}

	public override string WebSite
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
				case 2:
					return "";
				default:
					return (string)fLjh2R1zikRCPuDqZ85(mainModule);
				case 1:
					if (mainModule != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
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

	public override string HtmlDescription => "";

	public override bool ServerModuleRequired => false;

	public IModule MainModule => mainModule;

	public ILicensedUnit MainLicensedUnit => mainLicensedUnit;

	public IEnumerable<IModule> SystemModules => systemModules;

	public Guid RegistrationKeyMethodUid
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
					if (MainLicensedModule == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num2 = 0;
						}
						break;
					}
					return FDPvsxNFiu9oUoX8BSy(MainLicensedModule);
				default:
					return Guid.Empty;
				}
			}
		}
	}

	private ILicensedUnit MainLicensedModule => MainModule as ILicensedUnit;

	public Application(ApplicationDescriptor descriptor, Module mainModule, ILicensedUnit mainLicensedUnit)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_00c8, IL_00d7, IL_00e6
		KyRm1p1j3mtcQkKd6VR();
		systemModules = new List<IModule>();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.mainModule = mainModule;
				num = 5;
				break;
			case 3:
				if (descriptor != null)
				{
					num = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num = 8;
					}
					break;
				}
				goto case 6;
			case 5:
				this.mainLicensedUnit = mainLicensedUnit;
				num = 7;
				break;
			case 7:
				if (mainModule == null)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				return;
			case 4:
				systemModules.Add(mainModule);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 6:
				throw new ArgumentNullException((string)jfiSNH1YIHcrOfO29U9(-2099751081 ^ -2099763811));
			case 8:
				this.descriptor = descriptor;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public void AddSystemModule(IModule module)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (systemModules.Contains(module))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				systemModules.Add(module);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
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
				if (MainLicensedModule != null)
				{
					return (string)qQI2LiNBoUX10UVLwoo(MainLicensedModule);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ApplyActivationKey(string key)
	{
		//Discarded unreachable code: IL_008d, IL_009c, IL_00a7, IL_0134, IL_0164, IL_0173, IL_017f, IL_018e
		int num = 3;
		_003C_003Ec__DisplayClass31_0 _003C_003Ec__DisplayClass31_ = default(_003C_003Ec__DisplayClass31_0);
		IEnumerator<ILicensedUnit> enumerator = default(IEnumerator<ILicensedUnit>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					YGZJOFNWoKsPEkhyEDA(_003C_003Ec__DisplayClass31_.sdkUnit, key);
					num2 = 5;
					continue;
				case 1:
					if (_003C_003Ec__DisplayClass31_.sdkUnit != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 3:
					_003C_003Ec__DisplayClass31_ = new _003C_003Ec__DisplayClass31_0();
					num2 = 2;
					continue;
				case 0:
					return;
				case 6:
					try
					{
						while (true)
						{
							int num3;
							if (!FbFET7NoenNN6QVbNtA(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
								{
									num3 = 2;
								}
								goto IL_00ab;
							}
							goto IL_00e7;
							IL_00e7:
							YGZJOFNWoKsPEkhyEDA(enumerator.Current, key);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num3 = 0;
							}
							goto IL_00ab;
							IL_00ab:
							switch (num3)
							{
							case 2:
								return;
							case 1:
								goto IL_00e7;
							}
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num4 = 0;
							}
							goto IL_0138;
						}
						goto IL_014e;
						IL_014e:
						mQkdgANbE3XijYi5w46(enumerator);
						num4 = 2;
						goto IL_0138;
						IL_0138:
						switch (num4)
						{
						default:
							goto end_IL_0113;
						case 1:
							break;
						case 0:
							goto end_IL_0113;
						case 2:
							goto end_IL_0113;
						}
						goto IL_014e;
						end_IL_0113:;
					}
				case 2:
					_003C_003Ec__DisplayClass31_.sdkUnit = Units.OfType<IModule>().FirstOrDefault((IModule m) => _003C_003Ec.HindwbfM7x4aDvrd28H7(_003C_003Ec.VMYMiWfMAsoPvlk7h4oS(m), __ModuleInfo.UID)) as ILicensedUnit;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					break;
				}
				break;
			}
			enumerator = Units.OfType<ILicensedUnit>().Where(_003C_003Ec__DisplayClass31_._003CApplyActivationKey_003Eb__1).GetEnumerator();
			num = 6;
		}
	}

	public void CompleteLicensingInitialize()
	{
		//Discarded unreachable code: IL_005b, IL_006a, IL_00f5, IL_012d, IL_013c
		int num = 2;
		int num2 = num;
		IEnumerator<ILicensedUnit> enumerator = default(IEnumerator<ILicensedUnit>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				enumerator = Units.OfType<ILicensedUnit>().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						int num4;
						if (!FbFET7NoenNN6QVbNtA(enumerator))
						{
							int num3 = 2;
							num4 = num3;
							goto IL_0079;
						}
						goto IL_008f;
						IL_0079:
						switch (num4)
						{
						case 2:
							return;
						case 1:
							break;
						default:
							continue;
						}
						goto IL_008f;
						IL_008f:
						cM9sHcNhGYZ2NvDi9Q7(enumerator.Current);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num4 = 0;
						}
						goto IL_0079;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								mQkdgANbE3XijYi5w46(enumerator);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
								{
									num5 = 1;
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
	}

	public ILicenseInfo GetLicenseInfo()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (MainLicensedModule == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (ILicenseInfo)Abug6BNGIUli0SdVdko(MainLicensedModule);
			default:
				return null;
			}
		}
	}

	public void UpdateLicenseInfo()
	{
		//Discarded unreachable code: IL_005b, IL_0065, IL_00f1, IL_0129, IL_0138
		int num = 2;
		int num2 = num;
		IEnumerator<ILicensedUnit> enumerator = default(IEnumerator<ILicensedUnit>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				enumerator = Units.OfType<ILicensedUnit>().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!FbFET7NoenNN6QVbNtA(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num3 = 0;
							}
							goto IL_0069;
						}
						goto IL_007f;
						IL_007f:
						enumerator.Current.UpdateLicenseInfo();
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
						{
							num3 = 0;
						}
						goto IL_0069;
						IL_0069:
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							break;
						case 1:
							continue;
						}
						goto IL_007f;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								mQkdgANbE3XijYi5w46(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
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
	}

	public byte[] GetActivationToken()
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
				if (MainLicensedModule != null)
				{
					return (byte[])lHElneNEWGN9KDPYFMJ(MainLicensedModule);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	ActivationToken IActivationTokenContainer.GetActivationToken()
	{
		//Discarded unreachable code: IL_0031
		int num = 2;
		int num2 = num;
		IActivationTokenContainer activationTokenContainer = default(IActivationTokenContainer);
		while (true)
		{
			switch (num2)
			{
			case 2:
				activationTokenContainer = MainLicensedModule as IActivationTokenContainer;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return null;
			default:
				return (ActivationToken)yknP7XNf4gu2jDqhaeO(activationTokenContainer);
			case 1:
				if (activationTokenContainer != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	internal static void KyRm1p1j3mtcQkKd6VR()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object jfiSNH1YIHcrOfO29U9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool litREW1gX9I5pYeoboZ()
	{
		return iiD7lQ1rlTYeHMTPOje == null;
	}

	internal static Application CGZHf615GxsYwQXGBWN()
	{
		return iiD7lQ1rlTYeHMTPOje;
	}

	internal static Guid n5R4dU1LnsFjprRUInm(object P_0)
	{
		return ((ApplicationDescriptor)P_0).Uid;
	}

	internal static object aaHeDc1UJbITjNhJ7Ej(object P_0)
	{
		return ((ApplicationDescriptor)P_0).Description;
	}

	internal static object tSm1CO1so56JrMh6vaM(object P_0)
	{
		return ((IApplicationUnit)P_0).Version;
	}

	internal static object q9In0t1cOtDKGsDUTx7(object P_0)
	{
		return ((IApplicationUnit)P_0).Author;
	}

	internal static object fLjh2R1zikRCPuDqZ85(object P_0)
	{
		return ((IModule)P_0).WebSite;
	}

	internal static Guid FDPvsxNFiu9oUoX8BSy(object P_0)
	{
		return ((ILicensedUnit)P_0).RegistrationKeyMethodUid;
	}

	internal static object qQI2LiNBoUX10UVLwoo(object P_0)
	{
		return ((ILicensedUnit)P_0).GetRegistrationKey();
	}

	internal static void YGZJOFNWoKsPEkhyEDA(object P_0, object P_1)
	{
		((ILicensedUnit)P_0).ApplyActivationKey((string)P_1);
	}

	internal static bool FbFET7NoenNN6QVbNtA(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void mQkdgANbE3XijYi5w46(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void cM9sHcNhGYZ2NvDi9Q7(object P_0)
	{
		((ILicensedUnit)P_0).CompleteLicensingInitialize();
	}

	internal static object Abug6BNGIUli0SdVdko(object P_0)
	{
		return ((ILicensedUnit)P_0).GetLicenseInfo();
	}

	internal static object lHElneNEWGN9KDPYFMJ(object P_0)
	{
		return ((ILicensedUnit)P_0).GetActivationToken();
	}

	internal static object yknP7XNf4gu2jDqhaeO(object P_0)
	{
		return ((IActivationTokenContainer)P_0).GetActivationToken();
	}
}
